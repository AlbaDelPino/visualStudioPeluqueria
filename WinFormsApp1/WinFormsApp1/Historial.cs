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
    public partial class Historial : Form
    {
        private readonly string _token;
        private readonly CitaDto _cita; // Esta es la tabla 'Cita'
        private readonly UsersDto _usuarioActual;

        public Historial(CitaDto cita, string token, UsersDto usuarioActual)
        {
            InitializeComponent();
            _cita = cita;
            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void Historial_Load(object sender, EventArgs e)
        {

            // 2. Lógica de la tabla CITA (Los 3 campos)
            if (_cita.Estado.ToUpper() == "COMPLETADO")
            {
                // Si ya existe en la tabla Cita, mostramos lo guardado
                richTextBoxTratamientos.Text = _cita.Tratamientos;
                richTextBoxProductos.Text = _cita.Productos;
                richTextBoxObservaciones.Text = _cita.Observaciones;

                // Bloqueamos edición
                ConfigurarControles(true);
            }
            else
            {
                // Si la cita está en curso, dejamos los campos vacíos para rellenar
                ConfigurarControles(false);
            }
        }

        private void ConfigurarControles(bool esLectura)
        {
            richTextBoxTratamientos.ReadOnly = esLectura;
            richTextBoxProductos.ReadOnly = esLectura;
            richTextBoxObservaciones.ReadOnly = esLectura;
            buttonCompletar.Visible = !esLectura; // Solo mostramos el botón si no está completada

            if (esLectura)
            {
                richTextBoxTratamientos.BackColor = Color.FromArgb(240, 240, 240);
            }
        }



        // --- LLAMADAS A TU API (Java Controller) ---

        private bool GuardarFichaAPI()
        {
            try
            {
                // URL: @PutMapping("/{id}/ficha")
                var url = $"http://localhost:8082/citas/{_cita.Id}/ficha";

                // Creamos el objeto Cita para el @RequestBody de Java
                var citaUpdate = new
                {
                    id = _cita.Id,
                    tratamientos = richTextBoxTratamientos.Text,
                    productos = richTextBoxProductos.Text,
                    observaciones = richTextBoxObservaciones.Text
                };

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "PUT";
                request.ContentType = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                string json = JsonConvert.SerializeObject(citaUpdate);

                using (var sw = new StreamWriter(request.GetRequestStream()))
                {
                    sw.Write(json);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar ficha: " + ex.Message);
                return false;
            }
        }

        private bool FinalizarCitaAPI() 
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
            if (FinalizarCitaAPI())
            {
                if (GuardarFichaAPI())
                {
                    MessageBox.Show("✅ Cita completada y ficha guardada.");

                    // BUSCAR AL PADRE Y PEDIR RECARGA
                    // Buscamos en los formularios abiertos el PanelPrincipal
                    var principal = Application.OpenForms.OfType<PanelPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.RecargarDatos(); // Llamamos al método de recarga
                    }

                    this.Close(); // Esto cerrará el formulario dentro del panel
                }
            }
        }

    }

}
