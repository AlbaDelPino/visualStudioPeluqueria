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

        public Historial(UsersDto usuario, string token)
        {
            InitializeComponent();
            _usuario = usuario;
            _token = token;
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }
        private Panel CrearPanelCita(CitaDto cita, int ancho)
        {
            Panel panel = new Panel
            {
                Size = new Size(ancho, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = ObtenerColorEstado(cita.Estado),
                Padding = new Padding(10),
                Tag = cita.Id
            };


            Label lblHora = new Label
            {
                Text = $"🕒 {cita.HoraInicio:HH:mm}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(15, 15),
                Size = new Size(80, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var fecha = $"{cita.Fecha.Day:00}/{cita.Fecha.Month:00}/{cita.Fecha.Year}";
            Label lblFecha = new Label
            {
                Text = $"🗓️ {fecha}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(120, 15),
                Size = new Size(150, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblEstado = new Label
            {
                Text = $"{cita.Estado}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(280, 15),
                Size = new Size(150, 20),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblCliente = new Label
            {
                Text = $"👤 {cita.Cliente.Nombre}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(15, 40),
                Size = new Size(ancho - 150, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            if (_usuarioActual.Role.Equals("ROLE_ADMIN"))
            {
                Label lblGrupo = new Label
                {
                    Text = $"👥 {cita.Horario.Grupo.Curso}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    Location = new Point(170, 40),
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panel.Controls.Add(lblGrupo);
            }

            Label lblServicio = new Label
            {
                Text = $"📋 {cita.Horario?.Servicio?.Nombre ?? "Sin servicio"}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(15, 70),
                Size = new Size(ancho - 220, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };


            if (cita.Horario?.Servicio?.Duracion > 0)
            {
                Label lblDuracion = new Label
                {
                    Text = $"{cita.Horario.Servicio.Duracion} min",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(220, 70),
                    Size = new Size(80, 25),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panel.Controls.Add(lblDuracion);
            }



            Button btnAccion = new Button
            {
                Text = "Ver usuario",
                Size = new Size(100, 30),
                Location = new Point(ancho - 120, 15),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Tag = cita.Id,
                Cursor = Cursors.Hand
            };
            btnAccion.Click += (s, e) => {
                // 1. Obtenemos la lista completa de clientes desde tu API
                List<ClienteDto> todosLosClientes = ObtenerClientes();

                // 2. Buscamos el cliente específico por ID
                ClienteDto clienteCompleto = todosLosClientes?.FirstOrDefault(c => c.Id == cita.Cliente.Id);

                if (clienteCompleto != null)
                {
                    // 3. Llamamos a VerUsuario pasando los datos completos
                    VerUsuario(clienteCompleto, cita);
                }
                else
                {
                    // Fallback: Si no lo encuentra, creamos uno vacío para que no de error
                    VerUsuario(new ClienteDto { Id = cita.Cliente.Id }, cita);
                }
            };



            panel.Controls.Add(lblHora);
            panel.Controls.Add(lblFecha);
            panel.Controls.Add(lblServicio);
            panel.Controls.Add(lblCliente);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(btnAccion);


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
                panel.BackColor = ObtenerColorEstado(cita.Estado);
                panel.BorderStyle = BorderStyle.FixedSingle;
            };


            return panel;
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
