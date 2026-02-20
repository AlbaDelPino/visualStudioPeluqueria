using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class FichaCita : Form
    {
        private readonly string _token;
        private readonly CitaDto _cita;
        public FichaCita(CitaDto cita, string token)
        {
            InitializeComponent();
            _cita = cita;
            _token = token;
        }

        private List<ClienteDto> ObtenerClientes()
        {
            try
            {
                var url = "http://localhost:8082/clientes";
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
                    var clientes = JsonConvert.DeserializeObject<List<ClienteDto>>(json);
                    return clientes;
                }

            }
            catch (WebException e)
            {
                MessageBox.Show($"Error de conexión: {e.Message}", "No tienes permisos",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private bool CargarComentario()
        {
            string comentario = "";
            string alergenos = "";
            var observaciones = "";
            var clientes = ObtenerClientes();
            foreach (ClienteDto c in clientes)
            {
                if (c.Id == _cita.Cliente.Id)
                {
                    comentario = c.Comentario ?? "";
                    comentario = comentario.Replace("\n", "\\n");
                    alergenos = c.Alergenos ?? "";
                    observaciones = c.Observacion ?? "";
                }
            }

            comentario += "Fecha: " + _cita.Fecha.ToString() + "\\nServicio: " + _cita.Horario.Servicio.Nombre;
            if (!string.IsNullOrEmpty(richTextBoxTratamientos.Text))
            {
                comentario += "\\nTratamientos: " + richTextBoxTratamientos.Text;
            }
            if (!string.IsNullOrEmpty(richTextBoxProductos.Text))
            {
                comentario += "\\nProductos: " + richTextBoxProductos.Text;
            }
            if (!string.IsNullOrEmpty(richTextBoxObservaciones.Text))
            {
                comentario += "\\nObservaciones: " + richTextBoxObservaciones.Text;
            }
            comentario += "\\n\\n";

            var url = $"http://localhost:8082/clientes/" + _cita.Cliente.Id;
            var data = "{\r\n  \"username\": \"" + _cita.Cliente.Username + "\",\r\n  \"contrasenya\": \"" + _cita.Cliente.Contrasenya + "\",\r\n  \"email\": \"" + _cita.Cliente.Email + "\",\r\n  \"nombre\": \"" + _cita.Cliente.Nombre + "\",\r\n  \"telefono\": \"" + _cita.Cliente.Telefono + "\",\r\n  \"estado\": \"" + _cita.Cliente.Estado + "\",\r\n  \"comentarioCitas\": \"" + comentario + "\",\r\n  \"observacion\": \"" + observaciones + "\",\r\n  \"alergenos\": \"" + alergenos + "\"\r\n}\r\n";

            var request = (HttpWebRequest)WebRequest.Create(url);
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
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return true;
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
                MessageBox.Show("Error al modificar usuario", "Error al modificar usuario", MessageBoxButtons.OK);
            }
            return false;
        }

        private void CambiarEstado()
        {
            try
            {
                var urlCOM = $"http://localhost:8082/citas/{_cita.Id}/estado?estado=COMPLETADO";
                var requestCOM = (HttpWebRequest)WebRequest.Create(urlCOM);
                requestCOM.Method = "PUT";
                requestCOM.ContentType = "application/json";
                requestCOM.Accept = "application/json";
                requestCOM.Headers["Authorization"] = $"Bearer {_token}";

                using (var response = (HttpWebResponse)requestCOM.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error al completar la cita: {response.StatusCode}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al completar la cita: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (CargarComentario())
            {
                CambiarEstado();
            }
        }

        private void labelProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
