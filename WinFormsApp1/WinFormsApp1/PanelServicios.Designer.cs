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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelVisualServicios = new Panel();
            textBoxSerBuscar = new TextBox();
            panelTipoSer = new Panel();
            labelNumTipoSer = new Label();
            labelTipoSer = new Label();
            pictureTipoSer = new PictureBox();
            panelVerServicios = new Panel();
            labelNumServicios = new Label();
            labelServicios = new Label();
            pictureServicios = new PictureBox();
            dataGridViewServicios = new DataGridView();
            dataGridViewTextBoxColumnSerNombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerDescripcion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerDuracion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerPrecio = new DataGridViewTextBoxColumn();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            panelEspaciado = new Panel();
            panelMargenes = new Panel();
            panelFiltros = new Panel();
            panelBotones = new Panel();
            anyadirServicio = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonTodos = new Button();
            comboBoxTipo = new ComboBox();
            panelVisualServicios.SuspendLayout();
            panelTipoSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTipoSer).BeginInit();
            panelVerServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            panelPaginacion.SuspendLayout();
            panelMargenes.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualServicios
            // 
            panelVisualServicios.Controls.Add(textBoxSerBuscar);
            panelVisualServicios.Dock = DockStyle.Top;
            panelVisualServicios.Location = new Point(0, 0);
            panelVisualServicios.Margin = new Padding(5, 4, 5, 4);
            panelVisualServicios.Name = "panelVisualServicios";
            panelVisualServicios.Padding = new Padding(17, 0, 0, 0);
            panelVisualServicios.Size = new Size(1571, 100);
            panelVisualServicios.TabIndex = 5;
            panelVisualServicios.Paint += panelVisualServicios_Paint;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.BorderStyle = BorderStyle.None;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(441, 49);
            textBoxSerBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(947, 20);
            textBoxSerBuscar.TabIndex = 0;
            textBoxSerBuscar.TextChanged += textBoxSerBuscar_TextChanged;
            // 
            // panelTipoSer
            // 
            panelTipoSer.BackColor = SystemColors.Control;
            panelTipoSer.BorderStyle = BorderStyle.FixedSingle;
            panelTipoSer.Controls.Add(labelNumTipoSer);
            panelTipoSer.Controls.Add(labelTipoSer);
            panelTipoSer.Controls.Add(pictureTipoSer);
            panelTipoSer.ForeColor = SystemColors.ControlDarkDark;
            panelTipoSer.Location = new Point(85, 540);
            panelTipoSer.Margin = new Padding(5, 4, 5, 4);
            panelTipoSer.Name = "panelTipoSer";
            panelTipoSer.Size = new Size(180, 110);
            panelTipoSer.TabIndex = 11;
            // 
            // labelNumTipoSer
            // 
            labelNumTipoSer.AutoSize = true;
            labelNumTipoSer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumTipoSer.ForeColor = SystemColors.ControlText;
            labelNumTipoSer.Location = new Point(70, 55);
            labelNumTipoSer.Margin = new Padding(5, 0, 5, 0);
            labelNumTipoSer.Name = "labelNumTipoSer";
            labelNumTipoSer.Size = new Size(27, 29);
            labelNumTipoSer.TabIndex = 2;
            labelNumTipoSer.Text = "0";
            // 
            // labelTipoSer
            // 
            labelTipoSer.AutoSize = true;
            labelTipoSer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipoSer.Location = new Point(20, 25);
            labelTipoSer.Margin = new Padding(5, 0, 5, 0);
            labelTipoSer.Name = "labelTipoSer";
            labelTipoSer.Size = new Size(138, 20);
            labelTipoSer.TabIndex = 0;
            labelTipoSer.Text = "Tipos de Servicio";
            // 
            // pictureTipoSer
            // 
            pictureTipoSer.Image = Properties.Resources.servicio;
            pictureTipoSer.Location = new Point(35, 50);
            pictureTipoSer.Margin = new Padding(5, 4, 5, 4);
            pictureTipoSer.Name = "pictureTipoSer";
            pictureTipoSer.Size = new Size(34, 40);
            pictureTipoSer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTipoSer.TabIndex = 1;
            pictureTipoSer.TabStop = false;
            // 
            // panelVerServicios
            // 
            panelVerServicios.BackColor = SystemColors.Control;
            panelVerServicios.BorderStyle = BorderStyle.FixedSingle;
            panelVerServicios.Controls.Add(labelNumServicios);
            panelVerServicios.Controls.Add(labelServicios);
            panelVerServicios.Controls.Add(pictureServicios);
            panelVerServicios.ForeColor = SystemColors.ControlDarkDark;
            panelVerServicios.Location = new Point(85, 660);
            panelVerServicios.Margin = new Padding(5, 4, 5, 4);
            panelVerServicios.Name = "panelVerServicios";
            panelVerServicios.Size = new Size(180, 110);
            panelVerServicios.TabIndex = 4;
            // 
            // labelNumServicios
            // 
            labelNumServicios.AutoSize = true;
            labelNumServicios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumServicios.ForeColor = SystemColors.ControlText;
            labelNumServicios.Location = new Point(70, 55);
            labelNumServicios.Margin = new Padding(5, 0, 5, 0);
            labelNumServicios.Name = "labelNumServicios";
            labelNumServicios.Size = new Size(27, 29);
            labelNumServicios.TabIndex = 2;
            labelNumServicios.Text = "0";
            // 
            // labelServicios
            // 
            labelServicios.AutoSize = true;
            labelServicios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelServicios.Location = new Point(20, 25);
            labelServicios.Margin = new Padding(5, 0, 5, 0);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(120, 20);
            labelServicios.TabIndex = 0;
            labelServicios.Text = "Total Servicios";
            // 
            // pictureServicios
            // 
            pictureServicios.Image = Properties.Resources.servicio;
            pictureServicios.Location = new Point(35, 50);
            pictureServicios.Margin = new Padding(5, 4, 5, 4);
            pictureServicios.Name = "pictureServicios";
            pictureServicios.Size = new Size(34, 40);
            pictureServicios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureServicios.TabIndex = 1;
            pictureServicios.TabStop = false;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicios.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewServicios.BorderStyle = BorderStyle.None;
            dataGridViewServicios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnSerNombre, Tipo, dataGridViewTextBoxColumnSerDescripcion, dataGridViewTextBoxColumnSerDuracion, dataGridViewTextBoxColumnSerPrecio });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewServicios.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewServicios.Dock = DockStyle.Right;
            dataGridViewServicios.EnableHeadersVisualStyles = false;
            dataGridViewServicios.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewServicios.Location = new Point(437, 0);
            dataGridViewServicios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewServicios.RowHeadersVisible = false;
            dataGridViewServicios.RowHeadersWidth = 51;
            dataGridViewServicios.RowTemplate.Height = 35;
            dataGridViewServicios.Size = new Size(1100, 801);
            dataGridViewServicios.TabIndex = 11;
            dataGridViewServicios.CellContentClick += dataGridViewServicios_CellContentClick;
            // 
            // dataGridViewTextBoxColumnSerNombre
            // 
            dataGridViewTextBoxColumnSerNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerNombre.FillWeight = 100.10363F;
            dataGridViewTextBoxColumnSerNombre.HeaderText = "Nombre";
            dataGridViewTextBoxColumnSerNombre.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerNombre.Name = "dataGridViewTextBoxColumnSerNombre";
            dataGridViewTextBoxColumnSerNombre.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 91;
            // 
            // dataGridViewTextBoxColumnSerDescripcion
            // 
            dataGridViewTextBoxColumnSerDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerDescripcion.FillWeight = 99.89638F;
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
            dataGridViewTextBoxColumnSerDuracion.Width = 131;
            // 
            // dataGridViewTextBoxColumnSerPrecio
            // 
            dataGridViewTextBoxColumnSerPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnSerPrecio.HeaderText = "Precio";
            dataGridViewTextBoxColumnSerPrecio.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerPrecio.Name = "dataGridViewTextBoxColumnSerPrecio";
            dataGridViewTextBoxColumnSerPrecio.ReadOnly = true;
            dataGridViewTextBoxColumnSerPrecio.Width = 107;
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
            panelPaginacion.TabIndex = 12;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(212, 11);
            labelPaginaActual.Name = "labelPaginaActual";
            labelPaginaActual.Size = new Size(17, 20);
            labelPaginaActual.TabIndex = 5;
            labelPaginaActual.Text = "1";
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 944);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 80);
            panelEspaciado.TabIndex = 13;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(panelFiltros);
            panelMargenes.Controls.Add(dataGridViewServicios);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 100);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(34, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 801);
            panelMargenes.TabIndex = 14;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(panelBotones);
            panelFiltros.Controls.Add(panelTipoSer);
            panelFiltros.Controls.Add(buttonTodos);
            panelFiltros.Controls.Add(panelVerServicios);
            panelFiltros.Controls.Add(comboBoxTipo);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(27, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(410, 801);
            panelFiltros.TabIndex = 21;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(anyadirServicio);
            panelBotones.Controls.Add(buttonModificar);
            panelBotones.Controls.Add(buttonEliminar);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(350, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(4);
            panelBotones.Size = new Size(60, 801);
            panelBotones.TabIndex = 22;
            // 
            // anyadirServicio
            // 
            anyadirServicio.BackColor = Color.FromArgb(255, 128, 0);
            anyadirServicio.Dock = DockStyle.Top;
            anyadirServicio.FlatAppearance.BorderSize = 0;
            anyadirServicio.FlatStyle = FlatStyle.Flat;
            anyadirServicio.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyadirServicio.ForeColor = Color.White;
            anyadirServicio.Location = new Point(4, 114);
            anyadirServicio.Margin = new Padding(0, 5, 0, 0);
            anyadirServicio.Name = "anyadirServicio";
            anyadirServicio.Size = new Size(52, 55);
            anyadirServicio.TabIndex = 21;
            anyadirServicio.Text = "+";
            anyadirServicio.TextAlign = ContentAlignment.TopRight;
            anyadirServicio.UseVisualStyleBackColor = false;
            anyadirServicio.Click += anyadirServicio_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackgroundImage = Properties.Resources.edit;
            buttonModificar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonModificar.Dock = DockStyle.Top;
            buttonModificar.Location = new Point(4, 59);
            buttonModificar.Margin = new Padding(0);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Padding = new Padding(0, 8, 0, 0);
            buttonModificar.Size = new Size(52, 55);
            buttonModificar.TabIndex = 21;
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackgroundImage = Properties.Resources.trash;
            buttonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEliminar.Dock = DockStyle.Top;
            buttonEliminar.Location = new Point(4, 4);
            buttonEliminar.Margin = new Padding(0);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Padding = new Padding(0, 0, 0, 8);
            buttonEliminar.Size = new Size(52, 55);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonTodos
            // 
            buttonTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(40, 70);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(280, 35);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todos los servicios";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DisplayMember = "1";
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FlatStyle = FlatStyle.Flat;
            comboBoxTipo.Location = new Point(40, 20);
            comboBoxTipo.Margin = new Padding(6, 5, 6, 5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(280, 28);
            comboBoxTipo.TabIndex = 20;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // PanelServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualServicios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelServicios";
            Text = "PanelServicios";
            Load += PanelServicios_Load;
            Resize += PanelServicios_Resize;
            panelVisualServicios.ResumeLayout(false);
            panelVisualServicios.PerformLayout();
            panelTipoSer.ResumeLayout(false);
            panelTipoSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTipoSer).EndInit();
            panelVerServicios.ResumeLayout(false);
            panelVerServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            panelMargenes.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
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
        private Panel panelVerServicios;
        private Label labelNumServicios;
        private Label labelServicios;
        private PictureBox pictureServicios;
        private DataGridView dataGridViewServicios;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelPaginacion;
        private Panel panelEspaciado;
        private Panel panelMargenes;
        private Label labelPaginaActual;
        private Panel panelFiltros;
        private Panel panelBotones;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonTodos;
        private ComboBox comboBoxTipo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerNombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerDescripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerDuracion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerPrecio;
    }
}