using CitasInfo.Models;
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
        private UsersDto _usuarioSeleccionado;
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

            _usuariosCompletos = new List<UsersDto>();
            _usuariosFiltrados = new List<UsersDto>();
            _usuarioSeleccionado = new UsersDto();

            CargarTodosLosUsuarios();
            limpiarFiltros();
        }

        private void ActualizarRegiones()
        {
            dataGridViewUsuarios.Width = panelVisualUsuarios.Width / 4 * 3;
            textBoxSUsBuscar.Left = panelFiltros.Width + 80;
            textBoxSUsBuscar.Width = dataGridViewUsuarios.Width - 45;
            panelPaginacion.Padding = new Padding(panelFiltros.Width + 47, 0, 0, 0);
            labelPaginaActual.Left = buttonPaginacionDelante.Left + 85;
            panelCliente.Top = panelFiltros.Height - panelCliente.Height;
            panelUsuarios.Top = panelCliente.Top - panelUsuarios.Height - 20;

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
            Rectangle rectBusqueda = new Rectangle(
                textBoxSUsBuscar.Left - 35,
                textBoxSUsBuscar.Top - 15,
                textBoxSUsBuscar.Width + 45,
                textBoxSUsBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, new Pen(Color.FromArgb(220, 220, 220), 1), Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxSUsBuscar.Left - 25, textBoxSUsBuscar.Top - 2);
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










        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado.Id != 0)
            {
                Historial pantallaHistorial = new Historial(_usuarioSeleccionado, _token);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado.Id != 0)
            {
                Usuario pantallaInfo = new Usuario(_usuarioSeleccionado, _token, _usuarioActual);

                if (pantallaInfo.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK);
                    CargarTodosLosUsuarios();
                    filtrarUsuarios();
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado.Id != 0)
            {
                var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el usuario \"{_usuarioSeleccionado.Nombre}\"?",
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
                            if (_usuarioSeleccionado.Role.Equals("ROLE_CLIENTE"))
                            {
                                url = $"http://localhost:8082/clientes/{_usuarioSeleccionado.Id}";
                            }
                            else if (_usuarioSeleccionado.Role.Equals("ROLE_GRUPO"))
                            {
                                url = $"http://localhost:8082/grupos/{_usuarioSeleccionado.Id}";
                            }
                            else if (_usuarioSeleccionado.Role.Equals("ROLE_ADMIN"))
                            {
                                url = $"http://localhost:8082/admins/{_usuarioSeleccionado.Id}";
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
        }


        private void anyadirUsuario_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado.Id != 0)
            {
                Usuario pantallaAnyadir = new Usuario(_token, null);

                if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodosLosUsuarios();
                    filtrarUsuarios();
                }
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewUsuarios.Rows.Count)
            {
                var fila = dataGridViewUsuarios.Rows[e.RowIndex];
                _usuarioSeleccionado = fila.Tag as UsersDto;
            }


        }
        private void filtrarUsuarios()
        {
            string textoBusqueda = textBoxSUsBuscar.Text.Trim().ToLower();
            string estadoSeleccionado = comboBoxEstado.SelectedItem?.ToString().ToLower();
            string rolSeleccionado = comboBoxRol.SelectedItem?.ToString().ToLower();

            _usuariosFiltrados = _usuariosCompletos.Where(u =>
            {
                bool pasaTexto = string.IsNullOrEmpty(textoBusqueda) ||
                                (u.Nombre?.ToLower().Contains(textoBusqueda) == true) ||
                                (u.Username?.ToLower().Contains(textoBusqueda) == true);

                bool pasaEstado = true;
                switch (estadoSeleccionado)
                {
                    case "activos":
                        pasaEstado = u.Estado.Equals("true");
                        break;

                    case "inactivos":
                        pasaEstado = u.Estado.Equals("false");
                        break;
                }

                bool pasaRol = true;
                switch (rolSeleccionado)
                {
                    case "administradores":
                        pasaRol = u.Role.Equals("ROLE_ADMIN");
                        break;

                    case "clientes":
                        pasaRol = u.Role.Equals("ROLE_CLIENTE");
                        break;

                    case "grupos":
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
        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }
        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }
        private void buttonTodos_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void limpiarFiltros()
        {
            comboBoxEstado.SelectedIndex = 0;
            comboBoxRol.SelectedIndex = 0;
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
                    labelNumClientes.Text = $"{usuarios?.Where(u => u.Role.Equals("ROLE_CLIENTE")).ToList().Count ?? 0}";
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

        

        private void CargarTodosLosUsuarios()
        {
            _usuariosCompletos = ObtenerUsuarios();
            _usuariosFiltrados = new List<UsersDto>(_usuariosCompletos);
            _paginaActual = 1;

            pasarPagina();
        }

    }

}
