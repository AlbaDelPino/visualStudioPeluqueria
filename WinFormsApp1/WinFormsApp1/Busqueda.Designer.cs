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
            textBoxHoBuscar = new TextBox();
            labelTituoIBuscar = new Label();
            buttonSeleccionar = new Button();
            buttonTodoDia = new Button();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Location = new Point(107, 197);
            Tabla.Margin = new Padding(3, 4, 3, 4);
            Tabla.Name = "Tabla";
            Tabla.RowHeadersWidth = 51;
            Tabla.Size = new Size(702, 345);
            Tabla.TabIndex = 0;
            Tabla.CellContentClick += Tabla_CellContentClick;
            Tabla.CellContentDoubleClick += Tabla_CellDoubleClick;
            // 
            // textBoxHoBuscar
            // 
            textBoxHoBuscar.Location = new Point(107, 118);
            textBoxHoBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxHoBuscar.Name = "textBoxHoBuscar";
            textBoxHoBuscar.Size = new Size(702, 27);
            textBoxHoBuscar.TabIndex = 1;
            // 
            // labelTituoIBuscar
            // 
            labelTituoIBuscar.AutoSize = true;
            labelTituoIBuscar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoIBuscar.Location = new Point(107, 73);
            labelTituoIBuscar.Name = "labelTituoIBuscar";
            labelTituoIBuscar.Size = new Size(176, 32);
            labelTituoIBuscar.TabIndex = 50;
            labelTituoIBuscar.Text = "Selecione Uno";
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.BackColor = Color.DarkOrange;
            buttonSeleccionar.FlatStyle = FlatStyle.Flat;
            buttonSeleccionar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeleccionar.ForeColor = SystemColors.ControlLightLight;
            buttonSeleccionar.Location = new Point(677, 549);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(132, 39);
            buttonSeleccionar.TabIndex = 51;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.UseVisualStyleBackColor = false;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonTodoDia
            // 
            buttonTodoDia.BackColor = Color.DarkOrange;
            buttonTodoDia.FlatStyle = FlatStyle.Flat;
            buttonTodoDia.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTodoDia.ForeColor = SystemColors.ControlLightLight;
            buttonTodoDia.Location = new Point(454, 549);
            buttonTodoDia.Name = "buttonTodoDia";
            buttonTodoDia.Size = new Size(217, 39);
            buttonTodoDia.TabIndex = 52;
            buttonTodoDia.Text = "Seleccionar todo el dia";
            buttonTodoDia.UseVisualStyleBackColor = false;
            buttonTodoDia.Click += buttonTodoDia_Click;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 605);
            Controls.Add(buttonTodoDia);
            Controls.Add(buttonSeleccionar);
            Controls.Add(labelTituoIBuscar);
            Controls.Add(textBoxHoBuscar);
            Controls.Add(Tabla);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Busqueda";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabla;
        private TextBox textBoxHoBuscar;
        private Label labelTituoIBuscar;
        private Button buttonSeleccionar;
        private Button buttonTodoDia;
    }
}