namespace WinFormsApp1
{
    partial class Horario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horario));
            labelHoServicio = new Label();
            labelHoGrupo = new Label();
            textBoxHoServicio = new WinFormsApp1.Usuario.RoundedTextBox();
            textBoxHoGrupo = new WinFormsApp1.Usuario.RoundedTextBox();
            buttonHoServicio = new Button();
            buttonHoGrupo = new Button();
            labelHoHorarioInicio = new Label();
            label1 = new Label();
            dateTimePickerHoaraInicio = new DateTimePicker();
            dateTimePickerHoraFin = new DateTimePicker();
            labelPlaza = new Label();
            labelHoDiaSemana = new Label();
            comboBoxDiaSemana = new ComboBox();
            buttonGuardar = new WinFormsApp1.Bloqueo.RoundedButton();
            labelTituloCrearHorario = new Label();
            labelTituoModificarHorario = new Label();
            buttonModificar = new WinFormsApp1.Bloqueo.RoundedButton();
            numericPlazas = new NumericUpDown();
            panelIcon = new Panel();
            pictureBoxICon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericPlazas).BeginInit();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // labelHoServicio
            // 
            labelHoServicio.AutoSize = true;
            labelHoServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoServicio.Location = new Point(269, 184);
            labelHoServicio.Margin = new Padding(6, 0, 6, 0);
            labelHoServicio.Name = "labelHoServicio";
            labelHoServicio.Size = new Size(69, 20);
            labelHoServicio.TabIndex = 74;
            labelHoServicio.Text = "Servicio";
            // 
            // labelHoGrupo
            // 
            labelHoGrupo.AutoSize = true;
            labelHoGrupo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoGrupo.Location = new Point(269, 249);
            labelHoGrupo.Margin = new Padding(6, 0, 6, 0);
            labelHoGrupo.Name = "labelHoGrupo";
            labelHoGrupo.Size = new Size(55, 20);
            labelHoGrupo.TabIndex = 76;
            labelHoGrupo.Text = "Grupo";
            // 
            // textBoxHoServicio
            // 
            textBoxHoServicio.BackColor = SystemColors.Control;
            textBoxHoServicio.BorderColor = SystemColors.ControlDarkDark;
            textBoxHoServicio.BorderRadius = 10;
            textBoxHoServicio.BorderSize = 1;
            textBoxHoServicio.Location = new Point(447, 184);
            textBoxHoServicio.Margin = new Padding(3, 4, 3, 4);
            textBoxHoServicio.Name = "textBoxHoServicio";
            textBoxHoServicio.PasswordChar = '\0';
            textBoxHoServicio.ReadOnly = true;
            textBoxHoServicio.Size = new Size(114, 31);
            textBoxHoServicio.TabIndex = 77;
            // 
            // textBoxHoGrupo
            // 
            textBoxHoGrupo.BackColor = SystemColors.Control;
            textBoxHoGrupo.BorderColor = SystemColors.ControlDarkDark;
            textBoxHoGrupo.BorderRadius = 10;
            textBoxHoGrupo.BorderSize = 1;
            textBoxHoGrupo.Location = new Point(447, 249);
            textBoxHoGrupo.Margin = new Padding(3, 4, 3, 4);
            textBoxHoGrupo.Name = "textBoxHoGrupo";
            textBoxHoGrupo.PasswordChar = '\0';
            textBoxHoGrupo.ReadOnly = true;
            textBoxHoGrupo.Size = new Size(114, 31);
            textBoxHoGrupo.TabIndex = 78;
            // 
            // buttonHoServicio
            // 
            buttonHoServicio.Location = new Point(574, 184);
            buttonHoServicio.Margin = new Padding(3, 4, 3, 4);
            buttonHoServicio.Name = "buttonHoServicio";
            buttonHoServicio.Size = new Size(50, 31);
            buttonHoServicio.TabIndex = 79;
            buttonHoServicio.UseVisualStyleBackColor = true;
            buttonHoServicio.Click += buttonHoServicio_Click;
            buttonHoServicio.Paint += buttonHoServicio_Paint;
            // 
            // buttonHoGrupo
            // 
            buttonHoGrupo.Location = new Point(574, 249);
            buttonHoGrupo.Margin = new Padding(3, 4, 3, 4);
            buttonHoGrupo.Name = "buttonHoGrupo";
            buttonHoGrupo.Size = new Size(50, 31);
            buttonHoGrupo.TabIndex = 80;
            buttonHoGrupo.UseVisualStyleBackColor = true;
            buttonHoGrupo.Click += buttonHoGrupo_Click;
            buttonHoGrupo.Paint += buttonHoBrupo_Paint;
            // 
            // labelHoHorarioInicio
            // 
            labelHoHorarioInicio.AutoSize = true;
            labelHoHorarioInicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoHorarioInicio.Location = new Point(269, 321);
            labelHoHorarioInicio.Margin = new Padding(6, 0, 6, 0);
            labelHoHorarioInicio.Name = "labelHoHorarioInicio";
            labelHoHorarioInicio.Size = new Size(109, 20);
            labelHoHorarioInicio.TabIndex = 81;
            labelHoHorarioInicio.Text = "Horario inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 365);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 82;
            label1.Text = "Horario fin";
            // 
            // dateTimePickerHoaraInicio
            // 
            dateTimePickerHoaraInicio.Location = new Point(447, 313);
            dateTimePickerHoaraInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHoaraInicio.Name = "dateTimePickerHoaraInicio";
            dateTimePickerHoaraInicio.Size = new Size(177, 27);
            dateTimePickerHoaraInicio.TabIndex = 83;
            // 
            // dateTimePickerHoraFin
            // 
            dateTimePickerHoraFin.Location = new Point(447, 365);
            dateTimePickerHoraFin.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            dateTimePickerHoraFin.Size = new Size(177, 27);
            dateTimePickerHoraFin.TabIndex = 84;
            // 
            // labelPlaza
            // 
            labelPlaza.AutoSize = true;
            labelPlaza.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlaza.Location = new Point(269, 423);
            labelPlaza.Margin = new Padding(6, 0, 6, 0);
            labelPlaza.Name = "labelPlaza";
            labelPlaza.Size = new Size(60, 20);
            labelPlaza.TabIndex = 85;
            labelPlaza.Text = "Plazas";
            // 
            // labelHoDiaSemana
            // 
            labelHoDiaSemana.AutoSize = true;
            labelHoDiaSemana.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoDiaSemana.Location = new Point(269, 128);
            labelHoDiaSemana.Margin = new Padding(6, 0, 6, 0);
            labelHoDiaSemana.Name = "labelHoDiaSemana";
            labelHoDiaSemana.Size = new Size(140, 20);
            labelHoDiaSemana.TabIndex = 87;
            labelHoDiaSemana.Text = "Dia de la semana";
            // 
            // comboBoxDiaSemana
            // 
            comboBoxDiaSemana.FormattingEnabled = true;
            comboBoxDiaSemana.Items.AddRange(new object[] { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" });
            comboBoxDiaSemana.Location = new Point(447, 125);
            comboBoxDiaSemana.Margin = new Padding(3, 4, 3, 4);
            comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            comboBoxDiaSemana.Size = new Size(177, 28);
            comboBoxDiaSemana.TabIndex = 88;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.DarkOrange;
            buttonGuardar.BorderColor = Color.Gray;
            buttonGuardar.BorderRadius = 10;
            buttonGuardar.BorderSize = 1;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonGuardar.ForeColor = SystemColors.ControlLightLight;
            buttonGuardar.HoverColor = Color.FromArgb(235, 120, 0);
            buttonGuardar.Location = new Point(431, 496);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.PaddingHorizontal = 12;
            buttonGuardar.PaddingVertical = 8;
            buttonGuardar.PressedColor = Color.FromArgb(255, 192, 128);
            buttonGuardar.Size = new Size(193, 51);
            buttonGuardar.TabIndex = 90;
            buttonGuardar.Text = "Añadir horario";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelTituloCrearHorario
            // 
            labelTituloCrearHorario.AutoSize = true;
            labelTituloCrearHorario.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labelTituloCrearHorario.ForeColor = SystemColors.ControlDarkDark;
            labelTituloCrearHorario.Location = new Point(253, 38);
            labelTituloCrearHorario.Name = "labelTituloCrearHorario";
            labelTituloCrearHorario.Size = new Size(254, 50);
            labelTituloCrearHorario.TabIndex = 91;
            labelTituloCrearHorario.Text = "Crear horario";
            // 
            // labelTituoModificarHorario
            // 
            labelTituoModificarHorario.AutoSize = true;
            labelTituoModificarHorario.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labelTituoModificarHorario.ForeColor = SystemColors.ControlDarkDark;
            labelTituoModificarHorario.Location = new Point(253, 38);
            labelTituoModificarHorario.Name = "labelTituoModificarHorario";
            labelTituoModificarHorario.Size = new Size(331, 50);
            labelTituoModificarHorario.TabIndex = 92;
            labelTituoModificarHorario.Text = "Modificar horario";
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.DarkOrange;
            buttonModificar.BorderColor = Color.Gray;
            buttonModificar.BorderRadius = 10;
            buttonModificar.BorderSize = 1;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonModificar.ForeColor = SystemColors.ControlLightLight;
            buttonModificar.HoverColor = Color.FromArgb(235, 120, 0);
            buttonModificar.Location = new Point(408, 496);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.PaddingHorizontal = 12;
            buttonModificar.PaddingVertical = 8;
            buttonModificar.PressedColor = Color.FromArgb(255, 192, 128);
            buttonModificar.Size = new Size(216, 51);
            buttonModificar.TabIndex = 93;
            buttonModificar.Text = "Modificar horario";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // numericPlazas
            // 
            numericPlazas.Location = new Point(449, 423);
            numericPlazas.Margin = new Padding(3, 4, 3, 4);
            numericPlazas.Name = "numericPlazas";
            numericPlazas.Size = new Size(175, 27);
            numericPlazas.TabIndex = 94;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBoxICon);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(200, 584);
            panelIcon.TabIndex = 95;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.Dock = DockStyle.Fill;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(200, 584);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 0;
            pictureBoxICon.TabStop = false;
            // 
            // Horario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 584);
            Controls.Add(panelIcon);
            Controls.Add(numericPlazas);
            Controls.Add(buttonModificar);
            Controls.Add(labelTituoModificarHorario);
            Controls.Add(labelTituloCrearHorario);
            Controls.Add(buttonGuardar);
            Controls.Add(comboBoxDiaSemana);
            Controls.Add(labelHoDiaSemana);
            Controls.Add(labelPlaza);
            Controls.Add(dateTimePickerHoraFin);
            Controls.Add(dateTimePickerHoaraInicio);
            Controls.Add(label1);
            Controls.Add(labelHoHorarioInicio);
            Controls.Add(buttonHoGrupo);
            Controls.Add(buttonHoServicio);
            Controls.Add(textBoxHoGrupo);
            Controls.Add(textBoxHoServicio);
            Controls.Add(labelHoGrupo);
            Controls.Add(labelHoServicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Horario";
            Text = "Crear un horario";
            Load += Horario_Load;
            ((System.ComponentModel.ISupportInitialize)numericPlazas).EndInit();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ComboBox comboServivioCita;
        private Label labelCitServicio;
        private ComboBox comboGrupoCita;
        private Label labelCitGrupo;
        private Label labelHoServicio;
        private Label labelHoGrupo;
        private Usuario.RoundedTextBox textBoxHoServicio;
        private Usuario.RoundedTextBox textBoxHoGrupo;
        private Button buttonHoServicio;
        private Button buttonHoGrupo;
        private Label labelHoHorarioInicio;
        private Label label1;
        private DateTimePicker dateTimePickerHoaraInicio;
        private DateTimePicker dateTimePickerHoraFin;
        private Label labelPlaza;
        private Label labelHoDiaSemana;
        private ComboBox comboBoxDiaSemana;
        private Bloqueo.RoundedButton buttonGuardar;
        private Label labelTituloCrearHorario;
        private Label labelTituoModificarHorario;
        private Bloqueo.RoundedButton buttonModificar;
        private NumericUpDown numericPlazas;
        private Panel panelIcon;
        private PictureBox pictureBoxICon;
    }
}