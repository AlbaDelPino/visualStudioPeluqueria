using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Usuario(UsersDto usuario, string token)
        {
            InitializeComponent();
            _usuario = usuario;
            _token = token;
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
            string email = textBoxUsEmail.Text;
            string tel = textBoxUsTel.Text;
            string contrasenya = textBoxUsContrasenya.Text;
            string validarContrasenya = textBoxUsConfigContrasenya.Text;
            bool estado = checkBoxEstado.Checked;
            var url = $"";
            string data = "";

            if (comboTipoUsuario.SelectedIndex == 0)
            {
                string direccion = tboxUserDirecc.Text;
                string alergenos = tboxUserAlerg.Text;
                string observciones = tboxUserObserv.Text;
                url = $"http://localhost:8082/api/auth/signup/cliente";
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"direccion\": \"" + direccion + "\",\r\n  \"observacion\": \"" + observciones + "\",\r\n  \"alergenos\": \"" + alergenos + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 1)
            {
                string curso = tboxUserCurso.Text;
                string turno = tboxUserTurno.Text;
                url = $"http://localhost:8082/api/auth/signup/grupo";
                data = "";
            }
            else if (comboTipoUsuario.SelectedIndex == 2)
            {
                string especialidad = tboxUserEspec.Text;
                url = $"http://localhost:8082/api/auth/signup/admin";
                data = "";
            }

            if (contrasenya == validarContrasenya)
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    //string json = $"{{\"data\":\"{data}\"}}";
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
                                // Do something with responseBody
                                Console.WriteLine(responseBody);
                                MessageBox.Show("Usuario añadido correctamente", "Usuario añadido correctamente", MessageBoxButtons.OK);
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

        private void ButtonUsModificar_Click(object sender, EventArgs e)
        {
            string username = tboxNombreUsuario.Text;
            string primernombre = txtBoxUsNombre.Text;
            string apellidos = textBoxUsApellidos.Text;
            string nombre = primernombre + " " + apellidos;
            string email = textBoxUsEmail.Text;
            string tel = textBoxUsTel.Text;
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
                string direccion = tboxUserDirecc.Text;
                string alergenos = tboxUserAlerg.Text;
                string observciones = tboxUserObserv.Text;
                contrasenya = _usuario.Contrasenya;
                url = $"http://localhost:8082/clientes/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"direccion\": \"" + direccion + "\",\r\n  \"observacion\": \"" + observciones + "\",\r\n  \"alergenos\": \"" + alergenos + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 1)
            {
                string curso = tboxUserCurso.Text;
                string turno = tboxUserTurno.Text;
                contrasenya = textBoxUsContrasenya.Text;
                url = $"http://localhost:8082/grupos/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"curso\": \"" + curso + "\",\r\n  \"turno\": \"" + turno + "\"\r\n}\r\n";
            }
            else if (comboTipoUsuario.SelectedIndex == 2)
            {
                string especialidad = tboxUserEspec.Text;
                contrasenya = _usuario.Contrasenya;
                url = $"http://localhost:8082/admins/" + id;
                data = "{\r\n  \"username\": \"" + username + "\",\r\n  \"contrasenya\": \"" + contrasenya + "\",\r\n  \"email\": \"" + email + "\",\r\n  \"nombre\": \"" + nombre + "\",\r\n  \"telefono\": \"" + tel + "\",\r\n  \"estado\": \"" + estado + "\",\r\n  \"especialidad\": \"" + especialidad + "\"\r\n}\r\n";
            }
            if (contrasenya == validarContrasenya || validarContrasenya.Equals(""))
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                //string json = $"{{\"data\":\"{data}\"}}";
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
                                // Do something with responseBody
                                Console.WriteLine(responseBody);
                                MessageBox.Show("Usuario modificado correctamente", "Usuario modificado correctamente", MessageBoxButtons.OK);
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

        private void ButtonUsVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
