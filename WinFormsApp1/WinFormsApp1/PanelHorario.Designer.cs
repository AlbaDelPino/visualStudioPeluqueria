namespace WinFormsApp1
{
    partial class PanelHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelHorario));
            panelVisualHorarios = new Panel();
            anyadirHorario = new Button();
            comboBoxHorario = new ComboBox();
            textBoxHorarioBuscar = new TextBox();
            anyadirUsuario = new Button();
            label1 = new Label();
            panelAdmin = new Panel();
            pictureAdmin = new PictureBox();
            labelNumAdmin = new Label();
            labelAdmin = new Label();
            panelUInactivos = new Panel();
            labelNumUInactivos = new Label();
            labelUInactivos = new Label();
            pictureUInactivos = new PictureBox();
            panelUActivos = new Panel();
            labelNumUActivos = new Label();
            labelUActivos = new Label();
            pictureUActivos = new PictureBox();
            panelUsuarios = new Panel();
            labelNumUsuarios = new Label();
            labelUsuarios = new Label();
            pictureUsuarios = new PictureBox();
            dataGridViewHorarios = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnUsModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnUsEliminar = new DataGridViewImageColumn();
            panelMargenes = new Panel();
            panel1 = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panel2 = new Panel();
            panelVisualHorarios.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).BeginInit();
            panelUInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUInactivos).BeginInit();
            panelUActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUActivos).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorarios).BeginInit();
            panelMargenes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualHorarios
            // 
            panelVisualHorarios.Controls.Add(anyadirHorario);
            panelVisualHorarios.Controls.Add(comboBoxHorario);
            panelVisualHorarios.Controls.Add(textBoxHorarioBuscar);
            panelVisualHorarios.Controls.Add(anyadirUsuario);
            panelVisualHorarios.Controls.Add(label1);
            panelVisualHorarios.Controls.Add(panelAdmin);
            panelVisualHorarios.Controls.Add(panelUInactivos);
            panelVisualHorarios.Controls.Add(panelUActivos);
            panelVisualHorarios.Controls.Add(panelUsuarios);
            panelVisualHorarios.Dock = DockStyle.Top;
            panelVisualHorarios.ForeColor = Color.FromArgb(255, 128, 0);
            panelVisualHorarios.Location = new Point(0, 0);
            panelVisualHorarios.Margin = new Padding(5, 4, 5, 4);
            panelVisualHorarios.Name = "panelVisualHorarios";
            panelVisualHorarios.Padding = new Padding(17, 0, 0, 0);
            panelVisualHorarios.Size = new Size(1571, 256);
            panelVisualHorarios.TabIndex = 17;
            panelVisualHorarios.Paint += panelVisualHorarios_Paint;
            // 
            // anyadirHorario
            // 
            anyadirHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirHorario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirHorario.FlatAppearance.BorderSize = 0;
            anyadirHorario.FlatStyle = FlatStyle.Flat;
            anyadirHorario.ForeColor = Color.White;
            anyadirHorario.Location = new Point(1451, 175);
            anyadirHorario.Margin = new Padding(3, 5, 3, 5);
            anyadirHorario.Name = "anyadirHorario";
            anyadirHorario.Size = new Size(86, 31);
            anyadirHorario.TabIndex = 21;
            anyadirHorario.Text = "+";
            anyadirHorario.UseVisualStyleBackColor = false;
            anyadirHorario.Click += anyadirHorario_Click;
            // 
            // comboBoxHorario
            // 
            comboBoxHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxHorario.DisplayMember = "1";
            comboBoxHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHorario.FlatStyle = FlatStyle.Flat;
            comboBoxHorario.Location = new Point(1234, 187);
            comboBoxHorario.Margin = new Padding(6, 5, 6, 5);
            comboBoxHorario.Name = "comboBoxHorario";
            comboBoxHorario.Size = new Size(153, 28);
            comboBoxHorario.TabIndex = 20;
            comboBoxHorario.SelectedIndexChanged += comboBoxHorario_SelectedIndexChanged;
            // 
            // textBoxHorarioBuscar
            // 
            textBoxHorarioBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxHorarioBuscar.BorderStyle = BorderStyle.None;
            textBoxHorarioBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxHorarioBuscar.Location = new Point(34, 192);
            textBoxHorarioBuscar.Margin = new Padding(6, 5, 6, 5);
            textBoxHorarioBuscar.Name = "textBoxHorarioBuscar";
            textBoxHorarioBuscar.PlaceholderText = "Buscar por cliente o servicio...";
            textBoxHorarioBuscar.Size = new Size(947, 20);
            textBoxHorarioBuscar.TabIndex = 19;
            textBoxHorarioBuscar.TextChanged += textBoxSHorarioBuscar_TextChanged;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Location = new Point(2794, 175);
            anyadirUsuario.Margin = new Padding(3, 4, 3, 4);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(86, 31);
            anyadirUsuario.TabIndex = 15;
            anyadirUsuario.Text = "+";
            anyadirUsuario.UseVisualStyleBackColor = false;
            anyadirUsuario.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1037, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 14;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = SystemColors.Control;
            panelAdmin.BorderStyle = BorderStyle.FixedSingle;
            panelAdmin.Controls.Add(pictureAdmin);
            panelAdmin.Controls.Add(labelNumAdmin);
            panelAdmin.Controls.Add(labelAdmin);
            panelAdmin.ForeColor = SystemColors.ControlDarkDark;
            panelAdmin.Location = new Point(597, 19);
            panelAdmin.Margin = new Padding(5, 4, 5, 4);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(196, 113);
            panelAdmin.TabIndex = 5;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Image = Properties.Resources.Usuario;
            pictureAdmin.Location = new Point(23, 44);
            pictureAdmin.Margin = new Padding(5, 4, 5, 4);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(43, 51);
            pictureAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAdmin.TabIndex = 3;
            pictureAdmin.TabStop = false;
            // 
            // labelNumAdmin
            // 
            labelNumAdmin.AutoSize = true;
            labelNumAdmin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAdmin.ForeColor = SystemColors.ControlText;
            labelNumAdmin.Location = new Point(66, 56);
            labelNumAdmin.Margin = new Padding(5, 0, 5, 0);
            labelNumAdmin.Name = "labelNumAdmin";
            labelNumAdmin.Size = new Size(27, 29);
            labelNumAdmin.TabIndex = 2;
            labelNumAdmin.Text = "2";
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdmin.Location = new Point(18, 24);
            labelAdmin.Margin = new Padding(5, 0, 5, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(128, 20);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "Usuarios Admin";
            // 
            // panelUInactivos
            // 
            panelUInactivos.BackColor = SystemColors.Control;
            panelUInactivos.BorderStyle = BorderStyle.FixedSingle;
            panelUInactivos.Controls.Add(labelNumUInactivos);
            panelUInactivos.Controls.Add(labelUInactivos);
            panelUInactivos.Controls.Add(pictureUInactivos);
            panelUInactivos.ForeColor = SystemColors.ControlDarkDark;
            panelUInactivos.Location = new Point(394, 19);
            panelUInactivos.Margin = new Padding(5, 4, 5, 4);
            panelUInactivos.Name = "panelUInactivos";
            panelUInactivos.Size = new Size(193, 113);
            panelUInactivos.TabIndex = 6;
            // 
            // labelNumUInactivos
            // 
            labelNumUInactivos.AutoSize = true;
            labelNumUInactivos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUInactivos.ForeColor = SystemColors.ControlText;
            labelNumUInactivos.Location = new Point(66, 56);
            labelNumUInactivos.Margin = new Padding(5, 0, 5, 0);
            labelNumUInactivos.Name = "labelNumUInactivos";
            labelNumUInactivos.Size = new Size(27, 29);
            labelNumUInactivos.TabIndex = 2;
            labelNumUInactivos.Text = "2";
            // 
            // labelUInactivos
            // 
            labelUInactivos.AutoSize = true;
            labelUInactivos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUInactivos.Location = new Point(18, 24);
            labelUInactivos.Margin = new Padding(5, 0, 5, 0);
            labelUInactivos.Name = "labelUInactivos";
            labelUInactivos.Size = new Size(147, 20);
            labelUInactivos.TabIndex = 0;
            labelUInactivos.Text = "Usuarios Inactivos";
            // 
            // pictureUInactivos
            // 
            pictureUInactivos.Image = Properties.Resources.usuarioInactivo;
            pictureUInactivos.Location = new Point(29, 51);
            pictureUInactivos.Margin = new Padding(5, 4, 5, 4);
            pictureUInactivos.Name = "pictureUInactivos";
            pictureUInactivos.Size = new Size(30, 40);
            pictureUInactivos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUInactivos.TabIndex = 1;
            pictureUInactivos.TabStop = false;
            // 
            // panelUActivos
            // 
            panelUActivos.BackColor = SystemColors.Control;
            panelUActivos.BorderStyle = BorderStyle.FixedSingle;
            panelUActivos.Controls.Add(labelNumUActivos);
            panelUActivos.Controls.Add(labelUActivos);
            panelUActivos.Controls.Add(pictureUActivos);
            panelUActivos.ForeColor = SystemColors.ControlDarkDark;
            panelUActivos.Location = new Point(205, 19);
            panelUActivos.Margin = new Padding(5, 4, 5, 4);
            panelUActivos.Name = "panelUActivos";
            panelUActivos.Size = new Size(179, 113);
            panelUActivos.TabIndex = 7;
            // 
            // labelNumUActivos
            // 
            labelNumUActivos.AutoSize = true;
            labelNumUActivos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUActivos.ForeColor = SystemColors.ControlText;
            labelNumUActivos.Location = new Point(74, 56);
            labelNumUActivos.Margin = new Padding(5, 0, 5, 0);
            labelNumUActivos.Name = "labelNumUActivos";
            labelNumUActivos.Size = new Size(27, 29);
            labelNumUActivos.TabIndex = 2;
            labelNumUActivos.Text = "5";
            // 
            // labelUActivos
            // 
            labelUActivos.AutoSize = true;
            labelUActivos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUActivos.Location = new Point(18, 24);
            labelUActivos.Margin = new Padding(5, 0, 5, 0);
            labelUActivos.Name = "labelUActivos";
            labelUActivos.Size = new Size(136, 20);
            labelUActivos.TabIndex = 0;
            labelUActivos.Text = "Usuarios Activos";
            // 
            // pictureUActivos
            // 
            pictureUActivos.Image = Properties.Resources.UusarioActivo;
            pictureUActivos.Location = new Point(30, 52);
            pictureUActivos.Margin = new Padding(5, 4, 5, 4);
            pictureUActivos.Name = "pictureUActivos";
            pictureUActivos.Size = new Size(35, 39);
            pictureUActivos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUActivos.TabIndex = 1;
            pictureUActivos.TabStop = false;
            // 
            // panelUsuarios
            // 
            panelUsuarios.BackColor = SystemColors.Control;
            panelUsuarios.BorderStyle = BorderStyle.FixedSingle;
            panelUsuarios.Controls.Add(labelNumUsuarios);
            panelUsuarios.Controls.Add(labelUsuarios);
            panelUsuarios.Controls.Add(pictureUsuarios);
            panelUsuarios.ForeColor = SystemColors.ControlDarkDark;
            panelUsuarios.Location = new Point(34, 19);
            panelUsuarios.Margin = new Padding(5, 4, 5, 4);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(162, 113);
            panelUsuarios.TabIndex = 4;
            // 
            // labelNumUsuarios
            // 
            labelNumUsuarios.AutoSize = true;
            labelNumUsuarios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUsuarios.ForeColor = SystemColors.ControlText;
            labelNumUsuarios.Location = new Point(66, 56);
            labelNumUsuarios.Margin = new Padding(5, 0, 5, 0);
            labelNumUsuarios.Name = "labelNumUsuarios";
            labelNumUsuarios.Size = new Size(27, 29);
            labelNumUsuarios.TabIndex = 2;
            labelNumUsuarios.Text = "2";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuarios.Location = new Point(18, 24);
            labelUsuarios.Margin = new Padding(5, 0, 5, 0);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(118, 20);
            labelUsuarios.TabIndex = 0;
            labelUsuarios.Text = "Total Usuarios";
            // 
            // pictureUsuarios
            // 
            pictureUsuarios.Image = Properties.Resources.Usuario_gris;
            pictureUsuarios.Location = new Point(23, 44);
            pictureUsuarios.Margin = new Padding(5, 4, 5, 4);
            pictureUsuarios.Name = "pictureUsuarios";
            pictureUsuarios.Size = new Size(43, 51);
            pictureUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUsuarios.TabIndex = 1;
            pictureUsuarios.TabStop = false;
            // 
            // dataGridViewHorarios
            // 
            dataGridViewHorarios.AllowUserToOrderColumns = true;
            dataGridViewHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHorarios.BackgroundColor = Color.White;
            dataGridViewHorarios.BorderStyle = BorderStyle.None;
            dataGridViewHorarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Servicio, Grupo, dataGridViewTextBoxColumn4, dataGridViewImageColumnUsModificar, dataGridViewImageColumnUsEliminar });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewHorarios.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewHorarios.Dock = DockStyle.Fill;
            dataGridViewHorarios.EnableHeadersVisualStyles = false;
            dataGridViewHorarios.GridColor = Color.Black;
            dataGridViewHorarios.ImeMode = ImeMode.NoControl;
            dataGridViewHorarios.Location = new Point(30, 0);
            dataGridViewHorarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHorarios.MultiSelect = false;
            dataGridViewHorarios.Name = "dataGridViewHorarios";
            dataGridViewHorarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewHorarios.RowHeadersVisible = false;
            dataGridViewHorarios.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewHorarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewHorarios.RowTemplate.Height = 35;
            dataGridViewHorarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewHorarios.Size = new Size(1511, 657);
            dataGridViewHorarios.TabIndex = 18;
            dataGridViewHorarios.CellContentClick += dataGridViewHorario_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn2.HeaderText = "Dia de la semana";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn1.HeaderText = "Hora de incio";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn3.HeaderText = "hora de fin";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 115;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Grupo";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Servicio";
            Grupo.MinimumWidth = 6;
            Grupo.Name = "Grupo";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn4.HeaderText = "Plaza";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewImageColumnUsModificar
            // 
            dataGridViewImageColumnUsModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewImageColumnUsModificar.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewImageColumnUsModificar.HeaderText = "Modificar";
            dataGridViewImageColumnUsModificar.Image = Properties.Resources.edit;
            dataGridViewImageColumnUsModificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsModificar.MinimumWidth = 22;
            dataGridViewImageColumnUsModificar.Name = "dataGridViewImageColumnUsModificar";
            dataGridViewImageColumnUsModificar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsModificar.Width = 135;
            // 
            // dataGridViewImageColumnUsEliminar
            // 
            dataGridViewImageColumnUsEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewImageColumnUsEliminar.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewImageColumnUsEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnUsEliminar.Image = Properties.Resources.trash;
            dataGridViewImageColumnUsEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsEliminar.MinimumWidth = 6;
            dataGridViewImageColumnUsEliminar.Name = "dataGridViewImageColumnUsEliminar";
            dataGridViewImageColumnUsEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsEliminar.Width = 123;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewHorarios);
            panelMargenes.Controls.Add(panel1);
            panelMargenes.Controls.Add(panel2);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1571, 768);
            panelMargenes.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPaginacionDelante);
            panel1.Controls.Add(buttonPaginacionAtras);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 657);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(34, 0, 0, 0);
            panel1.Size = new Size(1511, 43);
            panel1.TabIndex = 18;
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
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 700);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1511, 68);
            panel2.TabIndex = 17;
            // 
            // PanelHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelVisualHorarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelHorario";
            Text = "PanelHorario";
            Load += PanelHorario_Load;
            Resize += PanelHorario_Resize;
            panelVisualHorarios.ResumeLayout(false);
            panelVisualHorarios.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).EndInit();
            panelUInactivos.ResumeLayout(false);
            panelUInactivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUInactivos).EndInit();
            panelUActivos.ResumeLayout(false);
            panelUActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUActivos).EndInit();
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorarios).EndInit();
            panelMargenes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelVisualHorarios;
        private Button anyadirUsuario;
        private Label label1;
      
        private Panel panelAdmin;
        private PictureBox pictureAdmin;
        private Label labelNumAdmin;
        private Label labelAdmin;
        private Panel panelUInactivos;
        private Label labelNumUInactivos;
        private Label labelUInactivos;
        private PictureBox pictureUInactivos;
        private Panel panelUActivos;
        private Label labelNumUActivos;
        private Label labelUActivos;
        private PictureBox pictureUActivos;
        private Panel panelUsuarios;
        private Label labelNumUsuarios;
        private Label labelUsuarios;
        private PictureBox pictureUsuarios;
        private DataGridView dataGridViewHorarios;
        private Button anyadirHorario;
        private ComboBox comboBoxHorario;
        private TextBox textBoxHorarioBuscar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumnUsModificar;
        private DataGridViewImageColumn dataGridViewImageColumnUsEliminar;
        private Panel panelMargenes;
        private Panel panel1;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panel2;
    }
}