namespace WinFormsApp1
{
    partial class FichaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaCita));
            panelFicha = new Panel();
            buttonCompletar = new Button();
            labelTratamientos = new Label();
            richTextBoxTratamientos = new RichTextBox();
            richTextBoxProductos = new RichTextBox();
            labelProductos = new Label();
            richTextBoxObservaciones = new RichTextBox();
            labelObservaciones = new Label();
            panelFicha.SuspendLayout();
            SuspendLayout();
            // 
            // panelFicha
            // 
            panelFicha.Controls.Add(richTextBoxObservaciones);
            panelFicha.Controls.Add(labelObservaciones);
            panelFicha.Controls.Add(richTextBoxProductos);
            panelFicha.Controls.Add(labelProductos);
            panelFicha.Controls.Add(richTextBoxTratamientos);
            panelFicha.Controls.Add(labelTratamientos);
            panelFicha.Controls.Add(buttonCompletar);
            panelFicha.Dock = DockStyle.Fill;
            panelFicha.Location = new Point(0, 0);
            panelFicha.Name = "panelFicha";
            panelFicha.Size = new Size(914, 600);
            panelFicha.TabIndex = 0;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(336, 484);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(176, 69);
            buttonCompletar.TabIndex = 0;
            buttonCompletar.Text = "Completar";
            buttonCompletar.UseVisualStyleBackColor = true;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // labelTratamientos
            // 
            labelTratamientos.AutoSize = true;
            labelTratamientos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTratamientos.Location = new Point(71, 54);
            labelTratamientos.Margin = new Padding(5, 0, 5, 0);
            labelTratamientos.Name = "labelTratamientos";
            labelTratamientos.Size = new Size(138, 26);
            labelTratamientos.TabIndex = 16;
            labelTratamientos.Text = "Tratamientos";
            // 
            // richTextBoxTratamientos
            // 
            richTextBoxTratamientos.Location = new Point(71, 83);
            richTextBoxTratamientos.Name = "richTextBoxTratamientos";
            richTextBoxTratamientos.Size = new Size(271, 136);
            richTextBoxTratamientos.TabIndex = 17;
            richTextBoxTratamientos.Text = "";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.Location = new Point(505, 83);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(271, 136);
            richTextBoxProductos.TabIndex = 19;
            richTextBoxProductos.Text = "";
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductos.Location = new Point(505, 54);
            labelProductos.Margin = new Padding(5, 0, 5, 0);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(110, 26);
            labelProductos.TabIndex = 18;
            labelProductos.Text = "Productos";
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(71, 271);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.Size = new Size(271, 136);
            richTextBoxObservaciones.TabIndex = 21;
            richTextBoxObservaciones.Text = "";
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObservaciones.Location = new Point(71, 242);
            labelObservaciones.Margin = new Padding(5, 0, 5, 0);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(157, 26);
            labelObservaciones.TabIndex = 20;
            labelObservaciones.Text = "Observaciones";
            // 
            // FichaCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelFicha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FichaCita";
            Text = "FichaCita";
            panelFicha.ResumeLayout(false);
            panelFicha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFicha;
        private Button buttonCompletar;
        private Label labelTratamientos;
        private RichTextBox richTextBoxTratamientos;
        private RichTextBox richTextBoxProductos;
        private Label labelProductos;
        private RichTextBox richTextBoxObservaciones;
        private Label labelObservaciones;
    }
}