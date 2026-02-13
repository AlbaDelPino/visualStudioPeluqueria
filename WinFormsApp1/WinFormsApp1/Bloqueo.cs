using CitasInfo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Bloqueo : Form
    {
        private readonly string _token;
        private long? _idHorarioSeleccionado = null;
        public Bloqueo(string token)
        {
            InitializeComponent();
            _token = token;
            CalendarCitas.MinDate = DateTime.Today;
        }

        public Bloqueo(BloqueoHorarioDto bloqueo, string token) : this(token)
        {
        }

        private void ButtonAnyadir_Click(object sender, EventArgs e)
        {

        }

        private void buttonHorarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, 13, 2);
        }
    }
}
