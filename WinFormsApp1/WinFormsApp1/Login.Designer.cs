using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 7767
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LabelUsuario = new Label();
            labelContraseña = new Label();
            textBoxUsuario = new WinFormsApp1.Usuario.RoundedTextBox();
            textBoxContrasenya = new WinFormsApp1.Usuario.RoundedTextBox();
            buttonInicioSesion = new WinFormsApp1.Bloqueo.RoundedButton();
            labelTituoInicioSesion = new Label();
            panelIcon = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxMostrar = new PictureBox();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrar).BeginInit();
            SuspendLayout();
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(383, 148);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(59, 20);
            LabelUsuario.TabIndex = 0;
            LabelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(382, 193);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(83, 20);
            labelContraseña.TabIndex = 1;
            labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.BorderColor = SystemColors.ControlDarkDark;
            textBoxUsuario.BorderRadius = 10;
            textBoxUsuario.BorderSize = 1;
            textBoxUsuario.Location = new Point(495, 146);
            textBoxUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PasswordChar = '\0';
            textBoxUsuario.ReadOnly = false;
            textBoxUsuario.Size = new Size(114, 32);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContrasenya
            // 
            textBoxContrasenya.BackColor = Color.White;
            textBoxContrasenya.BorderColor = SystemColors.ControlDarkDark;
            textBoxContrasenya.BorderRadius = 10;
            textBoxContrasenya.BorderSize = 1;
            textBoxContrasenya.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContrasenya.Location = new Point(494, 186);
            textBoxContrasenya.Margin = new Padding(3, 4, 3, 4);
            textBoxContrasenya.Name = "textBoxContrasenya";
            textBoxContrasenya.PasswordChar = '●';
            textBoxContrasenya.ReadOnly = false;
            textBoxContrasenya.Size = new Size(114, 32);
            textBoxContrasenya.TabIndex = 2;
            // 
            // buttonInicioSesion
            // 
            buttonInicioSesion.BackColor = Color.DarkOrange;
            buttonInicioSesion.BorderColor = Color.Gray;
            buttonInicioSesion.BorderRadius = 10;
            buttonInicioSesion.BorderSize = 1;
            buttonInicioSesion.FlatStyle = FlatStyle.Flat;
            buttonInicioSesion.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonInicioSesion.ForeColor = SystemColors.ControlLightLight;
            buttonInicioSesion.HoverColor = Color.FromArgb(235, 120, 0);
            buttonInicioSesion.Location = new Point(448, 262);
            buttonInicioSesion.Margin = new Padding(3, 4, 3, 4);
            buttonInicioSesion.Name = "buttonInicioSesion";
            buttonInicioSesion.PaddingHorizontal = 12;
            buttonInicioSesion.PaddingVertical = 8;
            buttonInicioSesion.PressedColor = Color.FromArgb(255, 192, 128);
            buttonInicioSesion.Size = new Size(107, 40);
            buttonInicioSesion.TabIndex = 3;
            buttonInicioSesion.Text = "Iniciar";
            buttonInicioSesion.UseVisualStyleBackColor = false;
            buttonInicioSesion.Click += buttonInicioSesion_Click;
            // 
            // labelTituoInicioSesion
            // 
            labelTituoInicioSesion.AutoSize = true;
            labelTituoInicioSesion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituoInicioSesion.ForeColor = SystemColors.ControlDarkDark;
            labelTituoInicioSesion.Location = new Point(383, 60);
            labelTituoInicioSesion.Name = "labelTituoInicioSesion";
            labelTituoInicioSesion.Size = new Size(229, 46);
            labelTituoInicioSesion.TabIndex = 25;
            labelTituoInicioSesion.Text = "Iniciar sesión";
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBox1);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(334, 366);
            panelIcon.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPeluqueria;
            pictureBox1.Location = new Point(6, 60);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxMostrar
            // 
            pictureBoxMostrar.Image = Properties.Resources.Ojo;
            pictureBoxMostrar.Location = new Point(609, 181);
            pictureBoxMostrar.Name = "pictureBoxMostrar";
            pictureBoxMostrar.Size = new Size(46, 40);
            pictureBoxMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMostrar.TabIndex = 27;
            pictureBoxMostrar.TabStop = false;
            pictureBoxMostrar.Click += pictureBoxMostrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 366);
            Controls.Add(pictureBoxMostrar);
            Controls.Add(panelIcon);
            Controls.Add(labelTituoInicioSesion);
            Controls.Add(buttonInicioSesion);
            Controls.Add(textBoxContrasenya);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(LabelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(695, 1000);
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelUsuario;
        private Label labelContraseña;
        private Usuario.RoundedTextBox textBoxUsuario;
        private Usuario.RoundedTextBox textBoxContrasenya;
        private Bloqueo.RoundedButton buttonInicioSesion;
        private Label labelTituoInicioSesion;
        private Panel panelIcon;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxMostrar;

    }
}