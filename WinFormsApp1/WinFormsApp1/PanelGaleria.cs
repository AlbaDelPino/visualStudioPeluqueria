using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class PanelGaleria : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        private readonly string _token;
        private static int pagSer;
        private static int contador = 1;
        private static List<ServicioDto> _servicios;
        public PanelGaleria(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void PanelGaleria_Load(object sender, EventArgs e)
        {
            dataGridViewGaleria.ReadOnly = true;
            dataGridViewGaleria.AllowUserToAddRows = false;
            dataGridViewGaleria.AllowUserToDeleteRows = false;
            dataGridViewGaleria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //_servicios = new List<ServicioDto>();
            //RecargarServicios();
           // pasarPagina();

            ConfigurarUIEstiloImagen();

        }

        private void ConfigurarUIEstiloImagen()
        {
            anyadirServicio.Text = "+";
            anyadirServicio.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirServicio.FlatStyle = FlatStyle.Flat;
            anyadirServicio.FlatAppearance.BorderSize = 0;
            anyadirServicio.BackColor = Color.FromArgb(255, 128, 0);
            anyadirServicio.ForeColor = Color.White;
            anyadirServicio.Size = new Size(45, 45);

            anyadirServicio.Left = panelVisualGaleria.Width - 60;

            textBoxSerBuscar.Left = 50;
            textBoxSerBuscar.Width = panelVisualGaleria.Width - 350;

            comboBoxSerFiltrar.Width = 180;
            comboBoxSerFiltrar.Left = textBoxSerBuscar.Right + 30;

            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirServicio.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirServicio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirServicio.Width, anyadirServicio.Height, anyadirServicio.Width, anyadirServicio.Height));
        }


        private void PanelGaleria_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualGaleria.Invalidate();
        }
       

        private void panelVisualGaleria_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(
                textBoxSerBuscar.Left - 35,
                textBoxSerBuscar.Top - 15,
                textBoxSerBuscar.Width + 45,
                textBoxSerBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSerBuscar.Left - 25, textBoxSerBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(
                comboBoxSerFiltrar.Left - 10,
                comboBoxSerFiltrar.Top - 10,
                comboBoxSerFiltrar.Width + 25,
                comboBoxSerFiltrar.Height + 20
            );
            DibujarCapsula(g, rectFiltro, penBorde, fondoBlanco);
        }

        private void DibujarCapsula(Graphics g, Rectangle rect, Pen p, Brush b)
        {
            GraphicsPath path = new GraphicsPath();
            int radio = rect.Height - 1;
            path.AddArc(rect.X, rect.Y, radio, radio, 90, 180);
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 180);
            path.CloseFigure();

            g.FillPath(b, path);
            g.DrawPath(p, path);
        }
        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
