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
        public PanelGaleria(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelGaleria_Load(object sender, EventArgs e)
        {

            _galeria = new List<GaleriaDto>();

            DataGridViewImageColumn colImagen = new DataGridViewImageColumn();

            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom; // Para que no se deforme
            colImagen.Width = 120;

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

            if (_galeria.Count % 15 != 0)
            {
                pagSer = (_galeria.Count / 15) + 1;
            }
            else
            {
                pagSer = (_galeria.Count / 15);
            }


        }

        private void pasarPagina()
        {
            // dataGridViewGaleria.Rows.Clear();

            int registrosASaltar = (contador - 1) * 15;
            var galeriaPagina = _galeria.Skip(registrosASaltar).Take(15).ToList();

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
            // 1. Crear el panel contenedor (la "tarjeta")
            Panel panel = new Panel
            {
                Size = new Size(200, 220), // Tamaño fijo para que parezca una galería
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(10), // Espacio entre tarjetas
                BorderStyle = BorderStyle.None,
                Cursor = Cursors.Hand
            };

            // 2. Crear el PictureBox para la imagen
            PictureBox pb = new PictureBox
            {
                Size = new Size(180, 150),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = ConvertirBase64AImagen(item.ImagenBase64), // Usamos tu función anterior
                BackColor = Color.FromArgb(245, 245, 245)
            };

            // 3. Crear el Label para el nombre del servicio
            Label lblServicio = new Label
            {
                Text = item.Servicio.Nombre ?? "Sin Servicio",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 165),
                Size = new Size(180, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 4. Botón de Eliminar (opcional, como el de "Ver Usuario")
            Button btnEliminar = new Button
            {
                Text = "🗑️",
                Size = new Size(30, 30),
                Location = new Point(160, 185),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Red
            };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += (s, e) => EliminarImagen(item); // Tu lógica de borrar

            // Efecto Hover (como el que tienes en citas)
            panel.MouseEnter += (s, e) => { panel.BackColor = Color.FromArgb(240, 240, 240); };
            panel.MouseLeave += (s, e) => { panel.BackColor = Color.White; };

            // Agregar controles al panel
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

                        var url = $"http://localhost:8082/servicio/{galeria.Servicio}";
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
                pasarPagina();
            }
        }
    }
}
