using Newtonsoft.Json;
using ServiciosInfo.Models;
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
        private readonly UsersDto _usuarioActual;
        public PanelServicios(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelServicios_Load(object sender, EventArgs e)
        {
            dataGridViewServicios.ReadOnly = true;
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _serviciosCompletos = new List<ServicioDto>();
            _serviciosFiltrados = new List<ServicioDto>();

            ActualizarRegiones();
            CargarTodosLosServicios();

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirServicio.Left = panelVisualServicios.Width - 60;

            textBoxSerBuscar.Left = 50;
            textBoxSerBuscar.Width = panelVisualServicios.Width - 350;

            comboBoxSerFiltrar.Width = 180;
            comboBoxSerFiltrar.Left = textBoxSerBuscar.Right + 30;

            anyadirServicio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirServicio.Width, anyadirServicio.Height, anyadirServicio.Width, anyadirServicio.Height));
        }
        private void PanelServicios_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualUsuarios.Invalidate();
        }

        private void panelVisualServicios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(
                textBoxSerBuscar.Left - 35,
                textBoxSerBuscar.Top - 15,
                textBoxSerBuscar.Width + 45,
                textBoxSerBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSerBuscar.Left - 25, textBoxSerBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(
                comboBoxSerFiltrar.Left - 10,
                comboBoxSerFiltrar.Top - 10,
                comboBoxSerFiltrar.Width + 25,
                comboBoxSerFiltrar.Height + 20
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














        private void ModificarServicio(ServicioDto servicio)
        {

            Servicio pantallaModificar = new Servicio(servicio, _token);
            pantallaModificar.Form = "Modificar información de " + servicio.Nombre;
            pantallaModificar.LabelTituoCrearServicio = "MODIFICAR SERVICIO";
            pantallaModificar.buttonSerModificar = true;
            pantallaModificar.buttonSerAnyadir = false;

            pantallaModificar.TboxNombreServicio.Text = servicio.Nombre;
            pantallaModificar.TxtBoxDescripcion.Text = servicio.Descripcion;
            pantallaModificar.TextBoxPrecio.Text = servicio.Precio.ToString();
            pantallaModificar.TextBoxDuracion.Text = servicio.Duracion.ToString();
            pantallaModificar.ComboTipoServicio.SelectedIndex = Convert.ToInt32(servicio.TipoServicio?.Id - 1);

            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Servicio modificado correctamente", "Éxito", MessageBoxButtons.OK);
                CargarTodosLosServicios();
                filtrarServicios();
            }
        }


        private void EliminarServicio(ServicioDto servicio)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio \"{servicio.Nombre}\"?",
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

                        var url = $"http://localhost:8082/servicio/{servicio.Id_Servicio}";
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

                                // Refrescar la tabla
                                RecargarServicios();
                                pasarPagina();
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


        private void anyadirServicio_Click(object sender, EventArgs e)
        {
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
                RecargarServicios();
                pasarPagina();
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
                return servicios;
            }
        }


        private void RecargarServicios()
        {
            _servicios = ObtenerServicios();

            if (_servicios.Count % 15 != 0)
            {
                pagSer = (_servicios.Count / 15) + 1;
            }
            else
            {
                pagSer = (_servicios.Count / 15);
            }

            labelNumServicios.Text = $" {_servicios.Count}";
            labelNumTipoSer.Text = (comboBoxSerFiltrar.Items.Count - 1).ToString();
        }
        private void pasarPagina()
        {
            dataGridViewServicios.Rows.Clear();

            int registrosASaltar = (contador - 1) * 15;
            var servicioPagina = _servicios.Skip(registrosASaltar).Take(15).ToList();

            foreach (var u in servicioPagina)
            {
                var precio = u.Precio.ToString() + " €";
                var duracion = u.Duracion.ToString() + " minutos";
                int index = dataGridViewServicios.Rows.Add(
                    u.Nombre,
                   u.Descripcion,
                    duracion,
                    precio,
                    u.TipoServicio?.Nombre

                );

                dataGridViewServicios.Rows[index].Tag = u;
            }
        }


        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            if (e.RowIndex >= dataGridViewServicios.Rows.Count) return;

            var fila = dataGridViewServicios.Rows[e.RowIndex];
            var servicio = fila.Tag as ServicioDto;
            if (servicio == null) return;

            var columna = dataGridViewServicios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnModificar")
            {
                ModificarServicio(servicio);
            }
            else if (columna == "dataGridViewImageColumnEliminar")
            {
                EliminarServicio(servicio);
            }

        }

        private void filtrarServicios()
        {
            string texto = textBoxSerBuscar.Text.Trim().ToLower();
            string categoria = comboBoxSerFiltrar.SelectedItem.ToString();

            if (_servicios == null) return;

            var listaFiltrada = _servicios.AsEnumerable();

            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    (s.Nombre != null && s.Nombre.ToLower().Contains(texto)) ||
                    (s.Descripcion != null && s.Descripcion.ToLower().Contains(texto))
                );
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    s.TipoServicio != null &&
                    s.TipoServicio.Nombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)
                );
            }

            dataGridViewServicios.Rows.Clear();

            foreach (var s in listaFiltrada)
            {
                var precio = s.Precio + " €";
                var duracion = s.Duracion + " minutos";

                int index = dataGridViewServicios.Rows.Add(
                    s.Nombre,
                    s.Descripcion,
                    duracion,
                    precio,
                    s.TipoServicio?.Nombre
                );

                dataGridViewServicios.Rows[index].Tag = s;
            }
        }

        private void comboBoxSerFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }


        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagSer)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagSer)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagSer)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }

        
    }
}
