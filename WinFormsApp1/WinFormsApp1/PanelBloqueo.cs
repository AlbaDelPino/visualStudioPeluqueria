using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class PanelBloqueo : Form
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
        private List<BloqueoHorarioDto> _bloqueosCompletos;
        private List<BloqueoHorarioDto> _bloqueosFiltrados;
        private static BloqueoHorarioDto _bloqueoSeleccionado;
        private readonly UsersDto _usuarioActual;

        public PanelBloqueo(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelBloqueo_Load(object sender, EventArgs e)
        {
            dataGridViewBloqueos.ReadOnly = true;
            dataGridViewBloqueos.AllowUserToAddRows = false;
            dataGridViewBloqueos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBloqueos.DataError += (s, ev) => { ev.ThrowException = false; };

            _bloqueosCompletos = new List<BloqueoHorarioDto>();
            _bloqueosFiltrados = new List<BloqueoHorarioDto>();
            _bloqueoSeleccionado = new BloqueoHorarioDto();

            ActualizarRegiones();
            CargarTodosLosBloqueos();
            limpiarFiltros();
        }

        private void ActualizarRegiones()
        {
            dataGridViewBloqueos.Width = panelVisualBloqueos.Width / 4 * 3;
            textBoxBloqueoBuscar.Left = panelFiltros.Width + 80;
            textBoxBloqueoBuscar.Width = dataGridViewBloqueos.Width - 45;
            panelPaginacion.Padding = new Padding(panelFiltros.Width + 47, 0, 0, 0);
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;
            panelAnuales.Top = panelFiltros.Height - panelAnuales.Height;
            panelPuntuales.Top = panelAnuales.Top + panelPuntuales.Height + 20;


            anyadirBloqueo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirBloqueo.Width, anyadirBloqueo.Height, anyadirBloqueo.Width, anyadirBloqueo.Height));
        }

        private void panelVisualBloqueos_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectBusqueda = new Rectangle(
                textBoxBloqueoBuscar.Left - 35,
                textBoxBloqueoBuscar.Top - 15,
                textBoxBloqueoBuscar.Width + 45,
                textBoxBloqueoBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, new Pen(Color.FromArgb(220, 220, 220), 1), Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxBloqueoBuscar.Left - 25, textBoxBloqueoBuscar.Top - 2);
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el bloqueo horario?",
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

                        var url = $"http://localhost:8082/bloqueos/{_bloqueoSeleccionado.Id}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Bloqueo eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarTodosLosBloqueos();
                                filtrarBloqueos();
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Bloqueo pantallaModificar = new Bloqueo(_bloqueoSeleccionado, _token);
            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                CargarTodosLosBloqueos();
                filtrarBloqueos();
            }
        }

        private void anyadirBloqueo_Click(object sender, EventArgs e)
        {
            Bloqueo pantallaAnyadir = new Bloqueo(_token);
            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                CargarTodosLosBloqueos();
                filtrarBloqueos();
                MessageBox.Show("Bloqueo horario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewBloqueos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewBloqueos.Rows.Count)
            {
                var fila = dataGridViewBloqueos.Rows[e.RowIndex];
                _bloqueoSeleccionado = fila.Tag as BloqueoHorarioDto;
            }
        }

        private void filtrarBloqueos()
        {
            string textoBusqueda = textBoxBloqueoBuscar.Text.Trim().ToLower();
            string recurrente = comboBoxRecurrente.Text.ToLower();
            DateTime inicio = monthCalendarFiltrar.SelectionStart.Date;
            DateTime fin = monthCalendarFiltrar.SelectionEnd.Date;

            _bloqueosFiltrados = _bloqueosCompletos.Where(b =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) /*|| //obtener horarios
                                (b.Horarios?.Nombre?.ToLower().Contains(textoBusqueda) == true) ||
                                (h.Grupo?.Curso?.ToLower().Contains(textoBusqueda) == true)*/;



                bool pasaDia = string.IsNullOrEmpty(recurrente) ||
                                recurrente.Equals("todos los bloqueos") ||
                                (recurrente.Equals("anual") && b.Recurrente) ||
                                (recurrente.Equals("puntual") && !b.Recurrente);


                bool pasaFecha = true;
                if (inicio == fin)
                {
                    pasaFecha = (b.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(inicio).ToDateOnly()) == 0) == true;
                }
                else
                {
                    pasaFecha = ((b.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(inicio).ToDateOnly()) >= 0) == true) &&
                                ((b.Fecha.ToDateOnly().CompareTo(LocalDate.FromDateTime(fin).ToDateOnly()) <= 0) == true);
                }
                return pasaTexto && pasaFecha;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
        }

        private void textBoxBloqueoBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarBloqueos();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void limpiarFiltros()
        {
            comboBoxRecurrente.SelectedIndex = 0;
            textBoxBloqueoBuscar.Text = string.Empty;
            monthCalendarFiltrar.SelectionEnd = DateTime.Today;
            monthCalendarFiltrar.SelectionStart = DateTime.Today;

            _bloqueosCompletos = ObtenerBloqueos();
            _bloqueosFiltrados = ObtenerBloqueos();
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewBloqueos.Rows.Clear();

            int totalPaginas = (_bloqueosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _bloqueosFiltrados.Count);

            for (int i = inicio; i < fin; i++)
            {
                var b = _bloqueosFiltrados[i];
                var horarios = /*obtener horario*/"";
                int index = dataGridViewBloqueos.Rows.Add(
                    b.Fecha.ToString() ?? "Sin Fecha",
                    horarios ?? "Sin Horarios",
                    b.Recurrente
                );
                dataGridViewBloqueos.Rows[index].Tag = b;
            }

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_bloqueosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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
            int totalPaginas = (_bloqueosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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

        private List<BloqueoHorarioDto> ObtenerBloqueos()
        {
            var url = "http://localhost:8082/bloqueos";
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
                var bloqueos = JsonConvert.DeserializeObject<List<BloqueoHorarioDto>>(json);
                labelNumPuntuales.Text = $" {bloqueos?.Where(b => b.Recurrente).ToList().Count ?? 0}";
                labelNumPuntuales.Text = $" {bloqueos?.Where(b => !b.Recurrente).ToList().Count ?? 0}";
                return bloqueos;
            }

        }

        private void CargarTodosLosBloqueos()
        {
            _bloqueosCompletos = ObtenerBloqueos().ToList();
            _bloqueosFiltrados = new List<BloqueoHorarioDto>(_bloqueosCompletos);
            _paginaActual = 1;

            pasarPagina();
        }
    }
}
