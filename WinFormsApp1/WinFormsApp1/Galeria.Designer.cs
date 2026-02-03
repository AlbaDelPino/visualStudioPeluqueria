namespace WinFormsApp1
{
    partial class Galeria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            ButtonGaAnyadir = new Button();
            ButtonGaModificar = new Button();
            buttonHoServicio = new Button();
            textBoxHoServicio = new TextBox();
            labelHoServicio = new Label();
            pictureBox1 = new PictureBox();
            buttonAnydirImagen = new Button();
            panelIcon = new Panel();
            pictureBox2 = new PictureBox();
            labelTituoCrearGaleria = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ButtonGaAnyadir
            // 
            ButtonGaAnyadir.Location = new Point(563, 409);
            ButtonGaAnyadir.Name = "ButtonGaAnyadir";
            ButtonGaAnyadir.Size = new Size(75, 23);
            ButtonGaAnyadir.TabIndex = 73;
            ButtonGaAnyadir.Text = "Añadir";
            ButtonGaAnyadir.UseVisualStyleBackColor = true;
            // 
            // ButtonGaModificar
            // 
            ButtonGaModificar.Location = new Point(535, 409);
            ButtonGaModificar.Name = "ButtonGaModificar";
            ButtonGaModificar.Size = new Size(128, 23);
            ButtonGaModificar.TabIndex = 72;
            ButtonGaModificar.Text = "Guardar cambios";
            ButtonGaModificar.UseVisualStyleBackColor = true;
            ButtonGaModificar.Visible = false;
            // 
            // buttonHoServicio
            // 
            buttonHoServicio.Location = new Point(758, 77);
            buttonHoServicio.Name = "buttonHoServicio";
            buttonHoServicio.Size = new Size(75, 23);
            buttonHoServicio.TabIndex = 82;
            buttonHoServicio.Text = "...";
            buttonHoServicio.UseVisualStyleBackColor = true;
            buttonHoServicio.Click += buttonHoServicio_Click;
            // 
            // textBoxHoServicio
            // 
            textBoxHoServicio.Location = new Point(433, 77);
            textBoxHoServicio.Name = "textBoxHoServicio";
            textBoxHoServicio.ReadOnly = true;
            textBoxHoServicio.Size = new Size(291, 23);
            textBoxHoServicio.TabIndex = 81;
            // 
            // labelHoServicio
            // 
            labelHoServicio.AutoSize = true;
            labelHoServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoServicio.Location = new Point(346, 77);
            labelHoServicio.Margin = new Padding(5, 0, 5, 0);
            labelHoServicio.Name = "labelHoServicio";
            labelHoServicio.Size = new Size(58, 17);
            labelHoServicio.TabIndex = 80;
            labelHoServicio.Text = "Servicio";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(369, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 256);
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // buttonAnydirImagen
            // 
            buttonAnydirImagen.Location = new Point(346, 118);
            buttonAnydirImagen.Name = "buttonAnydirImagen";
            buttonAnydirImagen.Size = new Size(119, 23);
            buttonAnydirImagen.TabIndex = 84;
            buttonAnydirImagen.Text = "Añadir Imagen";
            buttonAnydirImagen.UseVisualStyleBackColor = true;
            buttonAnydirImagen.Click += buttonAnydirImagen_Click;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBox2);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(292, 473);
            panelIcon.TabIndex = 85;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconPeluqueria;
            pictureBox2.Location = new Point(3, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // labelTituoCrearGaleria
            // 
            labelTituoCrearGaleria.AutoSize = true;
            labelTituoCrearGaleria.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoCrearGaleria.ForeColor = Color.FromArgb(241, 123, 35);
            labelTituoCrearGaleria.Location = new Point(464, 19);
            labelTituoCrearGaleria.Name = "labelTituoCrearGaleria";
            labelTituoCrearGaleria.Size = new Size(174, 25);
            labelTituoCrearGaleria.TabIndex = 63;
            labelTituoCrearGaleria.Text = "AÑADIR SERVICIO";
            // 
            // Galeria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 473);
            Controls.Add(panelIcon);
            Controls.Add(buttonAnydirImagen);
            Controls.Add(pictureBox1);
            Controls.Add(buttonHoServicio);
            Controls.Add(textBoxHoServicio);
            Controls.Add(labelHoServicio);
            Controls.Add(ButtonGaAnyadir);
            Controls.Add(ButtonGaModificar);
            Controls.Add(labelTituoCrearGaleria);
            Name = "Galeria";
            Text = "Galeria";
            Load += Galeria_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelTituoCrearGaleria;
        public Button ButtonGaAnyadir;
        public Button ButtonGaModificar;
        private Button buttonHoServicio;
        private TextBox textBoxHoServicio;
        private Label labelHoServicio;
        private PictureBox pictureBox1;
        private Button buttonAnydirImagen;
        private Panel panelIcon;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}