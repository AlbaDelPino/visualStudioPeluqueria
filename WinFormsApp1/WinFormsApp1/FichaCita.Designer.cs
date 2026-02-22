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
            pictureBoxICon = new PictureBox();
            richTextBoxObservaciones = new RichTextBox();
            labelObservaciones = new Label();
            richTextBoxProductos = new RichTextBox();
            labelProductos = new Label();
            richTextBoxTratamientos = new RichTextBox();
            labelTratamientos = new Label();
            buttonCompletar = new Button();
            panelFicha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // panelFicha
            // 
            panelFicha.Controls.Add(pictureBoxICon);
            panelFicha.Controls.Add(richTextBoxObservaciones);
            panelFicha.Controls.Add(labelObservaciones);
            panelFicha.Controls.Add(richTextBoxProductos);
            panelFicha.Controls.Add(labelProductos);
            panelFicha.Controls.Add(richTextBoxTratamientos);
            panelFicha.Controls.Add(labelTratamientos);
            panelFicha.Controls.Add(buttonCompletar);
            panelFicha.Dock = DockStyle.Fill;
            panelFicha.Location = new Point(0, 0);
            panelFicha.Margin = new Padding(3, 2, 3, 2);
            panelFicha.Name = "panelFicha";
            panelFicha.Size = new Size(891, 450);
            panelFicha.TabIndex = 0;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 450);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 22;
            pictureBoxICon.TabStop = false;
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(256, 245);
            richTextBoxObservaciones.Margin = new Padding(3, 2, 3, 2);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.Size = new Size(569, 103);
            richTextBoxObservaciones.TabIndex = 21;
            richTextBoxObservaciones.Text = "";
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObservaciones.ForeColor = SystemColors.ControlDarkDark;
            labelObservaciones.Location = new Point(256, 207);
            labelObservaciones.Margin = new Padding(4, 0, 4, 0);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(130, 22);
            labelObservaciones.TabIndex = 20;
            labelObservaciones.Text = "Observaciones";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.Location = new Point(587, 92);
            richTextBoxProductos.Margin = new Padding(3, 2, 3, 2);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(238, 103);
            richTextBoxProductos.TabIndex = 19;
            richTextBoxProductos.Text = "";
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductos.ForeColor = SystemColors.ControlDarkDark;
            labelProductos.Location = new Point(605, 56);
            labelProductos.Margin = new Padding(4, 0, 4, 0);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(91, 22);
            labelProductos.TabIndex = 18;
            labelProductos.Text = "Productos";
            labelProductos.Click += labelProductos_Click;
            // 
            // richTextBoxTratamientos
            // 
            richTextBoxTratamientos.Location = new Point(256, 92);
            richTextBoxTratamientos.Margin = new Padding(3, 2, 3, 2);
            richTextBoxTratamientos.Name = "richTextBoxTratamientos";
            richTextBoxTratamientos.Size = new Size(238, 103);
            richTextBoxTratamientos.TabIndex = 17;
            richTextBoxTratamientos.Text = "";
            // 
            // labelTratamientos
            // 
            labelTratamientos.AutoSize = true;
            labelTratamientos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTratamientos.ForeColor = SystemColors.ControlDarkDark;
            labelTratamientos.Location = new Point(256, 56);
            labelTratamientos.Margin = new Padding(4, 0, 4, 0);
            labelTratamientos.Name = "labelTratamientos";
            labelTratamientos.Size = new Size(115, 22);
            labelTratamientos.TabIndex = 16;
            labelTratamientos.Text = "Tratamientos";
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackColor = Color.DarkOrange;
            buttonCompletar.ForeColor = SystemColors.ControlLightLight;
            buttonCompletar.Location = new Point(488, 379);
            buttonCompletar.Margin = new Padding(3, 2, 3, 2);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(154, 52);
            buttonCompletar.TabIndex = 0;
            buttonCompletar.Text = "Completar";
            buttonCompletar.UseVisualStyleBackColor = false;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // FichaCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(panelFicha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FichaCita";
            Text = "FichaCita";
            Load += FichaCita_Load;
            panelFicha.ResumeLayout(false);
            panelFicha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
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
        private PictureBox pictureBoxICon;
    }
}