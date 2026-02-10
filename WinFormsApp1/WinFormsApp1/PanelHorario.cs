using CitasInfo.Models;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Globalization; 
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class PanelHorario : Form
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
        private List<HorarioSemanalDto> _horariosCompletos;
        private List<HorarioSemanalDto> _horariosFiltrados;
        private static HorarioSemanalDto _horarioSeleccionado;
        private readonly List<UsersDto> _grupos;
        private readonly UsersDto _usuarioActual;

        public PanelHorario(UsersDto usuarioActual, List<UsersDto> grupos, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            _token = token;
            _grupos = grupos;
            _usuarioActual = usuarioActual;
        }
        private void PanelHorario_Load(object sender, EventArgs e)
        {
            dataGridViewHorarios.ReadOnly = true;
            dataGridViewHorarios.AllowUserToAddRows = false;
            dataGridViewHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHorarios.DataError += (s, ev) => { ev.ThrowException = false; };

            _horariosCompletos = new List<HorarioSemanalDto>();
            _horariosFiltrados = new List<HorarioSemanalDto>();
            _horarioSeleccionado = new HorarioSemanalDto();

            ActualizarRegiones();
            CargarTodosLosHorarios();

            comboBoxGrupos.DataSource = _grupos;
            comboBoxGrupos.DisplayMember = "Nombre";
            comboBoxGrupos.ValueMember = "Id";
            limpiarFiltros();
            if (_usuarioActual.Role.Equals("ROLE_GRUPO"))
            {
                var grupoSeleccionado = _grupos.FirstOrDefault(g => g.Id == _usuarioActual.Id);
                if (grupoSeleccionado != null)
                {
                    comboBoxGrupos.SelectedItem = grupoSeleccionado;
                }
                filtrarHorario();
            }
        }

        private void ActualizarRegiones()
        {
            dataGridViewHorarios.Width = panelVisualHorarios.Width / 4 * 3;
            textBoxHorarioBuscar.Left = panelFiltros.Width + 80;
            textBoxHorarioBuscar.Width = dataGridViewHorarios.Width - 45;
            panelPaginacion.Padding = new Padding(panelFiltros.Width + 47, 0, 0, 0);
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;
            panelHorarios.Top = panelFiltros.Height - panelHorarios.Height;

            anyadirHorario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirHorario.Width, anyadirHorario.Height, anyadirHorario.Width, anyadirHorario.Height));
        }
        private void PanelHorario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualHorarios.Invalidate();
        }

        private void panelVisualHorarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectBusqueda = new Rectangle(
                textBoxHorarioBuscar.Left - 35,
                textBoxHorarioBuscar.Top - 15,
                textBoxHorarioBuscar.Width + 45,
                textBoxHorarioBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, new Pen(Color.FromArgb(220, 220, 220), 1), Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxHorarioBuscar.Left - 25, textBoxHorarioBuscar.Top - 2);
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












        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Horario pantallaModificar = new Horario(_horarioSeleccionado, _token);
            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                CargarTodosLosHorarios();
                filtrarHorario();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el horario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        var url = $"http://localhost:8082/horarios/{_horarioSeleccionado.Id}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Horario eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarTodosLosHorarios();
                                filtrarHorario();
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar: {response.StatusCode}", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la eliminación: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void anyadirHorario_Click(object sender, EventArgs e)
        {
            Horario pantallaAnyadir = new Horario(_token);
            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                CargarTodosLosHorarios();
                filtrarHorario();
                MessageBox.Show("Horario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewHorarios.Rows.Count)
            {
                var fila = dataGridViewHorarios.Rows[e.RowIndex];
                _horarioSeleccionado = fila.Tag as HorarioSemanalDto;
            }
        }

        private void filtrarHorario()
        {
            string textoBusqueda = textBoxHorarioBuscar.Text.Trim().ToLower();
            UsersDto grupoSeleccionado = comboBoxGrupos.SelectedItem as UsersDto;
            string diaSeleccionado = comboBoxDia.Text.ToLower();

            _horariosFiltrados = _horariosCompletos.Where(h =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                (h.Servicio?.Nombre?.ToLower().Contains(textoBusqueda) == true) ||
                                (h.Grupo?.Curso?.ToLower().Contains(textoBusqueda) == true);

                bool pasaGrupo = true;
                if (grupoSeleccionado != null && grupoSeleccionado.Id != 0)
                {
                    if (h.Grupo == null || h.Grupo.Id == null)
                    {
                        pasaGrupo = false;
                    }
                    else
                    {
                        pasaGrupo = h.Grupo.Id == grupoSeleccionado.Id;
                    }
                } else
                {
                    pasaGrupo = grupoSeleccionado.Nombre.Equals("todos los grupos");
                }

                    bool pasaDia = string.IsNullOrEmpty(diaSeleccionado) ||
                                    diaSeleccionado.Equals("todos los dias de la semana") ||
                                    (h.DiaSemana?.ToLower().Contains(diaSeleccionado) == true);

                return pasaTexto && pasaGrupo && pasaDia;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
        }

        private void textBoxSHorarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }
        private void comboBoxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }
        private void comboBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }
        private void buttonTodos_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }
        private void limpiarFiltros()
        {
            comboBoxGrupos.SelectedIndex = 0;
            comboBoxDia.SelectedIndex = 0;
            textBoxHorarioBuscar.Text = string.Empty;
            monthCalendarFiltrar.SelectionEnd = DateTime.Today;
            monthCalendarFiltrar.SelectionStart = DateTime.Today;

            _horariosCompletos = ObtenerHorarios();
            _horariosFiltrados = ObtenerHorarios();
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewHorarios.Rows.Clear();

            int totalPaginas = (_horariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _horariosFiltrados.Count);

            for (int i = inicio; i < fin; i++)
            {
                var h = _horariosFiltrados[i];
                string inicioHora = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string finHora = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);

                int index = dataGridViewHorarios.Rows.Add(
                    h.DiaSemana,
                    inicioHora,
                    finHora,
                    h.Grupo?.Curso ?? "Sin Grupo",
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Plazas
                );
                dataGridViewHorarios.Rows[index].Tag = h;
            }

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_horariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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
            int totalPaginas = (_horariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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

        private List<HorarioSemanalDto> ObtenerHorarios()
        {

            var url = "http://localhost:8082/horarios";
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
                var horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                labelNumHorarios.Text = $" {horarios?.Count ?? 0}";
                return horarios ?? new List<HorarioSemanalDto>();
            }
        }
        private void CargarTodosLosHorarios()
        {
            _horariosCompletos = ObtenerHorarios().ToList();
            _horariosFiltrados = new List<HorarioSemanalDto>(_horariosCompletos);
            _paginaActual = 1;

            pasarPagina();
        }
    }
}