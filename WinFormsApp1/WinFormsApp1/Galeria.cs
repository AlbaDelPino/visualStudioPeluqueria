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
    }
}
