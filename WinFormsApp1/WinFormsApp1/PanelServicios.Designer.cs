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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelServicios));
            panelVisualServicios = new Panel();
            comboBoxSerFiltrar = new ComboBox();
            panelTipoSer = new Panel();
            labelNumTipoSer = new Label();
            labelTipoSer = new Label();
            pictureTipoSer = new PictureBox();
            textBoxSerBuscar = new TextBox();
            anyadirServicio = new Button();
            panelVerServicios = new Panel();
            labelNumServicios = new Label();
            labelServicios = new Label();
            pictureServicios = new PictureBox();
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
            labelPaginaActual = new Label();
            panelEspaciado = new Panel();
            panelMargenes = new Panel();
            panelFiltros = new Panel();
            panelBotones = new Panel();
            anyadirHorario = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            comboBoxDia = new ComboBox();
            buttonTodos = new Button();
            panelHorarios = new Panel();
            labelNumHorarios = new Label();
            labelHorarios = new Label();
            pictureHorarios = new PictureBox();
            comboBoxGrupos = new ComboBox();
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
            panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).BeginInit();
            SuspendLayout();
            // 
            // panelVisualServicios
            // 
            panelVisualServicios.Controls.Add(comboBoxSerFiltrar);
            panelVisualServicios.Controls.Add(panelTipoSer);
            panelVisualServicios.Controls.Add(textBoxSerBuscar);
            panelVisualServicios.Controls.Add(anyadirServicio);
            panelVisualServicios.Controls.Add(panelVerServicios);
            panelVisualServicios.Dock = DockStyle.Top;
            panelVisualServicios.Location = new Point(0, 0);
            panelVisualServicios.Margin = new Padding(5, 4, 5, 4);
            panelVisualServicios.Name = "panelVisualServicios";
            panelVisualServicios.Padding = new Padding(17, 0, 0, 0);
            panelVisualServicios.Size = new Size(1571, 256);
            panelVisualServicios.TabIndex = 5;
            panelVisualServicios.Paint += panelVisualServicios_Paint;
            // 
            // comboBoxSerFiltrar
            // 
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSerFiltrar.DisplayMember = "1";
            comboBoxSerFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSerFiltrar.FlatStyle = FlatStyle.Flat;
            comboBoxSerFiltrar.Items.AddRange(new object[] { "" });
            comboBoxSerFiltrar.Location = new Point(1056, 185);
            comboBoxSerFiltrar.Margin = new Padding(5, 4, 5, 4);
            comboBoxSerFiltrar.Name = "comboBoxSerFiltrar";
            comboBoxSerFiltrar.Size = new Size(153, 28);
            comboBoxSerFiltrar.TabIndex = 6;
            comboBoxSerFiltrar.SelectedIndexChanged += comboBoxSerFiltrar_SelectedIndexChanged;
            // 
            // panelTipoSer
            // 
            panelTipoSer.BackColor = SystemColors.Control;
            panelTipoSer.BorderStyle = BorderStyle.FixedSingle;
            panelTipoSer.Controls.Add(labelNumTipoSer);
            panelTipoSer.Controls.Add(labelTipoSer);
            panelTipoSer.Controls.Add(pictureTipoSer);
            panelTipoSer.ForeColor = SystemColors.ControlDarkDark;
            panelTipoSer.Location = new Point(206, 17);
            panelTipoSer.Margin = new Padding(5, 4, 5, 4);
            panelTipoSer.Name = "panelTipoSer";
            panelTipoSer.Size = new Size(183, 113);
            panelTipoSer.TabIndex = 11;
            // 
            // labelNumTipoSer
            // 
            labelNumTipoSer.AutoSize = true;
            labelNumTipoSer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumTipoSer.ForeColor = SystemColors.ControlText;
            labelNumTipoSer.Location = new Point(66, 56);
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
            labelTipoSer.Location = new Point(18, 24);
            labelTipoSer.Margin = new Padding(5, 0, 5, 0);
            labelTipoSer.Name = "labelTipoSer";
            labelTipoSer.Size = new Size(138, 20);
            labelTipoSer.TabIndex = 0;
            labelTipoSer.Text = "Tipos de Servicio";
            // 
            // pictureTipoSer
            // 
            pictureTipoSer.Image = Properties.Resources.servicio;
            pictureTipoSer.Location = new Point(34, 53);
            pictureTipoSer.Margin = new Padding(5, 4, 5, 4);
            pictureTipoSer.Name = "pictureTipoSer";
            pictureTipoSer.Size = new Size(34, 40);
            pictureTipoSer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTipoSer.TabIndex = 1;
            pictureTipoSer.TabStop = false;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.BorderStyle = BorderStyle.None;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(34, 192);
            textBoxSerBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(947, 20);
            textBoxSerBuscar.TabIndex = 0;
            textBoxSerBuscar.TextChanged += textBoxSerBuscar_TextChanged;
            // 
            // anyadirServicio
            // 
            anyadirServicio.BackColor = Color.FromArgb(255, 128, 0);
            anyadirServicio.FlatStyle = FlatStyle.Flat;
            anyadirServicio.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            anyadirServicio.ForeColor = SystemColors.ControlLightLight;
            anyadirServicio.Location = new Point(1446, 175);
            anyadirServicio.Margin = new Padding(3, 4, 3, 4);
            anyadirServicio.Name = "anyadirServicio";
            anyadirServicio.Size = new Size(52, 55);
            anyadirServicio.TabIndex = 10;
            anyadirServicio.Text = "+";
            anyadirServicio.UseVisualStyleBackColor = false;
            anyadirServicio.Click += anyadirServicio_Click;
            // 
            // panelVerServicios
            // 
            panelVerServicios.BackColor = SystemColors.Control;
            panelVerServicios.BorderStyle = BorderStyle.FixedSingle;
            panelVerServicios.Controls.Add(labelNumServicios);
            panelVerServicios.Controls.Add(labelServicios);
            panelVerServicios.Controls.Add(pictureServicios);
            panelVerServicios.ForeColor = SystemColors.ControlDarkDark;
            panelVerServicios.Location = new Point(34, 17);
            panelVerServicios.Margin = new Padding(5, 4, 5, 4);
            panelVerServicios.Name = "panelVerServicios";
            panelVerServicios.Size = new Size(162, 113);
            panelVerServicios.TabIndex = 4;
            // 
            // labelNumServicios
            // 
            labelNumServicios.AutoSize = true;
            labelNumServicios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumServicios.ForeColor = SystemColors.ControlText;
            labelNumServicios.Location = new Point(66, 56);
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
            labelServicios.Location = new Point(18, 24);
            labelServicios.Margin = new Padding(5, 0, 5, 0);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(120, 20);
            labelServicios.TabIndex = 0;
            labelServicios.Text = "Total Servicios";
            // 
            // pictureServicios
            // 
            pictureServicios.Image = Properties.Resources.servicio;
            pictureServicios.Location = new Point(34, 53);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnSerNombre, dataGridViewTextBoxColumnSerDescripcion, dataGridViewTextBoxColumnSerDuracion, dataGridViewTextBoxColumnSerPrecio, Tipo, dataGridViewImageColumnModificar, dataGridViewImageColumnEliminar });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewServicios.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewServicios.Dock = DockStyle.Right;
            dataGridViewServicios.EnableHeadersVisualStyles = false;
            dataGridViewServicios.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewServicios.Location = new Point(437, 0);
            dataGridViewServicios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewServicios.RowHeadersVisible = false;
            dataGridViewServicios.RowHeadersWidth = 51;
            dataGridViewServicios.RowTemplate.Height = 35;
            dataGridViewServicios.Size = new Size(1100, 648);
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
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 91;
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
            dataGridViewImageColumnModificar.Width = 135;
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
            dataGridViewImageColumnEliminar.Width = 123;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(120, 0);
            buttonPaginacionDelante.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(86, 40);
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
            buttonPaginacionAtras.Size = new Size(86, 40);
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
            panelPaginacion.Location = new Point(0, 904);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 40);
            panelPaginacion.TabIndex = 12;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(777, 10);
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
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(34, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 648);
            panelMargenes.TabIndex = 14;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(panelBotones);
            panelFiltros.Controls.Add(comboBoxDia);
            panelFiltros.Controls.Add(buttonTodos);
            panelFiltros.Controls.Add(panelHorarios);
            panelFiltros.Controls.Add(comboBoxGrupos);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(26, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(411, 648);
            panelFiltros.TabIndex = 21;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(anyadirHorario);
            panelBotones.Controls.Add(buttonModificar);
            panelBotones.Controls.Add(buttonEliminar);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(351, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(4);
            panelBotones.Size = new Size(60, 648);
            panelBotones.TabIndex = 22;
            // 
            // anyadirHorario
            // 
            anyadirHorario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirHorario.Dock = DockStyle.Top;
            anyadirHorario.FlatAppearance.BorderSize = 0;
            anyadirHorario.FlatStyle = FlatStyle.Flat;
            anyadirHorario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyadirHorario.ForeColor = Color.White;
            anyadirHorario.Location = new Point(4, 114);
            anyadirHorario.Margin = new Padding(0, 5, 0, 0);
            anyadirHorario.Name = "anyadirHorario";
            anyadirHorario.Size = new Size(52, 55);
            anyadirHorario.TabIndex = 21;
            anyadirHorario.Text = "+";
            anyadirHorario.TextAlign = ContentAlignment.TopRight;
            anyadirHorario.UseVisualStyleBackColor = false;
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
            // 
            // comboBoxDia
            // 
            comboBoxDia.DisplayMember = "1";
            comboBoxDia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDia.FlatStyle = FlatStyle.Flat;
            comboBoxDia.Items.AddRange(new object[] { "Todos los dias de la semana", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
            comboBoxDia.Location = new Point(40, 440);
            comboBoxDia.Margin = new Padding(6, 5, 6, 5);
            comboBoxDia.Name = "comboBoxDia";
            comboBoxDia.Size = new Size(282, 28);
            comboBoxDia.TabIndex = 21;
            // 
            // buttonTodos
            // 
            buttonTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(40, 490);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(282, 32);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todos los horarios";
            buttonTodos.UseVisualStyleBackColor = true;
            // 
            // panelHorarios
            // 
            panelHorarios.BackColor = SystemColors.Control;
            panelHorarios.BorderStyle = BorderStyle.FixedSingle;
            panelHorarios.Controls.Add(labelNumHorarios);
            panelHorarios.Controls.Add(labelHorarios);
            panelHorarios.Controls.Add(pictureHorarios);
            panelHorarios.ForeColor = SystemColors.ControlDarkDark;
            panelHorarios.Location = new Point(98, 600);
            panelHorarios.Margin = new Padding(5, 4, 5, 4);
            panelHorarios.Name = "panelHorarios";
            panelHorarios.Size = new Size(162, 110);
            panelHorarios.TabIndex = 4;
            // 
            // labelNumHorarios
            // 
            labelNumHorarios.AutoSize = true;
            labelNumHorarios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumHorarios.ForeColor = SystemColors.ControlText;
            labelNumHorarios.Location = new Point(66, 56);
            labelNumHorarios.Margin = new Padding(5, 0, 5, 0);
            labelNumHorarios.Name = "labelNumHorarios";
            labelNumHorarios.Size = new Size(27, 29);
            labelNumHorarios.TabIndex = 2;
            labelNumHorarios.Text = "2";
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHorarios.Location = new Point(18, 24);
            labelHorarios.Margin = new Padding(5, 0, 5, 0);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(116, 20);
            labelHorarios.TabIndex = 0;
            labelHorarios.Text = "Total Horarios";
            // 
            // pictureHorarios
            // 
            pictureHorarios.Image = Properties.Resources.Usuario_gris;
            pictureHorarios.Location = new Point(23, 44);
            pictureHorarios.Margin = new Padding(5, 4, 5, 4);
            pictureHorarios.Name = "pictureHorarios";
            pictureHorarios.Size = new Size(43, 51);
            pictureHorarios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHorarios.TabIndex = 1;
            pictureHorarios.TabStop = false;
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.DisplayMember = "1";
            comboBoxGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupos.FlatStyle = FlatStyle.Flat;
            comboBoxGrupos.Location = new Point(40, 390);
            comboBoxGrupos.Margin = new Padding(6, 5, 6, 5);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(282, 28);
            comboBoxGrupos.TabIndex = 20;
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
            panelHorarios.ResumeLayout(false);
            panelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).EndInit();
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
        private ComboBox comboBoxSerFiltrar;
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
        private Panel panelMargenes;
        private Label labelPaginaActual;
        private Panel panelFiltros;
        private Panel panelBotones;
        private Button anyadirHorario;
        private Button buttonModificar;
        private Button buttonEliminar;
        private ComboBox comboBoxDia;
        private Button buttonTodos;
        private Panel panelHorarios;
        private Label labelNumHorarios;
        private Label labelHorarios;
        private PictureBox pictureHorarios;
        private ComboBox comboBoxGrupos;
    }
}