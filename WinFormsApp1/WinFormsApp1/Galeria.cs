using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Galeria : Form
    {
        private readonly GaleriaDto _galeria;
        private long? _idServicioSeleccionado = null;
        private readonly string _token;
        public Galeria(GaleriaDto galeria, string token)
        {
            InitializeComponent();
            _galeria = galeria;
            _token = token;
        }

        private void Galeria_Load(object sender, EventArgs e)
        {

        }

        private void buttonHoServicio_Click(object sender, EventArgs e)
        {
            var listaServicios = ObtenerServicios();
            if (listaServicios == null || listaServicios.Count == 0) return;

            using (var buscador = new Busqueda("Seleccionar Servicio", listaServicios))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    var serv = (ServicioDto)buscador.ItemSeleccionado;
                    textBoxHoServicio.Text = serv.Nombre;
                    _idServicioSeleccionado = serv.Id_Servicio;
                }
            }
        }

        private List<ServicioDto> ObtenerServicios()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8082/servicio");
                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var resp = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(resp.GetResponseStream()))
                    return JsonConvert.DeserializeObject<List<ServicioDto>>(reader.ReadToEnd());
            }
            catch { return new List<ServicioDto>(); }
        }

        private void buttonAnydirImagen_Click(object sender, EventArgs e)
        {
            // Configurar el diálogo para seleccionar archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen en el PictureBox
                string rutaImagen = openFileDialog.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(rutaImagen);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void ButtonGaAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones previas
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Primero selecciona una imagen con el botón correspondiente.", "Aviso");
                    return;
                }

                if (_idServicioSeleccionado == null)
                {
                    MessageBox.Show("Por favor, selecciona un servicio.");
                    return;
                }

                // 2. Convertir la imagen del PictureBox a Bytes
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    // Guardamos la imagen del picturebox en el stream para obtener los bytes
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }

                // 3. Configurar la petición Multipart (Form Data)
                long idServicio = _idServicioSeleccionado.Value;
                var url = $"http://localhost:8082/api/imagenes/subir/{idServicio}";
                string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var requestStream = request.GetRequestStream())
                {
                    using (var writer = new StreamWriter(requestStream))
                    {
                        writer.WriteLine("--" + boundary);
                        // "foto" debe coincidir con @RequestParam("foto") en Java
                        writer.WriteLine("Content-Disposition: form-data; name=\"foto\"; filename=\"imagen.jpg\"");
                        writer.WriteLine("Content-Type: image/jpeg");
                        writer.WriteLine();
                        writer.Flush();

                        // Escribimos los bytes que sacamos del PictureBox
                        requestStream.Write(imageBytes, 0, imageBytes.Length);

                        writer.WriteLine();
                        writer.WriteLine("--" + boundary + "--");
                        writer.Flush();
                    }
                }

                // 4. Leer respuesta
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string res = reader.ReadToEnd();
                        MessageBox.Show("Imagen del PictureBox subida con éxito");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir desde PictureBox: " + ex.Message);
            }
        }


    }


    }
