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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class PanelCita : Form
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
        private static int pagCit;
        private static int contador = 1;
        private static List<CitaDto> _citas;
        private readonly List<UsersDto> _grupos;
        private readonly UsersDto _usuarioActual;

        public PanelCita(UsersDto usuarioActual, List<UsersDto> grupos,string token)
        {
            InitializeComponent();
            _token = token;
            _grupos = grupos;
            _usuarioActual = usuarioActual;
        }

        private void PanelCita_Load(object sender, EventArgs e)
        {
            dataGridViewCitas.ReadOnly = true;
            dataGridViewCitas.AllowUserToAddRows = false;
            dataGridViewCitas.AllowUserToDeleteRows = false;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            comboBoxCitFiltrar.DataSource = _grupos;
            comboBoxCitFiltrar.DisplayMember = "Nombre";
            comboBoxCitFiltrar.ValueMember = "Id";
            comboBoxCitFiltrar.SelectedItem = _usuarioActual.Id;

            _citas = new List<CitaDto>();
            RecargarCitas();
            pasarPagina();

            ConfigurarUIEstiloImagen();

        }

        private void ConfigurarUIEstiloImagen()
        {
            anyadirCita.Text = "+";
            anyadirCita.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirCita.FlatStyle = FlatStyle.Flat;
            anyadirCita.FlatAppearance.BorderSize = 0;
            anyadirCita.BackColor = Color.FromArgb(255, 128, 0);
            anyadirCita.ForeColor = Color.White;
            anyadirCita.Size = new Size(45, 45);


            anyadirCita.Left = panelVisualCitas.Width - 60;

            textBoxCitBuscar.Left = 50;
            textBoxCitBuscar.Width = panelVisualCitas.Width - 350;

            comboBoxCitFiltrar.Width = 180;
            comboBoxCitFiltrar.Left = textBoxCitBuscar.Right + 30;

            textBoxCitBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCitFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirCita.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirCita.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirCita.Width, anyadirCita.Height, anyadirCita.Width, anyadirCita.Height));
        }

        private void PanelCita_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualCitas.Invalidate(); 
        }

        private void panelVisualCitas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(
                textBoxCitBuscar.Left - 35,
                textBoxCitBuscar.Top - 15,
                textBoxCitBuscar.Width + 45,
                textBoxCitBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxCitBuscar.Left - 25, textBoxCitBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(
                comboBoxCitFiltrar.Left - 10,
                comboBoxCitFiltrar.Top - 10,
                comboBoxCitFiltrar.Width + 25, 
                comboBoxCitFiltrar.Height + 20
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












        private void CompletarCita(CitaDto cita)
        {

            if (cita.Fecha.CompareTo(LocalDate.FromDateTime(DateTime.Now)) > 0)
            {
                MessageBox.Show($"No se puede completar una cita que no ha ocurrido todavia", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cita.Estado.Equals("CONFIRMADO"))
            {
                FichaCita ficha = new FichaCita(cita, _token);

                if (ficha.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cita completada correctamente", "Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarCitas();
                    pasarPagina();
                }
            }
            else if (cita.Estado.Equals("CANCELADO"))
            {
                MessageBox.Show($"No se puede completar una cita cancelada", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cita.Estado.Equals("COMPLETADO"))
            {
                MessageBox.Show($"La cida ya ha sido completada", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarCita(CitaDto cita)
        {
            if (cita.Estado.Equals("CONFIRMADO")) {
                var confirmResult = MessageBox.Show(
                        $"¿Seguro que quieres cancelar la cita?",
                        "Confirmar cancelación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        var url = $"http://localhost:8082/citas/{cita.Id}/estado?estado=CANCELADO";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "PUT";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Cita cancelada correctamente", "Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RecargarCitas();
                                pasarPagina();
                            }
                            else
                            {
                                MessageBox.Show($"Error al cancelar: {response.StatusCode}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la cancelación: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
            else if (cita.Estado.Equals("CANCELADO")){
                MessageBox.Show($"La cita ya está cancelada", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cita.Estado.Equals("COMPLETADO"))
            {
                MessageBox.Show($"No se puede cancelar una cita completada", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anyadirCita_Click(object sender, EventArgs e)
        {
            Cita pantallaAnyadir = new Cita(null, _token);
            pantallaAnyadir.ComboBoxCitHora.Enabled = false;

                if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
                {
                    RecargarCitas();
                    pasarPagina();
                    MessageBox.Show("Cita creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private List<CitaDto> ObtenerCitas()
        {
                var url = "http://localhost:8082/citas/todas";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    var citas = JsonConvert.DeserializeObject<List<CitaDto>>(json);
                    return citas;
                }

        }

        private void RecargarCitas()
        {
            _citas = ObtenerCitas();

            if (_citas.Count % 15 != 0)
            {
                pagCit = (_citas.Count / 15) + 1;
            }
            else
            {
                pagCit = (_citas.Count / 15);
            }

            int hoy = 0;
            int proximas = 0;

            foreach (var c in _citas)
            {

                if (c.Estado.Equals("CONFIRMADO") && c.Fecha.CompareTo(LocalDate.FromDateTime(DateTime.Now.Date))==0)
                {
                    hoy++;
                } else if (c.Estado.Equals("CONFIRMADO") && c.Fecha.CompareTo(LocalDate.FromDateTime(DateTime.Now.Date)) < 1)
                {
                    proximas++;
                }
            }

            labelNumHoy.Text = $"{hoy}";
            labelNumProximas.Text = $"{proximas}";
        }

        private void pasarPagina()
        {
            dataGridViewCitas.Rows.Clear();

            int registrosASaltar = (contador - 1) * 15;
            var citasPagina = _citas.Skip(registrosASaltar).Take(15).ToList();

            foreach (var c in citasPagina)
            {
                string hora = c.Horario.HoraInicio.ToString().Substring(0, 4);

                string estado = "";
                if (c.Estado.Equals("CONFIRMADO"))
                {
                    estado = "Confirmada";
                }
                else if (c.Estado.Equals("CANCELADO"))
                {
                    estado = "Cancelada";
                }
                else if (c.Estado.Equals("COMPLETADO"))
                {
                    estado = "Completada";
                }

                int index = dataGridViewCitas.Rows.Add(
                    c.Cliente?.Nombre ?? "Sin Nombre",
                    c.Horario.Servicio?.Nombre ?? "Sin Servicio",
                    c.Fecha.ToString(),
                    hora,
                    estado,
                    c.Horario.Grupo.Curso ?? "Sin Grupo"
                );

                dataGridViewCitas.Rows[index].Tag = c;
            }
        }
        private void dataGridViewCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 5) return;

            if (e.RowIndex >= dataGridViewCitas.Rows.Count) return;

            var fila = dataGridViewCitas.Rows[e.RowIndex];
            var cita = fila.Tag as CitaDto;
            if (cita == null) return;

            var columna = dataGridViewCitas.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnCitCompletar")
            {
                CompletarCita(cita);
            }
            else if (columna == "dataGridViewImageColumnCitCancelar")
            {
                CancelarCita(cita);
            }
        }

        private void filtrarCitas()
        {
            string texto = textBoxCitBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxCitFiltrar.SelectedItem.ToString();

            if (_citas == null) return;

            var listaFiltrada = _citas.AsEnumerable();

            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada
                    .Where(c => c.Cliente.Nombre.ToLower().Contains(texto)
                             || c.Cliente.Username.ToLower().Contains(texto)
                             || c.Horario.Servicio.Nombre.ToLower().Contains(texto)).ToList();
            }

            LocalDate hoy = LocalDate.FromDateTime(DateTime.Now.Date);
            LocalDate viernes = hoy.Next(IsoDayOfWeek.Friday);
            LocalDate proximoLunes = viernes.PlusDays(3);
            LocalDate proximoViernes = proximoLunes.PlusDays(4);

            switch (filtroCombo)
            {
                case " ":
                case "":
                    break;

                default:
                    UsersDto grupoSeleccionado = _grupos[1];//.Select(g => g.Id.ToString().Equals(filtroCombo));

                    if (grupoSeleccionado != null)
                    {
                        listaFiltrada = listaFiltrada
                            .Where(c =>
                                c.Horario != null &&
                                c.Horario.Grupo != null &&
                                c.Horario.Grupo.Id == grupoSeleccionado.Id
                            )
                            .ToList();
                    }
                    break;
            }

            dataGridViewCitas.Rows.Clear();

            foreach (var c in listaFiltrada)
            {
                string hora = c.Horario.HoraInicio.ToString().Substring(0, 4);
               
                string estado = "";
                if (c.Estado.Equals("CONFIRMADO"))
                {
                    estado = "Confirmada";
                }
                else if (c.Estado.Equals("CANCELADO"))
                {
                    estado = "Cancelada";
                }
                else if (c.Estado.Equals("COMPLETADO"))
                {
                    estado = "Completada";
                }

                int index = dataGridViewCitas.Rows.Add(
                    c.Cliente?.Nombre ?? "Sin Nombre",
                    c.Horario.Servicio?.Nombre ?? "Sin Servicio",
                    c.Fecha.ToString(),
                    hora,
                    estado,
                    c.Horario.Grupo.Curso ?? "Sin Grupo"
                );

                dataGridViewCitas.Rows[index].Tag = c;
            }
        }

        private void textBoxCitBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }

        private void comboBoxCitFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagCit)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagCit)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagCit)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }

       
    }
}
