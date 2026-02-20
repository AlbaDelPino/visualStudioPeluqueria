namespace WinFormsApp1
{
    partial class PanelUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            panelVisualUsuarios = new Panel();
            anyadirUsuario = new Button();
            label1 = new Label();
            comboBoxUsFiltrar = new ComboBox();
            textBoxSUsBuscar = new TextBox();
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
            dataGridViewUsuarios = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnUsInfo = new DataGridViewImageColumn();
            dataGridViewImageColumnUsEliminar = new DataGridViewImageColumn();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelMargenes = new Panel();
            panelVisualUsuarios.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).BeginInit();
            panelUInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUInactivos).BeginInit();
            panelUActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUActivos).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelPaginacion.SuspendLayout();
            panelMargenes.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualUsuarios
            // 
            panelVisualUsuarios.Controls.Add(anyadirUsuario);
            panelVisualUsuarios.Controls.Add(label1);
            panelVisualUsuarios.Controls.Add(comboBoxUsFiltrar);
            panelVisualUsuarios.Controls.Add(textBoxSUsBuscar);
            panelVisualUsuarios.Controls.Add(panelAdmin);
            panelVisualUsuarios.Controls.Add(panelUInactivos);
            panelVisualUsuarios.Controls.Add(panelUActivos);
            panelVisualUsuarios.Controls.Add(panelUsuarios);
            panelVisualUsuarios.Dock = DockStyle.Top;
            panelVisualUsuarios.ForeColor = Color.FromArgb(255, 128, 0);
            panelVisualUsuarios.Location = new Point(0, 0);
            panelVisualUsuarios.Margin = new Padding(5, 4, 5, 4);
            panelVisualUsuarios.Name = "panelVisualUsuarios";
            panelVisualUsuarios.Padding = new Padding(17, 0, 0, 0);
            panelVisualUsuarios.Size = new Size(1571, 256);
            panelVisualUsuarios.TabIndex = 5;
            panelVisualUsuarios.Paint += panelVisualUsuarios_Paint;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Location = new Point(1451, 175);
            anyadirUsuario.Margin = new Padding(3, 4, 3, 4);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(52, 55);
            anyadirUsuario.TabIndex = 15;
            anyadirUsuario.Text = "+";
            anyadirUsuario.UseVisualStyleBackColor = false;
            anyadirUsuario.Click += anyadirUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1019, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 14;
            // 
            // comboBoxUsFiltrar
            // 
            comboBoxUsFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxUsFiltrar.DisplayMember = "1";
            comboBoxUsFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsFiltrar.FlatStyle = FlatStyle.Flat;
            comboBoxUsFiltrar.Items.AddRange(new object[] { "", "Activos", "Inactivos", "Administradores", "Clientes", "Grupos" });
            comboBoxUsFiltrar.Location = new Point(1234, 187);
            comboBoxUsFiltrar.Margin = new Padding(5, 4, 5, 4);
            comboBoxUsFiltrar.Name = "comboBoxUsFiltrar";
            comboBoxUsFiltrar.Size = new Size(153, 28);
            comboBoxUsFiltrar.TabIndex = 13;
            comboBoxUsFiltrar.SelectedIndexChanged += comboBoxUsFiltrar_SelectedIndexChanged;
            // 
            // textBoxSUsBuscar
            // 
            textBoxSUsBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSUsBuscar.BorderStyle = BorderStyle.None;
            textBoxSUsBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSUsBuscar.Location = new Point(34, 192);
            textBoxSUsBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSUsBuscar.Name = "textBoxSUsBuscar";
            textBoxSUsBuscar.PlaceholderText = "Buscar por nombre o usuario...";
            textBoxSUsBuscar.Size = new Size(947, 20);
            textBoxSUsBuscar.TabIndex = 12;
            textBoxSUsBuscar.TextChanged += textBoxSUsBuscar_TextChanged;
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
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToOrderColumns = true;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BackgroundColor = Color.White;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new Padding(7);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewImageColumnUsInfo, dataGridViewImageColumnUsEliminar });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = Color.Black;
            dataGridViewUsuarios.ImeMode = ImeMode.NoControl;
            dataGridViewUsuarios.Location = new Point(34, 0);
            dataGridViewUsuarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewUsuarios.RowTemplate.Height = 35;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewUsuarios.Size = new Size(1503, 657);
            dataGridViewUsuarios.TabIndex = 9;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewImageColumnUsInfo
            // 
            dataGridViewImageColumnUsInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(255, 128, 0);
            dataGridViewImageColumnUsInfo.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewImageColumnUsInfo.HeaderText = "Ficha";
            dataGridViewImageColumnUsInfo.Image = Properties.Resources.info;
            dataGridViewImageColumnUsInfo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsInfo.MinimumWidth = 6;
            dataGridViewImageColumnUsInfo.Name = "dataGridViewImageColumnUsInfo";
            dataGridViewImageColumnUsInfo.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsInfo.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsInfo.Width = 98;
            // 
            // dataGridViewImageColumnUsEliminar
            // 
            dataGridViewImageColumnUsEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewImageColumnUsEliminar.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewImageColumnUsEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnUsEliminar.Image = Properties.Resources.trash;
            dataGridViewImageColumnUsEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsEliminar.MinimumWidth = 6;
            dataGridViewImageColumnUsEliminar.Name = "dataGridViewImageColumnUsEliminar";
            dataGridViewImageColumnUsEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsEliminar.Width = 123;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 956);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 68);
            panelEspaciado.TabIndex = 14;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(labelPaginaActual);
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 913);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 43);
            panelPaginacion.TabIndex = 15;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(777, 11);
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
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewUsuarios);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(34, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 657);
            panelMargenes.TabIndex = 16;
            // 
            // PanelUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualUsuarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelUsuario";
            Text = "PanelUsuario";
            Load += PanelUsuario_Load;
            Resize += PanelUsuario_Resize;
            panelVisualUsuarios.ResumeLayout(false);
            panelVisualUsuarios.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            panelMargenes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualUsuarios;
        private ComboBox comboBoxUsFiltrar;
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
        private TextBox textBoxSUsBuscar;
        private DataGridView dataGridViewUsuarios;
        private Panel panelEspaciado;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelMargenes;
        private Label label1;
        private Button anyadirUsuario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumnUsInfo;
        private DataGridViewImageColumn dataGridViewImageColumnUsEliminar;
        private Label labelPaginaActual;
    }
}