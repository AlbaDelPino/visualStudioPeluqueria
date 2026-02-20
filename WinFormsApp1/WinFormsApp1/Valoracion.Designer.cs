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
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).BeginInit();
            SuspendLayout();
            // 
            // labelTrato
            // 
            labelTrato.AutoSize = true;
            labelTrato.Location = new Point(160, 86);
            labelTrato.Name = "labelTrato";
            labelTrato.Size = new Size(82, 15);
            labelTrato.TabIndex = 5;
            labelTrato.Text = "Trato Personal";
            // 
            // labelDesarrollo
            // 
            labelDesarrollo.AutoSize = true;
            labelDesarrollo.Location = new Point(160, 144);
            labelDesarrollo.Name = "labelDesarrollo";
            labelDesarrollo.Size = new Size(122, 15);
            labelDesarrollo.TabIndex = 6;
            labelDesarrollo.Text = "Desarrollo del servicio";
            // 
            // labelComunicacion
            // 
            labelComunicacion.AutoSize = true;
            labelComunicacion.Location = new Point(160, 199);
            labelComunicacion.Name = "labelComunicacion";
            labelComunicacion.Size = new Size(158, 15);
            labelComunicacion.TabIndex = 7;
            labelComunicacion.Text = "Claridad en la comunicación";
            // 
            // labelOrganizacion
            // 
            labelOrganizacion.AutoSize = true;
            labelOrganizacion.Location = new Point(160, 249);
            labelOrganizacion.Name = "labelOrganizacion";
            labelOrganizacion.Size = new Size(135, 21);
            labelOrganizacion.TabIndex = 8;
            labelOrganizacion.Text = "Limpieza y organización";
            labelOrganizacion.UseCompatibleTextRendering = true;
            // 
            // labelGeneral
            // 
            labelGeneral.AutoSize = true;
            labelGeneral.Location = new Point(160, 48);
            labelGeneral.Name = "labelGeneral";
            labelGeneral.Size = new Size(110, 15);
            labelGeneral.TabIndex = 9;
            labelGeneral.Text = "Puntuacion general";
            // 
            // pictureBoxResultado
            // 
            pictureBoxResultado.Location = new Point(500, 86);
            pictureBoxResultado.Name = "pictureBoxResultado";
            pictureBoxResultado.Size = new Size(270, 125);
            pictureBoxResultado.TabIndex = 10;
            pictureBoxResultado.TabStop = false;
            // 
            // labelImagen
            // 
            labelImagen.AutoSize = true;
            labelImagen.Location = new Point(500, 40);
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
            labelComentario.Location = new Point(160, 297);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(83, 21);
            labelComentario.TabIndex = 12;
            labelComentario.Text = "COMENTARIO";
            labelComentario.UseCompatibleTextRendering = true;
            // 
            // TextBoxComentario
            // 
            TextBoxComentario.Location = new Point(160, 321);
            TextBoxComentario.Name = "TextBoxComentario";
            TextBoxComentario.Size = new Size(352, 96);
            TextBoxComentario.TabIndex = 13;
            TextBoxComentario.Text = "";
            // 
            // Puntuacion
            // 
            Puntuacion.AutoSize = true;
            Puntuacion.Location = new Point(321, 48);
            Puntuacion.Name = "Puntuacion";
            Puntuacion.Size = new Size(110, 15);
            Puntuacion.TabIndex = 18;
            Puntuacion.Text = "Puntuacion general";
            // 
            // PuntuacionLimpieza
            // 
            PuntuacionLimpieza.AutoSize = true;
            PuntuacionLimpieza.Location = new Point(321, 249);
            PuntuacionLimpieza.Name = "PuntuacionLimpieza";
            PuntuacionLimpieza.Size = new Size(135, 21);
            PuntuacionLimpieza.TabIndex = 17;
            PuntuacionLimpieza.Text = "Limpieza y organización";
            PuntuacionLimpieza.UseCompatibleTextRendering = true;
            // 
            // PuntuacionComunicacion
            // 
            PuntuacionComunicacion.AutoSize = true;
            PuntuacionComunicacion.Location = new Point(321, 199);
            PuntuacionComunicacion.Name = "PuntuacionComunicacion";
            PuntuacionComunicacion.Size = new Size(158, 15);
            PuntuacionComunicacion.TabIndex = 16;
            PuntuacionComunicacion.Text = "Claridad en la comunicación";
            // 
            // PuntuacionServicio
            // 
            PuntuacionServicio.AutoSize = true;
            PuntuacionServicio.Location = new Point(321, 144);
            PuntuacionServicio.Name = "PuntuacionServicio";
            PuntuacionServicio.Size = new Size(122, 15);
            PuntuacionServicio.TabIndex = 15;
            PuntuacionServicio.Text = "Desarrollo del servicio";
            // 
            // PuntuacionTrato
            // 
            PuntuacionTrato.AutoSize = true;
            PuntuacionTrato.Location = new Point(321, 86);
            PuntuacionTrato.Name = "PuntuacionTrato";
            PuntuacionTrato.Size = new Size(82, 15);
            PuntuacionTrato.TabIndex = 14;
            PuntuacionTrato.Text = "Trato Personal";
            // 
            // Valoracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
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
    }
}