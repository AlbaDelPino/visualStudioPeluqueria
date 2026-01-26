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
            textBoxHoServicio = new TextBox();
            textBoxHoGrupo = new TextBox();
            buttonHoServicio = new Button();
            buttonHoBrupo = new Button();
            labelHoHorarioInicio = new Label();
            label1 = new Label();
            dateTimePickerHoaraInicio = new DateTimePicker();
            dateTimePickerHoraFin = new DateTimePicker();
            labelPlaza = new Label();
            labelHoDiaSemana = new Label();
            comboBoxDiaSemana = new ComboBox();
            buttonGuardar = new Button();
            labelTituloCrearHorario = new Label();
            labelTituoModificarHorario = new Label();
            buttonModificar = new Button();
            numericPlazas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericPlazas).BeginInit();
            SuspendLayout();
            // 
            // labelHoServicio
            // 
            labelHoServicio.AutoSize = true;
            labelHoServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoServicio.Location = new Point(54, 192);
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
            labelHoGrupo.Location = new Point(65, 257);
            labelHoGrupo.Margin = new Padding(6, 0, 6, 0);
            labelHoGrupo.Name = "labelHoGrupo";
            labelHoGrupo.Size = new Size(55, 20);
            labelHoGrupo.TabIndex = 76;
            labelHoGrupo.Text = "Grupo";
            // 
            // textBoxHoServicio
            // 
            textBoxHoServicio.Location = new Point(243, 192);
            textBoxHoServicio.Margin = new Padding(3, 4, 3, 4);
            textBoxHoServicio.Name = "textBoxHoServicio";
            textBoxHoServicio.ReadOnly = true;
            textBoxHoServicio.Size = new Size(114, 27);
            textBoxHoServicio.TabIndex = 77;
            // 
            // textBoxHoGrupo
            // 
            textBoxHoGrupo.Location = new Point(243, 257);
            textBoxHoGrupo.Margin = new Padding(3, 4, 3, 4);
            textBoxHoGrupo.Name = "textBoxHoGrupo";
            textBoxHoGrupo.ReadOnly = true;
            textBoxHoGrupo.Size = new Size(114, 27);
            textBoxHoGrupo.TabIndex = 78;
            // 
            // buttonHoServicio
            // 
            buttonHoServicio.Location = new Point(398, 193);
            buttonHoServicio.Margin = new Padding(3, 4, 3, 4);
            buttonHoServicio.Name = "buttonHoServicio";
            buttonHoServicio.Size = new Size(86, 31);
            buttonHoServicio.TabIndex = 79;
            buttonHoServicio.Text = "...";
            buttonHoServicio.UseVisualStyleBackColor = true;
            buttonHoServicio.Click += buttonHoServicio_Click;
            // 
            // buttonHoBrupo
            // 
            buttonHoBrupo.Location = new Point(398, 257);
            buttonHoBrupo.Margin = new Padding(3, 4, 3, 4);
            buttonHoBrupo.Name = "buttonHoBrupo";
            buttonHoBrupo.Size = new Size(86, 31);
            buttonHoBrupo.TabIndex = 80;
            buttonHoBrupo.Text = "...";
            buttonHoBrupo.UseVisualStyleBackColor = true;
            buttonHoBrupo.Click += buttonHoGrupo_Click;
            // 
            // labelHoHorarioInicio
            // 
            labelHoHorarioInicio.AutoSize = true;
            labelHoHorarioInicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoHorarioInicio.Location = new Point(65, 329);
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
            label1.Location = new Point(65, 373);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 82;
            label1.Text = "Horario fin";
            // 
            // dateTimePickerHoaraInicio
            // 
            dateTimePickerHoaraInicio.Location = new Point(243, 321);
            dateTimePickerHoaraInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHoaraInicio.Name = "dateTimePickerHoaraInicio";
            dateTimePickerHoaraInicio.Size = new Size(177, 27);
            dateTimePickerHoaraInicio.TabIndex = 83;
            // 
            // dateTimePickerHoraFin
            // 
            dateTimePickerHoraFin.Location = new Point(243, 373);
            dateTimePickerHoraFin.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            dateTimePickerHoraFin.Size = new Size(177, 27);
            dateTimePickerHoraFin.TabIndex = 84;
            // 
            // labelPlaza
            // 
            labelPlaza.AutoSize = true;
            labelPlaza.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlaza.Location = new Point(65, 431);
            labelPlaza.Margin = new Padding(6, 0, 6, 0);
            labelPlaza.Name = "labelPlaza";
            labelPlaza.Size = new Size(51, 20);
            labelPlaza.TabIndex = 85;
            labelPlaza.Text = "Plaza";
            // 
            // labelHoDiaSemana
            // 
            labelHoDiaSemana.AutoSize = true;
            labelHoDiaSemana.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoDiaSemana.Location = new Point(54, 141);
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
            comboBoxDiaSemana.Location = new Point(243, 133);
            comboBoxDiaSemana.Margin = new Padding(3, 4, 3, 4);
            comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            comboBoxDiaSemana.Size = new Size(138, 28);
            comboBoxDiaSemana.TabIndex = 88;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(166, 504);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(216, 51);
            buttonGuardar.TabIndex = 90;
            buttonGuardar.Text = "Añadir horario";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelTituloCrearHorario
            // 
            labelTituloCrearHorario.AutoSize = true;
            labelTituloCrearHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituloCrearHorario.Location = new Point(166, 34);
            labelTituloCrearHorario.Name = "labelTituloCrearHorario";
            labelTituloCrearHorario.Size = new Size(209, 32);
            labelTituloCrearHorario.TabIndex = 91;
            labelTituloCrearHorario.Text = "CREAR HORARIO";
            // 
            // labelTituoModificarHorario
            // 
            labelTituoModificarHorario.AutoSize = true;
            labelTituoModificarHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoModificarHorario.Location = new Point(141, 34);
            labelTituoModificarHorario.Name = "labelTituoModificarHorario";
            labelTituoModificarHorario.Size = new Size(267, 32);
            labelTituoModificarHorario.TabIndex = 92;
            labelTituoModificarHorario.Text = "MODIFICAR HORARIO";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(166, 504);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(216, 51);
            buttonModificar.TabIndex = 93;
            buttonModificar.Text = "Modificar horario";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // numericPlazas
            // 
            numericPlazas.Location = new Point(245, 431);
            numericPlazas.Margin = new Padding(3, 4, 3, 4);
            numericPlazas.Name = "numericPlazas";
            numericPlazas.Size = new Size(137, 27);
            numericPlazas.TabIndex = 94;
            // 
            // Horario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 584);
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
            Controls.Add(buttonHoBrupo);
            Controls.Add(buttonHoServicio);
            Controls.Add(textBoxHoGrupo);
            Controls.Add(textBoxHoServicio);
            Controls.Add(labelHoGrupo);
            Controls.Add(labelHoServicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Horario";
            Text = "Crear un horario";
            ((System.ComponentModel.ISupportInitialize)numericPlazas).EndInit();
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
        private TextBox textBoxHoServicio;
        private TextBox textBoxHoGrupo;
        private Button buttonHoServicio;
        private Button buttonHoBrupo;
        private Label labelHoHorarioInicio;
        private Label label1;
        private DateTimePicker dateTimePickerHoaraInicio;
        private DateTimePicker dateTimePickerHoraFin;
        private Label labelPlaza;
        private Label labelHoDiaSemana;
        private ComboBox comboBoxDiaSemana;
        private Button buttonGuardar;
        private Label labelTituloCrearHorario;
        private Label labelTituoModificarHorario;
        private Button buttonModificar;
        private NumericUpDown numericPlazas;
    }
}