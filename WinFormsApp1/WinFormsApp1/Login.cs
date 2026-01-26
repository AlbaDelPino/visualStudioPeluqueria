using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Collections.Specialized.BitVector32;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public string Token { get; private set; }
        public UsersDto UsuarioActual { get; private set; }// propiedad para devolver el token
        public Login()
        {
            InitializeComponent();
        }

        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contranya = textBoxContrasenya.Text;

            var url = "http://localhost:8082/api/auth/signin";
            string data = $"{{\"username\":\"{usuario}\", \"contrasenya\":\"{contranya}\"}}";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                using (Stream strReader = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(strReader))
                {
                    string responseBody = reader.ReadToEnd();

                    var usuarioActual = JsonConvert.DeserializeObject<UsersDto>(responseBody);

                    // Parsear JSON y obtener token
                    var jsonObject = JObject.Parse(responseBody);
                    string token = jsonObject["token"]?.ToString();
                    var roles = jsonObject["roles"]?.ToObject<List<string>>();

                    if (!string.IsNullOrEmpty(token))
                    {

                        // Validar roles
                        if (roles != null && roles.Contains("ROLE_CLIENTE"))
                        {
                            MessageBox.Show("No tienes permisos suficientes para iniciar sesión.",
                                            "Acceso denegado",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return; // salir sin cerrar el formulario
                        }

                        Token = token;
                        UsuarioActual = usuarioActual;// guardar en propiedad
                        this.DialogResult = DialogResult.OK; // devolver OK al Program.cs
                        this.Close(); // cerrar login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (WebException)
            {
                // Aquí capturamos cualquier error de conexión o credenciales inválidas
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                // Captura genérica para otros errores inesperados
                MessageBox.Show("Ha ocurrido un error inesperado. Inténtalo de nuevo.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static class Session
        {
            public static string Token { get; set; }
        }

       
    }
}
