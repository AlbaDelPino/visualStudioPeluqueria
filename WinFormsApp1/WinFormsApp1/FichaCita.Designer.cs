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
            labelInfoCita = new Label();
            pictureBoxICon = new PictureBox();
            richTextBoxObservaciones = new RichTextBox();
            labelObservaciones = new Label();
            richTextBoxProductos = new RichTextBox();
            labelProductos = new Label();
            richTextBoxTratamientos = new RichTextBox();
            labelTratamientos = new Label();
            buttonCompletar = new Bloqueo.RoundedButton();
            panelFicha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // panelFicha
            // 
            panelFicha.Controls.Add(labelInfoCita);
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
            panelFicha.Name = "panelFicha";
            panelFicha.Size = new Size(984, 572);
            panelFicha.TabIndex = 0;
            // 
            // labelInfoCita
            // 
            labelInfoCita.AutoSize = true;
            labelInfoCita.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoCita.ForeColor = SystemColors.ControlDarkDark;
            labelInfoCita.Location = new Point(293, 24);
            labelInfoCita.Name = "labelInfoCita";
            labelInfoCita.Size = new Size(403, 50);
            labelInfoCita.TabIndex = 50;
            labelInfoCita.Text = "Información de la cita";
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 5, 3, 5);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(238, 572);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 22;
            pictureBoxICon.TabStop = false;
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(293, 338);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.Size = new Size(650, 136);
            richTextBoxObservaciones.TabIndex = 21;
            richTextBoxObservaciones.Text = "";
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObservaciones.ForeColor = SystemColors.ControlText;
            labelObservaciones.Location = new Point(293, 309);
            labelObservaciones.Margin = new Padding(5, 0, 5, 0);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(157, 26);
            labelObservaciones.TabIndex = 20;
            labelObservaciones.Text = "Observaciones";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.Location = new Point(671, 134);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(271, 136);
            richTextBoxProductos.TabIndex = 19;
            richTextBoxProductos.Text = "";
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductos.ForeColor = SystemColors.ControlText;
            labelProductos.Location = new Point(671, 105);
            labelProductos.Margin = new Padding(5, 0, 5, 0);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(110, 26);
            labelProductos.TabIndex = 18;
            labelProductos.Text = "Productos";
            // 
            // richTextBoxTratamientos
            // 
            richTextBoxTratamientos.Location = new Point(293, 134);
            richTextBoxTratamientos.Name = "richTextBoxTratamientos";
            richTextBoxTratamientos.Size = new Size(271, 136);
            richTextBoxTratamientos.TabIndex = 17;
            richTextBoxTratamientos.Text = "";
            // 
            // labelTratamientos
            // 
            labelTratamientos.AutoSize = true;
            labelTratamientos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTratamientos.ForeColor = SystemColors.ControlText;
            labelTratamientos.Location = new Point(293, 105);
            labelTratamientos.Margin = new Padding(5, 0, 5, 0);
            labelTratamientos.Name = "labelTratamientos";
            labelTratamientos.Size = new Size(138, 26);
            labelTratamientos.TabIndex = 16;
            labelTratamientos.Text = "Tratamientos";
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackColor = Color.DarkOrange;
            buttonCompletar.FlatStyle = FlatStyle.Flat;
            buttonCompletar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            buttonCompletar.ForeColor = SystemColors.ControlLightLight;
            buttonCompletar.Location = new Point(767, 492);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(176, 51);
            buttonCompletar.TabIndex = 0;
            buttonCompletar.Text = "Completar";
            buttonCompletar.UseVisualStyleBackColor = false;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // FichaCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 572);
            Controls.Add(panelFicha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FichaCita";
            Text = "FichaCita";
            panelFicha.ResumeLayout(false);
            panelFicha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFicha;
        private Bloqueo.RoundedButton buttonCompletar;
        private Label labelTratamientos;
        private RichTextBox richTextBoxTratamientos;
        private RichTextBox richTextBoxProductos;
        private Label labelProductos;
        private RichTextBox richTextBoxObservaciones;
        private Label labelObservaciones;
        private PictureBox pictureBoxICon;
        private Label labelInfoCita;
    }
}