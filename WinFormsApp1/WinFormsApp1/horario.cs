using CitasInfo.Models;
using Newtonsoft.Json;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Horario : Form
    {
        private readonly string _token;

        private long? _idServicioSeleccionado = null;
        private long? _idGrupoSeleccionado = null;

        private long? _idHorarioExistente = null;

        public Horario(string token)
        {
            InitializeComponent();
            _token = token;
            ConfigurarControlesHora();

            labelTituloCrearHorario.Visible = true;
            labelTituoModificarHorario.Visible = false;
            buttonGuardar.Visible = true;
            buttonModificar.Visible = false;
        }

        public Horario(HorarioSemanalDto datos, string token) : this(token)
        {

            _idHorarioExistente = datos.Id;

            labelTituloCrearHorario.Visible = false;
            labelTituoModificarHorario.Visible = true;
            buttonGuardar.Visible = false;
            buttonModificar.Visible = true;

            comboBoxDiaSemana.Text = datos.DiaSemana;
            numericPlazas.Value = datos.Plazas;

            textBoxHoServicio.Text = datos.Servicio?.Nombre;
            textBoxHoGrupo.Text = datos.Grupo?.Curso;

            _idServicioSeleccionado = datos.Servicio?.Id_Servicio;
            _idGrupoSeleccionado = datos.Grupo?.Id;

            DateTime hoy = DateTime.Today;
            dateTimePickerHoaraInicio.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day,
                                                           datos.HoraInicio.Hour, datos.HoraInicio.Minute, 0);
            dateTimePickerHoraFin.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day,
                                                         datos.HoraFin.Hour, datos.HoraFin.Minute, 0);
        }

        private void ConfigurarControlesHora()
        {
            DateTime hoy = DateTime.Today;

            dateTimePickerHoaraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoaraInicio.CustomFormat = "HH:mm";
            dateTimePickerHoaraInicio.ShowUpDown = true;
            dateTimePickerHoaraInicio.Text = "00:00";

            dateTimePickerHoraFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraFin.CustomFormat = "HH:mm";
            dateTimePickerHoraFin.ShowUpDown = true;
            dateTimePickerHoraFin.Text = "00:00";
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

        private void Horario_Load(object sender, EventArgs e)
        {

        }
    }
}