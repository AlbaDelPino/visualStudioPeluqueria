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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panelVisualCitas = new Panel();
            anyadirCita = new Button();
            comboBoxCitFiltrar = new ComboBox();
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
            dataGridViewCitas = new DataGridView();
            dataGridViewTextBoxColumnCliente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnServicio = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnFecha = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnHora = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumnEstado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnGrupo = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnCitCompletar = new DataGridViewImageColumn();
            dataGridViewImageColumnCitCancelar = new DataGridViewImageColumn();
            panelPaginacion = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelEspaciado = new Panel();
            panelVisualCitas.SuspendLayout();
            panelProximas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProximas).BeginInit();
            panelHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHoy).BeginInit();
            panelMargenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualCitas
            // 
            panelVisualCitas.Controls.Add(anyadirCita);
            panelVisualCitas.Controls.Add(comboBoxCitFiltrar);
            panelVisualCitas.Controls.Add(textBoxCitBuscar);
            panelVisualCitas.Controls.Add(panelProximas);
            panelVisualCitas.Controls.Add(panelHoy);
            panelVisualCitas.Dock = DockStyle.Top;
            panelVisualCitas.Location = new Point(0, 0);
            panelVisualCitas.Margin = new Padding(4, 3, 4, 3);
            panelVisualCitas.Name = "panelVisualCitas";
            panelVisualCitas.Size = new Size(1571, 256);
            panelVisualCitas.TabIndex = 6;
            panelVisualCitas.Paint += panelVisualCitas_Paint;
            // 
            // anyadirCita
            // 
            anyadirCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirCita.BackColor = Color.FromArgb(255, 128, 0);
            anyadirCita.FlatAppearance.BorderSize = 0;
            anyadirCita.FlatStyle = FlatStyle.Flat;
            anyadirCita.ForeColor = Color.White;
            anyadirCita.Location = new Point(1451, 175);
            anyadirCita.Margin = new Padding(3, 4, 3, 4);
            anyadirCita.Name = "anyadirCita";
            anyadirCita.Size = new Size(86, 31);
            anyadirCita.TabIndex = 18;
            anyadirCita.Text = "+";
            anyadirCita.UseVisualStyleBackColor = false;
            anyadirCita.Click += anyadirCita_Click;
            // 
            // comboBoxCitFiltrar
            // 
            comboBoxCitFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCitFiltrar.DisplayMember = "1";
            comboBoxCitFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCitFiltrar.FlatStyle = FlatStyle.Flat;
            comboBoxCitFiltrar.Items.AddRange(new object[] { "", "Activos", "Inactivos", "Administradores", "Clientes", "Grupos" });
            comboBoxCitFiltrar.Location = new Point(1234, 187);
            comboBoxCitFiltrar.Margin = new Padding(5, 4, 5, 4);
            comboBoxCitFiltrar.Name = "comboBoxCitFiltrar";
            comboBoxCitFiltrar.Size = new Size(153, 28);
            comboBoxCitFiltrar.TabIndex = 17;
            comboBoxCitFiltrar.SelectedIndexChanged += comboBoxCitFiltrar_SelectedIndexChanged;
            // 
            // textBoxCitBuscar
            // 
            textBoxCitBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCitBuscar.BorderStyle = BorderStyle.None;
            textBoxCitBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxCitBuscar.Location = new Point(34, 192);
            textBoxCitBuscar.Margin = new Padding(5, 4, 5, 4);
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
            panelProximas.Location = new Point(205, 18);
            panelProximas.Margin = new Padding(5, 4, 5, 4);
            panelProximas.Name = "panelProximas";
            panelProximas.Size = new Size(179, 113);
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
            panelHoy.Location = new Point(34, 18);
            panelHoy.Margin = new Padding(5, 4, 5, 4);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(162, 113);
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
            panelMargenes.Controls.Add(dataGridViewCitas);
            panelMargenes.Controls.Add(panelPaginacion);
            panelMargenes.Controls.Add(panelEspaciado);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1571, 768);
            panelMargenes.TabIndex = 16;
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.AllowUserToOrderColumns = true;
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitas.BackgroundColor = Color.White;
            dataGridViewCitas.BorderStyle = BorderStyle.None;
            dataGridViewCitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnCliente, dataGridViewTextBoxColumnServicio, dataGridViewTextBoxColumnFecha, dataGridViewTextBoxColumnHora, DataGridViewTextBoxColumnEstado, dataGridViewTextBoxColumnGrupo, dataGridViewImageColumnCitCompletar, dataGridViewImageColumnCitCancelar });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewCitas.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCitas.Dock = DockStyle.Fill;
            dataGridViewCitas.EnableHeadersVisualStyles = false;
            dataGridViewCitas.GridColor = Color.Black;
            dataGridViewCitas.ImeMode = ImeMode.NoControl;
            dataGridViewCitas.Location = new Point(30, 0);
            dataGridViewCitas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCitas.MultiSelect = false;
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCitas.RowHeadersVisible = false;
            dataGridViewCitas.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCitas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCitas.RowTemplate.Height = 35;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCitas.Size = new Size(1511, 657);
            dataGridViewCitas.TabIndex = 16;
            dataGridViewCitas.CellContentClick += dataGridViewCitas_CellContentClick;
            // 
            // dataGridViewTextBoxColumnCliente
            // 
            dataGridViewTextBoxColumnCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumnCliente.HeaderText = "Cliente";
            dataGridViewTextBoxColumnCliente.MinimumWidth = 6;
            dataGridViewTextBoxColumnCliente.Name = "dataGridViewTextBoxColumnCliente";
            dataGridViewTextBoxColumnCliente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnServicio
            // 
            dataGridViewTextBoxColumnServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnServicio.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumnServicio.HeaderText = "Servicio";
            dataGridViewTextBoxColumnServicio.MinimumWidth = 6;
            dataGridViewTextBoxColumnServicio.Name = "dataGridViewTextBoxColumnServicio";
            dataGridViewTextBoxColumnServicio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnFecha
            // 
            dataGridViewTextBoxColumnFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnFecha.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumnFecha.HeaderText = "Fecha";
            dataGridViewTextBoxColumnFecha.MinimumWidth = 6;
            dataGridViewTextBoxColumnFecha.Name = "dataGridViewTextBoxColumnFecha";
            dataGridViewTextBoxColumnFecha.ReadOnly = true;
            dataGridViewTextBoxColumnFecha.Width = 103;
            // 
            // dataGridViewTextBoxColumnHora
            // 
            dataGridViewTextBoxColumnHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumnHora.DefaultCellStyle = dataGridViewCellStyle5;
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
            DataGridViewTextBoxColumnEstado.Resizable = DataGridViewTriState.True;
            DataGridViewTextBoxColumnEstado.Width = 110;
            // 
            // dataGridViewTextBoxColumnGrupo
            // 
            dataGridViewTextBoxColumnGrupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnGrupo.HeaderText = "Grupo";
            dataGridViewTextBoxColumnGrupo.MinimumWidth = 6;
            dataGridViewTextBoxColumnGrupo.Name = "dataGridViewTextBoxColumnGrupo";
            dataGridViewTextBoxColumnGrupo.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewImageColumnCitCompletar
            // 
            dataGridViewImageColumnCitCompletar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewImageColumnCitCompletar.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewImageColumnCitCompletar.HeaderText = "Completar";
            dataGridViewImageColumnCitCompletar.Image = Properties.Resources.completada;
            dataGridViewImageColumnCitCompletar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnCitCompletar.MinimumWidth = 22;
            dataGridViewImageColumnCitCompletar.Name = "dataGridViewImageColumnCitCompletar";
            dataGridViewImageColumnCitCompletar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnCitCompletar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnCitCompletar.Width = 142;
            // 
            // dataGridViewImageColumnCitCancelar
            // 
            dataGridViewImageColumnCitCancelar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewImageColumnCitCancelar.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewImageColumnCitCancelar.HeaderText = "Cancelar";
            dataGridViewImageColumnCitCancelar.Image = Properties.Resources.x_icon4;
            dataGridViewImageColumnCitCancelar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnCitCancelar.MinimumWidth = 6;
            dataGridViewImageColumnCitCancelar.Name = "dataGridViewImageColumnCitCancelar";
            dataGridViewImageColumnCitCancelar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnCitCancelar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnCitCancelar.Width = 128;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(30, 657);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1511, 43);
            panelPaginacion.TabIndex = 18;
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
            panelEspaciado.Location = new Point(30, 700);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1511, 68);
            panelEspaciado.TabIndex = 17;
            // 
            // PanelCita
            // 
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelVisualCitas);
            Name = "PanelCita";
            Text = "PanelCita";
            Load += PanelCita_Load;
            Resize += PanelCita_Resize;
            panelVisualCitas.ResumeLayout(false);
            panelVisualCitas.PerformLayout();
            panelProximas.ResumeLayout(false);
            panelProximas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProximas).EndInit();
            panelHoy.ResumeLayout(false);
            panelHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHoy).EndInit();
            panelMargenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            panelPaginacion.ResumeLayout(false);
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
        private Button anyadirCita;
        private ComboBox comboBoxCitFiltrar;
        private TextBox textBoxCitBuscar;
        private DataGridView dataGridViewCitas;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelEspaciado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnServicio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnFecha;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnHora;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumnEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnGrupo;
        private DataGridViewImageColumn dataGridViewImageColumnCitCompletar;
        private DataGridViewImageColumn dataGridViewImageColumnCitCancelar;
    }
}
