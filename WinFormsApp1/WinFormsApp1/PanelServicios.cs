using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private static int pagSer;
        private static int contador = 1;
        private static List<ServicioDto> _servicios;
        public PanelServicios(string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void PanelServicios_Load(object sender, EventArgs e)
        {
            dataGridViewServicios.ReadOnly = true;
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _servicios = new List<ServicioDto>();
            RecargarServicios();
            pasarPagina();

            ConfigurarUIEstiloImagen();

        }

        private void ConfigurarUIEstiloImagen()
        {
            // BOTÓN (+) CIRCULAR
            anyadirServicio.Text = "+";
            anyadirServicio.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirServicio.FlatStyle = FlatStyle.Flat;
            anyadirServicio.FlatAppearance.BorderSize = 0;
            anyadirServicio.BackColor = Color.FromArgb(255, 128, 0);
            anyadirServicio.ForeColor = Color.White;
            anyadirServicio.Size = new Size(45, 45);

            // POSICIÓN DEL BOTÓN: Para que esté más alto, bajamos el valor de 'Top'
            //anyadirUsuario.Top = 15;
            anyadirServicio.Left = panelVisualServicios.Width - 60; // A la derecha

            // BUSCADOR Y COMBO
            //textBoxSUsBuscar.Top = 25;
            textBoxSerBuscar.Left = 50;
            // Ajustamos el ancho para que sea dinámico pero deje espacio al combo
            textBoxSerBuscar.Width = panelVisualServicios.Width - 350;

            // COMBO (Alargado)
            // comboBoxUsFiltrar.Top = 25;
            comboBoxSerFiltrar.Width = 180; // Más ancho
            comboBoxSerFiltrar.Left = textBoxSerBuscar.Right + 30; // Se posiciona justo después del buscador

            // ANCLAJES CORRECTOS para que al estirar la ventana no se solapen
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirServicio.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        // Se llama al cargar y al cambiar el tamaño de la ventana
        private void ActualizarRegiones()
        {
            // Redondeo físico del botón naranja (Círculo perfecto)
            anyadirServicio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirServicio.Width, anyadirServicio.Height, anyadirServicio.Width, anyadirServicio.Height));
        }

        // Evento que ocurre cuando cambias el tamaño de la ventana
        private void PanelUsuario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualServicios.Invalidate(); // Fuerza a redibujar el borde gris
        }
        private void PanelServicios_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualServicios.Invalidate(); // Fuerza a redibujar el borde gris
        }


        private void panelVisualServicios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            // 1. ÁREA DEL BUSCADOR (Sigue al TextBox)
            // Aumentamos el ancho (Width + 45) para que la cápsula cubra la lupa
            Rectangle rectBusqueda = new Rectangle(
                textBoxSerBuscar.Left - 35,
                textBoxSerBuscar.Top - 10,
                textBoxSerBuscar.Width + 45,
                textBoxSerBuscar.Height + 20
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSerBuscar.Left - 25, textBoxSerBuscar.Top - 2);

            // 2. ÁREA DEL FILTRO (Sigue al ComboBox)
            Rectangle rectFiltro = new Rectangle(
                comboBoxSerFiltrar.Left - 10,
                comboBoxSerFiltrar.Top - 10,
                comboBoxSerFiltrar.Width + 25, // Un poco más ancho para el desplegable
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
                RecargarServicios();
                pasarPagina();
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

            // Aquí añadimos el token
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
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            // Validar que la fila existe
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

            // --- FILTRO POR TEXTO ---
            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    (s.Nombre != null && s.Nombre.ToLower().Contains(texto)) ||
                    (s.Descripcion != null && s.Descripcion.ToLower().Contains(texto))
                );
            }

            // --- FILTRO POR CATEGORÍA ---
            if (!string.IsNullOrEmpty(categoria))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    s.TipoServicio != null &&
                    s.TipoServicio.Nombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)
                );
            }

            // Limpiar tabla
            dataGridViewServicios.Rows.Clear();

            // Rellenar con los resultados
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
