using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp1
{
    public partial class horario : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private readonly string _token;
        private static int pagHo;
        private static int contador = 1;
        private static List<HorarioSemanalDto> _Horario;
        public horario(string token)
        {
            InitializeComponent();
        

            _token = token;
        }

        private void horario_Load(object sender, EventArgs e)
        {
            dataGridViewHorario.ReadOnly = true;
            dataGridViewHorario.AllowUserToAddRows = false;
            dataGridViewHorario.AllowUserToDeleteRows = false;
            dataGridViewHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _Horario = new List<HorarioSemanalDto>();
            RecargarHorario();
            pasarPagina();

            // --- CONFIGURACIÓN ESTÉTICA INICIAL ---
            ConfigurarUIEstiloImagen();
        }

        private void ConfigurarUIEstiloImagen()
        {
            // BOTÓN (+) CIRCULAR
            buttonHorario.Text = "+";
            buttonHorario.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            buttonHorario.FlatStyle = FlatStyle.Flat;
            buttonHorario.FlatAppearance.BorderSize = 0;
            buttonHorario.BackColor = Color.FromArgb(255, 128, 0);
            buttonHorario.ForeColor = Color.White;
            buttonHorario.Size = new Size(45, 45);

            // POSICIÓN DEL BOTÓN: Para que esté más alto, bajamos el valor de 'Top'
            //anyadirUsuario.Top = 15;
            buttonHorario.Left = panelVisualHorario.Width - 60; // A la derecha

            // BUSCADOR Y COMBO
            textBoxSHorarioBuscar.Left = 50;
            // Ajustamos el ancho para que sea dinámico pero deje espacio al combo
            textBoxSHorarioBuscar.Width = panelVisualHorario.Width - 350;

            // COMBO (Alargado)
            comboBoxHorario.Width = 180; // Más ancho
            comboBoxHorario.Left = textBoxSHorarioBuscar.Right + 30; // Se posiciona justo después del buscador

            // ANCLAJES CORRECTOS para que al estirar la ventana no se solapen
            textBoxSHorarioBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHorario.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        // Se llama al cargar y al cambiar el tamaño de la ventana
        private void ActualizarRegiones()
        {
            // Redondeo físico del botón naranja (Círculo perfecto)
            buttonHorario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHorario.Width, buttonHorario.Height, buttonHorario.Width, buttonHorario.Height));
        }

        private void PanelUsuario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualHorario.Invalidate(); // Fuerza a redibujar el borde gris
        }

        private void panelVisualUsuarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            // 1. ÁREA DEL BUSCADOR (Sigue al TextBox)
            // Aumentamos el ancho (Width + 45) para que la cápsula cubra la lupa
            Rectangle rectBusqueda = new Rectangle(
                textBoxSHorarioBuscar.Left - 35,
                textBoxSHorarioBuscar.Top - 15,
                textBoxSHorarioBuscar.Width + 45,
                textBoxSHorarioBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSHorarioBuscar.Left - 25, textBoxSHorarioBuscar.Top - 2);

            // 2. ÁREA DEL FILTRO (Sigue al ComboBox)
            Rectangle rectFiltro = new Rectangle(
                comboBoxHorario.Left - 10,
                comboBoxHorario.Top - 10,
                comboBoxHorario.Width + 25, // Un poco más ancho para el desplegable
                comboBoxHorario.Height + 20
            );
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


       


        private void RecargarHorario()
        {
            _Horario = ObtenerHorario();

            if (_Horario.Count % 15 != 0)
            {
                pagHo = (_Horario.Count / 15) + 1;
            }
            else
            {
                pagHo = (_Horario.Count / 15);
            }

           // labelNumServicios.Text = $" {_Horario.Count}";
           // labelNumTipoSer.Text = (comboBoxHorario.Items.Count - 1).ToString();
        }
        private void pasarPagina()
        {
            dataGridViewHorario.Rows.Clear();

            // Seguridad: Si la lista es nula, salimos
            if (_Horario == null || _Horario.Count == 0) return;

            int registrosASaltar = (contador - 1) * 15;
            var servicioPagina = _Horario.Skip(registrosASaltar).Take(15).ToList();

            foreach (var u in servicioPagina)
            {
                // 1. Obtener el nombre del curso (accediendo a Grupo.Curso)
                string cursoAMostrar = u.Grupo?.Curso ?? "Sin Grupo";

                // 2. Formatear las horas para que no salgan segundos (opcional, queda más limpio)
                string horaInicio = u.HoraInicio.ToString("HH:mm", null);
                string horaFin = u.HoraFin.ToString("HH:mm", null);

                // 3. Añadir a la tabla
                int index = dataGridViewHorario.Rows.Add(
                    u.DiaSemana,
                    horaInicio,
                    horaFin,
                    cursoAMostrar,
                            // Asegúrate que la columna en el diseñador acepte números/texto
                    u.Servicio?.Nombre,
                   u.Plazas     // Mostramos el texto del curso, no el objeto GrupoDto
                );

                dataGridViewHorario.Rows[index].Tag = u;
            }
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagHo)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private List<HorarioSemanalDto> ObtenerHorario()
        {

            var url = "http://localhost:8082/horarios";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            // Aquí añadimos el token
            request.Headers["Authorization"] = $"Bearer {_token}";

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                var horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                return horarios;
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagHo)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagHo)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }


    }
}
