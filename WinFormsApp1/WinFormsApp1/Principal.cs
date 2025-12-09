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

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dataGridViewServicios.ReadOnly = true;
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecargarServicios();

            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecargarUsuarios();

        }


        private void panelTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelTabs.SelectedIndex == 0)
            {
                labTituto.Text = "Gestión general";
                labSubTituto.Text = "Administra la base de datos";
            }
            else if (panelTabs.SelectedIndex == 1)
            {
                labTituto.Text = "Gestión de Servicios";
                labSubTituto.Text = "Administra y visualiza los servicios actuales";
            }
            else if (panelTabs.SelectedIndex == 2)
            {
                labTituto.Text = "Gestión de Usuarios";
                labSubTituto.Text = "Administra y visualiza los usuarios actuales";
            }
            else if (panelTabs.SelectedIndex == 3)
            {
                labTituto.Text = "Gestión de Citas";
                labSubTituto.Text = "Administra las citas y bloquea días no disponibles";
            }
        }










        private void ModificarServicio(ServicioDto servicio)
        {

            Servicio pantallaModificar = new Servicio(servicio, _token);
            pantallaModificar.Form = "Modificar información de " + servicio.Nombre;
            pantallaModificar.LabelTituoCrearServicio = "MODIFICAR SERVICIO";
            pantallaModificar.buttonSerModificar = true;
            pantallaModificar.buttonSerAnyadir = false;

            pantallaModificar.TboxNombreServicio.Text = servicio.Nombre;
            pantallaModificar.TxtBoxDescripcion.Text = servicio.Descripcion;
            pantallaModificar.TextBoxPrecio.Text = servicio.Precio.ToString();
            pantallaModificar.TextBoxDuracion.Text = servicio.Duracion.ToString();
            pantallaModificar.ComboTipoServicio.SelectedIndex = Convert.ToInt32(servicio.TipoServicio?.Id - 1);

            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                RecargarServicios();
            }
        }


        private void EliminarServicio(ServicioDto servicio)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio \"{servicio.Nombre}\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        var url = $"http://localhost:8082/servicio/{servicio.Id_Servicio}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Servicio eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refrescar la tabla
                                RecargarServicios();
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar: {response.StatusCode}", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la eliminación: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void anyadirServicio_Click(object sender, EventArgs e)
        {
            Servicio pantallaAnyadir = new Servicio(null, _token);
            pantallaAnyadir.Form = "Añadir servicio nuevo";
            pantallaAnyadir.LabelTituoCrearServicio = "AÑADIR SERVICIO";
            pantallaAnyadir.buttonSerModificar = false;
            pantallaAnyadir.buttonSerAnyadir = true;

            pantallaAnyadir.TboxNombreServicio.Text = "";
            pantallaAnyadir.TxtBoxDescripcion.Text = "";
            pantallaAnyadir.TextBoxPrecio.Text = "";
            pantallaAnyadir.TextBoxDuracion.Text = "";
            pantallaAnyadir.ComboTipoServicio.SelectedItem = "";

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarServicios();
            }
        }


        private List<ServicioDto> ObtenerServicios()
        {

            var url = "http://localhost:8082/servicio";
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
                var servicios = JsonConvert.DeserializeObject<List<ServicioDto>>(json);
                return servicios;
            }
        }


        private void RecargarServicios()
        {
            var servicios = ObtenerServicios();

            dataGridViewServicios.Rows.Clear();

            var tope = 0;
            if (servicios.Count - ((contador - 1) * 20) < 20)
            {
                tope = ((contador - 1) * 20) + (servicios.Count - ((contador - 1) * 20)) - 1;
            }
            else
            {
                tope = contador * 20;
            }

            for (int i = (contador - 1) * 20; i <= tope; i++)
            {
                var precio = servicios[i].Precio.ToString() + " €";
                var duracion = servicios[i].Duracion.ToString() + " minutos";
                int index = dataGridViewServicios.Rows.Add(
                    servicios[i].Nombre,
                    servicios[i].Descripcion,
                    duracion,
                    precio,
                    servicios[i].TipoServicio?.Nombre

                );

                dataGridViewServicios.Rows[index].Tag = servicios[i];
            }

            labelNumServicios.Text = $" {servicios.Count}";
            labelNumTipoSer.Text = (comboBoxSerFiltrar.Items.Count - 1).ToString();

            labelNumSer.Text = $" {servicios.Count}";
        }


        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            // Validar que la fila existe
            if (e.RowIndex >= dataGridViewServicios.Rows.Count) return;

            var fila = dataGridViewServicios.Rows[e.RowIndex];
            var servicio = fila.Tag as ServicioDto;
            if (servicio == null) return;

            var columna = dataGridViewServicios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnModificar")
            {
                ModificarServicio(servicio);
            }
            else if (columna == "dataGridViewImageColumnEliminar")
            {
                EliminarServicio(servicio);
            }

        }


        private void comboBoxSerFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroCategoria = comboBoxSerFiltrar.SelectedItem?.ToString();

            // Obtener todos los servicios
            var servicios = ObtenerServicios();

            // Si selecciona "", mostramos todo
            if (filtroCategoria == "")
            {
                RecargarServicios();
                return;
            }

            // Filtrar por el nombre del tipo de servicio
            var serviciosFiltrados = servicios
                .Where(s => s.TipoServicio != null &&
                            s.TipoServicio.Nombre.Equals(filtroCategoria, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Limpiar la tabla
            dataGridViewServicios.Rows.Clear();

            // Rellenar con los resultados filtrados
            foreach (var s in serviciosFiltrados)
            {
                var precio = s.Precio.ToString() + " €";
                var duracion = s.Duracion.ToString() + " minutos";
                int index = dataGridViewServicios.Rows.Add(
                    s.Nombre,
                    s.Descripcion,
                    duracion,
                    precio,
                    s.TipoServicio?.Nombre
                );

                dataGridViewServicios.Rows[index].Tag = s;
            }
        }


        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxSerBuscar.Text.Trim().ToLower();

            // Obtener todos los servicios
            var servicios = ObtenerServicios();

            // Filtrar por nombre o descripción
            var serviciosFiltrados = servicios
                .Where(s => s.Nombre.ToLower().Contains(filtro)
                         || s.Descripcion.ToLower().Contains(filtro))
                .ToList();

            // Limpiar la tabla
            dataGridViewServicios.Rows.Clear();

            // Rellenar con los resultados filtrados
            foreach (var s in serviciosFiltrados)
            {
                var precio = s.Precio.ToString() + " €";
                var duracion = s.Duracion.ToString() + " minutos";
                int index = dataGridViewServicios.Rows.Add(
                    s.Nombre,
                    s.Descripcion,
                    duracion,
                    precio,
                    s.TipoServicio?.Nombre
                );

                dataGridViewServicios.Rows[index].Tag = s;
            }
        }












        private void InfoUsuario(UsersDto usuario)
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

            Usuario pantallaInfo = new Usuario(usuario, _token);
            pantallaInfo.Form = "Información de " + usuario.Nombre;
            pantallaInfo.LabelTituoCrearUsuario.Visible = false;
            pantallaInfo.LabelTituoInfoUsuario.Visible = true;


            pantallaInfo.buttonUsModificar = false;
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
            pantallaInfo.TboxUserDirecc.ReadOnly = true;
            pantallaInfo.TboxUserAlerg.ReadOnly = true;
            pantallaInfo.TboxUserObserv.ReadOnly = true;
            pantallaInfo.TboxUserCurso.ReadOnly = true;
            pantallaInfo.TboxUserTurno.ReadOnly = true;
            pantallaInfo.TboxUserEspec.ReadOnly = true;


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

            var indexRol = 3;
            if (usuario.Role.Equals("ROLE_CLIENTE"))
            {
                var clientes = ObtenerClientes();
                foreach (ClienteDto c in clientes)
                {
                    if (c.Id == usuario.Id)
                    {
                        pantallaInfo.TboxUserDirecc.Text = c.Direccion ?? "";
                        pantallaInfo.TboxUserAlerg.Text = c.Alergenos ?? "";
                        pantallaInfo.TboxUserObserv.Text = c.Observacion ?? "";
                    }
                }
                pantallaInfo.PanelAdmin.Visible = false;
                pantallaInfo.PanelUsGrupo.Visible = false;
                pantallaInfo.PanelCliente.Visible = true;

                indexRol = 0;
            }
            else if (usuario.Role.Equals("ROLE_GRUPO"))
            {

                var grupos = ObtenerGrupos();
                foreach (GrupoDto g in grupos)
                {
                    if (g.Id == usuario.Id)
                    {
                        pantallaInfo.TboxUserCurso.Text = g.Curso ?? "";
                        pantallaInfo.TboxUserTurno.Text = g.Turno ?? "";
                    }
                }
                pantallaInfo.PanelAdmin.Visible = false;
                pantallaInfo.PanelUsGrupo.Visible = true;
                pantallaInfo.PanelCliente.Visible = false;

                indexRol = 1;
            }
            else if (usuario.Role.Equals("ROLE_ADMIN"))
            {
                var admins = ObtenerAdmins();
                foreach (AdminDto a in admins)
                {
                    if (a.Id == usuario.Id)
                    {
                        pantallaInfo.TboxUserEspec.Text = a.Especialidad ?? "";
                    }
                }
                pantallaInfo.PanelAdmin.Visible = true;
                pantallaInfo.PanelUsGrupo.Visible = false;
                pantallaInfo.PanelCliente.Visible = false;

                indexRol = 2;
            }
            pantallaInfo.ComboTipoUsuario.SelectedIndex = indexRol;

            pantallaInfo.Show();

        }


        private void ModificarUsuario(UsersDto usuario)
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

            Usuario pantallaModificar = new Usuario(usuario, _token);
            pantallaModificar.Form = "Modificar información de " + usuario.Nombre;
            pantallaModificar.LabelTituoCrearUsuario.Text = "MODIFICAR USUARIO";
            pantallaModificar.LabelTituoCrearUsuario.Visible = true;
            pantallaModificar.LabelTituoInfoUsuario.Visible = false;
            pantallaModificar.buttonUsModificar = true;
            pantallaModificar.buttonUsVolver = false;
            pantallaModificar.buttonUsAnyadir = false;

            pantallaModificar.TboxNombreUsuario.Text = usuario.Username;
            pantallaModificar.TxtBoxUsNombre.Text = nombre;
            pantallaModificar.TextBoxUsApellidos.Text = apellidos;
            pantallaModificar.TextBoxUsEmail.Text = usuario.Email;
            pantallaModificar.TextBoxUsTel.Text = usuario.Telefono.ToString();
            pantallaModificar.ComboTipoUsuario.Enabled = false;

            if (usuario.Estado.Equals("true"))
            {
                pantallaModificar.CheckBoxEstado.Checked = true;
            }
            else if (usuario.Estado.Equals("false"))
            {
                pantallaModificar.CheckBoxEstado.Checked = false;
            }

            var indexRol = 3;
            if (usuario.Role.Equals("ROLE_CLIENTE"))
            {
                var clientes = ObtenerClientes();
                foreach (ClienteDto c in clientes)
                {
                    if (c.Id == usuario.Id)
                    {
                        pantallaModificar.TboxUserDirecc.Text = c.Direccion ?? "";
                        pantallaModificar.TboxUserAlerg.Text = c.Alergenos ?? "";
                        pantallaModificar.TboxUserObserv.Text = c.Observacion ?? "";
                    }
                }
                pantallaModificar.PanelAdmin.Visible = false;
                pantallaModificar.PanelUsGrupo.Visible = false;
                pantallaModificar.PanelCliente.Visible = true;

                pantallaModificar.TextBoxUsContrasenya.ReadOnly = true;
                pantallaModificar.TextBoxUsConfigContrasenya.ReadOnly = true;

                indexRol = 0;
            }
            else if (usuario.Role.Equals("ROLE_GRUPO"))
            {

                var grupos = ObtenerGrupos();
                foreach (GrupoDto g in grupos)
                {
                    if (g.Id == usuario.Id)
                    {
                        pantallaModificar.TboxUserCurso.Text = g.Curso ?? "";
                        pantallaModificar.TboxUserTurno.Text = g.Turno ?? "";
                    }
                }
                pantallaModificar.PanelAdmin.Visible = false;
                pantallaModificar.PanelUsGrupo.Visible = true;
                pantallaModificar.PanelCliente.Visible = false;

                indexRol = 1;
            }
            else if (usuario.Role.Equals("ROLE_ADMIN"))
            {
                var admins = ObtenerAdmins();
                foreach (AdminDto a in admins)
                {
                    if (a.Id == usuario.Id)
                    {
                        pantallaModificar.TboxUserEspec.Text = a.Especialidad ?? "";
                    }
                }
                pantallaModificar.PanelAdmin.Visible = true;
                pantallaModificar.PanelUsGrupo.Visible = false;
                pantallaModificar.PanelCliente.Visible = false;

                pantallaModificar.TextBoxUsContrasenya.ReadOnly = true;
                pantallaModificar.TextBoxUsConfigContrasenya.ReadOnly = true;

                indexRol = 2;
            }
            pantallaModificar.ComboTipoUsuario.SelectedIndex = indexRol;


            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                RecargarUsuarios();
            }
        }


        private void EliminarUsuario(UsersDto usuario)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el usuario \"{usuario.Nombre}\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        var url = $"";
                        if (usuario.Role.Equals("ROLE_CLIENTE"))
                        {
                            url = $"http://localhost:8082/clientes/{usuario.Id}";
                        }
                        else if (usuario.Role.Equals("ROLE_GRUPO"))
                        {
                            url = $"http://localhost:8082/grupos/{usuario.Id}";
                        }
                        else if (usuario.Role.Equals("ROLE_ADMIN"))
                        {
                            url = $"http://localhost:8082/admins/{usuario.Id}";
                        }
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Usuario eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refrescar la tabla
                                RecargarUsuarios();
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar: {response.StatusCode}", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la eliminación: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void anyadirUsuario_Click(object sender, EventArgs e)
        {
            Usuario pantallaAnyadir = new Usuario(null, _token);
            pantallaAnyadir.Form = "Añadir usuario nuevo";
            pantallaAnyadir.LabelTituoCrearUsuario.Text = "AÑADIR USUARIO";
            pantallaAnyadir.LabelTituoCrearUsuario.Visible = true;
            pantallaAnyadir.LabelTituoInfoUsuario.Visible = false;

            pantallaAnyadir.buttonUsModificar = false;
            pantallaAnyadir.buttonUsVolver = false;
            pantallaAnyadir.buttonUsAnyadir = true;
            pantallaAnyadir.ComboTipoUsuario.Enabled = true;
            pantallaAnyadir.CheckBoxEstado.Checked = true;

            pantallaAnyadir.TboxNombreUsuario.Text = "";
            pantallaAnyadir.TxtBoxUsNombre.Text = "";
            pantallaAnyadir.TextBoxUsApellidos.Text = "";
            pantallaAnyadir.TextBoxUsEmail.Text = "";
            pantallaAnyadir.TextBoxUsTel.Text = "";
            pantallaAnyadir.ComboTipoUsuario.SelectedItem = "";
            pantallaAnyadir.TboxUserDirecc.Text = "";
            pantallaAnyadir.TboxUserAlerg.Text = "";
            pantallaAnyadir.TboxUserObserv.Text = "";
            pantallaAnyadir.TboxUserCurso.Text = "";
            pantallaAnyadir.TboxUserTurno.Text = "";
            pantallaAnyadir.TboxUserEspec.Text = "";


            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarUsuarios();
            }
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

        private List<AdminDto> ObtenerAdmins()
        {
            try
            {
                var url = "http://localhost:8082/admins";
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

                // Aquí añadimos el token
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


        private void RecargarUsuarios()
        {
            var usuarios = ObtenerUsuarios();
            if (usuarios == null) return;

            dataGridViewUsuarios.Rows.Clear();

            int activos = 0;
            int inactivos = 0;
            int grupos = 0;
            int clientes = 0;
            int admins = 0;

            foreach (var u in usuarios)
            {
                string rol = "";
                if (u.Role.Equals("ROLE_CLIENTE"))
                {
                    rol = "Cliente";
                    clientes++;
                }
                else if (u.Role.Equals("ROLE_GRUPO"))
                {
                    rol = "Grupo";
                    grupos++;
                }
                else if (u.Role.Equals("ROLE_ADMIN"))
                {
                    rol = "Admin";
                    admins++;
                }

                string estado = "";
                if (u.Estado.Equals("true"))
                {
                    estado = "Activo";
                    activos++;
                }
                else if (u.Estado.Equals("false"))
                {
                    estado = "Inactivo";
                    inactivos++;
                }

                int index = dataGridViewUsuarios.Rows.Add(
                    u.Nombre,
                    u.Username,
                    rol,
                    estado
                );

                dataGridViewUsuarios.Rows[index].Tag = u;
            }

            // Actualizar labels con los conteos
            labelNumUsuarios.Text = $"{usuarios.Count}";
            labelNumUActivos.Text = $"{activos}";
            labelNumUInactivos.Text = $"{inactivos}";
            labelNumAdmin.Text = $"{admins}";

            labelNumCli.Text = $"{clientes}";
            labelNumAdm.Text = $"{admins}";
            labelNumGrup.Text = $"{grupos}";
        }


        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            // Validar que la fila existe
            if (e.RowIndex >= dataGridViewUsuarios.Rows.Count) return;

            var fila = dataGridViewUsuarios.Rows[e.RowIndex];
            var usuario = fila.Tag as UsersDto;
            if (usuario == null) return;

            var columna = dataGridViewUsuarios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnUsModificar")
            {
                ModificarUsuario(usuario);
            }
            else if (columna == "dataGridViewImageColumnUsEliminar")
            {
                EliminarUsuario(usuario);
            }
            else if (columna == "dataGridViewImageColumnUsInfo")
            {
                InfoUsuario(usuario);
            }

        }

        private void filtrar()
        {
            string filtro = textBoxSUsBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxUsFiltrar.SelectedItem?.ToString();

            // Obtener todos los usuarios
            var usuarios = ObtenerUsuarios();
            if (usuarios == null) return;

            var listaFiltrada = usuarios.AsEnumerable();

            // Filtrar por nombre o username
            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada
                    .Where(u => u.Nombre.ToLower().Contains(filtro)
                             || u.Username.ToLower().Contains(filtro)).ToList();
            }

            // Filtro por categoria
            switch (filtroCombo)
            {
                case "Activos":
                    listaFiltrada = listaFiltrada
                        .Where(u => u.Estado.Equals("true", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Inactivos":
                    listaFiltrada = listaFiltrada
                        .Where(u => u.Estado.Equals("false", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Administradores":
                    listaFiltrada = listaFiltrada
                        .Where(u => u.Role.Equals("ROLE_ADMIN", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Clientes":
                    listaFiltrada = listaFiltrada
                        .Where(u => u.Role.Equals("ROLE_CLIENTE", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Grupos":
                    listaFiltrada = listaFiltrada
                        .Where(u => u.Role.Equals("ROLE_GRUPO", StringComparison.OrdinalIgnoreCase));
                    break;
            }

            // Limpiar la tabla
            dataGridViewUsuarios.Rows.Clear();

            // Rellenar con los resultados filtrados
            foreach (var u in listaFiltrada)
            {
                string rol = "";
                if (u.Role.Equals("ROLE_CLIENTE"))
                {
                    rol = "Cliente";
                }
                else if (u.Role.Equals("ROLE_GRUPO"))
                {
                    rol = "Grupo";
                }
                else if (u.Role.Equals("ROLE_ADMIN"))
                {
                    rol = "Admin";
                }

                string estado = "";
                if (u.Estado.Equals("true"))
                {
                    estado = "Activo";
                }
                else if (u.Estado.Equals("false"))
                {
                    estado = "Inactivo";
                }

                int index = dataGridViewUsuarios.Rows.Add(
                    u.Nombre,
                    u.Username,
                    rol,
                    estado
                );

                dataGridViewUsuarios.Rows[index].Tag = u;
            }
        }


        private void textBoxSUsBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }


        private void comboBoxUsFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            var servicios = ObtenerServicios();
            if (servicios.Count % 20 != 0)
            {
                pagSer = (servicios.Count / 20) + 1;
            }
            else
            {
                pagSer = (servicios.Count / 20);
            }

            if (contador > 1)
            {
                contador--;
                RecargarServicios();
                if (contador != pagSer)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            var servicios = ObtenerServicios();
            if (servicios.Count % 20 != 0)
            {
                pagSer = (servicios.Count / 20) + 1;
            }
            else
            {
                pagSer = (servicios.Count / 20);
            }

            if (contador < pagSer)
            {
                contador++;
                RecargarServicios();

                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
                if (contador == pagSer)
                {
                    buttonPaginacionDelante.ForeColor = Color.Silver;
                }
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres cerrar sesión?", "Cerrar sesión",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}

    
