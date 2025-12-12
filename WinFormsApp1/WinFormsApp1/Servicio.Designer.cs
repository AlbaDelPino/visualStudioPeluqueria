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
            textBoxDuracion = new TextBox();
            label2 = new Label();
            labelSerTipo = new Label();
            labelSerDescripcion = new Label();
            labelTituoCrearServicio = new Label();
            txtBoxDescripcion = new TextBox();
            label1 = new Label();
            textBoxPrecio = new TextBox();
            labelSerPrecio = new Label();
            labelSerNombre = new Label();
            tboxNombreServicio = new TextBox();
            comboTipoServicio = new ComboBox();
            ButtonSerAnyadir = new Button();
            panelServicio = new Panel();
            panelServicio.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonSerModificar
            // 
            ButtonSerModificar.Location = new Point(111, 208);
            ButtonSerModificar.Name = "ButtonSerModificar";
            ButtonSerModificar.Size = new Size(128, 23);
            ButtonSerModificar.TabIndex = 69;
            ButtonSerModificar.Text = "Guardar cambios";
            ButtonSerModificar.UseVisualStyleBackColor = true;
            ButtonSerModificar.Visible = false;
            ButtonSerModificar.Click += ButtonSerModificar_Click;
            // 
            // labelSerDuracion
            // 
            labelSerDuracion.AutoSize = true;
            labelSerDuracion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerDuracion.Location = new Point(35, 139);
            labelSerDuracion.Margin = new Padding(4, 0, 4, 0);
            labelSerDuracion.Name = "labelSerDuracion";
            labelSerDuracion.Size = new Size(65, 17);
            labelSerDuracion.TabIndex = 68;
            labelSerDuracion.Text = "Duracion";
            // 
            // textBoxDuracion
            // 
            textBoxDuracion.Location = new Point(174, 139);
            textBoxDuracion.Name = "textBoxDuracion";
            textBoxDuracion.Size = new Size(140, 23);
            textBoxDuracion.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 67;
            // 
            // labelSerTipo
            // 
            labelSerTipo.AutoSize = true;
            labelSerTipo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerTipo.Location = new Point(35, 170);
            labelSerTipo.Margin = new Padding(4, 0, 4, 0);
            labelSerTipo.Name = "labelSerTipo";
            labelSerTipo.Size = new Size(108, 17);
            labelSerTipo.TabIndex = 66;
            labelSerTipo.Text = "Tipo de servicio";
            // 
            // labelSerDescripcion
            // 
            labelSerDescripcion.AutoSize = true;
            labelSerDescripcion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerDescripcion.Location = new Point(35, 85);
            labelSerDescripcion.Margin = new Padding(4, 0, 4, 0);
            labelSerDescripcion.Name = "labelSerDescripcion";
            labelSerDescripcion.Size = new Size(82, 17);
            labelSerDescripcion.TabIndex = 63;
            labelSerDescripcion.Text = "Descripcion";
            // 
            // labelTituoCrearServicio
            // 
            labelTituoCrearServicio.AutoSize = true;
            labelTituoCrearServicio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoCrearServicio.Location = new Point(87, 18);
            labelTituoCrearServicio.Name = "labelTituoCrearServicio";
            labelTituoCrearServicio.Size = new Size(174, 25);
            labelTituoCrearServicio.TabIndex = 62;
            labelTituoCrearServicio.Text = "AÑADIR SERVICIO";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(174, 85);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(140, 23);
            txtBoxDescripcion.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 61;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(174, 111);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(140, 23);
            textBoxPrecio.TabIndex = 52;
            // 
            // labelSerPrecio
            // 
            labelSerPrecio.AutoSize = true;
            labelSerPrecio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerPrecio.Location = new Point(35, 111);
            labelSerPrecio.Margin = new Padding(4, 0, 4, 0);
            labelSerPrecio.Name = "labelSerPrecio";
            labelSerPrecio.Size = new Size(48, 17);
            labelSerPrecio.TabIndex = 59;
            labelSerPrecio.Text = "Precio";
            // 
            // labelSerNombre
            // 
            labelSerNombre.AutoSize = true;
            labelSerNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerNombre.Location = new Point(35, 58);
            labelSerNombre.Margin = new Padding(4, 0, 4, 0);
            labelSerNombre.Name = "labelSerNombre";
            labelSerNombre.Size = new Size(58, 17);
            labelSerNombre.TabIndex = 48;
            labelSerNombre.Text = "Nombre";
            // 
            // tboxNombreServicio
            // 
            tboxNombreServicio.Location = new Point(174, 58);
            tboxNombreServicio.Name = "tboxNombreServicio";
            tboxNombreServicio.Size = new Size(140, 23);
            tboxNombreServicio.TabIndex = 49;
            // 
            // comboTipoServicio
            // 
            comboTipoServicio.DisplayMember = "1";
            comboTipoServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServicio.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboTipoServicio.Location = new Point(174, 168);
            comboTipoServicio.Margin = new Padding(4, 3, 4, 3);
            comboTipoServicio.MaxDropDownItems = 3;
            comboTipoServicio.Name = "comboTipoServicio";
            comboTipoServicio.Size = new Size(140, 23);
            comboTipoServicio.TabIndex = 70;
            comboTipoServicio.UseWaitCursor = true;
            // 
            // ButtonSerAnyadir
            // 
            ButtonSerAnyadir.Location = new Point(139, 208);
            ButtonSerAnyadir.Name = "ButtonSerAnyadir";
            ButtonSerAnyadir.Size = new Size(75, 23);
            ButtonSerAnyadir.TabIndex = 71;
            ButtonSerAnyadir.Text = "Añadir";
            ButtonSerAnyadir.UseVisualStyleBackColor = true;
            ButtonSerAnyadir.Click += ButtonSerAnyadir_Click;
            // 
            // panelServicio
            // 
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
            panelServicio.Margin = new Padding(3, 2, 3, 2);
            panelServicio.Name = "panelServicio";
            panelServicio.Size = new Size(341, 243);
            panelServicio.TabIndex = 72;
            // 
            // Servicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 243);
            Controls.Add(panelServicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(357, 282);
            MinimizeBox = false;
            MinimumSize = new Size(357, 282);
            Name = "Servicio";
            Text = "Añadir Servicio";
            panelServicio.ResumeLayout(false);
            panelServicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxUsConfigContrasenya;
        private Button ButtonSerAnyadir;
        private ComboBox comboTipoServicio;
        private Button ButtonSerModificar;
        private Label labelSerDuracion;
        private TextBox textBoxDuracion;
        private Label label2;
        private Label labelSerTipo;
        private Label labelSerDescripcion;
        private Label labelTituoCrearServicio;
        private TextBox txtBoxDescripcion;
        private Label label1;
        private TextBox textBoxPrecio;
        private Label labelSerPrecio;
        private Label labelSerNombre;
        private TextBox tboxNombreServicio;
        private Panel panelServicio;

        public TextBox TboxNombreServicio
        {
            get
            {
                return this.tboxNombreServicio;
            }
            set
            {
                this.tboxNombreServicio = value;
            }
        }

        public TextBox TxtBoxDescripcion
        {
            get
            {
                return this.txtBoxDescripcion;
            }
            set
            {
                this.txtBoxDescripcion = value;
            }
        }

        public TextBox TextBoxPrecio
        {
            get
            {
                return this.textBoxPrecio;
            }
            set
            {
                this.textBoxPrecio = value;
            }
        }

        public TextBox TextBoxDuracion
        {
            get
            {
                return this.textBoxDuracion;
            }
            set
            {
                this.textBoxDuracion = value;
            }
        }

        public ComboBox ComboTipoServicio
        {
            get
            {
                return this.comboTipoServicio;
            }
            set
            {
                this.comboTipoServicio = value;
            }
        }

        public string LabelTituoCrearServicio
        {
            get
            {
                return this.labelTituoCrearServicio.Text;
            }
            set
            {
                this.labelTituoCrearServicio.Text = value;
            }
        }

        public bool buttonSerAnyadir
        {
            get
            {
                return this.ButtonSerAnyadir.Visible;
            }
            set
            {
                this.ButtonSerAnyadir.Visible = value;
            }
        }
        public bool buttonSerModificar
        {
            get
            {
                return this.ButtonSerModificar.Visible;
            }
            set
            {
                this.ButtonSerModificar.Visible = value;
            }
        }
        public string Form
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }
    }
}
