using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using WindowsFormsApp1;


namespace WinFormsApp1
{
    public partial class Usuario : Form
    {
        private readonly UsersDto _usuario;
        private readonly string _token;
        private readonly UsersDto _usuarioActual;
        public Usuario(UsersDto usuario, string token, UsersDto usuarioActual)
        {
            InitializeComponent();
            _usuario = usuario;
            _token = token;
            _usuarioActual = usuarioActual;

            var nombre = usuario.Nombre;
            var apellidos = " ";
            this.Text = "Información de " + usuario.Nombre;
            labelTituoCrearUsuario.Visible = false;
            labelTituoInfoUsuario.Visible = true;


            ButtonUsGuardar.Visible = false;
            buttonModificar.Visible = true;
            ButtonUsVolver.Visible = true;
            ButtonUsAnyadir.Visible = false;

            tboxNombreUsuario.ReadOnly = true;
            txtBoxUsNombre.ReadOnly = true;
            textBoxUsApellidos.ReadOnly = true;
            textBoxUsEmail.ReadOnly = true;
            textBoxUsTel.ReadOnly = true;
            textBoxUsContrasenya.ReadOnly = true;
            textBoxUsConfigContrasenya.ReadOnly = true;
            comboTipoUsuario.Enabled = false;
            checkBoxEstado.Enabled = false;
            tboxUserAlerg.ReadOnly = true;
            textBoxObservaciones.ReadOnly = true;
            tboxUserCurso.ReadOnly = true;
            tboxUserTurno.ReadOnly = true;
            tboxUserEspec.ReadOnly = true;


            tboxNombreUsuario.Text = usuario.Username;
            txtBoxUsNombre.Text = nombre;
            textBoxUsApellidos.Text = apellidos;

            if (usuario.Estado.Equals("true"))
            {
                checkBoxEstado.Checked = true;
            }
            else if (usuario.Estado.Equals("false"))
            {
                checkBoxEstado.Checked = false;
            }

            var indexRol = 3;
            if (usuario.Role.Equals("ROLE_CLIENTE"))
            {
                var clientes = ObtenerClientes();
                foreach (ClienteDto c in clientes)
                {
                    if (c.Id == usuario.Id)
                    {
                        tboxUserAlerg.Text = c.Alergenos ?? "";
                        textBoxObservaciones.Text = c.Observacion ?? "";
                        textBoxUsEmail.Text = c.Email ?? "";
                        textBoxUsTel.Text = c.Telefono.ToString() ?? "";
                    }
                }
                panelAdmin.Visible = false;
                panelUsGrupo.Visible = false;
                panelCliente.Visible = true;

                var nombreYapellidos = usuario.Nombre.Split(' ');
                if (nombreYapellidos.Length >= 4)
                {
                    nombre = nombreYapellidos[0] + " " + nombreYapellidos[1];
                    apellidos = nombreYapellidos[2] + " " + nombreYapellidos[nombreYapellidos.Length - 1];
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
                txtBoxUsNombre.Text = nombre;
                textBoxUsApellidos.Text = apellidos;

                indexRol = 0;
            }
            else if (usuario.Role.Equals("ROLE_GRUPO"))
            {

                var grupos = ObtenerGrupos();
                foreach (GrupoDto g in grupos)
                {
                    if (g.Id == usuario.Id)
                    {
                        tboxUserCurso.Text = g.Curso ?? "";
                        tboxUserTurno.Text = g.Turno ?? "";
                    }
                }
                panelAdmin.Visible = false;
                panelUsGrupo.Visible = true;
                panelCliente.Visible = false;

                indexRol = 1;
            }
            else if (usuario.Role.Equals("ROLE_ADMIN"))
            {
                var admins = ObtenerAdmins();
                foreach (AdminDto a in admins)
                {
                    if (a.Id == usuario.Id)
                    {
                        tboxUserEspec.Text = a.Especialidad ?? "";
                    }
                }
                panelAdmin.Visible = true;
                panelUsGrupo.Visible = false;
                panelCliente.Visible = false;

                indexRol = 2;
            }
            comboTipoUsuario.SelectedIndex = indexRol;

        }

        public Usuario(string token, UsersDto usuarioActual)
        {
            InitializeComponent();
            _token = token;
            _usuarioActual = usuarioActual;

            this.Text = "Añadir nuevo usuario";
            labelTituoCrearUsuario.Visible = true;
            labelTituoInfoUsuario.Visible = false;

            buttonModificar.Visible = false;
            ButtonUsVolver.Visible = false;
            ButtonUsAnyadir.Visible = true;
            comboTipoUsuario.Enabled = true;
            checkBoxEstado.Checked = true;

            tboxNombreUsuario.Text = "";
            txtBoxUsNombre.Text = "";
            textBoxUsApellidos.Text = "";
            textBoxUsEmail.Text = "";
            textBoxUsTel.Text = "";
            textBoxObservaciones.Text = "";
            comboTipoUsuario.SelectedItem = "";
            tboxUserAlerg.Text = "";
            tboxUserCurso.Text = "";
            tboxUserTurno.Text = "";
            tboxUserEspec.Text = "";
        }

        private void comboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = comboTipoUsuario.SelectedItem.ToString();

            if (tipo == "Admin")
            {
                panelAdmin.Visible = true;
                panelCliente.Visible = false;
                panelUsGrupo.Visible = false;
            }
            else if (tipo == "Cliente")
            {
                panelAdmin.Visible = false;
                panelCliente.Visible = true;
                panelUsGrupo.Visible = false;
            }
            else if (tipo == "Grupo")
            {
                panelAdmin.Visible = false;
                panelCliente.Visible = false;
                panelUsGrupo.Visible = true;
            }
        }

        private void ButtonUsAñadir_Click(object sender, EventArgs e)
        {
            string username = tboxNombreUsuario.Text;
            string primernombre = txtBoxUsNombre.Text;
            string apellidos = textBoxUsApellidos.Text;
            string nombre = primernombre + " " + apellidos;
            string contrasenya = textBoxUsContrasenya.Text;
            string validarContrasenya = textBoxUsConfigContrasenya.Text;
            bool estado = checkBoxEstado.Checked;
            var url = $"";
            string data = "";

            if (comboTipoUsuario.SelectedIndex == 0)
            {
                string alergenos = tboxUserAlerg.Text;
                string observciones = textBoxObservaciones.Text;
                string email = textBoxUsEmail.Text;
                string tel = textBoxUsTel.Text;
                url = $"http://localhost:8082/api/auth/signup/cliente";
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"observacion\": \"" + observciones + "\",\r\n  \"alergenos\": \"" + alergenos + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 1)
            {
                string curso = tboxUserCurso.Text;
                string turno = tboxUserTurno.Text;
                url = $"http://localhost:8082/api/auth/signup/grupo";
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"curso\": \"" + curso + "\",\r\n  \"turno\": \"" + turno + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 2)
            {
                string especialidad = tboxUserEspec.Text;
                url = $"http://localhost:8082/api/auth/signup/admin";
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"especialidad\": \"" + especialidad + "\"\r\n}\r\n";
            }

            if (contrasenya == validarContrasenya)
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    string json = data;
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    request.Accept = "application/json";
                    request.Headers["Authorization"] = $"Bearer {_token}";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }


                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                            }
                        }
                    }
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (WebException ex)
                {
                    string mensaje = "";
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        mensaje = reader.ReadToEnd();
                    }
                    MessageBox.Show("Error al añadir usuario", "Error al añadir usuario", MessageBoxButtons.OK);
                }
                catch (UriFormatException exc)
                {
                    MessageBox.Show("Error al añadir usuario", "Error al añadir usuario", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Las contrasenyas introducidas deben de ser iguales", "Error al validar la contraseña", MessageBoxButtons.OK);
            }

        }

        private void ButtonUsVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonUsGuardar_Click(object sender, EventArgs e)
        {
            string username = tboxNombreUsuario.Text;
            string primernombre = txtBoxUsNombre.Text;
            string apellidos = textBoxUsApellidos.Text;
            string nombre = primernombre + " " + apellidos;
            string validarContrasenya = textBoxUsConfigContrasenya.Text;
            string estado = "";
            if (checkBoxEstado.Checked)
            {
                estado = "true";
            }
            else
            {
                estado = "false";
            }
            id = _usuario.Id;
            var url = $"";
            string data = "";

            if (comboTipoUsuario.SelectedIndex == 0)
            {
                string alergenos = tboxUserAlerg.Text;
                string observciones = textBoxObservaciones.Text;
                string email = textBoxUsEmail.Text;
                string tel = textBoxUsTel.Text;
                contrasenya = _usuario.Contrasenya;
                url = $"http://localhost:8082/clientes/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"observacion\": \"" + observciones + "\",\r\n  \"alergenos\": \"" + alergenos + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 1)
            {
                string curso = tboxUserCurso.Text;
                string turno = tboxUserTurno.Text;
                contrasenya = textBoxUsContrasenya.Text;
                url = $"http://localhost:8082/grupos/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"curso\": \"" + curso + "\",\r\n  \"turno\": \"" + turno + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 2)
            {
                string especialidad = tboxUserEspec.Text;
                contrasenya = _usuario.Contrasenya;
                url = $"http://localhost:8082/admins/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"especialidad\": \"" + especialidad + "\"\r\n}\r\n";
            }
            if (contrasenya == validarContrasenya || validarContrasenya.Equals(""))
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                string json = data;
                request.Method = "PUT";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                request.Headers["Authorization"] = $"Bearer {_token}";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                            }
                        }
                    }
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (WebException ex)
                {
                    string mensaje = "";
                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        mensaje = reader.ReadToEnd();
                    }
                    MessageBox.Show("Error al modificar usuario", "Error al modificar usuario", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Las contrasenyas introducidas deben de ser iguales", "Error al validar la contraseña", MessageBoxButtons.OK);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            labelTituoCrearUsuario.Text = "MODIFICAR USUARIO";

            buttonModificar.Visible = false;
            ButtonUsVolver.Visible = false;
            ButtonUsAnyadir.Visible = false;
            ButtonUsGuardar.Visible = true;

            comboTipoUsuario.Enabled = false;

            if (_usuario.Role.Equals("ROLE_CLIENTE"))
            {
                textBoxUsContrasenya.ReadOnly = true;
                textBoxUsConfigContrasenya.ReadOnly = true;
            }
            else if (_usuarioActual.Id == _usuario.Id)
            {
                textBoxUsContrasenya.ReadOnly = false;
                textBoxUsConfigContrasenya.ReadOnly = false;
            }
            else if (_usuario.Role.Equals("ROLE_GRUPO") && _usuarioActual.Role.Equals("ROLE_ADMIN"))
            {
                textBoxUsContrasenya.ReadOnly = false;
                textBoxUsConfigContrasenya.ReadOnly = false;
            }
            else if (_usuario.Role.Equals("ROLE_ADMIN") || _usuario.Role.Equals("ROLE_GRUPO"))
            {
                textBoxUsContrasenya.ReadOnly = true;
                textBoxUsConfigContrasenya.ReadOnly = true;
            }


            tboxNombreUsuario.ReadOnly = false;
            txtBoxUsNombre.ReadOnly = false;
            textBoxUsApellidos.ReadOnly = false;
            textBoxUsEmail.ReadOnly = false;
            textBoxUsTel.ReadOnly = false;
            comboTipoUsuario.Enabled = true;
            checkBoxEstado.Enabled = true;
            tboxUserAlerg.ReadOnly = false;
            textBoxObservaciones.ReadOnly = false;
            tboxUserCurso.ReadOnly = false;
            tboxUserTurno.ReadOnly = false;
            tboxUserEspec.ReadOnly = false;
        }


        private List<AdminDto> ObtenerAdmins()
        {
            try
            {
                var url = "http://localhost:8082/admins";
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
                    var admins = JsonConvert.DeserializeObject<List<AdminDto>>(json);
                    return admins;
                }

            }
            catch (WebException e)
            {
                MessageBox.Show($"Error de conexión: {e.Message}", "No tienes permisos",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        private List<GrupoDto> ObtenerGrupos()
        {
            try
            {
                var url = "http://localhost:8082/grupos";
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
                    var grupos = JsonConvert.DeserializeObject<List<GrupoDto>>(json);
                    return grupos;
                }

            }
            catch (WebException e)
            {
                MessageBox.Show($"Error de conexión: {e.Message}", "No tienes permisos",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
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

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
