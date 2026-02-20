using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiciosInfo.Models;

namespace WinFormsApp1
{
    public partial class Servicio : Form
    {
        private readonly ServicioDto _servicio;
        private List<TipoServicioDto> _tiposServicio;

        private readonly string _token;
        public Servicio(ServicioDto servicio, string token)
        {
            InitializeComponent();
            _servicio = servicio;
            _token = token;
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            _tiposServicio = ObtenerTiposServicio();

            comboTipoServicio.DataSource = _tiposServicio;
            comboTipoServicio.DisplayMember = "Nombre";
            comboTipoServicio.ValueMember = "Id";

            if (_servicio != null)
            {
                tboxNombreServicio.Text = _servicio.Nombre;
                txtBoxDescripcion.Text = _servicio.Descripcion;
                textBoxPrecio.Text = _servicio.Precio.ToString();
                textBoxDuracion.Text = _servicio.Duracion.ToString();

                // Seleccionar el tipo actual
                comboTipoServicio.SelectedValue = _servicio.TipoServicio?.Id;
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
                var tipos = JsonConvert.DeserializeObject<List<TipoServicioDto>>(json);
                return tipos;
            }
        }

        public event EventHandler ServicioActualizado;

        private void ButtonSerAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tboxNombreServicio.Text;
                string descripcion = txtBoxDescripcion.Text;
                string precio = textBoxPrecio.Text;
                string duracion = textBoxDuracion.Text;
                string idTipo = (comboTipoServicio.SelectedIndex + 1).ToString();
                string nombreTipo = comboTipoServicio.SelectedItem.ToString();

                var url = $"http://localhost:8082/servicio";
                string data = "{\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"descripcion\": \"" + descripcion + "\",\r\n  \"precio\": \"" + precio + "\",\r\n  \"duracion\": \"" + duracion + "\",\r\n  \"tipoServicio\": {\n\r\r\"id\": \"" + idTipo + "\",\n\r\r  \"nombre\": \"" + nombreTipo + "\"\n\r}\r}";

                var request = (HttpWebRequest)WebRequest.Create(url);
                //string json = $"{{\"data\":\"{data}\"}}";
                string json = data;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string mensaje = "";
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    mensaje = reader.ReadToEnd();
                }
                MessageBox.Show("Error al añadir el servicio", "Error al añadir el servicio", MessageBoxButtons.OK);
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Error al añadir el servicio", "Error al añadir el servicio", MessageBoxButtons.OK);
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }


        private void ButtonSerModificar_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreServicio.Text;
            string descripcion = txtBoxDescripcion.Text;
            string precio = textBoxPrecio.Text;
            string duracion = textBoxDuracion.Text;
            string idTipo = (comboTipoServicio.SelectedIndex + 1).ToString();
            string nombreTipo = comboTipoServicio.SelectedItem.ToString();

            var url = $"http://localhost:8082/servicio/" + _servicio.Id_Servicio;
            string data = "{\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"descripcion\": \"" + descripcion + "\",\r\n  \"precio\": \"" + precio + "\",\r\n  \"duracion\": \"" + duracion + "\",\r\n  \"tipoServicio\": {\r\n\n\"id\": \"" + idTipo + "\",\r\n\n  \"nombre\": \"" + nombreTipo + "\"\r\n}\r}";

            var request = (HttpWebRequest)WebRequest.Create(url);
            //string json = $"{{\"data\":\"{data}\"}}";
            string json = data;
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["Authorization"] = $"Bearer {_token}";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            MessageBox.Show("Servicio modificado correctamente", "Servicio modificado correctamente", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string mensaje = "";
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    mensaje = reader.ReadToEnd();
                }
                MessageBox.Show("Error al modificar servicio", "Error al modificar servicio", MessageBoxButtons.OK);
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void panelServicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
