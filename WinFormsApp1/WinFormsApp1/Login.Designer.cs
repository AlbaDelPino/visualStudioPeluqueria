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
            textBoxUsuario = new TextBox();
            textBoxContrasenya = new TextBox();
            buttonInicioSesion = new Button();
            labelTituoInicioSesion = new Label();
            panelIcon = new Panel();
            pictureBox1 = new PictureBox();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(336, 140);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(47, 15);
            LabelUsuario.TabIndex = 0;
            LabelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(336, 173);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 1;
            labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(434, 139);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContrasenya
            // 
            textBoxContrasenya.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContrasenya.Location = new Point(434, 168);
            textBoxContrasenya.Name = "textBoxContrasenya";
            textBoxContrasenya.PasswordChar = '●';
            textBoxContrasenya.Size = new Size(100, 23);
            textBoxContrasenya.TabIndex = 2;
            // 
            // buttonInicioSesion
            // 
            buttonInicioSesion.Location = new Point(399, 233);
            buttonInicioSesion.Name = "buttonInicioSesion";
            buttonInicioSesion.Size = new Size(75, 23);
            buttonInicioSesion.TabIndex = 3;
            buttonInicioSesion.Text = "Iniciar Session";
            buttonInicioSesion.UseVisualStyleBackColor = true;
            buttonInicioSesion.Click += buttonInicioSesion_Click;
            // 
            // labelTituoInicioSesion
            // 
            labelTituoInicioSesion.AutoSize = true;
            labelTituoInicioSesion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoInicioSesion.Location = new Point(361, 82);
            labelTituoInicioSesion.Name = "labelTituoInicioSesion";
            labelTituoInicioSesion.Size = new Size(154, 25);
            labelTituoInicioSesion.TabIndex = 25;
            labelTituoInicioSesion.Text = "INICIAR SESIÓN";
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBox1);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(292, 333);
            panelIcon.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPeluqueria;
            pictureBox1.Location = new Point(3, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 333);
            Controls.Add(panelIcon);
            Controls.Add(labelTituoInicioSesion);
            Controls.Add(buttonInicioSesion);
            Controls.Add(textBoxContrasenya);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(LabelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(610, 372);
            MinimizeBox = false;
            MinimumSize = new Size(610, 372);
            Name = "Login";
            Text = "Login";
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelUsuario;
        private Label labelContraseña;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasenya;
        private Button buttonInicioSesion;
        private Label labelTituoInicioSesion;
        private Panel panelIcon;
        private PictureBox pictureBox1;
    }
}