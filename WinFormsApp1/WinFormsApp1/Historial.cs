using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WinFormsApp1
{
    public partial class Historial : Form
    {
        private readonly string _token;
        private readonly UsersDto _usuario;
        private List<CitaDto> _citas;

        public Historial(UsersDto usuario, string token)
        {
            InitializeComponent();
            _usuario = usuario;
            _token = token;
            _citas = new List<CitaDto>();
        }
        private void Historial_Resize(object sender, EventArgs e)
        {
            cargarCitas();
        }
        private void cargarCitas()
        {
            _citas = ObtenerCitasUsuario().Where(c => c.Estado.ToLower().Equals("completado")).ToList();
            MostrarCitasEnPaneles(_citas);
        }
        private void MostrarCitasEnPaneles(List<CitaDto> citas)
        {
            Panel panelContenedor = panelCitas;
            panelContenedor.Controls.Clear();

            if (_citas == null || _citas.Count == 0)
            {
                Label lblNoCitas = new Label
                {
                    Text = "✅ No hay citas\nde este usuario",
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 350),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true
                };
                panelContenedor.Controls.Add(lblNoCitas);
                return;
            }

            int posicionY = 10;
            int anchoPanel = panelContenedor.Width - 75;

            foreach (CitaDto cita in _citas)
            {
                Panel panelCita = CrearPanelCita(cita, anchoPanel);
                panelCita.Location = new Point(10, posicionY);
                panelContenedor.Controls.Add(panelCita);

                posicionY += panelCita.Height + 10;
            }
            panelContenedor.AutoScroll = true;
        }
        private Panel CrearPanelCita(CitaDto cita, int ancho)
        {
            Panel panel = new Panel
            {
                Size = new Size(ancho, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = SystemColors.Control,
                Padding = new Padding(10),
                Tag = cita.Id
            };

            var fecha = $"{cita.Fecha.Day:00}/{cita.Fecha.Month:00}/{cita.Fecha.Year}";
            Label lblFecha = new Label
            {
                Text = $"🗓️ {fecha}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(120, 15),
                Size = new Size(150, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblGrupo = new Label
            {
                Text = $"👥 {cita.Horario.Grupo.Curso}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(170, 40),
                Size = new Size(80, 20),
                TextAlign = ContentAlignment.MiddleLeft
            };
            panel.Controls.Add(lblGrupo);

            Label lblServicio = new Label
            {
                Text = $"📋 {cita.Horario?.Servicio?.Nombre ?? "Sin servicio"}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(15, 70),
                Size = new Size(ancho - 220, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblProductos = new Label
            {
                Text = $"📋 {cita.Productos ?? " "}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(35, 70),
                Size = new Size(ancho - 220, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };
            Label lblTratamientos = new Label
            {
                Text = $"📋 {cita.Tratamientos ?? " "}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(55, 70),
                Size = new Size(ancho - 220, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button btnAccion = new Button
            {
                Text = "Ver información de la cita",
                Size = new Size(100, 30),
                Location = new Point(ancho - 120, 15),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Tag = cita.Id,
                Cursor = Cursors.Hand
            };
            btnAccion.Click += (s, e) => VerInfo(cita);

            panel.Controls.Add(lblFecha);
            panel.Controls.Add(lblServicio);
            panel.Controls.Add(btnAccion);
            panel.Controls.Add(lblProductos);
            panel.Controls.Add(lblTratamientos);


            panel.Cursor = Cursors.Hand;

            panel.MouseEnter += (s, e) =>
            {
                Color c = panel.BackColor;
                panel.BackColor = Color.FromArgb(
                    Math.Max(c.R - 10, 0),
                    Math.Max(c.G - 10, 0),
                    Math.Max(c.B - 10, 0));
                panel.BorderStyle = BorderStyle.Fixed3D;
            };


            foreach (Control h in panel.Controls)
            {
                if (h != null)
                    h.MouseEnter += (s, e) =>
                    {
                        Color c = panel.BackColor;
                        panel.BackColor = Color.FromArgb(
                            Math.Max(c.R - 10, 0),
                            Math.Max(c.G - 10, 0),
                            Math.Max(c.B - 10, 0));
                        panel.BorderStyle = BorderStyle.Fixed3D;
                    };
            }

            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = SystemColors.Control;
                panel.BorderStyle = BorderStyle.FixedSingle;
            };


            return panel;
        }
        private void VerInfo(CitaDto cita)
        {
            //
        }

        private List<CitaDto> ObtenerCitasUsuario()
        {
            var url = $"http://localhost:8082/citas/cliente/{_usuario.Id}";
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
                var citas = JsonConvert.DeserializeObject<List<CitaDto>>(json);
                return citas.OrderBy(c => c.Fecha).ToList();
            }

        }

    }

}
