using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class PanelPrincipal : Form
    {
        private readonly string _token;
        private readonly UsersDto _usuarioActual;
        private static List<CitaDto> _citas;
        public PanelPrincipal(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            List<CitaDto> citasHoy = ObtenerCitasHoy();
            if (_usuarioActual.Role.Equals("ROLE_GRUPO"))
            {
                List<CitaDto> citasFiltradas = new List<CitaDto>();
                foreach (CitaDto c in citasHoy)
                {
                    if (_usuarioActual.Id == c.Horario.Grupo.Id)
                    {
                        citasFiltradas.Add(c);
                    }
                }
                citasHoy.Clear();
                citasHoy = citasFiltradas;
            }
            _citas = citasHoy;
            MostrarCitasEnPaneles(_citas);
        }

        private void MostrarCitasEnPaneles(List<CitaDto> citas)
        {
            List<CitaDto> citasHoy = citas;
            Panel panelContenedor = panelCitasContainer; 
            panelContenedor.Controls.Clear();

            if (citasHoy == null || citasHoy.Count == 0)
            {
                Label lblNoCitas = new Label
                {
                    Text = "✅ No hay citas\nprogramadas para hoy",
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 350),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true
                };
                panelContenedor.Controls.Add(lblNoCitas);
                return;
            }

            citasHoy = citasHoy.OrderBy(c => c.HoraInicio).ToList();

            int posicionY = 10; 
            int anchoPanel = panelContenedor.Width - 25; 

            foreach (CitaDto cita in citasHoy)
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

            Label lblEstado = new Label
            {
                Text = $"📌 {cita.Estado}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(110, 15),
                Size = new Size(150, 20),
                TextAlign = ContentAlignment.MiddleLeft
            };

            if (_usuarioActual.Role.Equals("ROLE_ADMIN"))
            {
                Label lblGrupo = new Label
                {
                    Text = $"⏱️ {cita.Horario.Grupo.Curso}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(220, 15),
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panel.Controls.Add(lblGrupo);
            }

            Label lblCliente = new Label
            {
                Text = $"👤 {cita.Cliente.Nombre}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(15, 40),
                Size = new Size(ancho - 150, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

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
                    Text = $"⏱️ {cita.Horario.Servicio.Duracion} min",
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
            btnAccion.Click += (s, e) => VerUsuario(cita.Cliente);

            Button btnCambiarEstado = new Button
            {
                Text = "Completar",
                Size = new Size(100, 30),
                Location = new Point(ancho - 120, 50),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Tag = cita.Id,
                Cursor = Cursors.Hand,
            };
            btnCambiarEstado.Click += (s, e) => CompletarCita(cita);

            panel.Controls.Add(lblHora);
            panel.Controls.Add(lblServicio);
            panel.Controls.Add(lblCliente);
            panel.Controls.Add(lblEstado);
            panel.Controls.Add(btnAccion);
            panel.Controls.Add(btnCambiarEstado);

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

        private Color ObtenerColorEstado(string estado)
        {
            switch (estado?.ToUpper())
            {
                case "CONFIRMADO":
                    return Color.White;
                case "COMPLETADO":
                    return Color.LightGreen;
                case "CANCELADO":
                    return Color.LightPink;
                default:
                    return Color.WhiteSmoke;
            }
        }

        private void CompletarCita(CitaDto cita)
        {
            if (cita.Fecha.CompareTo(LocalDate.FromDateTime(DateTime.Now)) > 0)
            {
                MessageBox.Show($"No se puede completar una cita que no ha ocurrido todavia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cita.Estado.Equals("CONFIRMADO"))
            {
                FichaCita ficha = new FichaCita(cita, _token);

                if (ficha.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cita completada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCitasEnPaneles(_citas);
                }
            }
            else if (cita.Estado.Equals("CANCELADO"))
            {
                MessageBox.Show($"No se puede completar una cita cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cita.Estado.Equals("COMPLETADO"))
            {
                MessageBox.Show($"La cida ya ha sido completada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerUsuario(UsersDto usuario)
        {
            var nombreYapellidos = usuario.Nombre.Split(' ');
            var nombre = "";
            var apellidos = "";

            if (nombreYapellidos.Length == 4)
            {
                nombre = nombreYapellidos[0] + " " + nombreYapellidos[1];
                apellidos = nombreYapellidos[2] + " " + nombreYapellidos[3];
            }
            else if (nombreYapellidos.Length == 3)
            {
                nombre = nombreYapellidos[0];
                apellidos = nombreYapellidos[1] + " " + nombreYapellidos[2];
            }
            else if (nombreYapellidos.Length == 2)
            {
                nombre = nombreYapellidos[0];
                apellidos = nombreYapellidos[1];
            }
            else if (nombreYapellidos.Length == 1)
            {
                nombre = nombreYapellidos[0];
            }

            Usuario pantallaInfo = new Usuario(usuario, _token, _usuarioActual);
            pantallaInfo.Form = "Información de " + usuario.Nombre;
            pantallaInfo.LabelTituoCrearUsuario.Visible = false;
            pantallaInfo.LabelTituoInfoUsuario.Visible = true;


            pantallaInfo.buttonUsGuardar = false;
            pantallaInfo.ButtonUsModificar = false;
            pantallaInfo.buttonUsVolver = true;
            pantallaInfo.buttonUsAnyadir = false;

            pantallaInfo.TboxNombreUsuario.ReadOnly = true;
            pantallaInfo.TxtBoxUsNombre.ReadOnly = true;
            pantallaInfo.TextBoxUsApellidos.ReadOnly = true;
            pantallaInfo.TextBoxUsEmail.ReadOnly = true;
            pantallaInfo.TextBoxUsTel.ReadOnly = true;
            pantallaInfo.TextBoxUsContrasenya.ReadOnly = true;
            pantallaInfo.TextBoxUsConfigContrasenya.ReadOnly = true;
            pantallaInfo.ComboTipoUsuario.Enabled = false;
            pantallaInfo.CheckBoxEstado.Enabled = false;
            pantallaInfo.TboxUserComCit.ReadOnly = true;
            pantallaInfo.TboxUserAlerg.ReadOnly = true;
            pantallaInfo.TboxUserObserv.ReadOnly = true;


            pantallaInfo.TboxNombreUsuario.Text = usuario.Username;
            pantallaInfo.TxtBoxUsNombre.Text = nombre;
            pantallaInfo.TextBoxUsApellidos.Text = apellidos;
            pantallaInfo.TextBoxUsEmail.Text = usuario.Email;
            pantallaInfo.TextBoxUsTel.Text = usuario.Telefono.ToString();

            if (usuario.Estado.Equals("true"))
            {
                pantallaInfo.CheckBoxEstado.Checked = true;
            }
            else if (usuario.Estado.Equals("false"))
            {
                pantallaInfo.CheckBoxEstado.Checked = false;
            }

            if (usuario.Role.Equals("ROLE_CLIENTE"))
            {
                var clientes = ObtenerClientes();
                foreach (ClienteDto c in clientes)
                {
                    if (c.Id == usuario.Id)
                    {
                        pantallaInfo.TboxUserComCit.Text = c.Comentario ?? "";
                        pantallaInfo.TboxUserAlerg.Text = c.Alergenos ?? "";
                        pantallaInfo.TboxUserObserv.Text = c.Observacion ?? "";
                    }
                }
                pantallaInfo.PanelAdmin.Visible = false;
                pantallaInfo.PanelUsGrupo.Visible = false;
                pantallaInfo.PanelCliente.Visible = true;
            }
            pantallaInfo.ComboTipoUsuario.SelectedIndex = 0;
            pantallaInfo.Show();
        }

        private List<CitaDto> ObtenerCitasHoy()
        {
            var url = "http://localhost:8082/citas/hoy";
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
                return citas;
            }

        }

        private List<ClienteDto> ObtenerClientes()
        {
            try
            {
                var url = "http://localhost:8082/clientes";
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
                    var clientes = JsonConvert.DeserializeObject<List<ClienteDto>>(json);
                    return clientes;
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
