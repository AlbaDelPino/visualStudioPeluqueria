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
        public Bloqueo(string token)
        {
            InitializeComponent();
            _token = token;

            /*labelTituloCrearHorario.Visible = true;
            labelTituoModificarHorario.Visible = false;
            buttonGuardar.Visible = true;
            buttonModificar.Visible = false;*/
        }

        public Bloqueo(BloqueoHorarioDto bloqueo, string token) : this(token)
        {
        }
    }
}
