namespace WinFormsApp1
{
    partial class PanelCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            panelVisualCitas = new Panel();
            textBoxCitBuscar = new TextBox();
            panelProximas = new Panel();
            labelNumProximas = new Label();
            labelProximas = new Label();
            pictureProximas = new PictureBox();
            panelHoy = new Panel();
            labelNumHoy = new Label();
            labelHoy = new Label();
            pictureHoy = new PictureBox();
            panelMargenes = new Panel();
            panelFiltros = new Panel();
            panelBotones = new Panel();
            anyadirCitas = new Button();
            buttonCompletar = new Button();
            buttonCancelar = new Button();
            comboBoxEstado = new ComboBox();
            monthCalendarFiltrar = new WinFormsApp1.PanelPrincipal.MyMonthCalendar();
            buttonTodos = new Button();
            comboBoxGrupos = new ComboBox();
            dataGridViewCitas = new DataGridView();
            dataGridViewTextBoxColumnCliente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnServicio = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnFecha = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnHora = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumnEstado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnGrupo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumnValoración = new DataGridViewTextBoxColumn();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelEspaciado = new Panel();
            buttonProximas = new Button();
            panelVisualCitas.SuspendLayout();
            panelProximas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProximas).BeginInit();
            panelHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHoy).BeginInit();
            panelMargenes.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualCitas
            // 
            panelVisualCitas.Controls.Add(textBoxCitBuscar);
            panelVisualCitas.Dock = DockStyle.Top;
            panelVisualCitas.Location = new Point(0, 0);
            panelVisualCitas.Margin = new Padding(5, 4, 5, 4);
            panelVisualCitas.Name = "panelVisualCitas";
            panelVisualCitas.Padding = new Padding(17, 0, 0, 0);
            panelVisualCitas.Size = new Size(1571, 100);
            panelVisualCitas.TabIndex = 6;
            panelVisualCitas.Paint += panelVisualCitas_Paint;
            // 
            // textBoxCitBuscar
            // 
            textBoxCitBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCitBuscar.BorderStyle = BorderStyle.None;
            textBoxCitBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxCitBuscar.Location = new Point(441, 49);
            textBoxCitBuscar.Margin = new Padding(6, 5, 6, 5);
            textBoxCitBuscar.Name = "textBoxCitBuscar";
            textBoxCitBuscar.PlaceholderText = "Buscar por cliente o servicio...";
            textBoxCitBuscar.Size = new Size(947, 20);
            textBoxCitBuscar.TabIndex = 16;
            textBoxCitBuscar.TextChanged += textBoxCitBuscar_TextChanged;
            // 
            // panelProximas
            // 
            panelProximas.BackColor = SystemColors.Control;
            panelProximas.BorderStyle = BorderStyle.FixedSingle;
            panelProximas.Controls.Add(labelNumProximas);
            panelProximas.Controls.Add(labelProximas);
            panelProximas.Controls.Add(pictureProximas);
            panelProximas.ForeColor = SystemColors.ControlDarkDark;
            panelProximas.Location = new Point(101, 660);
            panelProximas.Margin = new Padding(5, 4, 5, 4);
            panelProximas.Name = "panelProximas";
            panelProximas.Size = new Size(179, 110);
            panelProximas.TabIndex = 9;
            // 
            // labelNumProximas
            // 
            labelNumProximas.AutoSize = true;
            labelNumProximas.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumProximas.ForeColor = SystemColors.ControlText;
            labelNumProximas.Location = new Point(74, 56);
            labelNumProximas.Margin = new Padding(5, 0, 5, 0);
            labelNumProximas.Name = "labelNumProximas";
            labelNumProximas.Size = new Size(27, 29);
            labelNumProximas.TabIndex = 2;
            labelNumProximas.Text = "5";
            // 
            // labelProximas
            // 
            labelProximas.AutoSize = true;
            labelProximas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProximas.Location = new Point(18, 24);
            labelProximas.Margin = new Padding(5, 0, 5, 0);
            labelProximas.Name = "labelProximas";
            labelProximas.Size = new Size(123, 20);
            labelProximas.TabIndex = 0;
            labelProximas.Text = "Próximas Citas";
            // 
            // pictureProximas
            // 
            pictureProximas.Image = Properties.Resources.cita_previa;
            pictureProximas.Location = new Point(30, 52);
            pictureProximas.Margin = new Padding(5, 4, 5, 4);
            pictureProximas.Name = "pictureProximas";
            pictureProximas.Size = new Size(35, 39);
            pictureProximas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProximas.TabIndex = 1;
            pictureProximas.TabStop = false;
            // 
            // panelHoy
            // 
            panelHoy.BackColor = SystemColors.Control;
            panelHoy.BorderStyle = BorderStyle.FixedSingle;
            panelHoy.Controls.Add(labelNumHoy);
            panelHoy.Controls.Add(labelHoy);
            panelHoy.Controls.Add(pictureHoy);
            panelHoy.ForeColor = SystemColors.ControlDarkDark;
            panelHoy.Location = new Point(101, 540);
            panelHoy.Margin = new Padding(5, 4, 5, 4);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(180, 110);
            panelHoy.TabIndex = 8;
            // 
            // labelNumHoy
            // 
            labelNumHoy.AutoSize = true;
            labelNumHoy.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumHoy.ForeColor = SystemColors.ControlText;
            labelNumHoy.Location = new Point(66, 56);
            labelNumHoy.Margin = new Padding(5, 0, 5, 0);
            labelNumHoy.Name = "labelNumHoy";
            labelNumHoy.Size = new Size(27, 29);
            labelNumHoy.TabIndex = 2;
            labelNumHoy.Text = "2";
            // 
            // labelHoy
            // 
            labelHoy.AutoSize = true;
            labelHoy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoy.Location = new Point(18, 24);
            labelHoy.Margin = new Padding(5, 0, 5, 0);
            labelHoy.Name = "labelHoy";
            labelHoy.Size = new Size(106, 20);
            labelHoy.TabIndex = 0;
            labelHoy.Text = "Citas de Hoy";
            // 
            // pictureHoy
            // 
            pictureHoy.Image = Properties.Resources.citas1;
            pictureHoy.Location = new Point(23, 44);
            pictureHoy.Margin = new Padding(5, 4, 5, 4);
            pictureHoy.Name = "pictureHoy";
            pictureHoy.Size = new Size(43, 51);
            pictureHoy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHoy.TabIndex = 1;
            pictureHoy.TabStop = false;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(panelFiltros);
            panelMargenes.Controls.Add(dataGridViewCitas);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 100);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1571, 801);
            panelMargenes.TabIndex = 16;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(buttonProximas);
            panelFiltros.Controls.Add(panelBotones);
            panelFiltros.Controls.Add(comboBoxEstado);
            panelFiltros.Controls.Add(monthCalendarFiltrar);
            panelFiltros.Controls.Add(buttonTodos);
            panelFiltros.Controls.Add(panelProximas);
            panelFiltros.Controls.Add(comboBoxGrupos);
            panelFiltros.Controls.Add(panelHoy);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(31, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(411, 801);
            panelFiltros.TabIndex = 21;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(anyadirCitas);
            panelBotones.Controls.Add(buttonCompletar);
            panelBotones.Controls.Add(buttonCancelar);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(352, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(5, 4, 5, 4);
            panelBotones.Size = new Size(59, 801);
            panelBotones.TabIndex = 23;
            // 
            // anyadirCitas
            // 
            anyadirCitas.BackColor = Color.FromArgb(255, 128, 0);
            anyadirCitas.Dock = DockStyle.Top;
            anyadirCitas.FlatAppearance.BorderSize = 0;
            anyadirCitas.FlatStyle = FlatStyle.Flat;
            anyadirCitas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyadirCitas.ForeColor = Color.White;
            anyadirCitas.Location = new Point(5, 114);
            anyadirCitas.Margin = new Padding(0, 5, 0, 0);
            anyadirCitas.Name = "anyadirCitas";
            anyadirCitas.Size = new Size(49, 55);
            anyadirCitas.TabIndex = 21;
            anyadirCitas.Text = "+";
            anyadirCitas.TextAlign = ContentAlignment.TopRight;
            anyadirCitas.UseVisualStyleBackColor = false;
            anyadirCitas.Click += anyadirCitas_Click;
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackgroundImage = Properties.Resources.completada1;
            buttonCompletar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCompletar.Dock = DockStyle.Top;
            buttonCompletar.Location = new Point(5, 59);
            buttonCompletar.Margin = new Padding(0);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Padding = new Padding(0, 8, 0, 0);
            buttonCompletar.Size = new Size(49, 55);
            buttonCompletar.TabIndex = 21;
            buttonCompletar.UseVisualStyleBackColor = true;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackgroundImage = Properties.Resources.x_icon41;
            buttonCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCancelar.Dock = DockStyle.Top;
            buttonCancelar.Location = new Point(5, 4);
            buttonCancelar.Margin = new Padding(0);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Padding = new Padding(0, 0, 0, 8);
            buttonCancelar.Size = new Size(49, 55);
            buttonCancelar.TabIndex = 20;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DisplayMember = "1";
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FlatStyle = FlatStyle.Flat;
            comboBoxEstado.Items.AddRange(new object[] { "Todos los estados", "Confirmada", "Completada", "Cancelada" });
            comboBoxEstado.Location = new Point(40, 490);
            comboBoxEstado.Margin = new Padding(6, 5, 6, 5);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(282, 28);
            comboBoxEstado.TabIndex = 21;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendarFiltrar.Location = new Point(40, 9);
            monthCalendarFiltrar.MaxSelectionCount = 31;
            monthCalendarFiltrar.Name = "monthCalendarFiltrar";
            monthCalendarFiltrar.RightToLeft = RightToLeft.Yes;
            monthCalendarFiltrar.ShowToday = false;
            monthCalendarFiltrar.TabIndex = 19;
            monthCalendarFiltrar.TitleBackColor = Color.DarkOrange;
            monthCalendarFiltrar.TrailingForeColor = SystemColors.ButtonShadow;
            monthCalendarFiltrar.DateSelected += monthCalendarFiltrar_DateSelected;
            // 
            // buttonTodos
            // 
            buttonTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(40, 540);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(282, 32);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todas las citas";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.DisplayMember = "1";
            comboBoxGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupos.FlatStyle = FlatStyle.Flat;
            comboBoxGrupos.Location = new Point(40, 440);
            comboBoxGrupos.Margin = new Padding(6, 5, 6, 5);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(282, 28);
            comboBoxGrupos.TabIndex = 20;
            comboBoxGrupos.SelectedIndexChanged += comboBoxGrupos_SelectedIndexChanged;
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.AllowUserToOrderColumns = true;
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitas.BackgroundColor = Color.White;
            dataGridViewCitas.BorderStyle = BorderStyle.None;
            dataGridViewCitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle41.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle41.Padding = new Padding(7);
            dataGridViewCellStyle41.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnCliente, dataGridViewTextBoxColumnServicio, dataGridViewTextBoxColumnFecha, dataGridViewTextBoxColumnHora, DataGridViewTextBoxColumnEstado, dataGridViewTextBoxColumnGrupo, DataGridViewTextBoxColumnValoración });
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = SystemColors.Window;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle46.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle46.Padding = new Padding(2);
            dataGridViewCellStyle46.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle46.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle46.WrapMode = DataGridViewTriState.False;
            dataGridViewCitas.DefaultCellStyle = dataGridViewCellStyle46;
            dataGridViewCitas.Dock = DockStyle.Right;
            dataGridViewCitas.EnableHeadersVisualStyles = false;
            dataGridViewCitas.GridColor = Color.Black;
            dataGridViewCitas.ImeMode = ImeMode.NoControl;
            dataGridViewCitas.Location = new Point(442, 0);
            dataGridViewCitas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCitas.MultiSelect = false;
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle47.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle47.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle47.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            dataGridViewCitas.RowHeadersVisible = false;
            dataGridViewCitas.RowHeadersWidth = 51;
            dataGridViewCellStyle48.BackColor = Color.White;
            dataGridViewCellStyle48.SelectionForeColor = Color.White;
            dataGridViewCitas.RowsDefaultCellStyle = dataGridViewCellStyle48;
            dataGridViewCitas.RowTemplate.Height = 35;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCitas.Size = new Size(1099, 801);
            dataGridViewCitas.TabIndex = 16;
            dataGridViewCitas.CellClick += dataGridViewCitas_CellClick;
            dataGridViewCitas.CellContentClick += dataGridViewCitas_CellClick;
            // 
            // dataGridViewTextBoxColumnCliente
            // 
            dataGridViewTextBoxColumnCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle42.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnCliente.DefaultCellStyle = dataGridViewCellStyle42;
            dataGridViewTextBoxColumnCliente.FillWeight = 50F;
            dataGridViewTextBoxColumnCliente.HeaderText = "Cliente";
            dataGridViewTextBoxColumnCliente.MinimumWidth = 6;
            dataGridViewTextBoxColumnCliente.Name = "dataGridViewTextBoxColumnCliente";
            dataGridViewTextBoxColumnCliente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnServicio
            // 
            dataGridViewTextBoxColumnServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle43.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle43.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnServicio.DefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewTextBoxColumnServicio.HeaderText = "Servicio";
            dataGridViewTextBoxColumnServicio.MinimumWidth = 6;
            dataGridViewTextBoxColumnServicio.Name = "dataGridViewTextBoxColumnServicio";
            dataGridViewTextBoxColumnServicio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnFecha
            // 
            dataGridViewTextBoxColumnFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle44.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnFecha.DefaultCellStyle = dataGridViewCellStyle44;
            dataGridViewTextBoxColumnFecha.HeaderText = "Fecha";
            dataGridViewTextBoxColumnFecha.MinimumWidth = 6;
            dataGridViewTextBoxColumnFecha.Name = "dataGridViewTextBoxColumnFecha";
            dataGridViewTextBoxColumnFecha.ReadOnly = true;
            dataGridViewTextBoxColumnFecha.Width = 103;
            // 
            // dataGridViewTextBoxColumnHora
            // 
            dataGridViewTextBoxColumnHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle45.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnHora.DefaultCellStyle = dataGridViewCellStyle45;
            dataGridViewTextBoxColumnHora.HeaderText = "Hora";
            dataGridViewTextBoxColumnHora.MinimumWidth = 6;
            dataGridViewTextBoxColumnHora.Name = "dataGridViewTextBoxColumnHora";
            dataGridViewTextBoxColumnHora.ReadOnly = true;
            dataGridViewTextBoxColumnHora.Width = 95;
            // 
            // DataGridViewTextBoxColumnEstado
            // 
            DataGridViewTextBoxColumnEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewTextBoxColumnEstado.HeaderText = "Estado";
            DataGridViewTextBoxColumnEstado.MinimumWidth = 6;
            DataGridViewTextBoxColumnEstado.Name = "DataGridViewTextBoxColumnEstado";
            DataGridViewTextBoxColumnEstado.ReadOnly = true;
            DataGridViewTextBoxColumnEstado.Resizable = DataGridViewTriState.True;
            DataGridViewTextBoxColumnEstado.Width = 110;
            // 
            // dataGridViewTextBoxColumnGrupo
            // 
            dataGridViewTextBoxColumnGrupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnGrupo.HeaderText = "Grupo";
            dataGridViewTextBoxColumnGrupo.MinimumWidth = 6;
            dataGridViewTextBoxColumnGrupo.Name = "dataGridViewTextBoxColumnGrupo";
            dataGridViewTextBoxColumnGrupo.ReadOnly = true;
            dataGridViewTextBoxColumnGrupo.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumnGrupo.Width = 107;
            // 
            // DataGridViewTextBoxColumnValoración
            // 
            DataGridViewTextBoxColumnValoración.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewTextBoxColumnValoración.HeaderText = "Valoración";
            DataGridViewTextBoxColumnValoración.MinimumWidth = 6;
            DataGridViewTextBoxColumnValoración.Name = "DataGridViewTextBoxColumnValoración";
            DataGridViewTextBoxColumnValoración.ReadOnly = true;
            DataGridViewTextBoxColumnValoración.Width = 144;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(labelPaginaActual);
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 901);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 43);
            panelPaginacion.TabIndex = 18;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(213, 11);
            labelPaginaActual.Name = "labelPaginaActual";
            labelPaginaActual.Size = new Size(17, 20);
            labelPaginaActual.TabIndex = 4;
            labelPaginaActual.Text = "1";
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(120, 0);
            buttonPaginacionDelante.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(86, 43);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            buttonPaginacionDelante.Click += buttonPaginacionDelante_Click;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(34, 0);
            buttonPaginacionAtras.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            buttonPaginacionAtras.Size = new Size(86, 43);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            buttonPaginacionAtras.Click += buttonPaginacionAtras_Click;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 944);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 80);
            panelEspaciado.TabIndex = 17;
            // 
            // buttonProximas
            // 
            buttonProximas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProximas.Location = new Point(40, 390);
            buttonProximas.Name = "buttonProximas";
            buttonProximas.Size = new Size(282, 32);
            buttonProximas.TabIndex = 24;
            buttonProximas.Text = "Ver solo las póximas citas";
            buttonProximas.UseVisualStyleBackColor = true;
            buttonProximas.Click += buttonProximas_Click;
            // 
            // PanelCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualCitas);
            Name = "PanelCita";
            Text = "PanelCita";
            Load += PanelCita_Load;
            panelVisualCitas.ResumeLayout(false);
            panelVisualCitas.PerformLayout();
            panelProximas.ResumeLayout(false);
            panelProximas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProximas).EndInit();
            panelHoy.ResumeLayout(false);
            panelHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHoy).EndInit();
            panelMargenes.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelVisualCitas;
        private Panel panelMargenes;
        private Panel panelProximas;
        private Label labelNumProximas;
        private Label labelProximas;
        private PictureBox pictureProximas;
        private Panel panelHoy;
        private Label labelNumHoy;
        private Label labelHoy;
        private PictureBox pictureHoy;
        private ComboBox comboBoxCitFiltrar;
        private TextBox textBoxCitBuscar;
        private DataGridView dataGridViewCitas;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelEspaciado;
        private Panel panelFiltros;
        private ComboBox comboBoxEstado;
        private PanelPrincipal.MyMonthCalendar monthCalendarFiltrar;
        private Button buttonTodos;
        private ComboBox comboBoxGrupos;
        private Panel panelBotones;
        private Button anyadirCitas;
        private Button buttonCompletar;
        private Button buttonCancelar;
        private Label labelPaginaActual;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnServicio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnFecha;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHora;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumnEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnGrupo;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumnValoración;
        private Button buttonProximas;
    }
}
