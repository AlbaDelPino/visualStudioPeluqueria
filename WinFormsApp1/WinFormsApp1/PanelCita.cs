using CitasInfo.Models;
using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using System.Data;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using UsersInfo.Models;

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
        private static int _paginaActual = 1;
        private const int REGISTROS_POR_PAGINA = 19;
        private static List<CitaDto> _citasCompletas;
        private static List<CitaDto> _citasFiltradas;
        private static CitaDto _citaSeleccionada;
        private readonly List<UsersDto> _grupos;
        private readonly UsersDto _usuarioActual;
        private static bool _fechaSeleccionada = false;
        private static bool _proximas = false;

        public PanelCita(UsersDto usuarioActual, List<UsersDto> grupos, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

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

            _citasCompletas = new List<CitaDto>();
            _citasFiltradas = new List<CitaDto>();
            _citaSeleccionada = new CitaDto();

            ActualizarRegiones();
            CargarTodasLasCitas();

            comboBoxGrupos.DataSource = _grupos;
            comboBoxGrupos.DisplayMember = "Nombre";
            comboBoxGrupos.ValueMember = "Id";
            limpiarFiltros();
            if (_usuarioActual.Role.Equals("ROLE_GRUPO"))
            {
                var grupoSeleccionado = _grupos.FirstOrDefault(g => g.Id == _usuarioActual.Id);
                if (grupoSeleccionado != null)
                {
                    comboBoxCitFiltrar.SelectedItem = grupoSeleccionado;
                }
                filtrarCitas();
            }
        }


        private void ActualizarRegiones()
        {
            dataGridViewCitas.Width = panelVisualCitas.Width / 4 * 3;
            textBoxCitBuscar.Left = panelFiltros.Width + 80;
            textBoxCitBuscar.Width = dataGridViewCitas.Width - 45;
            panelPaginacion.Padding = new Padding(panelFiltros.Width + 47, 0, 0, 0);
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;
            panelProximas.Top = panelFiltros.Height - panelProximas.Height;
            panelHoy.Top = panelProximas.Top + panelHoy.Height + 20;

            anyadirCitas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirCitas.Width, anyadirCitas.Height, anyadirCitas.Width, anyadirCitas.Height));
        }

        private void panelVisualCitas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectBusqueda = new Rectangle(
                textBoxCitBuscar.Left - 35,
                textBoxCitBuscar.Top - 15,
                textBoxCitBuscar.Width + 45,
                textBoxCitBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, new Pen(Color.FromArgb(220, 220, 220), 1), Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxCitBuscar.Left - 25, textBoxCitBuscar.Top - 2);
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











        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (_citaSeleccionada.Estado != null)
            {
                if (_citaSeleccionada.Fecha.CompareTo(LocalDate.FromDateTime(DateTime.Now)) > 0)
                {
                    MessageBox.Show($"No se puede completar una cita que no ha ocurrido todavia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_citaSeleccionada.Estado.Equals("CONFIRMADO"))
                {
                    FichaCita ficha = new FichaCita(_citaSeleccionada, _token);

                    if (ficha.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Cita completada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTodasLasCitas();
                        filtrarCitas();
                    }
                }
                else if (_citaSeleccionada.Estado.Equals("CANCELADO"))
                {
                    MessageBox.Show($"No se puede completar una cita cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_citaSeleccionada.Estado.Equals("COMPLETADO"))
                {
                    MessageBox.Show($"La cida ya ha sido completada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (_citaSeleccionada.Estado != null)
            {
                if (_citaSeleccionada.Estado.Equals("CONFIRMADO"))
                {
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
                            var url = $"http://localhost:8082/citas/{_citaSeleccionada.Id}/estado?estado=CANCELADO";
                            var request = (HttpWebRequest)WebRequest.Create(url);
                            request.Method = "PUT";
                            request.ContentType = "application/json";
                            request.Accept = "application/json";
                            request.Headers["Authorization"] = $"Bearer {_token}";

                            using (var response = (HttpWebResponse)request.GetResponse())
                            {
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    MessageBox.Show("Cita cancelada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarTodasLasCitas();
                                    pasarPagina();
                                }
                                else
                                {
                                    MessageBox.Show($"Error al cancelar: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (_citaSeleccionada.Estado.Equals("CANCELADO"))
                {
                    MessageBox.Show($"La cita ya está cancelada", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_citaSeleccionada.Estado.Equals("COMPLETADO"))
                {
                    MessageBox.Show($"No se puede cancelar una cita completada", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void anyadirCitas_Click(object sender, EventArgs e)
        {
            Cita pantallaAnyadir = new Cita(null, _token);
            pantallaAnyadir.ComboBoxCitHora.Enabled = false;

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                CargarTodasLasCitas();
                filtrarCitas();
                MessageBox.Show("Cita creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridViewCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewCitas.Rows.Count) return;

            var fila = dataGridViewCitas.Rows[e.RowIndex];
            _citaSeleccionada = fila.Tag as CitaDto;

            var columna = dataGridViewCitas.Columns[e.ColumnIndex].Name;

            if (columna == "DataGridViewTextBoxColumnValoración")
            {
                if (_citaSeleccionada != null)
                {
                    if (_citaSeleccionada.Valoracion != null)
                    {
                        using (var pantallaDetalle = new Valoracion(_citaSeleccionada.Valoracion, _token))
                        {
                            pantallaDetalle.ShowDialog();
                        }
                    }
                    else if (_citaSeleccionada.Estado == "COMPLETADO")
                    {
                        MessageBox.Show("El cliente aún no ha valorado esta cita.", "Información",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void filtrarCitas()
        {
            string textoBusqueda = textBoxCitBuscar.Text.Trim().ToLower();
            UsersDto grupoSeleccionado = comboBoxGrupos.SelectedItem as UsersDto;
            string estadoSeleccionado = comboBoxEstado.Text.ToLower();
            DateTime inicio = monthCalendarFiltrar.SelectionStart.Date;
            DateTime fin = monthCalendarFiltrar.SelectionEnd.Date;
            _citasFiltradas = _citasCompletas.Where(c =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                   (c.Cliente?.Nombre?.ToLower().Contains(textoBusqueda) == true) ||
                                   (c.Cliente?.Username?.ToLower().Contains(textoBusqueda) == true) ||
                                   (c.Horario?.Servicio?.Nombre?.ToLower().Contains(textoBusqueda) == true);

                bool pasaGrupo = true;
                if (grupoSeleccionado != null && grupoSeleccionado.Id != 0)
                {
                    if (c.Horario.Grupo == null || c.Horario.Grupo.Id == null)
                    {
                        pasaGrupo = false;
                    }
                    else
                    {
                        pasaGrupo = c.Horario.Grupo.Id == grupoSeleccionado.Id;
                    }
                }
                else
                {
                    pasaGrupo = grupoSeleccionado.Nombre.ToLower().Equals("todos los grupos");
                }

                bool pasaEstado = string.IsNullOrEmpty(estadoSeleccionado) ||
                                    estadoSeleccionado.Equals("todos los estados") ||
                                    (c.Estado?.ToLower().Contains(estadoSeleccionado?.Substring(0, (estadoSeleccionado.Length) - 1) + "o") == true);

                bool pasaFecha = true;
                if (_fechaSeleccionada)
                {
                    if (inicio == fin)
                    {
                        pasaFecha = (c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(inicio).ToDateOnly()) == 0) == true;
                    }
                    else
                    {
                        pasaFecha = ((c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(inicio).ToDateOnly()) >= 0) == true) &&
                                    ((c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(fin).ToDateOnly()) <= 0) == true);
                    }
                }
                bool pasaProxima = true;
                if (_proximas)
                {
                    pasaProxima = (c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(DateTime.Today).ToDateOnly()) >= 0);
                }

                return pasaTexto && pasaGrupo && pasaEstado && pasaFecha && pasaProxima;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
        }

        private void textBoxCitBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }
        private void comboBoxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }
        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }
        private void monthCalendarFiltrar_DateSelected(object sender, DateRangeEventArgs e)
        {
            _fechaSeleccionada = true;
            filtrarCitas();
        }
        private void buttonProximas_Click(object sender, EventArgs e)
        {
            _proximas = !_proximas;
            if (_proximas)
            {
                buttonProximas.Text = "Quitar la vista de póximas citas";
            }
            else
            {
                buttonProximas.Text = "Ver solo las póximas citas";
            }
            filtrarCitas();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            filtrarCitas();
        }
        private void limpiarFiltros()
        {
            comboBoxGrupos.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
            textBoxCitBuscar.Text = string.Empty;
            monthCalendarFiltrar.SelectionEnd = DateTime.Today;
            monthCalendarFiltrar.SelectionStart = DateTime.Today;
            _fechaSeleccionada = false;
            _proximas = false;
            buttonProximas.Text = "Ver solo las póximas citas";

            _citasCompletas = ObtenerCitas();
            _citasFiltradas = ObtenerCitas();
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewCitas.Rows.Clear();

            int totalPaginas = (_citasFiltradas.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _citasFiltradas.Count);

            for (int i = inicio; i < fin; i++)
            {
                var c = _citasFiltradas[i];
                string hora = c.Horario.HoraInicio.ToString().Substring(0, 4);

                string estado = c.Estado switch
                {
                    "CONFIRMADO" => "Confirmada",
                    "CANCELADO" => "Cancelada",
                    "COMPLETADO" => "Completada",
                    _ => c.Estado ?? "Desconocido"
                };

                int index = dataGridViewCitas.Rows.Add(
                    c.Cliente?.Nombre ?? "Sin Nombre",
                    c.Horario.Servicio?.Nombre ?? "Sin Servicio",
                    c.Fecha.ToString(),
                    hora,
                    estado,
                    c.Horario.Grupo.Curso ?? "Sin Grupo",
                    ""
                );
                DataGridViewRow fila = dataGridViewCitas.Rows[index];
                fila.Tag = c;
                var celdaVal = fila.Cells["DataGridViewTextBoxColumnValoración"];
                if (c.Valoracion != null)
                {
                    celdaVal.Value = $"⭐ {c.Valoracion.Puntuacion}/5";
                    celdaVal.Style.ForeColor = Color.DarkGreen;
                    celdaVal.Style.SelectionForeColor = Color.White;
                    celdaVal.Style.Font = new Font(dataGridViewCitas.Font, FontStyle.Bold);
                }
                else
                {
                    celdaVal.Value = "Sin valorar";
                    celdaVal.Style.ForeColor = Color.Gray;
                }
            }

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_citasFiltradas.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
                _paginaActual--;
                pasarPagina();
                if (_paginaActual != totalPaginas)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (_paginaActual == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            int totalPaginas = (_citasFiltradas.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (_paginaActual < totalPaginas)
            {
                _paginaActual++;
                pasarPagina();
                if (_paginaActual != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (_paginaActual == totalPaginas)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
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
                labelNumHoy.Text = $" {citas?.Where(c => c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(DateTime.Today).ToDateOnly()) == 0 && c.Estado.Equals("CONFIRMADO")).ToList().Count ?? 0}";
                labelNumProximas.Text = $" {citas?.Where(c => c.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(DateTime.Today).ToDateOnly()) > 0 && c.Estado.Equals("CONFIRMADO")).ToList().Count ?? 0}";
                return citas;
            }

        }

        private void CargarTodasLasCitas()
        {
            _citasCompletas = ObtenerCitas().ToList();
            _citasFiltradas = new List<CitaDto>(_citasCompletas);
            _paginaActual = 1;

            pasarPagina();
        }
    }
}
