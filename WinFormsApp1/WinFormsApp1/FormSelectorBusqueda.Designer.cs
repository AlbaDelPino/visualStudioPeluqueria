namespace WinFormsApp1
{
    partial class FormSelectorBusqueda
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
            dgvSelector = new DataGridView();
            Servicios = new DataGridViewTextBoxColumn();
            textBoxHoBuscar = new TextBox();
            labelTituoIBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSelector).BeginInit();
            SuspendLayout();
            // 
            // dgvSelector
            // 
            dgvSelector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelector.Columns.AddRange(new DataGridViewColumn[] { Servicios });
            dgvSelector.Location = new Point(94, 148);
            dgvSelector.Name = "dgvSelector";
            dgvSelector.Size = new Size(614, 259);
            dgvSelector.TabIndex = 0;
            // 
            // Servicios
            // 
            Servicios.HeaderText = "Column1";
            Servicios.Name = "Servicios";
            // 
            // textBoxHoBuscar
            // 
            textBoxHoBuscar.Location = new Point(152, 87);
            textBoxHoBuscar.Name = "textBoxHoBuscar";
            textBoxHoBuscar.Size = new Size(448, 23);
            textBoxHoBuscar.TabIndex = 1;
            // 
            // labelTituoIBuscar
            // 
            labelTituoIBuscar.AutoSize = true;
            labelTituoIBuscar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoIBuscar.Location = new Point(252, 30);
            labelTituoIBuscar.Name = "labelTituoIBuscar";
            labelTituoIBuscar.Size = new Size(139, 25);
            labelTituoIBuscar.TabIndex = 50;
            labelTituoIBuscar.Text = "Selecione Uno";
            // 
            // FormSelectorBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTituoIBuscar);
            Controls.Add(textBoxHoBuscar);
            Controls.Add(dgvSelector);
            Name = "FormSelectorBusqueda";
            Text = "FormSelectorBusqueda";
            ((System.ComponentModel.ISupportInitialize)dgvSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSelector;
        private DataGridViewTextBoxColumn Servicios;
        private TextBox textBoxHoBuscar;
        private Label labelTituoIBuscar;
    }
}