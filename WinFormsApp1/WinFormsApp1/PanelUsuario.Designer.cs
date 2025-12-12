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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUsuario));
            panelVisualUsuarios = new Panel();
            comboBoxUsFiltrar = new ComboBox();
            textBoxSUsBuscar = new TextBox();
            anyadirUsuario = new Button();
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnUsInfo = new DataGridViewImageColumn();
            dataGridViewImageColumnUsModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnUsEliminar = new DataGridViewImageColumn();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
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
            panelVisualUsuarios.Controls.Add(comboBoxUsFiltrar);
            panelVisualUsuarios.Controls.Add(textBoxSUsBuscar);
            panelVisualUsuarios.Controls.Add(anyadirUsuario);
            panelVisualUsuarios.Controls.Add(panelAdmin);
            panelVisualUsuarios.Controls.Add(panelUInactivos);
            panelVisualUsuarios.Controls.Add(panelUActivos);
            panelVisualUsuarios.Controls.Add(panelUsuarios);
            panelVisualUsuarios.Dock = DockStyle.Top;
            panelVisualUsuarios.Location = new Point(0, 0);
            panelVisualUsuarios.Margin = new Padding(4, 3, 4, 3);
            panelVisualUsuarios.Name = "panelVisualUsuarios";
            panelVisualUsuarios.Size = new Size(1375, 192);
            panelVisualUsuarios.TabIndex = 5;
            // 
            // comboBoxUsFiltrar
            // 
            comboBoxUsFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxUsFiltrar.DisplayMember = "1";
            comboBoxUsFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsFiltrar.Items.AddRange(new object[] { "", "Activos", "Inactivos", "Administradores", "Clientes", "Grupos" });
            comboBoxUsFiltrar.Location = new Point(1204, 155);
            comboBoxUsFiltrar.Margin = new Padding(4, 3, 4, 3);
            comboBoxUsFiltrar.Name = "comboBoxUsFiltrar";
            comboBoxUsFiltrar.Size = new Size(134, 23);
            comboBoxUsFiltrar.TabIndex = 13;
            comboBoxUsFiltrar.SelectedIndexChanged += this.comboBoxUsFiltrar_SelectedIndexChanged;
            // 
            // textBoxSUsBuscar
            // 
            textBoxSUsBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSUsBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSUsBuscar.Location = new Point(15, 155);
            textBoxSUsBuscar.Margin = new Padding(4, 3, 4, 3);
            textBoxSUsBuscar.Name = "textBoxSUsBuscar";
            textBoxSUsBuscar.PlaceholderText = "Buscar por nombre o usuario...";
            textBoxSUsBuscar.Size = new Size(1158, 23);
            textBoxSUsBuscar.TabIndex = 12;
            textBoxSUsBuscar.TextChanged += comboBoxUsFiltrar_SelectedIndexChanged;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.Location = new Point(15, 126);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(59, 23);
            anyadirUsuario.TabIndex = 9;
            anyadirUsuario.Text = "Añadir";
            anyadirUsuario.UseVisualStyleBackColor = true;
            anyadirUsuario.Click += anyadirUsuario_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = SystemColors.Control;
            panelAdmin.BorderStyle = BorderStyle.FixedSingle;
            panelAdmin.Controls.Add(pictureAdmin);
            panelAdmin.Controls.Add(labelNumAdmin);
            panelAdmin.Controls.Add(labelAdmin);
            panelAdmin.ForeColor = SystemColors.ControlDarkDark;
            panelAdmin.Location = new Point(506, 13);
            panelAdmin.Margin = new Padding(4, 3, 4, 3);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(172, 85);
            panelAdmin.TabIndex = 5;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Image = (Image)resources.GetObject("pictureAdmin.Image");
            pictureAdmin.Location = new Point(16, 33);
            pictureAdmin.Margin = new Padding(4, 3, 4, 3);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(46, 38);
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
            panelUInactivos.Location = new Point(329, 13);
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
            pictureUInactivos.Image = (Image)resources.GetObject("pictureUInactivos.Image");
            pictureUInactivos.Location = new Point(25, 38);
            pictureUInactivos.Margin = new Padding(4, 3, 4, 3);
            pictureUInactivos.Name = "pictureUInactivos";
            pictureUInactivos.Size = new Size(25, 29);
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
            panelUActivos.Location = new Point(164, 13);
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
            pictureUActivos.Image = (Image)resources.GetObject("pictureUActivos.Image");
            pictureUActivos.Location = new Point(26, 42);
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
            panelUsuarios.Location = new Point(14, 13);
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
            pictureUsuarios.Image = (Image)resources.GetObject("pictureUsuarios.Image");
            pictureUsuarios.Location = new Point(20, 33);
            pictureUsuarios.Margin = new Padding(4, 3, 4, 3);
            pictureUsuarios.Name = "pictureUsuarios";
            pictureUsuarios.Size = new Size(38, 38);
            pictureUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUsuarios.TabIndex = 1;
            pictureUsuarios.TabStop = false;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewImageColumnUsInfo, dataGridViewImageColumnUsModificar, dataGridViewImageColumnUsEliminar });
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.Location = new Point(30, 0);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(1315, 446);
            dataGridViewUsuarios.TabIndex = 9;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewImageColumnUsInfo
            // 
            dataGridViewImageColumnUsInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumnUsInfo.HeaderText = "Info";
            dataGridViewImageColumnUsInfo.Image = (Image)resources.GetObject("dataGridViewImageColumnUsInfo.Image");
            dataGridViewImageColumnUsInfo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsInfo.MinimumWidth = 6;
            dataGridViewImageColumnUsInfo.Name = "dataGridViewImageColumnUsInfo";
            dataGridViewImageColumnUsInfo.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsInfo.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsInfo.Width = 53;
            // 
            // dataGridViewImageColumnUsModificar
            // 
            dataGridViewImageColumnUsModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumnUsModificar.HeaderText = "Modificar";
            dataGridViewImageColumnUsModificar.Image = (Image)resources.GetObject("dataGridViewImageColumnUsModificar.Image");
            dataGridViewImageColumnUsModificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsModificar.MinimumWidth = 6;
            dataGridViewImageColumnUsModificar.Name = "dataGridViewImageColumnUsModificar";
            dataGridViewImageColumnUsModificar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsModificar.Width = 83;
            // 
            // dataGridViewImageColumnUsEliminar
            // 
            dataGridViewImageColumnUsEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumnUsEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnUsEliminar.Image = (Image)resources.GetObject("dataGridViewImageColumnUsEliminar.Image");
            dataGridViewImageColumnUsEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnUsEliminar.MinimumWidth = 6;
            dataGridViewImageColumnUsEliminar.Name = "dataGridViewImageColumnUsEliminar";
            dataGridViewImageColumnUsEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnUsEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnUsEliminar.Width = 75;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 668);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1375, 100);
            panelEspaciado.TabIndex = 14;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 638);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(30, 0, 0, 0);
            panelPaginacion.Size = new Size(1375, 30);
            panelPaginacion.TabIndex = 15;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(105, 0);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(75, 30);
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
            buttonPaginacionAtras.Size = new Size(75, 30);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            buttonPaginacionAtras.Click += buttonPaginacionAtras_Click;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewUsuarios);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 192);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1375, 446);
            panelMargenes.TabIndex = 16;
            // 
            // PanelUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 768);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualUsuarios);
            Name = "PanelUsuario";
            Text = "PanelUsuario";
            Load += PanelUsuario_Load;
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
            panelMargenes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualUsuarios;
        private ComboBox comboBoxUsFiltrar;
        private Button anyadirUsuario;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumnUsInfo;
        private DataGridViewImageColumn dataGridViewImageColumnUsModificar;
        private DataGridViewImageColumn dataGridViewImageColumnUsEliminar;
        private Panel panelEspaciado;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelMargenes;
    }
}