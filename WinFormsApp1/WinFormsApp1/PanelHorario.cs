using CitasInfo.Models;
using Newtonsoft.Json;
using UsersInfo.Models;
using System.Drawing.Drawing2D;
using System.Globalization; 
using System.Net;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class PanelHorario : Form
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
        private static int pagHo;
        private static int contador = 1;
        private static List<HorarioSemanalDto> _horarios;
        private readonly List<UsersDto> _grupos;
        private readonly UsersDto _usuarioActual;

        public PanelHorario(UsersDto usuarioActual, List<UsersDto> grupos, string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            _token = token;
            _grupos = grupos;
            _usuarioActual = usuarioActual;
        }
        private void PanelHorario_Load(object sender, EventArgs e)
        {
            dataGridViewHorarios.ReadOnly = true;
            dataGridViewHorarios.AllowUserToAddRows = false;
            dataGridViewHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHorarios.DataError += (s, ev) => { ev.ThrowException = false; };

            _horarios = new List<HorarioSemanalDto>();
            RecargarHorario();
            pasarPagina();

            ConfigurarUIEstiloImagen();

            comboBoxHorario.DataSource = _grupos;
            comboBoxHorario.DisplayMember = "Nombre";
            comboBoxHorario.ValueMember = "Id";
            comboBoxHorario.SelectedItem = null;
            if (_usuarioActual.Role.Equals("ROLE_GRUPO"))
            {
                var grupoSeleccionado = _grupos.FirstOrDefault(g => g.Id == _usuarioActual.Id);
                if (grupoSeleccionado != null)
                {
                    comboBoxHorario.SelectedItem = grupoSeleccionado;
                }
                filtrarHorario();
            }
        }


        private void ConfigurarUIEstiloImagen()
        {
            anyadirHorario.Text = "+";
            anyadirHorario.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            anyadirHorario.FlatStyle = FlatStyle.Flat;
            anyadirHorario.FlatAppearance.BorderSize = 0;
            anyadirHorario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirHorario.ForeColor = Color.White;
            anyadirHorario.Size = new Size(45, 45);


            anyadirHorario.Left = panelVisualHorarios.Width - 60;

            textBoxHorarioBuscar.Left = 50;
            textBoxHorarioBuscar.Width = panelVisualHorarios.Width - 350;

            comboBoxHorario.Width = 180; 
            comboBoxHorario.Left = textBoxHorarioBuscar.Right + 30;

            textBoxHorarioBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirHorario.Anchor = AnchorStyles.Right;

            ActualizarRegiones();
        }
        private void ActualizarRegiones()
        {
            anyadirHorario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, anyadirHorario.Width, anyadirHorario.Height, anyadirHorario.Width, anyadirHorario.Height));
        }
        private void PanelHorario_Resize(object sender, EventArgs e)
        {
            ActualizarRegiones();
            panelVisualHorarios.Invalidate();
        }

        private void panelVisualHorarios_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen penBorde = new Pen(Color.FromArgb(220, 220, 220), 1);
            Brush fondoBlanco = Brushes.White;

            Rectangle rectBusqueda = new Rectangle(
                textBoxHorarioBuscar.Left - 35,
                textBoxHorarioBuscar.Top - 15,
                textBoxHorarioBuscar.Width + 45,
                textBoxHorarioBuscar.Height + 27
            );
            DibujarCapsula(g, rectBusqueda, penBorde, fondoBlanco);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 10), Brushes.Gray, textBoxHorarioBuscar.Left - 25, textBoxHorarioBuscar.Top - 2);

            Rectangle rectFiltro = new Rectangle(
                comboBoxHorario.Left - 10,
                comboBoxHorario.Top - 10,
                comboBoxHorario.Width + 25,
                comboBoxHorario.Height + 20
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












        private void ModificarHorario(HorarioSemanalDto horario)
        {

            Horario pantallaModificar = new Horario(horario, _token);
            /*pantallaModificar.Form = "Modificar información";
            pantallaModificar.LabelTituoCrearServicio = "MODIFICAR HORARIO";
            pantallaModificar.buttonSerModificar = true;
            pantallaModificar.buttonSerAnyadir = false;

            pantallaModificar.TboxNombreServicio.Text = servicio.Nombre;
            pantallaModificar.TxtBoxDescripcion.Text = servicio.Descripcion;
            pantallaModificar.TextBoxPrecio.Text = servicio.Precio.ToString();
            pantallaModificar.TextBoxDuracion.Text = servicio.Duracion.ToString();
            pantallaModificar.ComboTipoServicio.SelectedIndex = Convert.ToInt32(servicio.TipoServicio?.Id - 1);
            */
            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                RecargarHorario();
                pasarPagina();
            }
        }
        private void EliminarHorario(HorarioSemanalDto horario)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio ?",
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

                        var url = $"http://localhost:8082/horarios/{horario.Id}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Horario eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RecargarHorario();
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
        private void pasarPagina()
        {
            dataGridViewHorarios.Rows.Clear();


            int registrosASaltar = (contador - 1) * 15;
            var horarioPagina = _horarios.Skip(registrosASaltar).Take(15).ToList();

            foreach (var h in horarioPagina)
            {
                string inicio = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string fin = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);

                int index = dataGridViewHorarios.Rows.Add(
                    h.DiaSemana,
                    inicio,
                    fin,
                    h.Grupo?.Curso ?? "Sin Grupo",
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Plazas
                );
                dataGridViewHorarios.Rows[index].Tag = h;
            }
        }
        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 5) return;
            if (e.RowIndex >= dataGridViewHorarios.Rows.Count) return;
            var fila = dataGridViewHorarios.Rows[e.RowIndex];
            var horario = fila.Tag as HorarioSemanalDto;
            if (horario == null) return;

            var columna = dataGridViewHorarios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnUsModificar")
            {
                ModificarHorario(horario);
            }
            else if (columna == "dataGridViewImageColumnUsEliminar")
            {
                EliminarHorario(horario);
            }
        }



        // --- LÓGICA ---
        private void anyadirHorario_Click(object sender, EventArgs e)
        {
            Horario pantallaAnyadir = new Horario(_token);
            /*pantallaAnyadir.Form = "Añadir horario nuevo";
            pantallaAnyadir.LabelTituoCrearServicio = "AÑADIR HORARIO";
            pantallaAnyadir.buttonSerModificar = false;
            pantallaAnyadir.buttonSerAnyadir = true;

            pantallaAnyadir.TboxNombreServicio.Text = "";
            pantallaAnyadir.TxtBoxDescripcion.Text = "";
            pantallaAnyadir.TextBoxPrecio.Text = "";
            pantallaAnyadir.TextBoxDuracion.Text = "";
            pantallaAnyadir.ComboTipoServicio.SelectedItem = "";*/

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarHorario();
                pasarPagina();
            }
        }
        private List<HorarioSemanalDto> ObtenerHorarios()
        {

            var url = "http://localhost:8082/horarios";
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
                var horarios = JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(json);
                return horarios;
            }
        }
        private void RecargarHorario()
        {
            _horarios = ObtenerHorarios();

            if (_horarios.Count % 15 != 0)
            {
                pagHo = (_horarios.Count / 15) + 1;
            }
            else
            {
                pagHo = (_horarios.Count / 15);
            }

            labelNumHorarios.Text = $" {_horarios.Count}";
        }
       

        private void filtrarHorario()
        {
            string texto = textBoxHorarioBuscar.Text.Trim().ToLower();
            UsersDto? desplegable = (UsersDto)comboBoxHorario.SelectedItem;

            if (_horarios == null) return;

            var listaFiltrada = _horarios.AsEnumerable();

            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(h =>
                    h.Servicio?.Nombre?.ToLower().Contains(texto) == true ||
                    h.Grupo?.Curso?.ToLower().Contains(texto) == true
                );
            }

            if (desplegable != null && desplegable.Id != 0)
            {
                listaFiltrada = listaFiltrada
                    .Where(h => h!= null &&
                               h.Grupo != null &&
                               h.Grupo.Id == desplegable.Id)
                    .ToList();
            }

            dataGridViewHorarios.Rows.Clear();

            foreach (var h in listaFiltrada)
            {
                string inicio = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string fin = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);

                int index = dataGridViewHorarios.Rows.Add(
                    h.DiaSemana,
                    inicio,
                    fin,
                    h.Grupo?.Curso ?? "Sin Grupo",
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Plazas,
                    Properties.Resources.edit,
                    Properties.Resources.trash
                );
                dataGridViewHorarios.Rows[index].Tag = h;
            }
        }

        private void textBoxSHorarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }

        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                contador--;
                pasarPagina();
                if (contador != pagHo)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            if (contador < pagHo)
            {
                contador++;
                pasarPagina();
                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
            }
            if (contador == pagHo)
            {
                buttonPaginacionDelante.ForeColor = Color.Silver;
            }
        }

    }
}