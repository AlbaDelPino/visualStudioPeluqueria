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
using System.Drawing;
using System.Drawing.Drawing2D;
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
        // Cuando el mouse entra al área del Label
        


        private void labelUsuario_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelUsuario(_token));
        }

     
        private void labelCita_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelCita(_token));
        }

        // Color naranja de la imagen (RGB: 255, 178, 125 aprox)
        Color colorNaranjaHover = Color.FromArgb(251, 147, 92);
        Color colorGrisTexto = Color.FromArgb(100, 100, 100);


        private void DibujarBotonNaranja(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear el rectángulo redondeado
            int radius = 10;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Pintar el fondo naranja
            using (SolidBrush brush = new SolidBrush(colorNaranjaHover))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Escribir el texto encima del naranja
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle,
                                 Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }
        private void AplicarEstiloHover(Label label)
        {
            label.Cursor = Cursors.Hand;
            // Agregamos el evento de dibujo dinámicamente
            label.Paint += DibujarBotonNaranja;
            label.Invalidate(); // Esto obliga al label a redibujarse con el nuevo estilo
        }

        private void QuitarEstiloHover(Label label)
        {
            label.Cursor = Cursors.Default;
            // Quitamos el evento de dibujo para que vuelva a ser un label normal
            label.Paint -= DibujarBotonNaranja;
            label.Invalidate(); // Esto limpia el cuadro naranja
        }

       

        // --- APLICA ESTO A TUS EVENTOS EXISTENTES ---

        private void labelPrincipal_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelPrincipal);
        private void labelPrincipal_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelPrincipal);

        private void labelServicio_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelServicio);
        private void labelServicio_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelServicio);

        private void labelUsuario_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelUsuario);
        private void labelUsuario_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelUsuario);

        private void labelCita_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelCita);
        private void labelCita_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelCita);

        // Cuando el mouse sale del área del Label

        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarContenidoInicio();
        }
    }
}

    
