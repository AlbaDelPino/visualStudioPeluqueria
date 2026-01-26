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
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
    }
}