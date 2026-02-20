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
            labelTrato = new Label();
            labelDesarrollo = new Label();
            labelComunicacion = new Label();
            labelOrganizacion = new Label();
            labelGeneral = new Label();
            pictureBoxResultado = new PictureBox();
            labelImagen = new Label();
            labelComentario = new Label();
            TextBoxComentario = new RichTextBox();
            Puntuacion = new Label();
            PuntuacionLimpieza = new Label();
            PuntuacionComunicacion = new Label();
            PuntuacionServicio = new Label();
            PuntuacionTrato = new Label();
            pictureBoxICon = new PictureBox();
            labeltitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // labelTrato
            // 
            labelTrato.AutoSize = true;
            labelTrato.Location = new Point(472, 122);
            labelTrato.Name = "labelTrato";
            labelTrato.Size = new Size(31, 15);
            labelTrato.TabIndex = 5;
            labelTrato.Text = "PUN";
            // 
            // labelDesarrollo
            // 
            labelDesarrollo.AutoSize = true;
            labelDesarrollo.Location = new Point(474, 180);
            labelDesarrollo.Name = "labelDesarrollo";
            labelDesarrollo.Size = new Size(31, 15);
            labelDesarrollo.TabIndex = 6;
            labelDesarrollo.Text = "PUN";
            // 
            // labelComunicacion
            // 
            labelComunicacion.AutoSize = true;
            labelComunicacion.Location = new Point(474, 235);
            labelComunicacion.Name = "labelComunicacion";
            labelComunicacion.Size = new Size(31, 15);
            labelComunicacion.TabIndex = 7;
            labelComunicacion.Text = "PUN";
            // 
            // labelOrganizacion
            // 
            labelOrganizacion.AutoSize = true;
            labelOrganizacion.Location = new Point(474, 285);
            labelOrganizacion.Name = "labelOrganizacion";
            labelOrganizacion.Size = new Size(29, 21);
            labelOrganizacion.TabIndex = 8;
            labelOrganizacion.Text = "PUN";
            labelOrganizacion.UseCompatibleTextRendering = true;
            // 
            // labelGeneral
            // 
            labelGeneral.AutoSize = true;
            labelGeneral.Location = new Point(472, 84);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(31, 15);
            labelGeneral.TabIndex = 9;
            labelGeneral.Text = "PUN";
            // 
            // pictureBoxResultado
            // 
            pictureBoxResultado.Location = new Point(601, 125);
            pictureBoxResultado.Name = "pictureBoxResultado";
            pictureBoxResultado.Size = new Size(270, 125);
            pictureBoxResultado.TabIndex = 10;
            pictureBoxResultado.TabStop = false;
            // 
            // labelImagen
            // 
            labelImagen.AutoSize = true;
            labelImagen.Location = new Point(601, 84);
            labelImagen.Name = "labelImagen";
            labelImagen.Size = new Size(130, 21);
            labelImagen.TabIndex = 11;
            labelImagen.Text = "FOTO DEL RESULTADO";
            labelImagen.UseCompatibleTextRendering = true;
            labelImagen.Click += labelImagen_Click;
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.Location = new Point(257, 317);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(83, 21);
            labelComentario.TabIndex = 12;
            labelComentario.Text = "COMENTARIO";
            labelComentario.UseCompatibleTextRendering = true;
            // 
            // TextBoxComentario
            // 
            TextBoxComentario.Location = new Point(257, 341);
            TextBoxComentario.Name = "TextBoxComentario";
            TextBoxComentario.Size = new Size(641, 96);
            TextBoxComentario.TabIndex = 13;
            TextBoxComentario.Text = "";
            // 
            // Puntuacion
            // 
            Puntuacion.AutoSize = true;
            Puntuacion.Location = new Point(257, 84);
            Puntuacion.Name = "Puntuacion";
            Puntuacion.Size = new Size(136, 15);
            Puntuacion.TabIndex = 18;
            Puntuacion.Text = "PUNTUACION GENERAL";
            Puntuacion.Click += Puntuacion_Click;
            // 
            // PuntuacionLimpieza
            // 
            PuntuacionLimpieza.AutoSize = true;
            PuntuacionLimpieza.Location = new Point(257, 285);
            PuntuacionLimpieza.Name = "PuntuacionLimpieza";
            PuntuacionLimpieza.Size = new Size(160, 21);
            PuntuacionLimpieza.TabIndex = 17;
            PuntuacionLimpieza.Text = "LIMPIEZA Y ORGANIZACION";
            PuntuacionLimpieza.UseCompatibleTextRendering = true;
            // 
            // PuntuacionComunicacion
            // 
            PuntuacionComunicacion.AutoSize = true;
            PuntuacionComunicacion.Location = new Point(257, 235);
            PuntuacionComunicacion.Name = "PuntuacionComunicacion";
            PuntuacionComunicacion.Size = new Size(194, 15);
            PuntuacionComunicacion.TabIndex = 16;
            PuntuacionComunicacion.Text = "CLARIDAD EN LA COMUNICACIÓN";
            // 
            // PuntuacionServicio
            // 
            PuntuacionServicio.AutoSize = true;
            PuntuacionServicio.Location = new Point(257, 180);
            PuntuacionServicio.Name = "PuntuacionServicio";
            PuntuacionServicio.Size = new Size(154, 15);
            PuntuacionServicio.TabIndex = 15;
            PuntuacionServicio.Text = "DESARROLLO DEL SERVICIO";
            // 
            // PuntuacionTrato
            // 
            PuntuacionTrato.AutoSize = true;
            PuntuacionTrato.Location = new Point(257, 122);
            PuntuacionTrato.Name = "PuntuacionTrato";
            PuntuacionTrato.Size = new Size(104, 15);
            PuntuacionTrato.TabIndex = 14;
            PuntuacionTrato.Text = "TRATO PERSONAL";
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
            pictureBoxICon.TabIndex = 23;
            pictureBoxICon.TabStop = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labeltitulo.ForeColor = SystemColors.ControlDarkDark;
            labeltitulo.Location = new Point(250, 21);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(168, 32);
            labeltitulo.TabIndex = 24;
            labeltitulo.Text = "VALORACION";
            // 
            // Valoracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(944, 450);
            Controls.Add(labeltitulo);
            Controls.Add(pictureBoxICon);
            Controls.Add(Puntuacion);
            Controls.Add(PuntuacionLimpieza);
            Controls.Add(PuntuacionComunicacion);
            Controls.Add(PuntuacionServicio);
            Controls.Add(PuntuacionTrato);
            Controls.Add(TextBoxComentario);
            Controls.Add(labelComentario);
            Controls.Add(labelImagen);
            Controls.Add(pictureBoxResultado);
            Controls.Add(labelGeneral);
            Controls.Add(labelOrganizacion);
            Controls.Add(labelComunicacion);
            Controls.Add(labelDesarrollo);
            Controls.Add(labelTrato);
            Name = "Valoracion";
            Text = "Valoracion";
            Load += Valoracion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
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
        private RichTextBox TextBoxComentario;
        private Label Puntuacion;
        private Label PuntuacionLimpieza;
        private Label PuntuacionComunicacion;
        private Label PuntuacionServicio;
        private Label PuntuacionTrato;
        private PictureBox pictureBoxICon;
        private Label labeltitulo;
    }
}