using Newtonsoft.Json;
using System.Data;
using System.Drawing.Drawing2D;
using System.Net;
using UsersInfo.Models;
using System.Runtime.InteropServices;


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
        private static int pagUs;
        private static int contador = 1;
        private static List<UsersDto> _usuarios;
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
            
            _usuarios = new List<UsersDto>();
            RecargarUsuarios();
            pasarPagina();

            ConfigurarUIEstiloImagen();
        }

        private void ConfigurarUIEstiloImagen()
        {
            anyadirUsuario.Text = "+";
            anyadirUsuario.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Size = new Size(45, 45);

            anyadirUsuario.Left = panelVisualUsuarios.Width - 60;

            textBoxSUsBuscar.Left = 50;
            textBoxSUsBuscar.Width = panelVisualUsuarios.Width - 350;

            comboBoxUsFiltrar.Width = 180;
            comboBoxUsFiltrar.Left = textBoxSUsBuscar.Right + 30;

            textBoxSUsBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUsFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirUsuario.Anchor =  AnchorStyles.Right;

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            anyadirUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirUsuario.Width, anyadirUsuario.Height, anyadirUsuario.Width, anyadirUsuario.Height));
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
            pantallaInfo.TboxUserComCit.ReadOnly = true;
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
                        pantallaInfo.TboxUserComCit.Text = c.Comentario ?? "";
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

            if (pantallaInfo.ShowDialog() == DialogResult.OK)
            {
                RecargarUsuarios();
                pasarPagina();
                MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK);
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
                                pasarPagina();
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
            pantallaAnyadir.TboxUserComCit.Text = "";
            pantallaAnyadir.TboxUserAlerg.Text = "";
            pantallaAnyadir.TboxUserObserv.Text = "";
            pantallaAnyadir.TboxUserCurso.Text = "";
            pantallaAnyadir.TboxUserTurno.Text = "";
            pantallaAnyadir.TboxUserEspec.Text = "";

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarUsuarios();
                pasarPagina();
                MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void RecargarUsuarios()
        {
            _usuarios = ObtenerUsuarios();

            if (_usuarios.Count % 15 != 0)
            {
                pagUs = (_usuarios.Count / 15) + 1;
            }
            else
            {
                pagUs = (_usuarios.Count / 15);
            }

            int activos = 0;
            int inactivos = 0;
            int grupos = 0;
            int clientes = 0;
            int admins = 0;

            foreach (var u in _usuarios)
            {
                if (u.Role.Equals("ROLE_CLIENTE"))
                {
                    clientes++;
                }
                else if (u.Role.Equals("ROLE_GRUPO"))
                {
                    grupos++;
                }
                else if (u.Role.Equals("ROLE_ADMIN"))
                {
                    admins++;
                }

                if (u.Estado.Equals("true"))
                {
                    activos++;
                }
                else if (u.Estado.Equals("false"))
                {
                    inactivos++;
                }
            }

            labelNumUsuarios.Text = $"{_usuarios.Count}";
            labelNumUActivos.Text = $"{activos}";
            labelNumUInactivos.Text = $"{inactivos}";
            labelNumAdmin.Text = $"{admins}";
        }
        private void pasarPagina()
        {
            dataGridViewUsuarios.Rows.Clear();
            int registrosASaltar = (contador - 1) * 15;
            var usuariosPagina = _usuarios.Skip(registrosASaltar).Take(15).ToList();

            foreach (var u in usuariosPagina)
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

        }

        private void filtrarUsuarios()
        {
            string filtro = textBoxSUsBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxUsFiltrar.SelectedItem?.ToString();

            if (_usuarios == null) return;

            var listaFiltrada = _usuarios.AsEnumerable();

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada
                    .Where(u => u.Nombre?.ToLower().Contains(filtro) == true
                             || u.Username?.ToLower().Contains(filtro) == true).ToList();
            }

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

            dataGridViewUsuarios.Rows.Clear();

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
            filtrarUsuarios();
        }


        private void comboBoxUsFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagUs)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagUs)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagUs)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }
    }

}
