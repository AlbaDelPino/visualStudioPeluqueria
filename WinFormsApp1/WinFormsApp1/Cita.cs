using CitasInfo.Models;
using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Cita : Form
    {
        private readonly string _token;
        private readonly CitaDto _cita;

        private long? _idHorarioSeleccionado = null;
        private long? _idClienteSeleccionado = null;
        private string _HoraSeleccionada = null;

        public Cita(CitaDto cita, string token)
        {
            InitializeComponent();
            _cita = cita;
            _token = token;
        }

        private void buttonCitServicio_Click(object sender, EventArgs e)
        {
            var listaServicios = ObtenerServicios();
            if (listaServicios == null || listaServicios.Count == 0) return;

            using (var buscador = new Busqueda("Seleccionar Servicio", listaServicios))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    var serv = (ServicioDto)buscador.ItemSeleccionado;
                    textBoxCitServicio.Text = serv.Nombre;
                    if (textBoxCitFecha.Text != "")
                    {
                        comboBoxCitHora.Enabled = true;
                        Cita_Load(sender, e);
                    }
                }
            }
        }

        private void buttonCitCliente_Click(object sender, EventArgs e)
        {
            var listaClientes = ObtenerUsuarios().Where(u => u.Role.Equals("ROLE_CLIENTE")).ToList();
            if (listaClientes == null || listaClientes.Count == 0) return;

            using (var buscador = new Busqueda("Seleccionar Cliente", listaClientes))
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    UsersDto cliente = (UsersDto)buscador.ItemSeleccionado;
                    textBoxCitCliente.Text = cliente.Nombre;
                    _idClienteSeleccionado = cliente.Id;
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

        private List<UsersDto> ObtenerUsuarios()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:8082/api/auth/users");
                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var resp = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(resp.GetResponseStream()))
                    return JsonConvert.DeserializeObject<List<UsersDto>>(reader.ReadToEnd());
            }
            catch { return new List<UsersDto>(); }
        }

        private List<HorarioSemanalDto> ObtenerHorarios()
        {

            var url = "http://localhost:8082/horarios";
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
                var horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                return horarios;
            }
        }

        private List<BloqueDto> ComprobarHorarios()
        {
            string fecha = textBoxCitFecha.Text;
            var fechaFormato = DateTime.Now;
            string fechaConsulta = "";
            if (fecha != null)
            {
                fechaFormato = DateTime.ParseExact(fecha, "dd/MM/yyyy", new CultureInfo("es-ES"));
                fechaConsulta = fecha.Substring(6, 4) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);
            }
            var horariosExistentes = ObtenerHorarios();
            var dia = "";

            var horariosFecha = new List<HorarioSemanalDto>();
            foreach (HorarioSemanalDto h in horariosExistentes)
            {
                switch (h.DiaSemana)
                {
                    case "Lunes":
                        if (DayOfWeek.Monday == fechaFormato.DayOfWeek)
                        {
                            horariosFecha.Add(h);
                        }
                        break;
                    case "Martes":
                        if (DayOfWeek.Tuesday == fechaFormato.DayOfWeek)
                        {
                            horariosFecha.Add(h);
                        }
                        break;
                    case "Miércoles":
                        if (DayOfWeek.Wednesday == fechaFormato.DayOfWeek)
                        {
                            horariosFecha.Add(h);
                        }
                        break;
                    case "Jueves":
                        if (DayOfWeek.Thursday == fechaFormato.DayOfWeek)
                        {
                            horariosFecha.Add(h);
                        }
                        break;
                    case "Viernes":
                        if (DayOfWeek.Friday == fechaFormato.DayOfWeek)
                        {
                            horariosFecha.Add(h);
                        }
                        break;

                }
            }
            var disponibles = new List<BloqueDto>();
            foreach (HorarioSemanalDto h in horariosFecha)
            {
                var url = "http://localhost:8082/citas/disponible?fecha=" + fechaConsulta + "&horarioId=" + h.Id;
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
                    var data = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);

                    BloqueDto bl = new BloqueDto();
                    foreach (var entrada in data)
                    {
                        bl.Plazas = entrada.Value;
                        if (bl.Plazas > 0)
                        {
                            bl.Hora = entrada.Key;
                            bl.Horario = h;
                            disponibles.Add(bl);
                        }
                    }
                }
            }
            return disponibles;
        }

        private void panelCita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cita_Load(object sender, EventArgs e)
        {
            if (textBoxCitFecha.Text != "" && textBoxCitServicio.Text != "")
            {
                comboBoxCitHora.DataSource = ComprobarHorarios().OrderBy(b => b.Hora).ToList();
                comboBoxCitHora.DisplayMember = "Hora";
                comboBoxCitHora.ValueMember = "Horario";
                comboBoxCitHora.SelectedIndex = -1;
            }
        }

        private void comboBoxCitHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bloque = (BloqueDto)comboBoxCitHora.SelectedItem;

            if (bloque != null)
            {
                _idHorarioSeleccionado = bloque.Horario.Id;
                _HoraSeleccionada = bloque.Hora;
                if (comboBoxCitHora.Text != null)
                {
                    textBoxCitGrupo.Text = bloque.Horario.Grupo.Curso;
                }
            }
        }

        private void CalendarCitas_SelectedChanged(object sender, DateRangeEventArgs e)
        {
            textBoxCitFecha.Text = CalendarCitas.SelectionEnd.ToString().Substring(0, 10);
            if (textBoxCitServicio.Text != "")
            {
                comboBoxCitHora.Enabled = true;
                Cita_Load(sender, e);
            }
        }

        private void ButtonCitAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = textBoxCitFecha.Text;
                string fechaFormato = "";
                if (fecha != null)
                {
                    fechaFormato = fecha.Substring(6, 4) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);
                }
                string horaInicio = _HoraSeleccionada;
                string idHorario = _idHorarioSeleccionado.ToString();
                string idCliente = _idClienteSeleccionado.ToString();

                var url = $"http://localhost:8082/citas/reservar";
                string data = "{\r\n  \"fecha\": \"" + fechaFormato + "\",\r\n  \"horaInicio\":\"" + horaInicio + "\",\r\n  \"horario\": {\r\n \"id\": " + idHorario + "\r\n },\r\n  \"cliente\": {\r\n  \"id\": " + idCliente + " \r\n  }\r\n}";
                //string json = $"{{\"data\":\"{data}\"}}";
                var request = (HttpWebRequest)WebRequest.Create(url);
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
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (WebException ex)
            {
                string mensaje = "";
                using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    mensaje = reader.ReadToEnd();
                }
                MessageBox.Show("Error al añadir la cita !", "Error al añadir la cita", MessageBoxButtons.OK);
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Error al añadir la cita", "Error al añadir la cita", MessageBoxButtons.OK);
            }
        }
    }
}
