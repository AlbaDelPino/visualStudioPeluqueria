using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
