namespace WinFormsApp1
{
    partial class Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            Tabla = new DataGridView();
            textBoxBuscar = new WinFormsApp1.Usuario.RoundedTextBox();
            labelTituoIBuscar = new Label();
            buttonSeleccionar = new WinFormsApp1.Bloqueo.RoundedButton();
            buttonTodoDia = new WinFormsApp1.Bloqueo.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Location = new Point(94, 148);
            Tabla.Name = "Tabla";
            Tabla.RowHeadersWidth = 51;
            Tabla.Size = new Size(614, 259);
            Tabla.TabIndex = 0;
            Tabla.CellContentClick += Tabla_CellContentClick;
            Tabla.CellContentDoubleClick += Tabla_CellDoubleClick;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BackColor = Color.White;
            textBoxBuscar.BorderColor = SystemColors.ControlDarkDark;
            textBoxBuscar.BorderRadius = 10;
            textBoxBuscar.BorderSize = 1;
            textBoxBuscar.Location = new Point(94, 88);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PasswordChar = '\0';
            textBoxBuscar.ReadOnly = false;
            textBoxBuscar.Size = new Size(614, 24);
            textBoxBuscar.TabIndex = 1;
            textBoxBuscar.TextChanged += TextBoxBuscar_TextChanged;
            // 
            // labelTituoIBuscar
            // 
            labelTituoIBuscar.AutoSize = true;
            labelTituoIBuscar.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labelTituoIBuscar.ForeColor = SystemColors.ControlDarkDark;
            labelTituoIBuscar.Location = new Point(94, 44);
            labelTituoIBuscar.Name = "labelTituoIBuscar";
            labelTituoIBuscar.Size = new Size(213, 41);
            labelTituoIBuscar.TabIndex = 50;
            labelTituoIBuscar.Text = "Selecione uno";
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.BackColor = Color.DarkOrange;
            buttonSeleccionar.BorderColor = Color.Gray;
            buttonSeleccionar.BorderRadius = 10;
            buttonSeleccionar.BorderSize = 1;
            buttonSeleccionar.FlatStyle = FlatStyle.Flat;
            buttonSeleccionar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeleccionar.ForeColor = SystemColors.ControlLightLight;
            buttonSeleccionar.HoverColor = Color.FromArgb(235, 120, 0);
            buttonSeleccionar.Location = new Point(592, 412);
            buttonSeleccionar.Margin = new Padding(3, 2, 3, 2);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.PaddingHorizontal = 12;
            buttonSeleccionar.PaddingVertical = 8;
            buttonSeleccionar.PressedColor = Color.FromArgb(255, 192, 128);
            buttonSeleccionar.Size = new Size(116, 30);
            buttonSeleccionar.TabIndex = 51;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.UseVisualStyleBackColor = false;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonTodoDia
            // 
            buttonTodoDia.BackColor = Color.DarkOrange;
            buttonTodoDia.BorderColor = Color.Gray;
            buttonTodoDia.BorderRadius = 10;
            buttonTodoDia.BorderSize = 1;
            buttonTodoDia.FlatStyle = FlatStyle.Flat;
            buttonTodoDia.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTodoDia.ForeColor = SystemColors.ControlLightLight;
            buttonTodoDia.HoverColor = Color.FromArgb(235, 120, 0);
            buttonTodoDia.Location = new Point(380, 412);
            buttonTodoDia.Margin = new Padding(3, 2, 3, 2);
            buttonTodoDia.Name = "buttonTodoDia";
            buttonTodoDia.PaddingHorizontal = 12;
            buttonTodoDia.PaddingVertical = 8;
            buttonTodoDia.PressedColor = Color.FromArgb(255, 192, 128);
            buttonTodoDia.Size = new Size(207, 30);
            buttonTodoDia.TabIndex = 52;
            buttonTodoDia.Text = "Seleccionar todo el dia";
            buttonTodoDia.UseVisualStyleBackColor = false;
            buttonTodoDia.Click += buttonTodoDia_Click;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(buttonTodoDia);
            Controls.Add(buttonSeleccionar);
            Controls.Add(labelTituoIBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(Tabla);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Busqueda";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabla;
        private Usuario.RoundedTextBox textBoxBuscar;
        private Label labelTituoIBuscar;
        private Bloqueo.RoundedButton buttonSeleccionar;
        private Bloqueo.RoundedButton buttonTodoDia;
    }
}