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
            pictureBoxFoto = new PictureBox();
            buttonAnydirImagen = new Button();
            panelIcon = new Panel();
            pictureBoxICon = new PictureBox();
            labelTituoCrearGaleria = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // ButtonGaAnyadir
            // 
            ButtonGaAnyadir.BackColor = Color.DarkOrange;
            ButtonGaAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonGaAnyadir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ButtonGaAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonGaAnyadir.Location = new Point(607, 587);
            ButtonGaAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonGaAnyadir.Name = "ButtonGaAnyadir";
            ButtonGaAnyadir.Size = new Size(132, 50);
            ButtonGaAnyadir.TabIndex = 73;
            ButtonGaAnyadir.Text = "Añadir";
            ButtonGaAnyadir.UseVisualStyleBackColor = false;
            ButtonGaAnyadir.Click += ButtonGaAnyadir_Click;
            // 
            // ButtonGaModificar
            // 
            ButtonGaModificar.BackColor = Color.DarkOrange;
            ButtonGaModificar.FlatStyle = FlatStyle.Flat;
            ButtonGaModificar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonGaModificar.ForeColor = SystemColors.ControlLightLight;
            ButtonGaModificar.Location = new Point(540, 587);
            ButtonGaModificar.Margin = new Padding(3, 4, 3, 4);
            ButtonGaModificar.Name = "ButtonGaModificar";
            ButtonGaModificar.Size = new Size(199, 50);
            ButtonGaModificar.TabIndex = 72;
            ButtonGaModificar.Text = "Guardar cambios";
            ButtonGaModificar.UseVisualStyleBackColor = false;
            ButtonGaModificar.Visible = false;
            // 
            // buttonHoServicio
            // 
            buttonHoServicio.Location = new Point(685, 101);
            buttonHoServicio.Margin = new Padding(3, 4, 3, 4);
            buttonHoServicio.Name = "buttonHoServicio";
            buttonHoServicio.Size = new Size(50, 30);
            buttonHoServicio.TabIndex = 82;
            buttonHoServicio.UseVisualStyleBackColor = true;
            buttonHoServicio.Click += buttonHoServicio_Click;
            buttonHoServicio.Paint += buttonHoServicio_Paint;
            // 
            // textBoxHoServicio
            // 
            textBoxHoServicio.Location = new Point(402, 102);
            textBoxHoServicio.Margin = new Padding(3, 4, 3, 4);
            textBoxHoServicio.Name = "textBoxHoServicio";
            textBoxHoServicio.ReadOnly = true;
            textBoxHoServicio.Size = new Size(262, 27);
            textBoxHoServicio.TabIndex = 81;
            // 
            // labelHoServicio
            // 
            labelHoServicio.AutoSize = true;
            labelHoServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHoServicio.Location = new Point(303, 102);
            labelHoServicio.Margin = new Padding(6, 0, 6, 0);
            labelHoServicio.Name = "labelHoServicio";
            labelHoServicio.Size = new Size(69, 20);
            labelHoServicio.TabIndex = 80;
            labelHoServicio.Text = "Servicio";
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(340, 217);
            pictureBoxFoto.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(399, 341);
            pictureBoxFoto.TabIndex = 83;
            pictureBoxFoto.TabStop = false;
            // 
            // buttonAnydirImagen
            // 
            buttonAnydirImagen.BackColor = Color.DarkOrange;
            buttonAnydirImagen.FlatStyle = FlatStyle.Flat;
            buttonAnydirImagen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonAnydirImagen.ForeColor = SystemColors.ControlLightLight;
            buttonAnydirImagen.Location = new Point(340, 159);
            buttonAnydirImagen.Margin = new Padding(3, 4, 3, 4);
            buttonAnydirImagen.Name = "buttonAnydirImagen";
            buttonAnydirImagen.Size = new Size(188, 50);
            buttonAnydirImagen.TabIndex = 84;
            buttonAnydirImagen.Text = "Añadir Imagen";
            buttonAnydirImagen.UseVisualStyleBackColor = false;
            buttonAnydirImagen.Click += buttonAnydirImagen_Click;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBoxICon);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(255, 666);
            panelIcon.TabIndex = 85;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.Dock = DockStyle.Fill;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(255, 666);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 0;
            pictureBoxICon.TabStop = false;
            // 
            // labelTituoCrearGaleria
            // 
            labelTituoCrearGaleria.AutoSize = true;
            labelTituoCrearGaleria.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labelTituoCrearGaleria.ForeColor = SystemColors.ControlDarkDark;
            labelTituoCrearGaleria.Location = new Point(303, 31);
            labelTituoCrearGaleria.Name = "labelTituoCrearGaleria";
            labelTituoCrearGaleria.Size = new Size(336, 50);
            labelTituoCrearGaleria.TabIndex = 63;
            labelTituoCrearGaleria.Text = "Añadir nueva foto";
            // 
            // Galeria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 666);
            Controls.Add(panelIcon);
            Controls.Add(buttonAnydirImagen);
            Controls.Add(pictureBoxFoto);
            Controls.Add(buttonHoServicio);
            Controls.Add(textBoxHoServicio);
            Controls.Add(labelHoServicio);
            Controls.Add(ButtonGaAnyadir);
            Controls.Add(ButtonGaModificar);
            Controls.Add(labelTituoCrearGaleria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Galeria";
            Text = "Galeria";
            Load += Galeria_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
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
        private PictureBox pictureBoxFoto;
        private Button buttonAnydirImagen;
        private Panel panelIcon;
        private PictureBox pictureBoxICon;
        private Panel panel1;
    }
}