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
            ButtonSerModificar.Location = new Point(127, 277);
            ButtonSerModificar.Margin = new Padding(3, 4, 3, 4);
            ButtonSerModificar.Name = "ButtonSerModificar";
            ButtonSerModificar.Size = new Size(146, 31);
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
            labelSerDuracion.Location = new Point(40, 185);
            labelSerDuracion.Margin = new Padding(5, 0, 5, 0);
            labelSerDuracion.Name = "labelSerDuracion";
            labelSerDuracion.Size = new Size(77, 20);
            labelSerDuracion.TabIndex = 68;
            labelSerDuracion.Text = "Duracion";
            // 
            // textBoxDuracion
            // 
            textBoxDuracion.Location = new Point(199, 185);
            textBoxDuracion.Margin = new Padding(3, 4, 3, 4);
            textBoxDuracion.Name = "textBoxDuracion";
            textBoxDuracion.Size = new Size(159, 27);
            textBoxDuracion.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 185);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 67;
            // 
            // labelSerTipo
            // 
            labelSerTipo.AutoSize = true;
            labelSerTipo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerTipo.Location = new Point(40, 227);
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
            labelSerDescripcion.Location = new Point(40, 113);
            labelSerDescripcion.Margin = new Padding(5, 0, 5, 0);
            labelSerDescripcion.Name = "labelSerDescripcion";
            labelSerDescripcion.Size = new Size(99, 20);
            labelSerDescripcion.TabIndex = 63;
            labelSerDescripcion.Text = "Descripcion";
            // 
            // labelTituoCrearServicio
            // 
            labelTituoCrearServicio.AutoSize = true;
            labelTituoCrearServicio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoCrearServicio.Location = new Point(99, 24);
            labelTituoCrearServicio.Name = "labelTituoCrearServicio";
            labelTituoCrearServicio.Size = new Size(223, 32);
            labelTituoCrearServicio.TabIndex = 62;
            labelTituoCrearServicio.Text = "AÑADIR SERVICIO";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(199, 113);
            txtBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(159, 27);
            txtBoxDescripcion.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 113);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 61;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(199, 148);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(159, 27);
            textBoxPrecio.TabIndex = 52;
            // 
            // labelSerPrecio
            // 
            labelSerPrecio.AutoSize = true;
            labelSerPrecio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSerPrecio.Location = new Point(40, 148);
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
            labelSerNombre.Location = new Point(40, 77);
            labelSerNombre.Margin = new Padding(5, 0, 5, 0);
            labelSerNombre.Name = "labelSerNombre";
            labelSerNombre.Size = new Size(68, 20);
            labelSerNombre.TabIndex = 48;
            labelSerNombre.Text = "Nombre";
            // 
            // tboxNombreServicio
            // 
            tboxNombreServicio.Location = new Point(199, 77);
            tboxNombreServicio.Margin = new Padding(3, 4, 3, 4);
            tboxNombreServicio.Name = "tboxNombreServicio";
            tboxNombreServicio.Size = new Size(159, 27);
            tboxNombreServicio.TabIndex = 49;
            // 
            // comboTipoServicio
            // 
            comboTipoServicio.DisplayMember = "1";
            comboTipoServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServicio.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboTipoServicio.Location = new Point(199, 224);
            comboTipoServicio.Margin = new Padding(5, 4, 5, 4);
            comboTipoServicio.MaxDropDownItems = 3;
            comboTipoServicio.Name = "comboTipoServicio";
            comboTipoServicio.Size = new Size(159, 28);
            comboTipoServicio.TabIndex = 70;
            comboTipoServicio.UseWaitCursor = true;
            // 
            // ButtonSerAnyadir
            // 
            ButtonSerAnyadir.Location = new Point(159, 277);
            ButtonSerAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonSerAnyadir.Name = "ButtonSerAnyadir";
            ButtonSerAnyadir.Size = new Size(86, 31);
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
            panelServicio.Name = "panelServicio";
            panelServicio.Size = new Size(387, 313);
            panelServicio.TabIndex = 72;
            // 
            // Servicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 313);
            Controls.Add(panelServicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(405, 360);
            MinimizeBox = false;
            MinimumSize = new Size(405, 360);
            Name = "Servicio";
            Text = "Añadir Servicio";
            Load += Servicio_Load;
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
