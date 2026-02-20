using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Bloqueo : Form
    {
        private readonly string _token;
        private List<HorarioSemanalDto> _horariosSeleccionados;
        private BloqueoHorarioDto _bloqueo;
        public Bloqueo(string token)
        {
            InitializeComponent();
            _token = token;
            _horariosSeleccionados = new List<HorarioSemanalDto>();
            CalendarCitas.MinDate = DateTime.Today;
            textBoxCitFecha.Text = CalendarCitas.SelectionEnd.ToString().Substring(0, 10);
            labelTituo.Text = "Crear bloqueo";
            this.Text = "Crear bloqueo horario";
            buttonModificar.Visible = false;
            buttonAnyadir.Visible = true;
            _bloqueo = new BloqueoHorarioDto();
        }

        public Bloqueo(BloqueoHorarioDto bloqueo, string token) : this(token)
        {
          
                CalendarCitas.SelectionEnd = bloqueo.Fecha.ToDateTimeUnspecified();
                CalendarCitas.SelectionStart = bloqueo.Fecha.ToDateTimeUnspecified();
                textBoxCitFecha.Text = CalendarCitas.SelectionEnd.ToString().Substring(0, 10);
                _horariosSeleccionados = bloqueo.Horarios;
                var idHorarios = "";
                foreach (HorarioSemanalDto h in _horariosSeleccionados)
                {
                    idHorarios = idHorarios + h.Id + ", ";
                }
                textBoxHorarios.Text = idHorarios;
                textBoxMotivo.Text = bloqueo.Motivo;
                if (bloqueo.Recurrente)
                {
                    radioButtonAnual.Checked = true;
                }
                else
                {
                    radioButtonPuntual.Checked = true;
                }
                labelTituo.Text = "Modificar bloqueo";
                this.Text = "Modificar bloqueo horario";
                buttonModificar.Visible = true;
                buttonAnyadir.Visible = false;
                _bloqueo = bloqueo;

        }

        private void ButtonAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = textBoxCitFecha.Text;
                string fechaFormato = "";
                if (fecha != null)
                {
                    fechaFormato = fecha.Substring(6, 4) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);
                }
                bool recurrente = false;
                if (radioButtonAnual.Checked)
                {
                    recurrente = true;
                }
                string horarios = " [ \r\n";
                for (int i = 0; i < _horariosSeleccionados.Count; i++)
                {
                    horarios += "{\r\n \"id\": " + _horariosSeleccionados[i].Id + "\r\n }";
                    if (i != _horariosSeleccionados.Count - 1)
                    {
                        horarios += ",\r\n";
                    }
                }
                horarios += "\r\n]";
                string motivo = textBoxMotivo.Text;

                var url = $"http://localhost:8082/bloqueos";
                string data = "{\r\n  \"fecha\": \"" + fechaFormato + "\",\r\n  \"recurrente\":\"" + recurrente + "\",\r\n  \"horarios\": " + horarios + ",\r\n  \"motivo\": \"" + motivo + "\"\r\n}";
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
                MessageBox.Show("Error al añadir el bloqueo", "Error al añadir el bloqueo", MessageBoxButtons.OK);
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Error al añadir el bloqueo", "Error al añadir el bloqueo", MessageBoxButtons.OK);
            }
        }

        private void buttonHorarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, 13, 5);
        }

        private void buttonHorarios_Click(object sender, EventArgs e)
        {
            string dia = CalendarCitas.SelectionStart.DayOfWeek switch
            {
                DayOfWeek.Monday => "Lunes",
                DayOfWeek.Tuesday => "Martes",
                DayOfWeek.Wednesday => "Miércoles",
                DayOfWeek.Thursday => "Jueves",
                DayOfWeek.Friday => "Viernes"
            };

            var listaHorarios = ObtenerHorarios().Where(h => h.DiaSemana.Equals(dia)).ToList();
            if (listaHorarios == null || listaHorarios.Count == 0) return;
            if (_bloqueo.Id != 0)
            {
                using (var buscador = new Busqueda("Seleccionar Horarios", listaHorarios, _bloqueo))
                {
                    if (buscador.ShowDialog() == DialogResult.OK)
                    {
                        List<HorarioSemanalDto> horarios = buscador.ItemsSeleccionados;
                        var idHorarios = "";
                        foreach (HorarioSemanalDto h in horarios)
                        {
                            idHorarios = idHorarios + h.Id + ", ";
                        }
                        textBoxHorarios.Text = idHorarios;
                        _horariosSeleccionados = horarios;
                    }
                }
            } else
            {
                using (var buscador = new Busqueda("Seleccionar Horarios", listaHorarios))
                {
                    if (buscador.ShowDialog() == DialogResult.OK)
                    {
                        List<HorarioSemanalDto> horarios = buscador.ItemsSeleccionados;
                        var idHorarios = "";
                        foreach (HorarioSemanalDto h in horarios)
                        {
                            idHorarios = idHorarios + h.Id + ", ";
                        }
                        textBoxHorarios.Text = idHorarios;
                        _horariosSeleccionados = horarios;
                    }
                }
            }
        }

        private List<HorarioSemanalDto> ObtenerHorarios()
        {
            var url = "http://localhost:8082/horarios";
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
                var horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                return horarios.OrderBy(u => u.DiaSemana).ToList();
            }
        }

        private void CalendarCitas_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxCitFecha.Text = CalendarCitas.SelectionEnd.ToString().Substring(0, 10);
            textBoxHorarios.Text = "";
            _horariosSeleccionados = new List<HorarioSemanalDto>();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = textBoxCitFecha.Text;
                string fechaFormato = "";
                if (fecha != null)
                {
                    fechaFormato = fecha.Substring(6, 4) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);
                }
                bool recurrente = false;
                if (radioButtonAnual.Checked)
                {
                    recurrente = true;
                }
                string horarios = " [ \r\n";
                for (int i = 0; i < _horariosSeleccionados.Count; i++)
                {
                    horarios += "{\r\n \"id\": " + _horariosSeleccionados[i].Id + "\r\n }";
                    if (i != _horariosSeleccionados.Count - 1)
                    {
                        horarios += ",\r\n";
                    }
                }
                horarios += "\r\n]";
                string motivo = textBoxMotivo.Text;

                var url = $"http://localhost:8082/bloqueos/{_bloqueo.Id}";
                string data = "{\r\n  \"fecha\": \"" + fechaFormato + "\",\r\n  \"recurrente\":\"" + recurrente + "\",\r\n  \"horarios\": " + horarios + ",\r\n  \"motivo\": \"" + motivo + "\"\r\n}";
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
                MessageBox.Show("Error al añadir el bloqueo", "Error al añadir el bloqueo", MessageBoxButtons.OK);
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Error al añadir el bloqueo", "Error al añadir el bloqueo", MessageBoxButtons.OK);
            }
        }
    }
}
