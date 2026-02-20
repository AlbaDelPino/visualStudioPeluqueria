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

        private bool CargarFicha()
        {
            string observaciones = richTextBoxObservaciones.Text;
            string productos = richTextBoxProductos.Text;
            var tratamientos = richTextBoxTratamientos.Text;

            var url = $"http://localhost:8082/citas/{_cita.Id}/ficha";
            var data = "{\r\n  \"observaciones\": \"" + observaciones + "\",\r\n  \"productos\": \"" + productos + "\",\r\n  \"tratamientos\": \"" + tratamientos + "\"\r\n}\r\n";

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
                MessageBox.Show("Error al modificar la ficha", "Error al modificar la ficha", MessageBoxButtons.OK);
            }
            return false;
        }

        private bool CambiarEstado()
        {
            try
            {
                var url = $"http://localhost:8082/citas/{_cita.Id}/estado?estado=COMPLETADO";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "PUT";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var response = (HttpWebResponse)request.GetResponse())
                {

                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message);
                return false;
            }
        }

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (CambiarEstado())
            {
                if (CargarFicha())
                {
                    MessageBox.Show("✅ Cita completada y ficha guardada.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                

            
        }
        }

        private void labelProductos_Click(object sender, EventArgs e)
        {

        }

        private void FichaCita_Load(object sender, EventArgs e)
        {

        }
    }
}
