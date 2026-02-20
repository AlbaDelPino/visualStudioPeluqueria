using Newtonsoft.Json;
using System.Data;
using System.Drawing.Drawing2D;
using System.Net;
using System.Runtime.InteropServices;
using UsersInfo.Models;


namespace WinFormsApp1
{
    public partial class PanelUsuario : Form
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
        private static int _paginaActual = 1;
        private const int REGISTROS_POR_PAGINA = 19;
        private List<UsersDto> _usuariosCompletos;
        private List<UsersDto> _usuariosFiltrados;
        private readonly UsersDto _usuarioActual;

        public PanelUsuario(UsersDto usuarioActual, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            _token = token;
            _usuarioActual = usuarioActual;
        }

        private void PanelUsuario_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;

            _usuariosCompletos = new List<UsersDto>();
            _usuariosFiltrados = new List<UsersDto>();

            ActualizarRegiones();
            CargarTodosLosUsuarios();

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirUsuario.Left = panelVisualUsuarios.Width - 60;

            textBoxSUsBuscar.Left = 50;
            textBoxSUsBuscar.Width = panelVisualUsuarios.Width - 350;

            comboBoxUsFiltrar.Width = 180;
            comboBoxUsFiltrar.Left = textBoxSUsBuscar.Right + 30;
            
            anyadirUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirUsuario.Width, anyadirUsuario.Height, anyadirUsuario.Width, anyadirUsuario.Height));
        }
        private void PanelUsuario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualUsuarios.Invalidate();
        }

        private void panelVisualUsuarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(
                textBoxSUsBuscar.Left - 35,
                textBoxSUsBuscar.Top - 15,
                textBoxSUsBuscar.Width + 45,
                textBoxSUsBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSUsBuscar.Left - 25, textBoxSUsBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(
                comboBoxUsFiltrar.Left - 10,
                comboBoxUsFiltrar.Top - 10,
                comboBoxUsFiltrar.Width + 25,
                comboBoxUsFiltrar.Height + 20
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











        private void InfoUsuario(UsersDto usuario)
        {
            var nombre = usuario.Nombre;
            var apellidos = " ";
            Usuario pantallaInfo = new Usuario(usuario, _token, _usuarioActual);
            pantallaInfo.Form = "Información de " + usuario.Nombre;
            pantallaInfo.LabelTituoCrearUsuario.Visible = false;
            pantallaInfo.LabelTituoInfoUsuario.Visible = true;


            pantallaInfo.buttonUsGuardar = false;
            pantallaInfo.ButtonUsModificar = true;
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
            pantallaInfo.TboxUserAlerg.ReadOnly = true;
            pantallaInfo.TboxUserObserv.ReadOnly = true;
            pantallaInfo.TboxUserCurso.ReadOnly = true;
            pantallaInfo.TboxUserTurno.ReadOnly = true;
            pantallaInfo.TboxUserEspec.ReadOnly = true;


            pantallaInfo.TboxNombreUsuario.Text = usuario.Username;
            pantallaInfo.TxtBoxUsNombre.Text = nombre;
            pantallaInfo.TextBoxUsApellidos.Text = apellidos;

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
                        pantallaInfo.TboxUserAlerg.Text = c.Alergenos ?? "";
                        pantallaInfo.TboxUserObserv.Text = c.Observacion ?? "";
                        pantallaInfo.TextBoxUsEmail.Text = c.Email ?? "";
                        pantallaInfo.TextBoxUsTel.Text = c.Telefono.ToString() ?? "";
                    }
                }
                pantallaInfo.PanelAdmin.Visible = false;
                pantallaInfo.PanelUsGrupo.Visible = false;
                pantallaInfo.PanelCliente.Visible = true;

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
                pantallaInfo.TxtBoxUsNombre.Text = nombre;
                pantallaInfo.TextBoxUsApellidos.Text = apellidos;

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

            if (pantallaInfo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK);
                CargarTodosLosUsuarios();
                filtrarUsuarios();
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

                                CargarTodosLosUsuarios();
                                filtrarUsuarios();
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
            Usuario pantallaAnyadir = new Usuario(null, _token, null);
            pantallaAnyadir.Form = "Añadir usuario nuevo";
            pantallaAnyadir.LabelTituoCrearUsuario.Visible = true;
            pantallaAnyadir.LabelTituoInfoUsuario.Visible = false;

            pantallaAnyadir.ButtonUsModificar = false;
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
            pantallaAnyadir.TboxUserAlerg.Text = "";
            pantallaAnyadir.TboxUserObserv.Text = "";
            pantallaAnyadir.TboxUserCurso.Text = "";
            pantallaAnyadir.TboxUserTurno.Text = "";
            pantallaAnyadir.TboxUserEspec.Text = "";

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTodosLosUsuarios();
                filtrarUsuarios();
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            if (e.RowIndex >= dataGridViewUsuarios.Rows.Count) return;


            var fila = dataGridViewUsuarios.Rows[e.RowIndex];
            var usuario = fila.Tag as UsersDto;
            if (usuario == null) return;

            var columna = dataGridViewUsuarios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnUsEliminar")
            {
                EliminarUsuario(usuario);
            }
            else if (columna == "dataGridViewImageColumnUsInfo")
            {
                InfoUsuario(usuario);
            }
            //Mirar columnas

        }
        private void filtrarUsuarios()
        {
            string textoBusqueda = textBoxSUsBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxUsFiltrar.SelectedItem?.ToString().ToLower();

            _usuariosFiltrados = _usuariosCompletos.Where(u =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                (u.Nombre?.ToLower().Contains(textoBusqueda) == true) ||
                                (u.Username?.ToLower().Contains(textoBusqueda) == true);

                bool pasaEstado = true;
                switch (filtroCombo)
                {
                    case "activos":
                        pasaEstado = u.Estado.Equals("true");
                        break;

                    case "inactivos":
                        pasaEstado = u.Estado.Equals("false");
                        break;
                }

                bool pasaRol = true;
                switch (filtroCombo)
                {
                    case "Administradores":
                        pasaRol = u.Role.Equals("ROLE_ADMIN");
                        break;

                    case "Clientes":
                        pasaRol = u.Role.Equals("ROLE_CLIENTE");
                        break;

                    case "Grupos":
                        pasaRol = u.Role.Equals("ROLE_GRUPO");
                        break;
                }

                return pasaTexto && pasaEstado && pasaRol;
            }).ToList();

            _paginaActual = 1;
            pasarPagina();
        }
        private void textBoxSUsBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }
        private void comboBoxUsFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }

        private void limpiarFiltros()
        {
            comboBoxUsFiltrar.SelectedIndex = 0;
            textBoxSUsBuscar.Text = string.Empty;

            _usuariosCompletos = ObtenerUsuarios();
            _usuariosFiltrados = ObtenerUsuarios();
            _paginaActual = 1;
            pasarPagina();
        }

        private void pasarPagina()
        {
            dataGridViewUsuarios.Rows.Clear();

            int totalPaginas = (_usuariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (totalPaginas == 0) totalPaginas = 1;

            if (_paginaActual > totalPaginas)
                _paginaActual = totalPaginas;

            int inicio = (_paginaActual - 1) * REGISTROS_POR_PAGINA;
            int fin = Math.Min(inicio + REGISTROS_POR_PAGINA, _usuariosFiltrados.Count);


            for (int i = inicio; i < fin; i++)
            {
                var u = _usuariosFiltrados[i];

                string rol = "Cliente";
                if (u.Role.Equals("ROLE_GRUPO"))
                {
                    rol = "Grupo";
                }
                else if (u.Role.Equals("ROLE_ADMIN"))
                {
                    rol = "Admin";
                }

                var estado = "Activo";
                if (u.Estado.Equals("false"))
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

            buttonPaginacionAtras.Enabled = (_paginaActual > 1);
            buttonPaginacionDelante.Enabled = (_paginaActual < totalPaginas);

            labelPaginaActual.Text = $"Página {_paginaActual} de {totalPaginas}";
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                int totalPaginas = (_usuariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
                _paginaActual--;
                pasarPagina();
                if (_paginaActual != totalPaginas)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (_paginaActual == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            int totalPaginas = (_usuariosFiltrados.Count + REGISTROS_POR_PAGINA - 1) / REGISTROS_POR_PAGINA;
            if (_paginaActual < totalPaginas)
            {
                _paginaActual++;
                pasarPagina();
                if (_paginaActual != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (_paginaActual == totalPaginas)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
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

                request.Headers["Authorization"] = $"Bearer {_token}";
                using (var response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    var usuarios = JsonConvert.DeserializeObject<List<UsersDto>>(json);
                    labelNumUsuarios.Text = $"{usuarios.Count}";
                    labelNumUActivos.Text = $"{usuarios?.Where(u => u.Estado.Equals("true")).ToList().Count ?? 0}";
                    labelNumUInactivos.Text = $"{usuarios?.Where(u => u.Estado.Equals("false")).ToList().Count ?? 0}";
                    labelNumAdmin.Text = $"{usuarios?.Where(u => u.Role.Equals("ROLE_ADMIN")).ToList().Count ?? 0}";
                    return usuarios.OrderBy(u => u.Nombre).ToList();
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

        private void CargarTodosLosUsuarios()
        {
            _usuariosCompletos = ObtenerUsuarios();
            _usuariosFiltrados = new List<UsersDto>(_usuariosCompletos);
            _paginaActual = 1;

            pasarPagina();
        }
 
    }

}
