using CitasInfo.Models;
using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class horario : Form
    {
        // Importación para redondear botones
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly string _token;
        private static int pagHo;
        private static int contador = 1;
        private static List<HorarioSemanalDto> _Horario;

        public horario(string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            _token = token;
        }

        private void horario_Load(object sender, EventArgs e)
        {
            // --- Configuración del DataGridView ---
            dataGridViewHorario.ReadOnly = true;
            dataGridViewHorario.AllowUserToAddRows = false;
            dataGridViewHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evita ventana de error si falta una imagen o hay error de formato
            dataGridViewHorario.DataError += (s, ev) => { ev.ThrowException = false; };

            // Configurar columnas de imagen (Ajuste Zoom)
            if (dataGridViewHorario.Columns.Count > 6 && dataGridViewHorario.Columns[6] is DataGridViewImageColumn colMod)
                colMod.ImageLayout = DataGridViewImageCellLayout.Zoom;

            if (dataGridViewHorario.Columns.Count > 7 && dataGridViewHorario.Columns[7] is DataGridViewImageColumn colEli)
                colEli.ImageLayout = DataGridViewImageCellLayout.Zoom;

            _Horario = new List<HorarioSemanalDto>();
            RecargarHorario();
            ConfigurarUIEstiloImagen();
        }

        private void RecargarHorario()
        {
            _Horario = ObtenerHorario() ?? new List<HorarioSemanalDto>();
            // Calcular páginas (15 registros por página)
            pagHo = (int)Math.Ceiling((double)_Horario.Count / 15);
            if (pagHo == 0) pagHo = 1;

            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewHorario.Rows.Clear();
            if (_Horario == null || _Horario.Count == 0) return;

            // Cargar imágenes desde Recursos
            Image imgEliminar = Properties.Resources.trash;
            Image imgModificar = Properties.Resources.edit;

            int registrosASaltar = (contador - 1) * 15;
            var servicioPagina = _Horario.Skip(registrosASaltar).Take(15).ToList();

            foreach (var u in servicioPagina)
            {
                string cursoAMostrar = u.Grupo?.Curso ?? "Sin Grupo";

                // CORRECCIÓN NODATIME: Se añade 'null' como FormatProvider
                string horaInicio = u.HoraInicio.ToString("HH:mm", null);
                string horaFin = u.HoraFin.ToString("HH:mm", null);

                int index = dataGridViewHorario.Rows.Add(
                    u.DiaSemana,      // Col 0
                    horaInicio,       // Col 1
                    horaFin,          // Col 2
                    cursoAMostrar,    // Col 3
                    u.Servicio?.Nombre, // Col 4
                    u.Plazas,         // Col 5
                    imgModificar,     // Col 6
                    imgEliminar       // Col 7
                );

                // IMPORTANTE: Guardamos el objeto completo en el Tag (incluye el ID para Java)
                dataGridViewHorario.Rows[index].Tag = u;
            }

            // Actualizar estética de paginación
            buttonPaginacionAtras.ForeColor = (contador == 1) ? Color.Silver : Color.Black;
            buttonPaginacionDelante.ForeColor = (contador >= pagHo) ? Color.Silver : Color.Black;
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Recuperar el DTO desde el Tag de la fila
            if (dataGridViewHorario.Rows[e.RowIndex].Tag is HorarioSemanalDto u)
            {
                // Clic en Modificar (Columna 6)
                if (e.ColumnIndex == 6)
                {
                    horario_semanal formModificar = new horario_semanal(_token, u);
                    if (formModificar.ShowDialog() == DialogResult.OK)
                    {
                        RecargarHorario();
                    }
                }
                // Clic en Eliminar (Columna 7)
                else if (e.ColumnIndex == 7)
                {
                    // Confirmación con el ID real
                    DialogResult dr = MessageBox.Show($"¿Desea eliminar el horario con ID: {u.Id}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        EliminarHorario(u.Id);
                    }
                }
            }
        }

        private void EliminarHorario(long id)
        {
            // PRUEBA DE FUEGO
            if (id == 0)
            {
                MessageBox.Show("¡DETENTE! El ID que se intenta enviar es 0. " +
                    "Esto significa que el DataGridView no guardó bien el ID del objeto.");
                return;
            }

            try
            {
                string urlCompleta = $"http://localhost:8082/horarios/{id}";

                // Esto aparecerá en la consola de Visual Studio (puedes verla con Ctrl+Alt+O)
                System.Diagnostics.Debug.WriteLine(">>> URL DE BORRADO: " + urlCompleta);

                var request = (HttpWebRequest)WebRequest.Create(urlCompleta);
                request.Method = "DELETE";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Borrado exitoso en el servidor.");
                        RecargarHorario();
                    }
                }
            }
            catch (WebException ex)
            {
                // Si entra aquí, el ID llegó a Java pero Java dio error
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    string errorServer = reader.ReadToEnd();
                    MessageBox.Show("Java respondió con error: " + errorServer);
                }
            }
        }

        private List<HorarioSemanalDto> ObtenerHorario()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8082/horarios");
                request.Method = "GET";
                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener horarios: " + ex.Message);
                return null;
            }
        }

        // --- DISEÑO Y UI ---

        private void ConfigurarUIEstiloImagen()
        {
            buttonHorario.Text = "+";
            buttonHorario.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            buttonHorario.FlatStyle = FlatStyle.Flat;
            buttonHorario.FlatAppearance.BorderSize = 0;
            buttonHorario.BackColor = Color.FromArgb(255, 128, 0);
            buttonHorario.ForeColor = Color.White;
            buttonHorario.Size = new Size(45, 45);

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            buttonHorario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHorario.Width, buttonHorario.Height, buttonHorario.Width, buttonHorario.Height));
        }

        private void horario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualHorario.Invalidate();
        }

        private void panelVisualHorario_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(textBoxSHorarioBuscar.Left - 35, textBoxSHorarioBuscar.Top - 15, textBoxSHorarioBuscar.Width + 45, textBoxSHorarioBuscar.Height + 27);
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSHorarioBuscar.Left - 25, textBoxSHorarioBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(comboBoxHorario.Left - 10, comboBoxHorario.Top - 10, comboBoxHorario.Width + 25, comboBoxHorario.Height + 20);
            DibujarCapsula(g, rectFiltro, penBorde, fondoBlanco);
        }

        private void DibujarCapsula(Graphics g, Rectangle rect, Pen p, Brush b)
        {
            GraphicsPath path = new GraphicsPath();
            int radio = rect.Height - 1;
            path.AddArc(rect.X, rect.Y, radio, radio, 90, 180);
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 180);
            path.CloseFigure();
            g.FillPath(b, path);
            g.DrawPath(p, path);
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1) { contador--; pasarPagina(); }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagHo) { contador++; pasarPagina(); }
        }
    }
}