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
        private void CargarComentario()
        {
            string tratamientos = richTextBoxTratamientos.Text ?? "";
            string observaciones = richTextBoxObservaciones.Text ?? "";
            var productos = richTextBoxProductos.Text ?? "";

            var url = $"http://localhost:8082/citas/{_cita.Id}/ficha";
            var data = "{\r\n  \"tratamientos\": \"" + tratamientos + "\",\r\n  \"productos\": \"" + productos + "\",\r\n  \"observaciones\": \"" + observaciones + "\"\r\n}\r\n";

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
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
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
                MessageBox.Show("Error al modificar la ficha de la cita", "Error al modificar la ficha de la cita", MessageBoxButtons.OK);
            }
        }

        private bool CambiarEstado()
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
                        return true;
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
            return false;
        }

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (CambiarEstado())
            {
                CargarComentario();
            }
        }
    }
}
