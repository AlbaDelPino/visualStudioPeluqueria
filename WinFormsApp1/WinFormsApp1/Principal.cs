using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using WinFormsApp1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WinFormsApp1.Login;
using static WinFormsApp1.PanelPrincipal;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        private readonly string _token;
        private static int pagSer;
        private static int contador = 1;
        public Principal(string token)
        {
            InitializeComponent();
            _token = token;
            this.WindowState = FormWindowState.Maximized;
            ConfigurarPanelContenedor();
        }

        private void CargarNuevaPagina(Form formHijo)
        {
            // Asegúrate de que 'pnlContenedor' es el nombre correcto de tu Panel
            panelControl.Controls.Clear();
            panelControl.Dock = DockStyle.Fill;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelControl.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void ConfigurarPanelContenedor()
        {
            panelControl.Location = new System.Drawing.Point(149, 132);
            panelControl.Size = new System.Drawing.Size(this.ClientSize.Width - 270, this.ClientSize.Height);
            panelControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl.Visible = true;
        }

        private void MostrarContenidoInicio()
        {
            PanelPrincipal pantallaIntro = new PanelPrincipal();
            panelControl.Controls.Clear();
            panelControl.Dock = DockStyle.Fill;
            pantallaIntro.TopLevel = false;
            pantallaIntro.FormBorderStyle = FormBorderStyle.None;
            pantallaIntro.Dock = DockStyle.Fill;
            panelControl.Controls.Add(pantallaIntro);
            pantallaIntro.Show();
        }






















        //comentario
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void labelPrincipal_Click(object sender, EventArgs e)
        {
            MostrarContenidoInicio();
        }

        private void labelServicio_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelServicios(_token));
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelUsuario(_token));
        }

        private void labelCita_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelCita(_token));
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarContenidoInicio();
        }
    }
}

    
