using CitasInfo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class Diagnostico : Form
    {
        private readonly string _token;
        private readonly UsersDto _usuario;

        public Diagnostico(UsersDto usuario, string token)
        {
            InitializeComponent();
            _usuario = usuario;
            _token = token;
        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            comboBoxTipoPiel.SelectedIndex = 1;
            comboBoxTipoPelo.SelectedIndex = 2;
            comboBoxTexturaPelo.SelectedIndex = 3;
        }
    }
}
