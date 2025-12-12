namespace WinFormsApp1
{
    partial class PanelServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelServicios));
            panelVisualServicios = new Panel();
            panelTipoSer = new Panel();
            labelNumTipoSer = new Label();
            labelTipoSer = new Label();
            pictureTipoSer = new PictureBox();
            anyadirServicio = new Button();
            panel1 = new Panel();
            labelNumServicios = new Label();
            labelServicios = new Label();
            pictureServicios = new PictureBox();
            comboBoxSerFiltrar = new ComboBox();
            textBoxSerBuscar = new TextBox();
            comboBox1 = new ComboBox();
            dataGridViewServicios = new DataGridView();
            dataGridViewTextBoxColumnSerNombre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerDescripcion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerDuracion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerPrecio = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnEliminar = new DataGridViewImageColumn();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelPaginacion = new Panel();
            panelEspaciado = new Panel();
            panelVisualServicios.SuspendLayout();
            panelTipoSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTipoSer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualServicios
            // 
            panelVisualServicios.Controls.Add(comboBox1);
            panelVisualServicios.Controls.Add(panelTipoSer);
            panelVisualServicios.Controls.Add(textBoxSerBuscar);
            panelVisualServicios.Controls.Add(anyadirServicio);
            panelVisualServicios.Controls.Add(panel1);
            panelVisualServicios.Controls.Add(comboBoxSerFiltrar);
            panelVisualServicios.Dock = DockStyle.Top;
            panelVisualServicios.Location = new Point(0, 0);
            panelVisualServicios.Margin = new Padding(4, 3, 4, 3);
            panelVisualServicios.Name = "panelVisualServicios";
            panelVisualServicios.Size = new Size(1375, 192);
            panelVisualServicios.TabIndex = 5;
            // 
            // panelTipoSer
            // 
            panelTipoSer.BackColor = SystemColors.Control;
            panelTipoSer.BorderStyle = BorderStyle.FixedSingle;
            panelTipoSer.Controls.Add(labelNumTipoSer);
            panelTipoSer.Controls.Add(labelTipoSer);
            panelTipoSer.Controls.Add(pictureTipoSer);
            panelTipoSer.ForeColor = SystemColors.ControlDarkDark;
            panelTipoSer.Location = new Point(164, 13);
            panelTipoSer.Margin = new Padding(4, 3, 4, 3);
            panelTipoSer.Name = "panelTipoSer";
            panelTipoSer.Size = new Size(160, 85);
            panelTipoSer.TabIndex = 11;
            // 
            // labelNumTipoSer
            // 
            labelNumTipoSer.AutoSize = true;
            labelNumTipoSer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumTipoSer.ForeColor = SystemColors.ControlText;
            labelNumTipoSer.Location = new Point(58, 42);
            labelNumTipoSer.Margin = new Padding(4, 0, 4, 0);
            labelNumTipoSer.Name = "labelNumTipoSer";
            labelNumTipoSer.Size = new Size(23, 25);
            labelNumTipoSer.TabIndex = 2;
            labelNumTipoSer.Text = "3";
            // 
            // labelTipoSer
            // 
            labelTipoSer.AutoSize = true;
            labelTipoSer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipoSer.Location = new Point(16, 18);
            labelTipoSer.Margin = new Padding(4, 0, 4, 0);
            labelTipoSer.Name = "labelTipoSer";
            labelTipoSer.Size = new Size(124, 17);
            labelTipoSer.TabIndex = 0;
            labelTipoSer.Text = "Tipos de Servicios";
            // 
            // pictureTipoSer
            // 
            pictureTipoSer.Image = Properties.Resources.servicio;
            pictureTipoSer.Location = new Point(30, 40);
            pictureTipoSer.Margin = new Padding(4, 3, 4, 3);
            pictureTipoSer.Name = "pictureTipoSer";
            pictureTipoSer.Size = new Size(30, 30);
            pictureTipoSer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTipoSer.TabIndex = 1;
            pictureTipoSer.TabStop = false;
            // 
            // anyadirServicio
            // 
            anyadirServicio.Location = new Point(15, 126);
            anyadirServicio.Name = "anyadirServicio";
            anyadirServicio.Size = new Size(59, 23);
            anyadirServicio.TabIndex = 10;
            anyadirServicio.Text = "Añadir";
            anyadirServicio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelNumServicios);
            panel1.Controls.Add(labelServicios);
            panel1.Controls.Add(pictureServicios);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(14, 13);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 85);
            panel1.TabIndex = 4;
            // 
            // labelNumServicios
            // 
            labelNumServicios.AutoSize = true;
            labelNumServicios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumServicios.ForeColor = SystemColors.ControlText;
            labelNumServicios.Location = new Point(58, 42);
            labelNumServicios.Margin = new Padding(4, 0, 4, 0);
            labelNumServicios.Name = "labelNumServicios";
            labelNumServicios.Size = new Size(23, 25);
            labelNumServicios.TabIndex = 2;
            labelNumServicios.Text = "3";
            // 
            // labelServicios
            // 
            labelServicios.AutoSize = true;
            labelServicios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelServicios.Location = new Point(16, 18);
            labelServicios.Margin = new Padding(4, 0, 4, 0);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(101, 17);
            labelServicios.TabIndex = 0;
            labelServicios.Text = "Total Servicios";
            // 
            // pictureServicios
            // 
            pictureServicios.Image = Properties.Resources.servicio;
            pictureServicios.Location = new Point(30, 40);
            pictureServicios.Margin = new Padding(4, 3, 4, 3);
            pictureServicios.Name = "pictureServicios";
            pictureServicios.Size = new Size(30, 30);
            pictureServicios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureServicios.TabIndex = 1;
            pictureServicios.TabStop = false;
            // 
            // comboBoxSerFiltrar
            // 
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSerFiltrar.DisplayMember = "1";
            comboBoxSerFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSerFiltrar.Items.AddRange(new object[] { "", "Depilación", "Manicura y Pedicura", "Maquillaje", "Masajes", "Micropigmentación", "Peluquería", "Pestañas y Cejas", "Tratamientos Corporales", "Tratamientos Faciales" });
            comboBoxSerFiltrar.Location = new Point(2101, 155);
            comboBoxSerFiltrar.Margin = new Padding(4, 3, 4, 3);
            comboBoxSerFiltrar.Name = "comboBoxSerFiltrar";
            comboBoxSerFiltrar.Size = new Size(134, 23);
            comboBoxSerFiltrar.TabIndex = 1;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(15, 155);
            textBoxSerBuscar.Margin = new Padding(4, 3, 4, 3);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(1158, 23);
            textBoxSerBuscar.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.DisplayMember = "1";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "", "Depilación", "Manicura y Pedicura", "Maquillaje", "Masajes", "Micropigmentación", "Peluquería", "Pestañas y Cejas", "Tratamientos Corporales", "Tratamientos Faciales" });
            comboBox1.Location = new Point(1204, 155);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 6;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicios.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewServicios.BorderStyle = BorderStyle.None;
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnSerNombre, dataGridViewTextBoxColumnSerDescripcion, dataGridViewTextBoxColumnSerDuracion, dataGridViewTextBoxColumnSerPrecio, Tipo, dataGridViewImageColumnModificar, dataGridViewImageColumnEliminar });
            dataGridViewServicios.Dock = DockStyle.Fill;
            dataGridViewServicios.Location = new Point(0, 192);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewServicios.RowHeadersWidth = 51;
            dataGridViewServicios.Size = new Size(1375, 477);
            dataGridViewServicios.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumnSerNombre
            // 
            dataGridViewTextBoxColumnSerNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerNombre.HeaderText = "Nombre";
            dataGridViewTextBoxColumnSerNombre.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerNombre.Name = "dataGridViewTextBoxColumnSerNombre";
            dataGridViewTextBoxColumnSerNombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSerDescripcion
            // 
            dataGridViewTextBoxColumnSerDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerDescripcion.HeaderText = "Descripción";
            dataGridViewTextBoxColumnSerDescripcion.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerDescripcion.Name = "dataGridViewTextBoxColumnSerDescripcion";
            dataGridViewTextBoxColumnSerDescripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSerDuracion
            // 
            dataGridViewTextBoxColumnSerDuracion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnSerDuracion.HeaderText = "Duración";
            dataGridViewTextBoxColumnSerDuracion.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerDuracion.Name = "dataGridViewTextBoxColumnSerDuracion";
            dataGridViewTextBoxColumnSerDuracion.ReadOnly = true;
            dataGridViewTextBoxColumnSerDuracion.Width = 80;
            // 
            // dataGridViewTextBoxColumnSerPrecio
            // 
            dataGridViewTextBoxColumnSerPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnSerPrecio.HeaderText = "Precio";
            dataGridViewTextBoxColumnSerPrecio.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerPrecio.Name = "dataGridViewTextBoxColumnSerPrecio";
            dataGridViewTextBoxColumnSerPrecio.ReadOnly = true;
            dataGridViewTextBoxColumnSerPrecio.Width = 65;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 56;
            // 
            // dataGridViewImageColumnModificar
            // 
            dataGridViewImageColumnModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewImageColumnModificar.HeaderText = "Modificar";
            dataGridViewImageColumnModificar.Image = (Image)resources.GetObject("dataGridViewImageColumnModificar.Image");
            dataGridViewImageColumnModificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnModificar.MinimumWidth = 6;
            dataGridViewImageColumnModificar.Name = "dataGridViewImageColumnModificar";
            dataGridViewImageColumnModificar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnModificar.Width = 83;
            // 
            // dataGridViewImageColumnEliminar
            // 
            dataGridViewImageColumnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewImageColumnEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnEliminar.Image = (Image)resources.GetObject("dataGridViewImageColumnEliminar.Image");
            dataGridViewImageColumnEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnEliminar.MinimumWidth = 6;
            dataGridViewImageColumnEliminar.Name = "dataGridViewImageColumnEliminar";
            dataGridViewImageColumnEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnEliminar.Width = 75;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(75, 0);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(75, 30);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(0, 0);
            buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            buttonPaginacionAtras.Size = new Size(75, 30);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 669);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Size = new Size(1375, 30);
            panelPaginacion.TabIndex = 12;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 699);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1375, 69);
            panelEspaciado.TabIndex = 13;
            // 
            // PanelServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 768);
            Controls.Add(dataGridViewServicios);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualServicios);
            Name = "PanelServicios";
            Text = "PanelServicios";
            Load += PanelServicios_Load;
            panelVisualServicios.ResumeLayout(false);
            panelVisualServicios.PerformLayout();
            panelTipoSer.ResumeLayout(false);
            panelTipoSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTipoSer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).EndInit();
            panelPaginacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualServicios;
        private Panel panelTipoSer;
        private Label labelNumTipoSer;
        private Label labelTipoSer;
        private PictureBox pictureTipoSer;
        private TextBox textBoxSerBuscar;
        private Button anyadirServicio;
        private Panel panel1;
        private Label labelNumServicios;
        private Label labelServicios;
        private PictureBox pictureServicios;
        private ComboBox comboBoxSerFiltrar;
        private ComboBox comboBox1;
        private DataGridView dataGridViewServicios;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerNombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerDescripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerDuracion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerPrecio;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewImageColumn dataGridViewImageColumnModificar;
        private DataGridViewImageColumn dataGridViewImageColumnEliminar;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelPaginacion;
        private Panel panelEspaciado;
    }
}