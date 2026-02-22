using CitasInfo.Models;
using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Net;
using System.Runtime.InteropServices;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class PanelServicios : Form
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
        private List<ServicioDto> _serviciosCompletos;
        private List<ServicioDto> _serviciosFiltrados;
        private ServicioDto _servicioSeleccionado;
        public PanelServicios(string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            _token = token;
        }

        private void PanelServicios_Load(object sender, EventArgs e)
        {
            dataGridViewServicios.ReadOnly = true;
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _serviciosCompletos = new List<ServicioDto>();
            _serviciosFiltrados = new List<ServicioDto>();
            _servicioSeleccionado = new ServicioDto();

            CargarTodosLosServicios();

            comboBoxTipo.DataSource = ObtenerTiposServicio();
            comboBoxTipo.DisplayMember = "Nombre";
            comboBoxTipo.ValueMember = "Id";
        }

        private void ActualizarRegiones()
        {
            dataGridViewServicios.Width = panelVisualServicios.Width / 4 * 3;
            textBoxSerBuscar.Left = panelFiltros.Width + 80;
            textBoxSerBuscar.Width = dataGridViewServicios.Width - 45;
            panelPaginacion.Padding = new Padding(panelFiltros.Width + 47, 0, 0, 0);
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;
            panelVerServicios.Top = panelFiltros.Height - panelVerServicios.Height;
            panelTipoSer.Top = panelVerServicios.Top - panelTipoSer.Height - 20;

            anyadirServicio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirServicio.Width, anyadirServicio.Height, anyadirServicio.Width, anyadirServicio.Height));
        }
        private void PanelServicios_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualServicios.Invalidate();
        }

        private void panelVisualServicios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectBusqueda = new Rectangle(
                textBoxSerBuscar.Left - 35,
                textBoxSerBuscar.Top - 15,
                textBoxSerBuscar.Width + 45,
                textBoxSerBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, new Pen(Color.FromArgb(220, 220, 220), 1), Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSerBuscar.Left - 25, textBoxSerBuscar.Top - 2);
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
            if (_servicioSeleccionado.Id_Servicio != null)
            {
                Servicio pantallaModificar = new Servicio(_servicioSeleccionado, _token);
                if (pantallaModificar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Servicio modificado correctamente", "Éxito", MessageBoxButtons.OK);
                    CargarTodosLosServicios();
                    filtrarServicios();
                }
            }

            /*
            pantallaModificar.Form = "Modificar información de " + servicio.Nombre;
            pantallaModificar.LabelTituoCrearServicio = "MODIFICAR SERVICIO";
            pantallaModificar.buttonSerModificar = true;
            pantallaModificar.buttonSerAnyadir = false;

            pantallaModificar.TboxNombreServicio.Text = servicio.Nombre;
            pantallaModificar.TxtBoxDescripcion.Text = servicio.Descripcion;
            pantallaModificar.TextBoxPrecio.Text = servicio.Precio.ToString();
            pantallaModificar.TextBoxDuracion.Text = servicio.Duracion.ToString();
            pantallaModificar.ComboTipoServicio.SelectedIndex = Convert.ToInt32(servicio.TipoServicio?.Id - 1);
            */
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (_servicioSeleccionado.Id_Servicio != null)
            {
                var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio \"{_servicioSeleccionado.Nombre}\"?",
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

                            var url = $"http://localhost:8082/servicio/{_servicioSeleccionado.Id_Servicio}";
                            var request = (HttpWebRequest)WebRequest.Create(url);
                            request.Method = "DELETE";
                            request.ContentType = "application/json";
                            request.Accept = "application/json";
                            request.Headers["Authorization"] = $"Bearer {_token}";

                            using (var response = (HttpWebResponse)request.GetResponse())
                            {
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    MessageBox.Show("Servicio eliminado correctamente", "Éxito",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    CargarTodosLosServicios();
                                    filtrarServicios();
                                }
                                else
                                {
                                    MessageBox.Show($"Error al eliminar el servicio", "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error en la eliminación del servicio", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }


        private void anyadirServicio_Click(object sender, EventArgs e)
        {
            //.
            Servicio pantallaAnyadir = new Servicio(null, _token);
            pantallaAnyadir.Form = "Añadir servicio nuevo";
            pantallaAnyadir.LabelTituoCrearServicio = "AÑADIR SERVICIO";
            pantallaAnyadir.buttonSerModificar = false;
            pantallaAnyadir.buttonSerAnyadir = true;

            pantallaAnyadir.TboxNombreServicio.Text = "";
            pantallaAnyadir.TxtBoxDescripcion.Text = "";
            pantallaAnyadir.TextBoxPrecio.Text = "";
            pantallaAnyadir.TextBoxDuracion.Text = "";
            pantallaAnyadir.ComboTipoServicio.SelectedItem = "";

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Servicio añadido correctamente", "Servicio añadido correctamente", MessageBoxButtons.OK);
                CargarTodosLosServicios();
                filtrarServicios();
            }
        }

        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewServicios.Rows.Count)
            {
                var fila = dataGridViewServicios.Rows[e.RowIndex];
                _servicioSeleccionado = fila.Tag as ServicioDto;
            }
        }

        private void filtrarServicios()
        {
            string textoBusqueda = textBoxSerBuscar.Text.Trim().ToLower();
            TipoServicioDto tipoSeleccionado = comboBoxTipo.SelectedItem as TipoServicioDto;

            _serviciosFiltrados = _serviciosCompletos.Where(s =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                (s.Nombre != null && s.Nombre.ToLower().Contains(textoBusqueda) == true) ||
                                (s.Descripcion != null && s.Descripcion.ToLower().Contains(textoBusqueda) == true);

                bool pasaTipo = true;
                if (tipoSeleccionado != null && tipoSeleccionado.Id != 0)
                {
                    if (s.TipoServicio == null || s.TipoServicio.Id == null)
                    {
                        pasaTipo = false;
                    }
                    else
                    {
                        pasaTipo = s.TipoServicio.Id == tipoSeleccionado.Id;
                    }
                }

                return pasaTexto && pasaTipo;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }
        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }
        private void buttonTodos_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }
        private void limpiarFiltros()
        {
            comboBoxTipo.SelectedIndex = 0;
            textBoxSerBuscar.Text = string.Empty;

            _serviciosCompletos = ObtenerServicios();
            _serviciosFiltrados = ObtenerServicios();
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewServicios.Rows.Clear();

            int totalPaginas = (_serviciosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _serviciosFiltrados.Count);


            for (int i = inicio; i < fin; i++)
            {
                var s = _serviciosFiltrados[i];

                var precio = s.Precio.ToString() + " €";
                var duracion = s.Duracion.ToString() + " minutos";


                int index = dataGridViewServicios.Rows.Add(
                    s.Nombre,
                    s.TipoServicio?.Nombre,
                    s.Descripcion,
                    duracion,
                    precio                  
                );
                dataGridViewServicios.Rows[index].Tag = s;
            }

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_serviciosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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
            int totalPaginas = (_serviciosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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

        private List<ServicioDto> ObtenerServicios()
        {

            var url = "http://localhost:8082/servicio";
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
                var servicios = JsonConvert.DeserializeObject<List<ServicioDto>>(json);
                labelNumServicios.Text = $" {servicios?.Count ?? 0}";
                return servicios.OrderBy(s => s.Nombre).ToList(); ;
            }
        }


        private List<TipoServicioDto> ObtenerTiposServicio()
        {

            var url = "http://localhost:8082/tiposervicio";
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
                var servicios = JsonConvert.DeserializeObject<List<TipoServicioDto>>(json);
                labelNumTipoSer.Text = $" {servicios?.Count ?? 0}";
                var tipoServicios = new List<TipoServicioDto>
                {
                    new TipoServicioDto
                    {
                        Id = 0,
                        Nombre = "Todos las servicios"
                    }
                };
                tipoServicios.AddRange(servicios);
                return tipoServicios.OrderBy(s => s.Nombre).ToList(); ;
            }
        }

        private void CargarTodosLosServicios()
        {
            _serviciosCompletos = ObtenerServicios();
            _serviciosFiltrados = new List<ServicioDto>(_serviciosCompletos);
            _paginaActual = 1;

            pasarPagina();
        }

        
    }
}
