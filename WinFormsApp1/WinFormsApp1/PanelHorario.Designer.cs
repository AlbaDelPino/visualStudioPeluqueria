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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelVisualHorarios = new Panel();
            anyadirHorario = new Button();
            comboBoxHorario = new ComboBox();
            textBoxHorarioBuscar = new TextBox();
            anyadirUsuario = new Button();
            label1 = new Label();
            panelHorarios = new Panel();
            labelNumHorarios = new Label();
            labelHorarios = new Label();
            pictureHorarios = new PictureBox();
            dataGridViewHorarios = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panelMargenes = new Panel();
            buttonTodos = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            monthCalendarFiltrar = new WinFormsApp1.PanelPrincipal.MyMonthCalendar();
            panel1 = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panel2 = new Panel();
            panelVisualHorarios.SuspendLayout();
            panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).BeginInit();
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
            panelVisualHorarios.Controls.Add(panelHorarios);
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
            textBoxHorarioBuscar.PlaceholderText = "Buscar por grupo o servicio...";
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
            // panelHorarios
            // 
            panelHorarios.BackColor = SystemColors.Control;
            panelHorarios.BorderStyle = BorderStyle.FixedSingle;
            panelHorarios.Controls.Add(labelNumHorarios);
            panelHorarios.Controls.Add(labelHorarios);
            panelHorarios.Controls.Add(pictureHorarios);
            panelHorarios.ForeColor = SystemColors.ControlDarkDark;
            panelHorarios.Location = new Point(34, 19);
            panelHorarios.Margin = new Padding(5, 4, 5, 4);
            panelHorarios.Name = "panelHorarios";
            panelHorarios.Size = new Size(162, 113);
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
            dataGridViewHorarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Servicio, Grupo, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewHorarios.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewHorarios.Dock = DockStyle.Left;
            dataGridViewHorarios.EnableHeadersVisualStyles = false;
            dataGridViewHorarios.GridColor = Color.Black;
            dataGridViewHorarios.ImeMode = ImeMode.NoControl;
            dataGridViewHorarios.Location = new Point(30, 0);
            dataGridViewHorarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHorarios.MultiSelect = false;
            dataGridViewHorarios.Name = "dataGridViewHorarios";
            dataGridViewHorarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewHorarios.RowHeadersVisible = false;
            dataGridViewHorarios.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewHorarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewHorarios.RowTemplate.Height = 35;
            dataGridViewHorarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewHorarios.Size = new Size(1000, 657);
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
            dataGridViewTextBoxColumn1.HeaderText = "Incio";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn3.HeaderText = "Fin";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 79;
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
            dataGridViewTextBoxColumn4.HeaderText = "Plazas";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 107;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(buttonTodos);
            panelMargenes.Controls.Add(buttonModificar);
            panelMargenes.Controls.Add(buttonEliminar);
            panelMargenes.Controls.Add(monthCalendarFiltrar);
            panelMargenes.Controls.Add(dataGridViewHorarios);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1571, 657);
            panelMargenes.TabIndex = 18;
            // 
            // buttonTodos
            // 
            buttonTodos.Location = new Point(1165, 402);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(346, 29);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todos los horarios";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackgroundImage = Properties.Resources.edit;
            buttonModificar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonModificar.Location = new Point(1059, 80);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(55, 55);
            buttonModificar.TabIndex = 21;
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackgroundImage = Properties.Resources.trash;
            buttonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEliminar.Location = new Point(1059, 7);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(55, 55);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendarFiltrar.Location = new Point(1165, 13);
            monthCalendarFiltrar.MaxSelectionCount = 31;
            monthCalendarFiltrar.Name = "monthCalendarFiltrar";
            monthCalendarFiltrar.RightToLeft = RightToLeft.Yes;
            monthCalendarFiltrar.ShowToday = false;
            monthCalendarFiltrar.TabIndex = 19;
            monthCalendarFiltrar.TitleBackColor = Color.DarkOrange;
            monthCalendarFiltrar.TrailingForeColor = SystemColors.ButtonShadow;
            monthCalendarFiltrar.DateChanged += monthCalendarFiltrar_DateChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPaginaActual);
            panel1.Controls.Add(buttonPaginacionDelante);
            panel1.Controls.Add(buttonPaginacionAtras);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 913);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(34, 0, 0, 0);
            panel1.Size = new Size(1571, 43);
            panel1.TabIndex = 18;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(226, 11);
            labelPaginaActual.Name = "labelPaginaActual";
            labelPaginaActual.Size = new Size(17, 20);
            labelPaginaActual.TabIndex = 3;
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
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 956);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1571, 68);
            panel2.TabIndex = 17;
            // 
            // PanelHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelVisualHorarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelHorario";
            Text = "PanelHorario";
            Load += PanelHorario_Load;
            Resize += PanelHorario_Resize;
            panelVisualHorarios.ResumeLayout(false);
            panelVisualHorarios.PerformLayout();
            panelHorarios.ResumeLayout(false);
            panelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHorarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorarios).EndInit();
            panelMargenes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelVisualHorarios;
        private Button anyadirUsuario;
        private Label label1;
        private Panel panelHorarios;
        private Label labelNumHorarios;
        private Label labelHorarios;
        private PictureBox pictureHorarios;
        private DataGridView dataGridViewHorarios;
        private Button anyadirHorario;
        private ComboBox comboBoxHorario;
        private TextBox textBoxHorarioBuscar;
        private Panel panelMargenes;
        private Panel panel1;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panel2;
        private Button buttonModificar;
        private Button buttonEliminar;
        private PanelPrincipal.MyMonthCalendar monthCalendarFiltrar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label labelPaginaActual;
        private Button buttonTodos;
    }
}