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
        private static int _paginaActual = 1;
        private const int REGISTROS_POR_PAGINA = 14;
        private List<GaleriaDto> _galeriaCompleta;
        private List<GaleriaDto> _galeriaFiltrada;
        private readonly UsersDto _usuarioActual;
        private static List<ServicioDto> _servicios;
        public PanelGaleria(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelGaleria_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn colImagen = new DataGridViewImageColumn();

            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom; // Para que no se deforme
            colImagen.Width = 120;
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;

            _galeriaCompleta = new List<GaleriaDto>();
            _galeriaFiltrada = new List<GaleriaDto>();

            ActualizarRegiones();
            RecargarGaleria();
            MostrarGaleriaEnPaneles(_galeriaFiltrada);
            pasarPagina();
            

            comboBoxSerFiltrar.SelectedIndex = 0;
        }

        private void ActualizarRegiones()
        {
            anyadirGaleria.Left = comboBoxSerFiltrar.Left + comboBoxSerFiltrar.Width;

            textBoxSerBuscar.Left = 105;
            textBoxSerBuscar.Width = panelVisualGaleria.Width - 515;

            comboBoxSerFiltrar.Width = 180;
            comboBoxSerFiltrar.Left = textBoxSerBuscar.Right + 30;

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
                if (galeria != null)
                {
                    labelNumFotos.Text = $"{galeria.Count}";
                    return galeria.OrderBy(g => g.Servicio.Nombre).ToList();
                }
                return new List<GaleriaDto>();
            }
        }


        private void RecargarGaleria()
        {
            _galeriaCompleta = ObtenerGaleria();
            _galeriaFiltrada = new List<GaleriaDto>(_galeriaCompleta);
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            int totalPaginas = (_galeriaFiltrada.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _galeriaFiltrada.Count);

            foreach (GaleriaDto g in _galeriaFiltrada)
            {
                Image foto = ConvertirBase64AImagen(g.ImagenBase64);
            }
            MostrarGaleriaEnPaneles(_galeriaFiltrada);

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }
        private Image ConvertirBase64AImagen(string base64String)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(base64String)) return null;

                string base64Data = base64String.Contains(",") ? base64String.Split(',')[1] : base64String;

                byte[] imageBytes = Convert.FromBase64String(base64Data);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir la imagen");
                return null;
            }
        }

        private Panel CrearPanelImagen(GaleriaDto item, int ancho)
        {
            
                Panel panel = new Panel
            {
                Size = new Size(200, 280),
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                Cursor = Cursors.Hand
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(180, 140),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = ConvertirBase64AImagen(item.ImagenBase64),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            Label lblServicio = new Label
            {
                Text = item.Servicio?.Nombre ?? "Sin Servicio",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 160),
                Size = new Size(180, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnEliminar = new Button
            {
                Text = "BORRAR 🗑️",
                Size = new Size(120, 45),
                Location = new Point(40, 215),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(255, 230, 230),
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btnEliminar.MouseEnter += (s, e) => btnEliminar.ForeColor = Color.White;
            btnEliminar.MouseLeave += (s, e) => btnEliminar.ForeColor = Color.Red;

            btnEliminar.Click += (s, e) => EliminarImagen(item);

            panel.MouseEnter += (s, e) => { panel.BackColor = Color.FromArgb(248, 248, 248); };
            panel.MouseLeave += (s, e) => { panel.BackColor = Color.White; };

            panel.Controls.Add(pb);
            panel.Controls.Add(lblServicio);
            panel.Controls.Add(btnEliminar);

            return panel;
        }
        private void MostrarGaleriaEnPaneles(List<GaleriaDto> imagenes)
        {
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

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _galeriaFiltrada.Count);

            for (int i = inicio; i < fin; i++)
            {

                Panel p = CrearPanelImagen(imagenes[i], 200);

                flowLayoutPanelGaleria.Controls.Add(p);
            }
        }


        private void EliminarImagen(GaleriaDto galeria)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar la foto \"{galeria.Servicio}\"?",
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
                                MessageBox.Show("Foto eliminada correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RecargarGaleria();
                                MostrarGaleriaEnPaneles(_galeriaFiltrada);

                                pasarPagina();
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar la foto", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la eliminación de la foto", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }



        private void anyadirGaleria_Click(object sender, EventArgs e)
        {
            Galeria pantallaAnyadir = new Galeria(null, _token);
            pantallaAnyadir.Text = "Añadir foto nueva";
            pantallaAnyadir.labelTituoCrearGaleria.Text = "Añadir nueva foto";
            pantallaAnyadir.ButtonGaModificar.Visible = false;
            pantallaAnyadir.ButtonGaAnyadir.Visible = true;


            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto añadida correctamente", "Foto añadida correctamente", MessageBoxButtons.OK);
                RecargarGaleria();
                MostrarGaleriaEnPaneles(_galeriaFiltrada);
                pasarPagina();
            }
        }

        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarGaleria();
        }
        private void comboBoxSerFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarGaleria();
        }

        private void filtrarGaleria()
        {
            string textoBusqueda = textBoxSerBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxSerFiltrar.SelectedItem?.ToString().ToLower() ?? "";

            _galeriaFiltrada = _galeriaCompleta.Where(g =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                (g.Servicio.Nombre != null && g.Servicio.Nombre.ToLower().Contains(textoBusqueda) == true);

                bool pasaTipo = string.IsNullOrEmpty(filtroCombo) ||
                                (filtroCombo.Contains("todas las fotos", StringComparison.OrdinalIgnoreCase)) ||
                                (g.Servicio.TipoServicio.Nombre != null && g.Servicio.TipoServicio.Nombre.ToLower().Contains(filtroCombo));

                return pasaTexto && pasaTipo;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
            MostrarGaleriaEnPaneles(_galeriaFiltrada);
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_galeriaFiltrada.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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
            int totalPaginas = (_galeriaFiltrada.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
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
    }
}
