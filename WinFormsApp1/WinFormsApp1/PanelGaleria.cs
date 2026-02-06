using CitasInfo.Models;
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
using UsersInfo.Models;
using WinFormsApp1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class PanelGaleria : Form
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
        private static List<GaleriaDto> _galeria;
        private readonly UsersDto _usuarioActual;
        private static List<ServicioDto> _servicios;
        public PanelGaleria(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelGaleria_Load(object sender, EventArgs e)
        {


            DataGridViewImageColumn colImagen = new DataGridViewImageColumn();

            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom; // Para que no se deforme
            colImagen.Width = 120;


            _galeria = new List<GaleriaDto>();
            RecargarGaleria();
            pasarPagina();
            ConfigurarUIEstiloImagen();
            MostrarGaleriaEnPaneles(_galeria);

        }

        private void ConfigurarUIEstiloImagen()
        {
            anyadirGaleria.Text = "+";
            anyadirGaleria.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirGaleria.FlatStyle = FlatStyle.Flat;
            anyadirGaleria.FlatAppearance.BorderSize = 0;
            anyadirGaleria.BackColor = Color.FromArgb(255, 128, 0);
            anyadirGaleria.ForeColor = Color.White;
            anyadirGaleria.Size = new Size(45, 45);

            anyadirGaleria.Left = panelVisualGaleria.Width - 60;

            textBoxSerBuscar.Left = 50;
            textBoxSerBuscar.Width = panelVisualGaleria.Width - 350;

            comboBoxSerFiltrar.Width = 180;
            comboBoxSerFiltrar.Left = textBoxSerBuscar.Right + 30;

            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirGaleria.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirGaleria.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirGaleria.Width, anyadirGaleria.Height, anyadirGaleria.Width, anyadirGaleria.Height));
        }


        private void PanelGaleria_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualGaleria.Invalidate();
        }


        private void panelVisualGaleria_Paint(object sender, PaintEventArgs e)
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
        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {

        }
        private List<GaleriaDto> ObtenerGaleria()
        {

            var url = "http://localhost:8082/api/imagenes";
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
                var galeria = JsonConvert.DeserializeObject<List<GaleriaDto>>(json);
                return galeria;
            }
        }


        private void RecargarGaleria()
        {
            _galeria = ObtenerGaleria();

            if (_galeria != null)
            {

                if (_galeria.Count % 15 != 0)
                {
                    pagSer = (_galeria.Count / 15) + 1;
                }
                else
                {
                    pagSer = (_galeria.Count / 15);
                }

            }
        }

        private void pasarPagina()
        {
            // dataGridViewGaleria.Rows.Clear();

            int registrosASaltar = (contador - 1) * 15;
            var galeriaPagina = _galeria?.Skip(registrosASaltar).Take(15).ToList();

            if (galeriaPagina != null)
            {



                foreach (var g in galeriaPagina)
                {
                    Image foto = ConvertirBase64AImagen(g.ImagenBase64);

                    //int index = dataGridViewGaleria.Rows.Add(
                    //    g.Servicio?.Nombre ?? "Sin Servicio",
                    //    foto

                    //);

                    //dataGridViewGaleria.Rows[index].Height = 100;
                    //dataGridViewGaleria.Rows[index].Tag = g;
                }
            }

        }
        private Image ConvertirBase64AImagen(string base64String)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(base64String)) return null;

                // Limpieza de cabeceras comunes en Base64
                string base64Data = base64String.Contains(",") ? base64String.Split(',')[1] : base64String;

                byte[] imageBytes = Convert.FromBase64String(base64Data);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Creamos una copia de la imagen para que no se bloquee el stream
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir imagen: " + ex.Message);
                return null;
            }
        }

        private Panel CrearPanelImagen(GaleriaDto item, int ancho)
        {
            // 1. Ajustamos el alto del panel (280) para que quepa el botón de 50px de alto
            Panel panel = new Panel
            {
                Size = new Size(200, 280), // Aumentado de 220 a 280
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                Cursor = Cursors.Hand
            };

            // 2. Imagen
            PictureBox pb = new PictureBox
            {
                Size = new Size(180, 140),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = ConvertirBase64AImagen(item.ImagenBase64),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            // 3. Texto del Servicio
            Label lblServicio = new Label
            {
                Text = item.Servicio?.Nombre ?? "Sin Servicio",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 160),
                Size = new Size(180, 40), // Más alto por si el nombre es largo
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 4. Botón de Eliminar (Centrado y con mejor fuente)
            Button btnEliminar = new Button
            {
                Text = "BORRAR 🗑️", // Añadimos texto para aprovechar el ancho de 100
                Size = new Size(120, 45), // Un poco más ancho para que se vea imponente
                                          // Centrado horizontal: (AnchoPanel 200 - AnchoBoton 120) / 2 = 40
                Location = new Point(40, 215),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(255, 230, 230), // Fondo suave rojizo
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnEliminar.FlatAppearance.BorderSize = 1; // Un pequeño borde para definirlo
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            // Cambio de color de letra al pasar el ratón
            btnEliminar.MouseEnter += (s, e) => btnEliminar.ForeColor = Color.White;
            btnEliminar.MouseLeave += (s, e) => btnEliminar.ForeColor = Color.Red;

            btnEliminar.Click += (s, e) => EliminarImagen(item);

            // Efectos Hover del Panel
            panel.MouseEnter += (s, e) => { panel.BackColor = Color.FromArgb(248, 248, 248); };
            panel.MouseLeave += (s, e) => { panel.BackColor = Color.White; };

            panel.Controls.Add(pb);
            panel.Controls.Add(lblServicio);
            panel.Controls.Add(btnEliminar);

            return panel;
        }
        private void MostrarGaleriaEnPaneles(List<GaleriaDto> imagenes)
        {
            // Limpiar el contenedor (usa un FlowLayoutPanel para mejor resultado)
            flowLayoutPanelGaleria.Controls.Clear();
            flowLayoutPanelGaleria.AutoScroll = true;

            if (imagenes == null || imagenes.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "✅ No hay imágenes en la galería",
                    Font = new Font("Segoe UI", 14, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(50)
                };
                flowLayoutPanelGaleria.Controls.Add(lblVacio);
                return;
            }

            foreach (var item in imagenes)
            {
                // Creamos el panel de la foto
                Panel p = CrearPanelImagen(item, 200);

                // Lo añadimos al contenedor
                flowLayoutPanelGaleria.Controls.Add(p);
            }
        }


        private void EliminarImagen(GaleriaDto galeria)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio \"{galeria.Servicio}\"?",
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

                        var url = $"http://localhost:8082/api/imagenes/{galeria.Id}";
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
                                RecargarGaleria();
                                MostrarGaleriaEnPaneles(_galeria);

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



        private void anyadirGaleria_Click(object sender, EventArgs e)
        {
            Galeria pantallaAnyadir = new Galeria(null, _token);
            pantallaAnyadir.Text = "Añadir Galeria nuevo";
            pantallaAnyadir.labelTituoCrearGaleria.Text = "AÑADIR GALERIA";
            pantallaAnyadir.ButtonGaModificar.Visible = false;
            pantallaAnyadir.ButtonGaAnyadir.Visible = true;



            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarGaleria();
                MostrarGaleriaEnPaneles(_galeria);
                pasarPagina();
            }
        }

        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarGaleria();
        }

        private void filtrarGaleria()
        {

            string texto = textBoxSerBuscar.Text.Trim().ToLower();


            string categoria = comboBoxSerFiltrar.SelectedItem?.ToString() ?? "";


            if (_galeria == null) return;

            var listaFiltrada = _galeria.AsEnumerable();


            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(g =>
                    g.Servicio != null &&
                    g.Servicio.Nombre != null &&
                    g.Servicio.Nombre.ToLower().Contains(texto)
                );
            }


            if (!string.IsNullOrEmpty(categoria) && categoria != "Todas")
            {
                listaFiltrada = listaFiltrada.Where(g =>
                    g.Servicio?.TipoServicio != null &&
                    g.Servicio.TipoServicio.Nombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)
                );
            }


            MostrarGaleriaEnPaneles(listaFiltrada.ToList());
        }

        private void comboBoxSerFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarGaleriaPorServicio();
        }

        private void filtrarGaleriaPorServicio()
        {
            // 1. Obtener criterios de búsqueda
            string texto = textBoxSerBuscar.Text.Trim().ToLower();
            string categoria = comboBoxSerFiltrar.SelectedItem?.ToString() ?? "";

            // 2. IMPORTANTE: Filtramos la lista de la GALERÍA (_galeria)
            if (_galeria == null) return;

            var listaFiltrada = _galeria.AsEnumerable();

            // 3. Filtrar por nombre del servicio o descripción (dentro del objeto Servicio)
            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(g =>
                    g.Servicio != null && (
                        (g.Servicio.Nombre != null && g.Servicio.Nombre.ToLower().Contains(texto)) ||
                        (g.Servicio.Descripcion != null && g.Servicio.Descripcion.ToLower().Contains(texto))
                    )
                );
            }

            // 4. Filtrar por Tipo de Servicio (dentro del objeto Servicio)
            if (!string.IsNullOrEmpty(categoria) && categoria != "Todas")
            {
                listaFiltrada = listaFiltrada.Where(g =>
                    g.Servicio?.TipoServicio != null &&
                    g.Servicio.TipoServicio.Nombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)
                );
            }

            // 5. Mostrar los paneles con las fotos resultantes
            // Esto llamará a tu método CrearPanelImagen para cada resultado
            MostrarGaleriaEnPaneles(listaFiltrada.ToList());
        }
    }
        
}
