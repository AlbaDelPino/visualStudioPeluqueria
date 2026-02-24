namespace WinFormsApp1
{
    partial class Valoracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valoracion));
            labelTrato = new Label();
            labelDesarrollo = new Label();
            labelComunicacion = new Label();
            labelOrganizacion = new Label();
            labelGeneral = new Label();
            pictureBoxResultado = new PictureBox();
            labelImagen = new Label();
            labelComentario = new Label();
            Puntuacion = new Label();
            PuntuacionLimpieza = new Label();
            PuntuacionComunicacion = new Label();
            PuntuacionServicio = new Label();
            PuntuacionTrato = new Label();
            pictureBoxICon = new PictureBox();
            labeltitulo = new Label();
            panelCliente = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            richTextBoxComentario = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            panelCliente.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // labelTrato
            // 
            labelTrato.AutoSize = true;
            labelTrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTrato.Location = new Point(9, 8);
            labelTrato.Name = "labelTrato";
            labelTrato.Size = new Size(32, 15);
            labelTrato.TabIndex = 5;
            labelTrato.Text = "PUN";
            // 
            // labelDesarrollo
            // 
            labelDesarrollo.AutoSize = true;
            labelDesarrollo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesarrollo.Location = new Point(9, 8);
            labelDesarrollo.Name = "labelDesarrollo";
            labelDesarrollo.Size = new Size(32, 15);
            labelDesarrollo.TabIndex = 6;
            labelDesarrollo.Text = "PUN";
            // 
            // labelComunicacion
            // 
            labelComunicacion.AutoSize = true;
            labelComunicacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComunicacion.Location = new Point(9, 8);
            labelComunicacion.Name = "labelComunicacion";
            labelComunicacion.Size = new Size(32, 15);
            labelComunicacion.TabIndex = 7;
            labelComunicacion.Text = "PUN";
            // 
            // labelOrganizacion
            // 
            labelOrganizacion.AutoSize = true;
            labelOrganizacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrganizacion.Location = new Point(9, 8);
            labelOrganizacion.Name = "labelOrganizacion";
            labelOrganizacion.Size = new Size(31, 21);
            labelOrganizacion.TabIndex = 8;
            labelOrganizacion.Text = "PUN";
            labelOrganizacion.UseCompatibleTextRendering = true;
            // 
            // labelGeneral
            // 
            labelGeneral.AutoSize = true;
            labelGeneral.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGeneral.Location = new Point(9, 8);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(32, 15);
            labelGeneral.TabIndex = 9;
            labelGeneral.Text = "PUN";
            // 
            // pictureBoxResultado
            // 
            pictureBoxResultado.Location = new Point(601, 100);
            pictureBoxResultado.Name = "pictureBoxResultado";
            pictureBoxResultado.Size = new Size(270, 158);
            pictureBoxResultado.TabIndex = 10;
            pictureBoxResultado.TabStop = false;
            // 
            // labelImagen
            // 
            labelImagen.AutoSize = true;
            labelImagen.Location = new Point(601, 79);
            labelImagen.Name = "labelImagen";
            labelImagen.Size = new Size(87, 21);
            labelImagen.TabIndex = 11;
            labelImagen.Text = "Foto adjuntada";
            labelImagen.UseCompatibleTextRendering = true;
            labelImagen.Click += labelImagen_Click;
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.Location = new Point(258, 269);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(69, 21);
            labelComentario.TabIndex = 12;
            labelComentario.Text = "Comentario";
            labelComentario.UseCompatibleTextRendering = true;
            // 
            // Puntuacion
            // 
            Puntuacion.AutoSize = true;
            Puntuacion.Location = new Point(258, 82);
            Puntuacion.Name = "Puntuacion";
            Puntuacion.Size = new Size(110, 15);
            Puntuacion.TabIndex = 18;
            Puntuacion.Text = "Puntuación general";
            Puntuacion.Click += Puntuacion_Click;
            // 
            // PuntuacionLimpieza
            // 
            PuntuacionLimpieza.AutoSize = true;
            PuntuacionLimpieza.Location = new Point(257, 232);
            PuntuacionLimpieza.Name = "PuntuacionLimpieza";
            PuntuacionLimpieza.Size = new Size(135, 21);
            PuntuacionLimpieza.TabIndex = 17;
            PuntuacionLimpieza.Text = "Limpieza y organización";
            PuntuacionLimpieza.UseCompatibleTextRendering = true;
            // 
            // PuntuacionComunicacion
            // 
            PuntuacionComunicacion.AutoSize = true;
            PuntuacionComunicacion.Location = new Point(257, 195);
            PuntuacionComunicacion.Name = "PuntuacionComunicacion";
            PuntuacionComunicacion.Size = new Size(158, 15);
            PuntuacionComunicacion.TabIndex = 16;
            PuntuacionComunicacion.Text = "Claridad en la comunicación";
            // 
            // PuntuacionServicio
            // 
            PuntuacionServicio.AutoSize = true;
            PuntuacionServicio.Location = new Point(257, 158);
            PuntuacionServicio.Name = "PuntuacionServicio";
            PuntuacionServicio.Size = new Size(122, 15);
            PuntuacionServicio.TabIndex = 15;
            PuntuacionServicio.Text = "Desarrollo del servicio";
            // 
            // PuntuacionTrato
            // 
            PuntuacionTrato.AutoSize = true;
            PuntuacionTrato.Location = new Point(258, 120);
            PuntuacionTrato.Name = "PuntuacionTrato";
            PuntuacionTrato.Size = new Size(82, 15);
            PuntuacionTrato.TabIndex = 14;
            PuntuacionTrato.Text = "Trato personal";
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 408);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 23;
            pictureBoxICon.TabStop = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labeltitulo.ForeColor = SystemColors.ControlDarkDark;
            labeltitulo.Location = new Point(250, 21);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(166, 41);
            labeltitulo.TabIndex = 24;
            labeltitulo.Text = "Valoracion";
            // 
            // panelCliente
            // 
            panelCliente.BackColor = Color.DarkKhaki;
            panelCliente.Controls.Add(labelGeneral);
            panelCliente.ForeColor = SystemColors.ControlLightLight;
            panelCliente.Location = new Point(464, 79);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(47, 30);
            panelCliente.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkKhaki;
            panel1.Controls.Add(labelTrato);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(464, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(47, 30);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(labelDesarrollo);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(464, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(47, 30);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkKhaki;
            panel3.Controls.Add(labelComunicacion);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(464, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 30);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkKhaki;
            panel4.Controls.Add(labelOrganizacion);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(464, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(47, 30);
            panel4.TabIndex = 29;
            // 
            // richTextBoxComentario
            // 
            richTextBoxComentario.Location = new Point(257, 290);
            richTextBoxComentario.Margin = new Padding(3, 2, 3, 2);
            richTextBoxComentario.Name = "richTextBoxComentario";
            richTextBoxComentario.Size = new Size(615, 95);
            richTextBoxComentario.TabIndex = 30;
            richTextBoxComentario.Text = "";
            // 
            // Valoracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(913, 408);
            Controls.Add(richTextBoxComentario);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelCliente);
            Controls.Add(labeltitulo);
            Controls.Add(pictureBoxICon);
            Controls.Add(Puntuacion);
            Controls.Add(PuntuacionLimpieza);
            Controls.Add(PuntuacionComunicacion);
            Controls.Add(PuntuacionServicio);
            Controls.Add(PuntuacionTrato);
            Controls.Add(labelComentario);
            Controls.Add(labelImagen);
            Controls.Add(pictureBoxResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Valoracion";
            Text = "Valoracion";
            Load += Valoracion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTrato;
        private Label labelDesarrollo;
        private Label labelComunicacion;
        private Label labelOrganizacion;
        private Label labelGeneral;
        private PictureBox pictureBoxResultado;
        private Label labelImagen;
        private Label labelComentario;
        private Label Puntuacion;
        private Label PuntuacionLimpieza;
        private Label PuntuacionComunicacion;
        private Label PuntuacionServicio;
        private Label PuntuacionTrato;
        private PictureBox pictureBoxICon;
        private Label labeltitulo;
        private Panel panelCliente;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private RichTextBox richTextBoxComentario;
    }
}