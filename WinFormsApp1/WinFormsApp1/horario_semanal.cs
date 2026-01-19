using Newtonsoft.Json;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using UsersInfo.Models;
using CitasInfo.Models;

namespace WinFormsApp1
{
    public partial class horario_semanal : Form
    {
        private readonly string _token;

        // Usamos long? para coincidir con tus modelos DTO
        private long? _idServicioSeleccionado = null;
        private long? _idGrupoSeleccionado = null;

        public horario_semanal(string token)
        {
            InitializeComponent();
            _token = token;

            // Configuración para el selector de Hora de Inicio
            dateTimePickerHoaraInicio.Format = DateTimePickerFormat.Time;
            dateTimePickerHoaraInicio.ShowUpDown = true; // Quita el calendario y pone flechitas

            // Configuración para el selector de Hora de Fin
            dateTimePickerHoraFin.Format = DateTimePickerFormat.Time;
            dateTimePickerHoraFin.ShowUpDown = true;

            // Opcional: Forzar el formato de 24 horas (18:00)
            dateTimePickerHoaraInicio.CustomFormat = "HH:mm";
            dateTimePickerHoraFin.CustomFormat = "HH:mm";
        }

        private void buttonHoServicio_Click(object sender, EventArgs e)
        {
            // Cambiado a la URL correcta: /servicio
            var listaServicios = ObtenerServiciosDeAPI();

            if (listaServicios == null || listaServicios.Count == 0)
            {
                MessageBox.Show("No se pudieron cargar los servicios.");
                return;
            }

            using (var buscador = new FormSelectorBusqueda("Seleccionar Servicio", listaServicios))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    var serv = (ServicioDto)buscador.ItemSeleccionado;

                    textBoxHoServicio.Text = serv.Nombre;
                    // Usamos Id_Servicio que es el nombre en tu modelo ServicioDto
                    _idServicioSeleccionado = serv.Id_Servicio;
                }
            }
        }

        private void buttonHoBrupo_Click(object sender, EventArgs e)
        {
            // Cambiado a la URL correcta: /grupos (o como sea en tu API)
            var listaGrupos = ObtenerGruposDeAPI();

            if (listaGrupos == null || listaGrupos.Count == 0)
            {
                MessageBox.Show("No se pudieron cargar los grupos.");
                return;
            }

            using (var buscador = new FormSelectorBusqueda("Seleccionar Grupo", listaGrupos))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    var grupo = (GrupoDto)buscador.ItemSeleccionado;

                    textBoxHoGrupo.Text = grupo.Curso;
                    _idGrupoSeleccionado = grupo.Id;
                }
            }
        }

        // --- MÉTODOS DE CONEXIÓN (Ajustados a tu PanelServicios) ---

        private List<ServicioDto> ObtenerServiciosDeAPI()
        {
            try
            {
                // URL corregida a singular como en tu PanelServicios
                var url = "http://localhost:8082/servicio";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<ServicioDto>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error servicios: " + ex.Message);
                return new List<ServicioDto>();
            }
        }

        private List<GrupoDto> ObtenerGruposDeAPI()
        {
            try
            {
                // Verifica si grupos es plural o singular en tu API
                var url = "http://localhost:8082/grupos";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<GrupoDto>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error grupos: " + ex.Message);
                return new List<GrupoDto>();
            }
        }
        private void EnviarPostHorario(string json)
        {
            try
            {
                // Tu endpoint en Java
                var url = "http://localhost:8082/horarios";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Horario creado correctamente en el servidor.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (WebException ex)
            {
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    string error = reader.ReadToEnd();
                    MessageBox.Show("Error de validación en Java: " + error);
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (_idServicioSeleccionado == null || _idGrupoSeleccionado == null)
            {
                MessageBox.Show("Selecciona Servicio y Grupo");
                return;
            }

            try
            {
                // 2. Construir el objeto exactamente como pide tu Java
                // Importante: La API espera "HH:mm" para LocalTime
                var objetoParaEnviar = new
                {
                    diaSemana = comboBoxDiaSemana.Text.ToUpper(), // "LUNES"
                    horaInicio = dateTimePickerHoaraInicio.Value.ToString("HH:mm"),
                    horaFin = dateTimePickerHoraFin.Value.ToString("HH:mm"),
                    plazas = (long)numericPlazas.Value,
                    servicio = new { id = _idServicioSeleccionado.Value }, // Enviamos "id"
                    grupo = new { id = _idGrupoSeleccionado.Value }        // Enviamos "id"
                };

                // 3. Serializar y enviar
                string json = JsonConvert.SerializeObject(objetoParaEnviar);
                EnviarPostHorario(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void horario_semanal_Load(object sender, EventArgs e)
        {

        }
    }
}