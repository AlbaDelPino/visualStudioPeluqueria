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
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Cita : Form
    {
        private readonly string _token;
        private List<BloqueDto> _bloques;
        private List<HorarioSemanalDto> _horarios;
        private long? _idHorarioSeleccionado = null;
        private long? _idClienteSeleccionado = null;
        private long? _idServicioSeleccionado = null;
        private string _HoraSeleccionada = null;

        public Cita(CitaDto cita, string token)
        {
            InitializeComponent();
            _token = token;
            CalendarCitas.MinDate = DateTime.Today;

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
                    _idServicioSeleccionado = serv.Id_Servicio;
                    textBoxCitServicio.Text = serv.Nombre;
                    _horarios = ObtenerHorarios();
                    pintarDiasDisponibles();
                    if (textBoxCitFecha.Text != "")
                    {
                        cargarHoras();
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
            string fecha = textBoxCitFecha.Text;
            var fechaFormato = DateTime.Now;
            var diaSemana = "";
            var url = "";
            if (fecha != "")
            {
                fechaFormato = DateTime.ParseExact(fecha, "dd/MM/yyyy", new CultureInfo("es-ES"));
                switch (fechaFormato.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        diaSemana = "Lunes";
                        break;
                    case DayOfWeek.Tuesday:
                        diaSemana = "Martes";
                        break;
                    case DayOfWeek.Wednesday:
                        diaSemana = "Miércoles";
                        break;
                    case DayOfWeek.Thursday:
                        diaSemana = "Jueves";
                        break;
                    case DayOfWeek.Friday:
                        diaSemana = "Viernes";
                        break;
                }

                url = $"http://localhost:8082/horarios/buscar?diaSemana={diaSemana}&idServicio={_idServicioSeleccionado}";
            }
            else
            {
                url = $"http://localhost:8082/horarios/servicio/{_idServicioSeleccionado}";
            }
            var horarios = new List<HorarioSemanalDto>();

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
                horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
            }
            return horarios;
        }

        private List<BloqueDto> bloquesDisponibles()
        {
            string fecha = textBoxCitFecha.Text;

            var disponibles = new List<BloqueDto>();
            foreach (HorarioSemanalDto h in _horarios)
            {
                var url = $"http://localhost:8082/citas/disponible?fecha={fecha}&horarioId={h.Id}";
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


                    foreach (var entrada in data)
                    {
                        BloqueDto bl = new BloqueDto();
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


        private void pintarDiasDisponibles()
        {
            var diasConPlazas = _horarios.Select(h => h.DiaSemana).Where(h => !string.IsNullOrEmpty(h)).Distinct().ToList();

            var mapDias = new Dictionary<string, DayOfWeek>
             {
                 {"Lunes", DayOfWeek.Monday},
                 {"Martes", DayOfWeek.Tuesday},
                 {"Miércoles", DayOfWeek.Wednesday},
                 {"Jueves", DayOfWeek.Thursday},
                 {"Viernes", DayOfWeek.Friday},
                 {"Sábado", DayOfWeek.Saturday},
                 {"Domingo", DayOfWeek.Sunday}
             };

            var primerDiaMes = new DateTime(CalendarCitas.SelectionStart.Year, CalendarCitas.SelectionStart.Month, 1);
            var ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);

            for (DateTime fecha = primerDiaMes; fecha <= ultimoDiaMes; fecha = fecha.AddDays(1))
            {
                string nombreDia = fecha.ToString("dddd", new CultureInfo("es-ES"));
                nombreDia = char.ToUpper(nombreDia[0]) + nombreDia.Substring(1);

                if (diasConPlazas.Contains(nombreDia))
                {
                    CalendarCitas.AddBoldedDate(fecha);
                    CalendarCitas.UpdateBoldedDates();
                }
            }
        }

        private void comboBoxCitHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bloque = (BloqueDto)comboBoxCitHora.SelectedItem;

            if (bloque != null)
            {
                _idHorarioSeleccionado = bloque.Horario.Id;
                _HoraSeleccionada = bloque.Hora;
                if (comboBoxCitHora.Text != "")
                {
                    textBoxCitGrupo.Text = bloque.Horario.Grupo.Curso;
                }
                else
                {
                    textBoxCitGrupo.Text = "";
                }
            }
        }

        private void CalendarCitas_SelectedChanged(object sender, DateRangeEventArgs e)
        {
            if (textBoxCitServicio.Text != "")
            {
                textBoxCitFecha.Text = CalendarCitas.SelectionEnd.ToString().Substring(0, 10);
                _horarios = ObtenerHorarios();
                _bloques = bloquesDisponibles();
                if (textBoxCitFecha.Text != "" && textBoxCitServicio.Text != "")
                {
                    textBoxCitGrupo.Text = "";
                    cargarHoras();
                    
                }
            }
        }
        private void cargarHoras()
        {
            comboBoxCitHora.DataSource = _bloques.Where(b =>
            {
                if (DateTime.ParseExact(textBoxCitFecha.Text, "dd/MM/yyyy", new CultureInfo("es-ES")) > DateTime.Today)
                {
                    return true;
                }
                else if (TimeSpan.TryParse(b.Hora, out TimeSpan hora))
                    return hora > DateTime.Now.TimeOfDay;
                return false;
            }).OrderBy(b => b.Hora).ToList();

            if (comboBoxCitHora.DataSource != null)
            {
                comboBoxCitHora.Enabled = true;
                comboBoxCitHora.DisplayMember = "Hora";
                comboBoxCitHora.ValueMember = "Horario";
                comboBoxCitHora.SelectedIndex = -1;
            }
            else
            {
                textBoxCitGrupo.Text = "";
                comboBoxCitHora.Text = "Estas horas están llenas o son pasadas";
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
        private void buttonCitServicio_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, 13, 2);
        }

        private void buttonCitCliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, 13, 2);
        }
    }
}
