using CitasInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class PanelCita : Form
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
        private static int pagCit;
        private static int contador = 1;
        private static List<CitaDto> _citas;

        public PanelCita(string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void PanelCita_Load(object sender, EventArgs e)
        {
            dataGridViewCitas.ReadOnly = true;
            dataGridViewCitas.AllowUserToAddRows = false;
            dataGridViewCitas.AllowUserToDeleteRows = false;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _citas = new List<CitaDto>();
            RecargarCitas();
            pasarPagina();

            ConfigurarUIEstiloImagen();
        }

        private void ConfigurarUIEstiloImagen()
        {
            // BOTÓN (+) CIRCULAR
            anyadirCita.Text = "+";
            anyadirCita.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirCita.FlatStyle = FlatStyle.Flat;
            anyadirCita.FlatAppearance.BorderSize = 0;
            anyadirCita.BackColor = Color.FromArgb(255, 128, 0);
            anyadirCita.ForeColor = Color.White;
            anyadirCita.Size = new Size(45, 45);


            anyadirCita.Left = panelVisualCitas.Width - 60; // A la derecha

            // BUSCADOR Y COMBO
            textBoxCitBuscar.Left = 50;
            // AjCittamos el ancho para que sea dinámico pero deje espacio al combo
            textBoxCitBuscar.Width = panelVisualCitas.Width - 350;

            // COMBO (Alargado)
            comboBoxCitFiltrar.Width = 180; // Más ancho
            comboBoxCitFiltrar.Left = textBoxCitBuscar.Right + 30; // Se posiciona justo después del buscador

            // ANCLAJES CORRECTOS para que al estirar la ventana no se solapen
            textBoxCitBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCitFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirCita.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }

        private void ActualizarRegiones()
        {
            // Redondeo físico del botón naranja (Círculo perfecto)
            anyadirCita.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirCita.Width, anyadirCita.Height, anyadirCita.Width, anyadirCita.Height));
        }

        private void PanelCita_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualCitas.Invalidate(); // Fuerza a redibujar el borde gris
        }

        private void panelVisualCitas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            // 1. ÁREA DEL BUSCADOR (Sigue al TextBox)
            // Aumentamos el ancho (Width + 45) para que la cápsula cubra la lupa
            Rectangle rectBusqueda = new Rectangle(
                textBoxCitBuscar.Left - 35,
                textBoxCitBuscar.Top - 15,
                textBoxCitBuscar.Width + 45,
                textBoxCitBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxCitBuscar.Left - 25, textBoxCitBuscar.Top - 2);

            // 2. ÁREA DEL FILTRO (Sigue al ComboBox)
            Rectangle rectFiltro = new Rectangle(
                comboBoxCitFiltrar.Left - 10,
                comboBoxCitFiltrar.Top - 10,
                comboBoxCitFiltrar.Width + 25, // Un poco más ancho para el desplegable
                comboBoxCitFiltrar.Height + 20
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












        private void ModificarCita(CitaDto cita)
        {
            /*
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
                RecargarCitas();
                pasarPagina();
            }*/
        }

        private void EliminarCita(CitaDto cita)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar la cita?",
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
                        var url = $"http://localhost:8082/citas/{cita.Id}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Cita eliminada correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refrescar la tabla
                                RecargarCitas();
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

        private void anyadirCita_Click(object sender, EventArgs e)
        {
            /*Usuario pantallaAnyadir = new Usuario(null, _token);
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
                pasarPagina();
            }*/
        }

        private List<CitaDto> ObtenerCitas()
        {
            try
            {
                var url = "http://localhost:8082/citas/todas";
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
                    var citas = JsonConvert.DeserializeObject<List<CitaDto>>(json);
                    return citas;
                }

            }
            catch (WebException e)
            {
                MessageBox.Show($"Error de conexión: {e.Message}", "No tienes permisos",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void RecargarCitas()
        {
            /*_usuarios = ObtenerUsuarios();

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
            labelNumAdmin.Text = $"{admins}";*/
        }

        private void pasarPagina()
        {
            dataGridViewCitas.Rows.Clear();

            var tope = 0;
            if (_citas.Count - ((contador - 1) * 20) < 20)
            {
                tope = ((contador - 1) * 20) + (_citas.Count - ((contador - 1) * 20)) - 1;
            }
            else
            {
                tope = contador * 20;
            }

            for (int i = (contador - 1) * 20; i <= tope; i++)
            {
                var fecha = _citas[i].Horario.DiaSemana + " " + _citas[i].Fecha;
                var hora = _citas[i].Horario.HoraInicio + " - " + _citas[i].Horario.HoraFin;

                string estado = "";
                if (_citas[i].Estado.Equals("true"))
                {
                    estado = "Confirmada";
                }
                else if (_citas[i].Estado.Equals("false"))
                {
                    estado = "Cancelada";
                }

                int index = dataGridViewCitas.Rows.Add(
                    _citas[i].Cliente.Nombre,
                    _citas[i].Horario.Servicio.Nombre,
                    fecha,
                    hora,
                    estado,
                    _citas[i].Horario.Grupo.Nombre

                );

                dataGridViewCitas.Rows[index].Tag = _citas[i];
            }
        }
        private void dataGridViewCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 5) return;

            // Validar que la fila existe
            if (e.RowIndex >= dataGridViewCitas.Rows.Count) return;

            var fila = dataGridViewCitas.Rows[e.RowIndex];
            var servicio = fila.Tag as CitaDto;
            if (servicio == null) return;

            var columna = dataGridViewCitas.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnModificar")
            {
                //ModificarCitas(servicio);
            }
            else if (columna == "dataGridViewImageColumnEliminar")
            {
                //EliminarCitas(servicio);
            }
        }

        private void filtrarCitas()
        {
            /*string filtro = textBoxSUsBuscar.Text.Trim().ToLower();
            string filtroCombo = comboBoxUsFiltrar.SelectedItem?.ToString();

            // Obtener todos los usuarios
            if (_usuarios == null) return;

            var listaFiltrada = _usuarios.AsEnumerable();

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
            }*/
        }

        private void textBoxCitBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }

        private void comboBoxCitFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarCitas();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagCit)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagCit)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagCit)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }

       
    }
}
