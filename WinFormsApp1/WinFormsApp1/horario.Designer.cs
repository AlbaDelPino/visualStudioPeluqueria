namespace WinFormsApp1
{
    partial class horario
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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelVisualHorario = new Panel();
            buttonHorario = new Button();
            comboBoxHorario = new ComboBox();
            textBoxSHorarioBuscar = new TextBox();
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
            panelMargenes = new Panel();
            dataGridViewHorario = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnUsInfo = new DataGridViewImageColumn();
            dataGridViewImageColumnUsModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnUsEliminar = new DataGridViewImageColumn();
            panelPaginacion.SuspendLayout();
            panelVisualHorario.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).BeginInit();
            panelUInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUInactivos).BeginInit();
            panelUActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUActivos).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).BeginInit();
            panelMargenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 687);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1613, 51);
            panelEspaciado.TabIndex = 15;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 655);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(30, 0, 0, 0);
            panelPaginacion.Size = new Size(1613, 32);
            panelPaginacion.TabIndex = 16;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(105, 0);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(75, 32);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            buttonPaginacionDelante.Click += buttonPaginacionDelante_Click;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(30, 0);
            buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            buttonPaginacionAtras.Size = new Size(75, 32);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            buttonPaginacionAtras.Click += buttonPaginacionAtras_Click;
            // 
            // panelVisualHorario
            // 
            panelVisualHorario.Controls.Add(buttonHorario);
            panelVisualHorario.Controls.Add(comboBoxHorario);
            panelVisualHorario.Controls.Add(textBoxSHorarioBuscar);
            panelVisualHorario.Controls.Add(anyadirUsuario);
            panelVisualHorario.Controls.Add(label1);
            panelVisualHorario.Controls.Add(panelAdmin);
            panelVisualHorario.Controls.Add(panelUInactivos);
            panelVisualHorario.Controls.Add(panelUActivos);
            panelVisualHorario.Controls.Add(panelUsuarios);
            panelVisualHorario.Dock = DockStyle.Top;
            panelVisualHorario.ForeColor = Color.FromArgb(255, 128, 0);
            panelVisualHorario.Location = new Point(0, 0);
            panelVisualHorario.Margin = new Padding(4, 3, 4, 3);
            panelVisualHorario.Name = "panelVisualHorario";
            panelVisualHorario.Padding = new Padding(15, 0, 0, 0);
            panelVisualHorario.Size = new Size(1613, 192);
            panelVisualHorario.TabIndex = 17;
            panelVisualHorario.Paint += panelVisualHorario_Paint;
            // 
            // buttonHorario
            // 
            buttonHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHorario.BackColor = Color.FromArgb(255, 128, 0);
            buttonHorario.FlatAppearance.BorderSize = 0;
            buttonHorario.FlatStyle = FlatStyle.Flat;
            buttonHorario.ForeColor = Color.White;
            buttonHorario.Location = new Point(1492, 124);
            buttonHorario.Margin = new Padding(3, 4, 3, 4);
            buttonHorario.Name = "buttonHorario";
            buttonHorario.Size = new Size(86, 31);
            buttonHorario.TabIndex = 21;
            buttonHorario.Text = "+";
            buttonHorario.UseVisualStyleBackColor = false;
            // 
            // comboBoxHorario
            // 
            comboBoxHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxHorario.DisplayMember = "1";
            comboBoxHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHorario.FlatStyle = FlatStyle.Flat;
            comboBoxHorario.Items.AddRange(new object[] { "", "Activos", "Inactivos", "Administradores", "Clientes", "Grupos" });
            comboBoxHorario.Location = new Point(1255, 132);
            comboBoxHorario.Margin = new Padding(5, 4, 5, 4);
            comboBoxHorario.Name = "comboBoxHorario";
            comboBoxHorario.Size = new Size(153, 23);
            comboBoxHorario.TabIndex = 20;
            // 
            // textBoxSHorarioBuscar
            // 
            textBoxSHorarioBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSHorarioBuscar.BorderStyle = BorderStyle.None;
            textBoxSHorarioBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSHorarioBuscar.Location = new Point(14, 139);
            textBoxSHorarioBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSHorarioBuscar.Name = "textBoxSHorarioBuscar";
            textBoxSHorarioBuscar.PlaceholderText = "Buscar por cliente o servicio...";
            textBoxSHorarioBuscar.Size = new Size(1053, 16);
            textBoxSHorarioBuscar.TabIndex = 19;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Location = new Point(2683, 131);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(75, 23);
            anyadirUsuario.TabIndex = 15;
            anyadirUsuario.Text = "+";
            anyadirUsuario.UseVisualStyleBackColor = false;
            anyadirUsuario.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(907, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
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
            panelAdmin.Location = new Point(522, 14);
            panelAdmin.Margin = new Padding(4, 3, 4, 3);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(172, 85);
            panelAdmin.TabIndex = 5;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Image = Properties.Resources.Usuario;
            pictureAdmin.Location = new Point(20, 33);
            pictureAdmin.Margin = new Padding(4, 3, 4, 3);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(38, 38);
            pictureAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAdmin.TabIndex = 3;
            pictureAdmin.TabStop = false;
            // 
            // labelNumAdmin
            // 
            labelNumAdmin.AutoSize = true;
            labelNumAdmin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAdmin.ForeColor = SystemColors.ControlText;
            labelNumAdmin.Location = new Point(58, 42);
            labelNumAdmin.Margin = new Padding(4, 0, 4, 0);
            labelNumAdmin.Name = "labelNumAdmin";
            labelNumAdmin.Size = new Size(23, 25);
            labelNumAdmin.TabIndex = 2;
            labelNumAdmin.Text = "2";
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdmin.Location = new Point(16, 18);
            labelAdmin.Margin = new Padding(4, 0, 4, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(107, 17);
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
            panelUInactivos.Location = new Point(345, 14);
            panelUInactivos.Margin = new Padding(4, 3, 4, 3);
            panelUInactivos.Name = "panelUInactivos";
            panelUInactivos.Size = new Size(169, 85);
            panelUInactivos.TabIndex = 6;
            // 
            // labelNumUInactivos
            // 
            labelNumUInactivos.AutoSize = true;
            labelNumUInactivos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUInactivos.ForeColor = SystemColors.ControlText;
            labelNumUInactivos.Location = new Point(58, 42);
            labelNumUInactivos.Margin = new Padding(4, 0, 4, 0);
            labelNumUInactivos.Name = "labelNumUInactivos";
            labelNumUInactivos.Size = new Size(23, 25);
            labelNumUInactivos.TabIndex = 2;
            labelNumUInactivos.Text = "2";
            // 
            // labelUInactivos
            // 
            labelUInactivos.AutoSize = true;
            labelUInactivos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUInactivos.Location = new Point(16, 18);
            labelUInactivos.Margin = new Padding(4, 0, 4, 0);
            labelUInactivos.Name = "labelUInactivos";
            labelUInactivos.Size = new Size(123, 17);
            labelUInactivos.TabIndex = 0;
            labelUInactivos.Text = "Usuarios Inactivos";
            // 
            // pictureUInactivos
            // 
            pictureUInactivos.Image = Properties.Resources.usuarioInactivo;
            pictureUInactivos.Location = new Point(25, 38);
            pictureUInactivos.Margin = new Padding(4, 3, 4, 3);
            pictureUInactivos.Name = "pictureUInactivos";
            pictureUInactivos.Size = new Size(26, 30);
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
            panelUActivos.Location = new Point(179, 14);
            panelUActivos.Margin = new Padding(4, 3, 4, 3);
            panelUActivos.Name = "panelUActivos";
            panelUActivos.Size = new Size(157, 85);
            panelUActivos.TabIndex = 7;
            // 
            // labelNumUActivos
            // 
            labelNumUActivos.AutoSize = true;
            labelNumUActivos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUActivos.ForeColor = SystemColors.ControlText;
            labelNumUActivos.Location = new Point(65, 42);
            labelNumUActivos.Margin = new Padding(4, 0, 4, 0);
            labelNumUActivos.Name = "labelNumUActivos";
            labelNumUActivos.Size = new Size(23, 25);
            labelNumUActivos.TabIndex = 2;
            labelNumUActivos.Text = "5";
            // 
            // labelUActivos
            // 
            labelUActivos.AutoSize = true;
            labelUActivos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUActivos.Location = new Point(16, 18);
            labelUActivos.Margin = new Padding(4, 0, 4, 0);
            labelUActivos.Name = "labelUActivos";
            labelUActivos.Size = new Size(113, 17);
            labelUActivos.TabIndex = 0;
            labelUActivos.Text = "Usuarios Activos";
            // 
            // pictureUActivos
            // 
            pictureUActivos.Image = Properties.Resources.UusarioActivo;
            pictureUActivos.Location = new Point(26, 39);
            pictureUActivos.Margin = new Padding(4, 3, 4, 3);
            pictureUActivos.Name = "pictureUActivos";
            pictureUActivos.Size = new Size(31, 29);
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
            panelUsuarios.Location = new Point(30, 14);
            panelUsuarios.Margin = new Padding(4, 3, 4, 3);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(142, 85);
            panelUsuarios.TabIndex = 4;
            // 
            // labelNumUsuarios
            // 
            labelNumUsuarios.AutoSize = true;
            labelNumUsuarios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUsuarios.ForeColor = SystemColors.ControlText;
            labelNumUsuarios.Location = new Point(58, 42);
            labelNumUsuarios.Margin = new Padding(4, 0, 4, 0);
            labelNumUsuarios.Name = "labelNumUsuarios";
            labelNumUsuarios.Size = new Size(23, 25);
            labelNumUsuarios.TabIndex = 2;
            labelNumUsuarios.Text = "2";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuarios.Location = new Point(16, 18);
            labelUsuarios.Margin = new Padding(4, 0, 4, 0);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(100, 17);
            labelUsuarios.TabIndex = 0;
            labelUsuarios.Text = "Total Usuarios";
            // 
            // pictureUsuarios
            // 
            pictureUsuarios.Image = Properties.Resources.Usuario_gris;
            pictureUsuarios.Location = new Point(20, 33);
            pictureUsuarios.Margin = new Padding(4, 3, 4, 3);
            pictureUsuarios.Name = "pictureUsuarios";
            pictureUsuarios.Size = new Size(38, 38);
            pictureUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUsuarios.TabIndex = 1;
            pictureUsuarios.TabStop = false;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewHorario);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 192);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1613, 463);
            panelMargenes.TabIndex = 18;
            panelMargenes.Paint += panelMargenes_Paint;
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.AllowUserToOrderColumns = true;
            dataGridViewHorario.BackgroundColor = Color.White;
            dataGridViewHorario.BorderStyle = BorderStyle.None;
            dataGridViewHorario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new Padding(7);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Servicio, Grupo, dataGridViewTextBoxColumn4, dataGridViewImageColumnUsInfo, dataGridViewImageColumnUsModificar, dataGridViewImageColumnUsEliminar });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.Padding = new Padding(2);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dataGridViewHorario.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewHorario.Dock = DockStyle.Fill;
            dataGridViewHorario.EnableHeadersVisualStyles = false;
            dataGridViewHorario.GridColor = Color.Black;
            dataGridViewHorario.ImeMode = ImeMode.NoControl;
            dataGridViewHorario.Location = new Point(30, 0);
            dataGridViewHorario.MultiSelect = false;
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridViewHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewHorario.RowHeadersVisible = false;
            dataGridViewHorario.RowHeadersWidth = 51;
            dataGridViewCellStyle22.BackColor = Color.White;
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            dataGridViewHorario.RowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewHorario.RowTemplate.Height = 35;
            dataGridViewHorario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewHorario.Size = new Size(1553, 463);
            dataGridViewHorario.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn2.HeaderText = "Dia de la semana";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn1.HeaderText = "Hora de incio";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn3.HeaderText = "hora de fin";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 95;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Grupo";
            Servicio.Name = "Servicio";
            Servicio.Width = 288;
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Servicio";
            Grupo.Name = "Grupo";
            Grupo.Width = 288;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn4.HeaderText = "Plaza";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 82;
            // 
            // dataGridViewImageColumnUsInfo
            // 
            dataGridViewImageColumnUsInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(255, 128, 0);
            dataGridViewImageColumnUsInfo.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewImageColumnUsInfo.HeaderText = "Info";
            dataGridViewImageColumnUsInfo.Image = Properties.Resources.info;
            dataGridViewImageColumnUsInfo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsInfo.MinimumWidth = 6;
            dataGridViewImageColumnUsInfo.Name = "dataGridViewImageColumnUsInfo";
            dataGridViewImageColumnUsInfo.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsInfo.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsInfo.Width = 73;
            // 
            // dataGridViewImageColumnUsModificar
            // 
            dataGridViewImageColumnUsModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewImageColumnUsModificar.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewImageColumnUsModificar.HeaderText = "Modificar";
            dataGridViewImageColumnUsModificar.Image = Properties.Resources.edit;
            dataGridViewImageColumnUsModificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsModificar.MinimumWidth = 22;
            dataGridViewImageColumnUsModificar.Name = "dataGridViewImageColumnUsModificar";
            dataGridViewImageColumnUsModificar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsModificar.Width = 111;
            // 
            // dataGridViewImageColumnUsEliminar
            // 
            dataGridViewImageColumnUsEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewImageColumnUsEliminar.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewImageColumnUsEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnUsEliminar.Image = Properties.Resources.trash;
            dataGridViewImageColumnUsEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsEliminar.MinimumWidth = 6;
            dataGridViewImageColumnUsEliminar.Name = "dataGridViewImageColumnUsEliminar";
            dataGridViewImageColumnUsEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsEliminar.Width = 101;
            // 
            // horario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1613, 738);
            Controls.Add(panelMargenes);
            Controls.Add(panelVisualHorario);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Name = "horario";
            Text = "horario";
            Load += horario_Load;
            panelPaginacion.ResumeLayout(false);
            panelVisualHorario.ResumeLayout(false);
            panelVisualHorario.PerformLayout();
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
            panelMargenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEspaciado;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelVisualHorario;
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
        private Button buttonHorario;
        private ComboBox comboBoxHorario;
        private TextBox textBoxSHorarioBuscar;
        private Panel panelMargenes;
        private DataGridView dataGridViewHorario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumnUsInfo;
        private DataGridViewImageColumn dataGridViewImageColumnUsModificar;
        private DataGridViewImageColumn dataGridViewImageColumnUsEliminar;
    }
}