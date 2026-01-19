using CitasInfo.Models;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Cita : Form
    {
        private readonly CitaDto _cita;
        private Label labelCitFecha;
        private Label labelTituoCrearCita;
        private Panel panelCita;
        private MonthCalendar monthCalendar1;
        private Label labelCitServicio;
        private Label labelCitHora;
        private Label labelCitCliente;
        private Label labelCitGrupo;
        private CheckBox checkBoxEstado;
        private Button ButtonCitModificar;
        private Button ButtonCitAnyadir;
        private Label labelTituoModificarCita;
        private ComboBox comboGrupoCita;
        private ComboBox comboHoraCita;
        private readonly string _token;

        public Cita(CitaDto cita, string token)
        {
            _cita = cita;
            _token = token;
        }
        private void Cita_Load(object sender, EventArgs e)
        {
        }

        private void Cita_Load_1(object sender, EventArgs e)
        {

        }

        private void panelCita_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
