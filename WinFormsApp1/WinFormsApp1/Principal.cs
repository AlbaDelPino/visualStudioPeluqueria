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
        private static List<UsersDto> _grupos;
        private readonly UsersDto _usuarioActual;
        public Principal(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            _token = token;
            _usuarioActual = usuarioActual;
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
            PanelPrincipal pantallaIntro = new PanelPrincipal(_usuarioActual, _token);
            panelControl.Controls.Clear();
            panelControl.Dock = DockStyle.Fill;
            pantallaIntro.TopLevel = false;
            pantallaIntro.FormBorderStyle = FormBorderStyle.None;
            pantallaIntro.Dock = DockStyle.Fill;
            panelControl.Controls.Add(pantallaIntro);
            pantallaIntro.Show();
        }






















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
            CargarNuevaPagina(new PanelServicios(_usuarioActual, _token));
        }
        // Cuando el mouse entra al área del Label



        private void labelUsuario_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelUsuario(_usuarioActual, _token));
        }


        private void labelCita_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelCita(_usuarioActual, _grupos, _token));
        }
        private void labelHorario_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelHorario(_usuarioActual, _grupos, _token));
        }

        private void labelGaleria_Click(object sender, EventArgs e)
        {
            CargarNuevaPagina(new PanelGaleria(_usuarioActual, _token));
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

        private void labelHorario_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelHorario);
        private void labelHorario_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelHorario);


        private void labelGaleria_MouseEnter(object sender, EventArgs e) => AplicarEstiloHover(labelGaleria);
        private void labelGaleria_MouseLeave(object sender, EventArgs e) => QuitarEstiloHover(labelGaleria);

        // Cuando el mouse sale del área del Label

        private void Principal_Load(object sender, EventArgs e)
        {
            var grupos = ObtenerUsuarios();
            _grupos = grupos.Where(u => u.Role.Equals("ROLE_GRUPO", StringComparison.OrdinalIgnoreCase)).ToList();
            var gruposConVacio = new List<UsersDto>
            {
                new UsersDto
                {
                    Id = 0,
                    Nombre = ""
                }
            };
            gruposConVacio.AddRange(_grupos);
            _grupos = gruposConVacio;
            MostrarContenidoInicio();
        }

        private void labTituto_Click(object sender, EventArgs e)
        {

        }

        private List<UsersDto> ObtenerUsuarios()
        {
            try
            {
                var url = "http://localhost:8082/api/auth/users";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                // Aquí añadimos el token
                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    var usuarios = JsonConvert.DeserializeObject<List<UsersDto>>(json);
                    return usuarios;
                }

            }
            catch (WebException e)
            {
                MessageBox.Show($"Error de conexión: {e.Message}", "No tienes permisos",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        
    }
}

    
