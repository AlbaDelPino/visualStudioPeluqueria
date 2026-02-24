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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelVisualUsuarios = new Panel();
            textBoxSUsBuscar = new TextBox();
            panelCliente = new Panel();
            pictureCliente = new PictureBox();
            labelNumClientes = new Label();
            labelCliente = new Label();
            panelUsuarios = new Panel();
            labelNumUsuarios = new Label();
            labelUsuarios = new Label();
            pictureUsuarios = new PictureBox();
            dataGridViewUsuarios = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelMargenes = new Panel();
            panelFiltros = new Panel();
            panelBotones = new Panel();
            anyadirUsuario = new Button();
            buttonHistorial = new Button();
            buttonInfo = new Button();
            buttonEliminar = new Button();
            comboBoxRol = new ComboBox();
            buttonTodos = new Button();
            comboBoxEstado = new ComboBox();
            panelVisualUsuarios.SuspendLayout();
            panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCliente).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelPaginacion.SuspendLayout();
            panelMargenes.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualUsuarios
            // 
            panelVisualUsuarios.Controls.Add(textBoxSUsBuscar);
            panelVisualUsuarios.Dock = DockStyle.Top;
            panelVisualUsuarios.ForeColor = Color.FromArgb(255, 128, 0);
            panelVisualUsuarios.Location = new Point(0, 0);
            panelVisualUsuarios.Margin = new Padding(5, 4, 5, 4);
            panelVisualUsuarios.Name = "panelVisualUsuarios";
            panelVisualUsuarios.Padding = new Padding(17, 0, 0, 0);
            panelVisualUsuarios.Size = new Size(1571, 100);
            panelVisualUsuarios.TabIndex = 5;
            panelVisualUsuarios.Paint += panelVisualUsuarios_Paint;
            // 
            // textBoxSUsBuscar
            // 
            textBoxSUsBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSUsBuscar.BorderStyle = BorderStyle.None;
            textBoxSUsBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSUsBuscar.Location = new Point(441, 49);
            textBoxSUsBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSUsBuscar.Name = "textBoxSUsBuscar";
            textBoxSUsBuscar.PlaceholderText = "Buscar por nombre o usuario...";
            textBoxSUsBuscar.Size = new Size(947, 20);
            textBoxSUsBuscar.TabIndex = 12;
            textBoxSUsBuscar.TextChanged += textBoxSUsBuscar_TextChanged;
            // 
            // panelCliente
            // 
            panelCliente.BackColor = SystemColors.Control;
            panelCliente.BorderStyle = BorderStyle.FixedSingle;
            panelCliente.Controls.Add(pictureCliente);
            panelCliente.Controls.Add(labelNumClientes);
            panelCliente.Controls.Add(labelCliente);
            panelCliente.ForeColor = SystemColors.ControlDarkDark;
            panelCliente.Location = new Point(82, 656);
            panelCliente.Margin = new Padding(5, 4, 5, 4);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(180, 110);
            panelCliente.TabIndex = 5;
            // 
            // pictureCliente
            // 
            pictureCliente.Image = Properties.Resources.Usuario;
            pictureCliente.Location = new Point(30, 50);
            pictureCliente.Margin = new Padding(5, 4, 5, 4);
            pictureCliente.Name = "pictureCliente";
            pictureCliente.Size = new Size(43, 51);
            pictureCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCliente.TabIndex = 3;
            pictureCliente.TabStop = false;
            // 
            // labelNumClientes
            // 
            labelNumClientes.AutoSize = true;
            labelNumClientes.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumClientes.ForeColor = SystemColors.ControlText;
            labelNumClientes.Location = new Point(70, 55);
            labelNumClientes.Margin = new Padding(5, 0, 5, 0);
            labelNumClientes.Name = "labelNumClientes";
            labelNumClientes.Size = new Size(27, 29);
            labelNumClientes.TabIndex = 2;
            labelNumClientes.Text = "0";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCliente.Location = new Point(20, 25);
            labelCliente.Margin = new Padding(5, 0, 5, 0);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(109, 20);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Total clientes";
            // 
            // panelUsuarios
            // 
            panelUsuarios.BackColor = SystemColors.Control;
            panelUsuarios.BorderStyle = BorderStyle.FixedSingle;
            panelUsuarios.Controls.Add(labelNumUsuarios);
            panelUsuarios.Controls.Add(labelUsuarios);
            panelUsuarios.Controls.Add(pictureUsuarios);
            panelUsuarios.ForeColor = SystemColors.ControlDarkDark;
            panelUsuarios.Location = new Point(82, 535);
            panelUsuarios.Margin = new Padding(5, 4, 5, 4);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(180, 110);
            panelUsuarios.TabIndex = 4;
            // 
            // labelNumUsuarios
            // 
            labelNumUsuarios.AutoSize = true;
            labelNumUsuarios.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumUsuarios.ForeColor = SystemColors.ControlText;
            labelNumUsuarios.Location = new Point(70, 55);
            labelNumUsuarios.Margin = new Padding(5, 0, 5, 0);
            labelNumUsuarios.Name = "labelNumUsuarios";
            labelNumUsuarios.Size = new Size(27, 29);
            labelNumUsuarios.TabIndex = 2;
            labelNumUsuarios.Text = "0";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuarios.Location = new Point(20, 25);
            labelUsuarios.Margin = new Padding(5, 0, 5, 0);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(115, 20);
            labelUsuarios.TabIndex = 0;
            labelUsuarios.Text = "Total usuarios";
            // 
            // pictureUsuarios
            // 
            pictureUsuarios.Image = Properties.Resources.Usuario_gris;
            pictureUsuarios.Location = new Point(30, 50);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUsuarios.Dock = DockStyle.Right;
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = Color.Black;
            dataGridViewUsuarios.ImeMode = ImeMode.NoControl;
            dataGridViewUsuarios.Location = new Point(437, 0);
            dataGridViewUsuarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewUsuarios.RowTemplate.Height = 35;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewUsuarios.Size = new Size(1100, 801);
            dataGridViewUsuarios.TabIndex = 9;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn2.HeaderText = "Usuario";
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
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 944);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 80);
            panelEspaciado.TabIndex = 14;
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
            panelPaginacion.TabIndex = 15;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(212, 11);
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
            panelMargenes.Controls.Add(panelFiltros);
            panelMargenes.Controls.Add(dataGridViewUsuarios);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 100);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(34, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 801);
            panelMargenes.TabIndex = 16;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(panelBotones);
            panelFiltros.Controls.Add(comboBoxRol);
            panelFiltros.Controls.Add(buttonTodos);
            panelFiltros.Controls.Add(comboBoxEstado);
            panelFiltros.Controls.Add(panelCliente);
            panelFiltros.Controls.Add(panelUsuarios);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(26, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(411, 801);
            panelFiltros.TabIndex = 21;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(anyadirUsuario);
            panelBotones.Controls.Add(buttonHistorial);
            panelBotones.Controls.Add(buttonInfo);
            panelBotones.Controls.Add(buttonEliminar);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(351, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(4);
            panelBotones.Size = new Size(60, 801);
            panelBotones.TabIndex = 22;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.Dock = DockStyle.Top;
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Location = new Point(4, 169);
            anyadirUsuario.Margin = new Padding(0, 5, 0, 0);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(52, 55);
            anyadirUsuario.TabIndex = 21;
            anyadirUsuario.Text = "+";
            anyadirUsuario.TextAlign = ContentAlignment.TopRight;
            anyadirUsuario.UseVisualStyleBackColor = false;
            anyadirUsuario.Click += anyadirUsuario_Click;
            // 
            // buttonHistorial
            // 
            buttonHistorial.BackgroundImage = Properties.Resources.clock;
            buttonHistorial.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHistorial.Dock = DockStyle.Top;
            buttonHistorial.Location = new Point(4, 114);
            buttonHistorial.Margin = new Padding(0);
            buttonHistorial.Name = "buttonHistorial";
            buttonHistorial.Padding = new Padding(0, 8, 0, 0);
            buttonHistorial.Size = new Size(52, 55);
            buttonHistorial.TabIndex = 22;
            buttonHistorial.UseVisualStyleBackColor = true;
            buttonHistorial.Click += buttonHistorial_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackgroundImage = Properties.Resources.info;
            buttonInfo.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo.Dock = DockStyle.Top;
            buttonInfo.Location = new Point(4, 59);
            buttonInfo.Margin = new Padding(0);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Padding = new Padding(0, 8, 0, 0);
            buttonInfo.Size = new Size(52, 55);
            buttonInfo.TabIndex = 21;
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
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
            // comboBoxRol
            // 
            comboBoxRol.DisplayMember = "1";
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.Items.AddRange(new object[] { "Todos los roles", "Clientes", "Grupos", "Administradores" });
            comboBoxRol.Location = new Point(40, 70);
            comboBoxRol.Margin = new Padding(6, 5, 6, 5);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(280, 28);
            comboBoxRol.TabIndex = 21;
            comboBoxRol.SelectedIndexChanged += comboBoxRol_SelectedIndexChanged;
            // 
            // buttonTodos
            // 
            buttonTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(40, 120);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(280, 35);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todos los usuarios";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DisplayMember = "1";
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FlatStyle = FlatStyle.Flat;
            comboBoxEstado.Items.AddRange(new object[] { "Todos los usuarios", "Activos", "Inactivos" });
            comboBoxEstado.Location = new Point(40, 20);
            comboBoxEstado.Margin = new Padding(6, 5, 6, 5);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(280, 28);
            comboBoxEstado.TabIndex = 20;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
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
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCliente).EndInit();
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            panelMargenes.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualUsuarios;
        private Panel panelCliente;
        private PictureBox pictureCliente;
        private Label labelNumClientes;
        private Label labelCliente;
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
        private Label labelPaginaActual;
        private Panel panelFiltros;
        private Panel panelBotones;
        private Button anyadirUsuario;
        private Button buttonInfo;
        private Button buttonEliminar;
        private ComboBox comboBoxRol;
        private Button buttonTodos;
        private ComboBox comboBoxEstado;
        private Button buttonHistorial;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}