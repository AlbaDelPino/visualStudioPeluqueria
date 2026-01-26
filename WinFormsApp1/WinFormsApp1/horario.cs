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
    public partial class Horario : Form
    {
        private readonly string _token;

        // IDs para las relaciones con Servicio y Grupo
        private long? _idServicioSeleccionado = null;
        private long? _idGrupoSeleccionado = null;

        // ID del registro actual (solo se usa en modo Edición)
        private long? _idHorarioExistente = null;

        // CONSTRUCTOR 1: Para Crear nuevo horario
        public Horario(HorarioSemanalDto horario, string token)
        {
            InitializeComponent();
            _token = token;
            ConfigurarControlesHora();

            // Configuración visual modo CREAR
            labelTituloCrearHorario.Visible = true;
            labelTituoModificarHorario.Visible = false;
            buttonGuardar.Visible = true;      // Botón que hace el POST
            buttonModificar.Visible = false;   // Botón que hace el PUT
        }

        // CONSTRUCTOR 2: Para Modificar horario existente
        public Horario(string token, HorarioSemanalDto datos) : this(null, token)
        {
            _idHorarioExistente = datos.Id;

            // Configuración visual modo EDITAR
            labelTituloCrearHorario.Visible = false;
            labelTituoModificarHorario.Visible = true;
            buttonGuardar.Visible = false;
            buttonModificar.Visible = true;

            // Rellenar los campos con los datos recibidos del DTO
            comboBoxDiaSemana.Text = datos.DiaSemana;
            numericPlazas.Value = datos.Plazas;

            // Mostrar nombres en los TextBox de búsqueda
            textBoxHoServicio.Text = datos.Servicio?.Nombre;
            textBoxHoGrupo.Text = datos.Grupo?.Curso;

            // Guardar los IDs de las relaciones
            _idServicioSeleccionado = datos.Servicio?.Id_Servicio;
            _idGrupoSeleccionado = datos.Grupo?.Id;

            // CORRECCIÓN NodaTime: Convertir LocalTime a DateTime para el Picker
            DateTime hoy = DateTime.Today;
            dateTimePickerHoaraInicio.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day,
                                                           datos.HoraInicio.Hour, datos.HoraInicio.Minute, 0);
            dateTimePickerHoraFin.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day,
                                                         datos.HoraFin.Hour, datos.HoraFin.Minute, 0);
        }

        private void ConfigurarControlesHora()
        {
            dateTimePickerHoaraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoaraInicio.CustomFormat = "HH:mm";
            dateTimePickerHoaraInicio.ShowUpDown = true;

            dateTimePickerHoraFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraFin.CustomFormat = "HH:mm";
            dateTimePickerHoraFin.ShowUpDown = true;
        }

        // --- LÓGICA DE BUSCADORES ---

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
        private void buttonHoGrupo_Click(object sender, EventArgs e)
        {
            var listaGrupos = ObtenerGrupos();
            if (listaGrupos == null || listaGrupos.Count == 0) return;

            using (var buscador = new Busqueda("Seleccionar Grupo", listaGrupos))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    UsersDto grupo = (UsersDto)buscador.ItemSeleccionado;
                    textBoxHoGrupo.Text = grupo.Nombre;
                    _idGrupoSeleccionado = grupo.Id;
                }
            }
        }
        

        // --- LÓGICA DE ENVÍO (BOTONES) ---

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            EjecutarOperacion("POST");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            EjecutarOperacion("PUT");
        }

        private void EjecutarOperacion(string metodo)
        {
            if (!_idServicioSeleccionado.HasValue || !_idGrupoSeleccionado.HasValue)
            {
                MessageBox.Show("Por favor, selecciona un Servicio y un Grupo.");
                return;
            }

            try
            {
                // Construcción del objeto JSON dinámico
                // Usamos HH:mm:ss para que Java LocalTime lo reciba correctamente
                var datosHorario = new
                {
                    diaSemana = comboBoxDiaSemana.Text.ToUpper(),
                    horaInicio = dateTimePickerHoaraInicio.Value.ToString("HH:mm:ss"),
                    horaFin = dateTimePickerHoraFin.Value.ToString("HH:mm:ss"),
                    plazas = (int)numericPlazas.Value,
                    servicio = new { id_servicio = _idServicioSeleccionado.Value },
                    grupo = new { id = _idGrupoSeleccionado.Value }
                };

                string json = JsonConvert.SerializeObject(datosHorario);
                EnviarDatosAPI(json, metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar datos: " + ex.Message);
            }
        }

        private void EnviarDatosAPI(string json, string metodo)
        {
            try
            {
                // La URL se ajusta: para PUT debe ser /horarios/{id}
                var url = "http://localhost:8082/horarios";
                if (metodo == "PUT" && _idHorarioExistente.HasValue)
                {
                    url += $"/{_idHorarioExistente.Value}";
                }

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = metodo;
                request.ContentType = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.NoContent)
                    {
                        string msg = (metodo == "POST") ? "Horario creado." : "Horario actualizado.";
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        MessageBox.Show("Error del servidor: " + reader.ReadToEnd());
                    }
                }
                else
                {
                    MessageBox.Show("Error de red: " + ex.Message);
                }
            }
        }

        // --- MÉTODOS AUXILIARES DE CARGA ---

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

        private List<UsersDto> ObtenerGrupos()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8082/api/auth/users");
                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var resp = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(resp.GetResponseStream()))
                    return JsonConvert.DeserializeObject<List<UsersDto>>(reader.ReadToEnd()).Where(u => u.Role.Equals("ROLE_GRUPO")).ToList();
            }
            catch { return new List<UsersDto>(); }
        }

        
    }
}