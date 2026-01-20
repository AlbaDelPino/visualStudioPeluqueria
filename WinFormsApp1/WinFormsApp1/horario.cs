using CitasInfo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Globalization; // Necesario para CultureInfo

namespace WinFormsApp1
{
    public partial class horario : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly string _token;
        private int pagHo;
        private int contador = 1;
        private List<HorarioSemanalDto> _Horario = new List<HorarioSemanalDto>();

        public horario(string token)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            _token = token;
            buttonHorario.Click += new EventHandler(buttonHorario_Click);
        }

        private void horario_Load(object sender, EventArgs e)
        {
            dataGridViewHorario.ReadOnly = true;
            dataGridViewHorario.AllowUserToAddRows = false;
            dataGridViewHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHorario.DataError += (s, ev) => { ev.ThrowException = false; };

            ConfigurarUIEstiloImagen();
            RecargarHorario();

            this.BeginInvoke(new Action(() =>
            {
                ActualizarRegiones();
                panelVisualHorario.Invalidate();
            }));
        }

        // --- SOLUCIÓN AL ERROR DE FORMATO (NodaTime) ---
        private void pasarPagina()
        {
            dataGridViewHorario.Rows.Clear();
            if (_Horario == null || _Horario.Count == 0) return;

            var lista = _Horario.Skip((contador - 1) * 15).Take(15).ToList();
            foreach (var h in lista)
            {
                // ✅ CORRECCIÓN: Se añade CultureInfo.InvariantCulture como segundo argumento
                string inicio = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string fin = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);

                int idx = dataGridViewHorario.Rows.Add(
                    h.DiaSemana,
                    inicio,
                    fin,
                    h.Grupo?.Curso ?? "Sin Grupo",
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Plazas,
                    Properties.Resources.edit,
                    Properties.Resources.trash
                );
                dataGridViewHorario.Rows[idx].Tag = h;
            }
            buttonPaginacionAtras.Enabled = (contador > 1);
            buttonPaginacionDelante.Enabled = (contador < pagHo);
        }

        // --- DISEÑO VISUAL ---
        private void ConfigurarUIEstiloImagen()
        {
            panelVisualHorario.BackColor = Color.FromArgb(242, 242, 242);
            textBoxSHorarioBuscar.BorderStyle = BorderStyle.None;
            comboBoxHorario.FlatStyle = FlatStyle.Flat;
            buttonHorario.BackColor = Color.FromArgb(255, 128, 0);
            buttonHorario.Size = new Size(42, 42);
        }

        private void panelVisualHorario_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.FromArgb(225, 225, 225), 1);

            // Cápsula Buscador
            Rectangle rBus = new Rectangle(textBoxSHorarioBuscar.Left - 45, textBoxSHorarioBuscar.Top - 12, textBoxSHorarioBuscar.Width + 55, textBoxSHorarioBuscar.Height + 24);
            DibujarCapsula(g, rBus, p, Brushes.White);
            g.DrawString("🔍", new Font("Segoe UI Symbol", 9), Brushes.Gray, textBoxSHorarioBuscar.Left - 32, textBoxSHorarioBuscar.Top - 1);

            // Cápsula Combo
            Rectangle rCom = new Rectangle(comboBoxHorario.Left - 15, comboBoxHorario.Top - 12, comboBoxHorario.Width + 30, comboBoxHorario.Height + 24);
            DibujarCapsula(g, rCom, p, Brushes.White);
        }

        private void DibujarCapsula(Graphics g, Rectangle r, Pen p, Brush b)
        {
            GraphicsPath path = new GraphicsPath();
            int rad = r.Height - 1;
            path.AddArc(r.X, r.Y, rad, rad, 90, 180);
            path.AddArc(r.Right - rad, r.Y, rad, rad, 270, 180);
            path.CloseFigure();
            g.FillPath(b, path);
            g.DrawPath(p, path);
        }

        private void ActualizarRegiones()
        {
            if (buttonHorario.Width > 0)
                buttonHorario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonHorario.Width, buttonHorario.Height, buttonHorario.Width, buttonHorario.Height));
        }

        // --- LÓGICA ---
        private void RecargarHorario()
        {
            _Horario = ObtenerHorarioDesdeAPI() ?? new List<HorarioSemanalDto>();
            pagHo = (int)Math.Ceiling((double)_Horario.Count / 15);
            if (pagHo == 0) pagHo = 1;
            pasarPagina();
        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            using (var f = new horario_semanal(_token))
                if (f.ShowDialog() == DialogResult.OK) RecargarHorario();
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var h = dataGridViewHorario.Rows[e.RowIndex].Tag as HorarioSemanalDto;
            if (h == null) return;

            if (e.ColumnIndex == 6)
            { // Editar
                using (var f = new horario_semanal(_token, h))
                    if (f.ShowDialog() == DialogResult.OK) RecargarHorario();
            }
            else if (e.ColumnIndex == 7)
            { // Eliminar
                if (MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) EliminarHorario(h.Id);
            }
        }

        private List<HorarioSemanalDto> ObtenerHorarioDesdeAPI()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create("http://localhost:8082/horarios");
                req.Headers["Authorization"] = $"Bearer {_token}";
                using (var res = (HttpWebResponse)req.GetResponse())
                using (var r = new StreamReader(res.GetResponseStream()))
                    return JsonConvert.DeserializeObject<List<HorarioSemanalDto>>(r.ReadToEnd());
            }
            catch { return null; }
        }

        private void EliminarHorario(long id)
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create($"http://localhost:8082/horarios/{id}");
                req.Method = "DELETE";
                req.Headers["Authorization"] = $"Bearer {_token}";
                req.GetResponse().Dispose();
                RecargarHorario();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void PanelHorario_Resize(object sender, EventArgs e) { ActualizarRegiones(); panelVisualHorario.Invalidate(); }
        private void buttonPaginacionAtras_Click(object sender, EventArgs e) { if (contador > 1) { contador--; pasarPagina(); } }
        private void buttonPaginacionDelante_Click(object sender, EventArgs e) { if (contador < pagHo) { contador++; pasarPagina(); } }


        // --- LÓGICA DE FILTRADO ---

        private void filtrarHorario()
        {
            // 1. Obtener los valores de los filtros
            string filtroTexto = textBoxSHorarioBuscar.Text.Trim().ToLower();
            string filtroDia = comboBoxHorario.SelectedItem?.ToString();

            if (_Horario == null) return;

            // 2. Aplicar filtros usando LINQ
            var listaFiltrada = _Horario.AsEnumerable();

            // Filtrar por texto (Servicio o Curso)
            if (!string.IsNullOrEmpty(filtroTexto))
            {
                listaFiltrada = listaFiltrada.Where(h =>
                    (h.Servicio?.Nombre?.ToLower().Contains(filtroTexto) ?? false) ||
                    (h.Grupo?.Curso?.ToLower().Contains(filtroTexto) ?? false)
                );
            }

            // Filtrar por día de la semana (ComboBox)
            // Asumimos que el combo tiene opciones como "Lunes", "Martes", etc. 
            // Si tiene una opción "Todos", la ignoramos.
            if (!string.IsNullOrEmpty(filtroDia) && filtroDia != "Todos")
            {
                listaFiltrada = listaFiltrada.Where(h => h.DiaSemana.Equals(filtroDia, StringComparison.OrdinalIgnoreCase));
            }

            // 3. Actualizar el DataGridView
            dataGridViewHorario.Rows.Clear();

            foreach (var h in listaFiltrada)
            {
                string inicio = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string fin = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);

                int idx = dataGridViewHorario.Rows.Add(
                    h.DiaSemana,
                    inicio,
                    fin,
                    h.Grupo?.Curso ?? "Sin Grupo",
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Plazas,
                    Properties.Resources.edit,
                    Properties.Resources.trash
                );
                dataGridViewHorario.Rows[idx].Tag = h;
            }
        }

        // --- EVENTOS CONECTADOS ---

        // Asegúrate de que este evento esté vinculado en el Designer o en el Constructor
        private void textBoxSHorarioBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }

        // Asegúrate de que este evento esté vinculado en el Designer o en el Constructor
        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarHorario();
        }
    }
    }