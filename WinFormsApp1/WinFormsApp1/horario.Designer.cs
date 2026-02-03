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
            labelHoServicio.Location = new Point(47, 144);
            labelHoServicio.Margin = new Padding(5, 0, 5, 0);
            labelHoServicio.Name = "labelHoServicio";
            labelHoServicio.Size = new Size(58, 17);
            labelHoServicio.TabIndex = 74;
            labelHoServicio.Text = "Servicio";
            // 
            // labelHoGrupo
            // 
            labelHoGrupo.AutoSize = true;
            labelHoGrupo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoGrupo.Location = new Point(57, 193);
            labelHoGrupo.Margin = new Padding(5, 0, 5, 0);
            labelHoGrupo.Name = "labelHoGrupo";
            labelHoGrupo.Size = new Size(48, 17);
            labelHoGrupo.TabIndex = 76;
            labelHoGrupo.Text = "Grupo";
            // 
            // textBoxHoServicio
            // 
            textBoxHoServicio.Location = new Point(213, 144);
            textBoxHoServicio.Name = "textBoxHoServicio";
            textBoxHoServicio.ReadOnly = true;
            textBoxHoServicio.Size = new Size(100, 23);
            textBoxHoServicio.TabIndex = 77;
            // 
            // textBoxHoGrupo
            // 
            textBoxHoGrupo.Location = new Point(213, 193);
            textBoxHoGrupo.Name = "textBoxHoGrupo";
            textBoxHoGrupo.ReadOnly = true;
            textBoxHoGrupo.Size = new Size(100, 23);
            textBoxHoGrupo.TabIndex = 78;
            // 
            // buttonHoServicio
            // 
            buttonHoServicio.Location = new Point(348, 145);
            buttonHoServicio.Name = "buttonHoServicio";
            buttonHoServicio.Size = new Size(75, 23);
            buttonHoServicio.TabIndex = 79;
            buttonHoServicio.Text = "...";
            buttonHoServicio.UseVisualStyleBackColor = true;
            buttonHoServicio.Click += buttonHoServicio_Click;
            // 
            // buttonHoBrupo
            // 
            buttonHoBrupo.Location = new Point(348, 193);
            buttonHoBrupo.Name = "buttonHoBrupo";
            buttonHoBrupo.Size = new Size(75, 23);
            buttonHoBrupo.TabIndex = 80;
            buttonHoBrupo.Text = "...";
            buttonHoBrupo.UseVisualStyleBackColor = true;
            buttonHoBrupo.Click += buttonHoGrupo_Click;
            // 
            // labelHoHorarioInicio
            // 
            labelHoHorarioInicio.AutoSize = true;
            labelHoHorarioInicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoHorarioInicio.Location = new Point(57, 247);
            labelHoHorarioInicio.Margin = new Padding(5, 0, 5, 0);
            labelHoHorarioInicio.Name = "labelHoHorarioInicio";
            labelHoHorarioInicio.Size = new Size(91, 17);
            labelHoHorarioInicio.TabIndex = 81;
            labelHoHorarioInicio.Text = "Horario inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 280);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 82;
            label1.Text = "Horario fin";
            // 
            // dateTimePickerHoaraInicio
            // 
            dateTimePickerHoaraInicio.Location = new Point(213, 241);
            dateTimePickerHoaraInicio.Name = "dateTimePickerHoaraInicio";
            dateTimePickerHoaraInicio.Size = new Size(155, 23);
            dateTimePickerHoaraInicio.TabIndex = 83;
            // 
            // dateTimePickerHoraFin
            // 
            dateTimePickerHoraFin.Location = new Point(213, 280);
            dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            dateTimePickerHoraFin.Size = new Size(155, 23);
            dateTimePickerHoraFin.TabIndex = 84;
            // 
            // labelPlaza
            // 
            labelPlaza.AutoSize = true;
            labelPlaza.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlaza.Location = new Point(57, 323);
            labelPlaza.Margin = new Padding(5, 0, 5, 0);
            labelPlaza.Name = "labelPlaza";
            labelPlaza.Size = new Size(43, 17);
            labelPlaza.TabIndex = 85;
            labelPlaza.Text = "Plaza";
            // 
            // labelHoDiaSemana
            // 
            labelHoDiaSemana.AutoSize = true;
            labelHoDiaSemana.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoDiaSemana.Location = new Point(47, 106);
            labelHoDiaSemana.Margin = new Padding(5, 0, 5, 0);
            labelHoDiaSemana.Name = "labelHoDiaSemana";
            labelHoDiaSemana.Size = new Size(118, 17);
            labelHoDiaSemana.TabIndex = 87;
            labelHoDiaSemana.Text = "Dia de la semana";
            // 
            // comboBoxDiaSemana
            // 
            comboBoxDiaSemana.FormattingEnabled = true;
            comboBoxDiaSemana.Items.AddRange(new object[] { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" });
            comboBoxDiaSemana.Location = new Point(213, 100);
            comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            comboBoxDiaSemana.Size = new Size(121, 23);
            comboBoxDiaSemana.TabIndex = 88;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(145, 378);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(189, 38);
            buttonGuardar.TabIndex = 90;
            buttonGuardar.Text = "Añadir horario";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelTituloCrearHorario
            // 
            labelTituloCrearHorario.AutoSize = true;
            labelTituloCrearHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituloCrearHorario.Location = new Point(145, 26);
            labelTituloCrearHorario.Name = "labelTituloCrearHorario";
            labelTituloCrearHorario.Size = new Size(162, 25);
            labelTituloCrearHorario.TabIndex = 91;
            labelTituloCrearHorario.Text = "CREAR HORARIO";
            // 
            // labelTituoModificarHorario
            // 
            labelTituoModificarHorario.AutoSize = true;
            labelTituoModificarHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoModificarHorario.Location = new Point(123, 26);
            labelTituoModificarHorario.Name = "labelTituoModificarHorario";
            labelTituoModificarHorario.Size = new Size(208, 25);
            labelTituoModificarHorario.TabIndex = 92;
            labelTituoModificarHorario.Text = "MODIFICAR HORARIO";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(214, 378);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(189, 38);
            buttonModificar.TabIndex = 93;
            buttonModificar.Text = "Modificar horario";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // numericPlazas
            // 
            numericPlazas.Location = new Point(214, 323);
            numericPlazas.Name = "numericPlazas";
            numericPlazas.Size = new Size(120, 23);
            numericPlazas.TabIndex = 94;
            // 
            // Horario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 438);
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
            Name = "Horario";
            Text = "Crear un horario";
            Load += Horario_Load;
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