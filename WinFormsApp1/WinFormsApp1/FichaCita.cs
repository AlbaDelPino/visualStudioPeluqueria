using CitasInfo.Models;
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

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            //completar ficha
            
                try
                {
                    var url = $"http://localhost:8082/citas/{_cita.Id}/estado/COMPLETADO";
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "PUT";
                    request.ContentType = "application/json";
                    request.Accept = "application/json";
                    request.Headers["Authorization"] = $"Bearer {_token}";

                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Cita completada correctamente", "Éxito",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                          
                        }
                        else
                        {
                            MessageBox.Show($"Error al completa r la cita: {response.StatusCode}", "Error",
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

        private void FichaCita_Load(object sender, EventArgs e)
        {

        }
    }
}
