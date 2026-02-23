namespace WinFormsApp1
{
    partial class Servicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicio));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ButtonSerModificar = new Button();
            labelSerDuracion = new Label();
            textBoxDuracion = new WinFormsApp1.Usuario.RoundedTextBox();
            labelSerTipo = new Label();
            labelSerDescripcion = new Label();
            labelTituoCrearServicio = new Label();
            txtBoxDescripcion = new WinFormsApp1.Usuario.RoundedTextBox();
            textBoxPrecio = new WinFormsApp1.Usuario.RoundedTextBox();
            labelSerPrecio = new Label();
            labelSerNombre = new Label();
            tboxNombreServicio = new WinFormsApp1.Usuario.RoundedTextBox();
            comboTipoServicio = new ComboBox();
            ButtonSerAnyadir = new Button();
            panelServicio = new Panel();
            panelIcon = new Panel();
            pictureBoxICon = new PictureBox();
            panelServicio.SuspendLayout();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // ButtonSerModificar
            // 
            ButtonSerModificar.BackColor = Color.DarkOrange;
            ButtonSerModificar.FlatStyle = FlatStyle.Flat;
            ButtonSerModificar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ButtonSerModificar.ForeColor = SystemColors.ControlLightLight;
            ButtonSerModificar.Location = new Point(375, 386);
            ButtonSerModificar.Margin = new Padding(3, 4, 3, 4);
            ButtonSerModificar.Name = "ButtonSerModificar";
            ButtonSerModificar.Size = new Size(214, 51);
            ButtonSerModificar.TabIndex = 69;
            ButtonSerModificar.Text = "Guardar cambios";
            ButtonSerModificar.UseVisualStyleBackColor = false;
            ButtonSerModificar.Visible = false;
            ButtonSerModificar.Click += ButtonSerModificar_Click;
            // 
            // labelSerDuracion
            // 
            labelSerDuracion.AutoSize = true;
            labelSerDuracion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerDuracion.Location = new Point(238, 217);
            labelSerDuracion.Margin = new Padding(5, 0, 5, 0);
            labelSerDuracion.Name = "labelSerDuracion";
            labelSerDuracion.Size = new Size(77, 20);
            labelSerDuracion.TabIndex = 68;
            labelSerDuracion.Text = "Duracion";
            // 
            // textBoxDuracion
            // 
            textBoxDuracion.BackColor = Color.White;
            textBoxDuracion.BorderColor = SystemColors.ControlDarkDark;
            textBoxDuracion.BorderRadius = 10;
            textBoxDuracion.BorderSize = 1;
            textBoxDuracion.Location = new Point(397, 217);
            textBoxDuracion.Margin = new Padding(3, 4, 3, 4);
            textBoxDuracion.Name = "textBoxDuracion";
            textBoxDuracion.PasswordChar = '\0';
            textBoxDuracion.ReadOnly = false;
            textBoxDuracion.Size = new Size(192, 32);
            textBoxDuracion.TabIndex = 53;
            // 
            // labelSerTipo
            // 
            labelSerTipo.AutoSize = true;
            labelSerTipo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerTipo.Location = new Point(238, 324);
            labelSerTipo.Margin = new Padding(5, 0, 5, 0);
            labelSerTipo.Name = "labelSerTipo";
            labelSerTipo.Size = new Size(127, 20);
            labelSerTipo.TabIndex = 66;
            labelSerTipo.Text = "Tipo de servicio";
            // 
            // labelSerDescripcion
            // 
            labelSerDescripcion.AutoSize = true;
            labelSerDescripcion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerDescripcion.Location = new Point(238, 161);
            labelSerDescripcion.Margin = new Padding(5, 0, 5, 0);
            labelSerDescripcion.Name = "labelSerDescripcion";
            labelSerDescripcion.Size = new Size(99, 20);
            labelSerDescripcion.TabIndex = 63;
            labelSerDescripcion.Text = "Descripcion";
            // 
            // labelTituoCrearServicio
            // 
            labelTituoCrearServicio.AutoSize = true;
            labelTituoCrearServicio.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            labelTituoCrearServicio.ForeColor = SystemColors.ControlDarkDark;
            labelTituoCrearServicio.Location = new Point(238, 28);
            labelTituoCrearServicio.Name = "labelTituoCrearServicio";
            labelTituoCrearServicio.Size = new Size(284, 50);
            labelTituoCrearServicio.TabIndex = 62;
            labelTituoCrearServicio.Text = "Añadir servicio";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.BackColor = Color.White;
            txtBoxDescripcion.BorderColor = SystemColors.ControlDarkDark;
            txtBoxDescripcion.BorderRadius = 10;
            txtBoxDescripcion.BorderSize = 1;
            txtBoxDescripcion.Location = new Point(397, 161);
            txtBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.PasswordChar = '\0';
            txtBoxDescripcion.ReadOnly = false;
            txtBoxDescripcion.Size = new Size(192, 32);
            txtBoxDescripcion.TabIndex = 50;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.BackColor = Color.White;
            textBoxPrecio.BorderColor = SystemColors.ControlDarkDark;
            textBoxPrecio.BorderRadius = 10;
            textBoxPrecio.BorderSize = 1;
            textBoxPrecio.Location = new Point(397, 268);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PasswordChar = '\0';
            textBoxPrecio.ReadOnly = false;
            textBoxPrecio.Size = new Size(192, 32);
            textBoxPrecio.TabIndex = 52;
            // 
            // labelSerPrecio
            // 
            labelSerPrecio.AutoSize = true;
            labelSerPrecio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerPrecio.Location = new Point(238, 268);
            labelSerPrecio.Margin = new Padding(5, 0, 5, 0);
            labelSerPrecio.Name = "labelSerPrecio";
            labelSerPrecio.Size = new Size(57, 20);
            labelSerPrecio.TabIndex = 59;
            labelSerPrecio.Text = "Precio";
            // 
            // labelSerNombre
            // 
            labelSerNombre.AutoSize = true;
            labelSerNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerNombre.Location = new Point(238, 111);
            labelSerNombre.Margin = new Padding(5, 0, 5, 0);
            labelSerNombre.Name = "labelSerNombre";
            labelSerNombre.Size = new Size(68, 20);
            labelSerNombre.TabIndex = 48;
            labelSerNombre.Text = "Nombre";
            // 
            // tboxNombreServicio
            // 
            tboxNombreServicio.BackColor = Color.White;
            tboxNombreServicio.BorderColor = SystemColors.ControlDarkDark;
            tboxNombreServicio.BorderRadius = 10;
            tboxNombreServicio.BorderSize = 1;
            tboxNombreServicio.Location = new Point(397, 111);
            tboxNombreServicio.Margin = new Padding(3, 4, 3, 4);
            tboxNombreServicio.Name = "tboxNombreServicio";
            tboxNombreServicio.PasswordChar = '\0';
            tboxNombreServicio.ReadOnly = false;
            tboxNombreServicio.Size = new Size(192, 32);
            tboxNombreServicio.TabIndex = 49;
            // 
            // comboTipoServicio
            // 
            comboTipoServicio.DisplayMember = "1";
            comboTipoServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServicio.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboTipoServicio.Location = new Point(397, 322);
            comboTipoServicio.Margin = new Padding(5, 4, 5, 4);
            comboTipoServicio.MaxDropDownItems = 3;
            comboTipoServicio.Name = "comboTipoServicio";
            comboTipoServicio.Size = new Size(192, 28);
            comboTipoServicio.TabIndex = 70;
            comboTipoServicio.UseWaitCursor = true;
            // 
            // ButtonSerAnyadir
            // 
            ButtonSerAnyadir.BackColor = Color.DarkOrange;
            ButtonSerAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonSerAnyadir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSerAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonSerAnyadir.Location = new Point(456, 386);
            ButtonSerAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonSerAnyadir.Name = "ButtonSerAnyadir";
            ButtonSerAnyadir.Size = new Size(133, 51);
            ButtonSerAnyadir.TabIndex = 71;
            ButtonSerAnyadir.Text = "Añadir";
            ButtonSerAnyadir.UseVisualStyleBackColor = false;
            ButtonSerAnyadir.Click += ButtonSerAnyadir_Click;
            // 
            // panelServicio
            // 
            panelServicio.Controls.Add(panelIcon);
            panelServicio.Controls.Add(labelTituoCrearServicio);
            panelServicio.Controls.Add(ButtonSerAnyadir);
            panelServicio.Controls.Add(labelSerNombre);
            panelServicio.Controls.Add(comboTipoServicio);
            panelServicio.Controls.Add(tboxNombreServicio);
            panelServicio.Controls.Add(ButtonSerModificar);
            panelServicio.Controls.Add(labelSerPrecio);
            panelServicio.Controls.Add(labelSerDuracion);
            panelServicio.Controls.Add(textBoxPrecio);
            panelServicio.Controls.Add(textBoxDuracion);
            panelServicio.Controls.Add(txtBoxDescripcion);
            panelServicio.Controls.Add(labelSerDescripcion);
            panelServicio.Controls.Add(labelSerTipo);
            panelServicio.Dock = DockStyle.Fill;
            panelServicio.Location = new Point(0, 0);
            panelServicio.Name = "panelServicio";
            panelServicio.Size = new Size(640, 478);
            panelServicio.TabIndex = 72;
            panelServicio.Paint += panelServicio_Paint;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBoxICon);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(208, 478);
            panelIcon.TabIndex = 94;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.Dock = DockStyle.Fill;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 478);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 0;
            pictureBoxICon.TabStop = false;
            // 
            // Servicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 478);
            Controls.Add(panelServicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(40683, 37318);
            MinimizeBox = false;
            MinimumSize = new Size(404, 358);
            Name = "Servicio";
            Text = "Añadir Servicio";
            Load += Servicio_Load;
            panelServicio.ResumeLayout(false);
            panelServicio.PerformLayout();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Usuario.RoundedTextBox textBoxUsConfigContrasenya;
        private Button ButtonSerAnyadir;
        private ComboBox comboTipoServicio;
        private Button ButtonSerModificar;
        private Label labelSerDuracion;
        private Usuario.RoundedTextBox textBoxDuracion;
        private Label labelSerTipo;
        private Label labelSerDescripcion;
        private Label labelTituoCrearServicio;
        private Usuario.RoundedTextBox txtBoxDescripcion;
        private Usuario.RoundedTextBox textBoxPrecio;
        private Label labelSerPrecio;
        private Label labelSerNombre;
        private Usuario.RoundedTextBox tboxNombreServicio;
        private Panel panelServicio;
        private Panel panelIcon;
        private PictureBox pictureBoxICon;
    }
}
