namespace WinFormsApp1
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            labNombreUsuario = new Label();
            tboxNombreUsuario = new TextBox();
            labTipoUser = new Label();
            comboTipoUsuario = new ComboBox();
            textBoxUsConfigContrasenya = new TextBox();
            LabUsConfigContraseña = new Label();
            textBoxUsContrasenya = new TextBox();
            LabUsContrasenya = new Label();
            textBoxUsApellidos = new TextBox();
            labUsApellido = new Label();
            txtBoxUsNombre = new TextBox();
            lavUsNombre = new Label();
            ButtonUsAnyadir = new Button();
            labelTituoCrearUsuario = new Label();
            labelUsNombre = new Label();
            panelUsGrupo = new Panel();
            tboxUserTurno = new TextBox();
            tboxUserCurso = new TextBox();
            labUserTurno = new Label();
            labUserCurso = new Label();
            panelAdmin = new Panel();
            tboxUserEspec = new TextBox();
            labUserEspecialidad = new Label();
            panelCliente = new Panel();
            labUserObserv = new Label();
            textUserObserv = new TextBox();
            tboxUserAlerg = new TextBox();
            labUserAlerg = new Label();
            textBoxUsTel = new TextBox();
            labUsTel = new Label();
            textBoxUsEmail = new TextBox();
            labUsEmail = new Label();
            checkBoxEstado = new CheckBox();
            ButtonUsGuardar = new Button();
            ButtonUsVolver = new Button();
            labelTituoInfoUsuario = new Label();
            panelUsuario = new Panel();
            pictureBoxICon = new PictureBox();
            buttonModificar = new Button();
            panelUsGrupo.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelCliente.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // labNombreUsuario
            // 
            labNombreUsuario.AutoSize = true;
            labNombreUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labNombreUsuario.Location = new Point(240, 90);
            labNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            labNombreUsuario.Name = "labNombreUsuario";
            labNombreUsuario.Size = new Size(132, 17);
            labNombreUsuario.TabIndex = 1;
            labNombreUsuario.Text = "Nombre del usuario";
            // 
            // tboxNombreUsuario
            // 
            tboxNombreUsuario.Location = new Point(382, 90);
            tboxNombreUsuario.Name = "tboxNombreUsuario";
            tboxNombreUsuario.Size = new Size(168, 23);
            tboxNombreUsuario.TabIndex = 1;
            // 
            // labTipoUser
            // 
            labTipoUser.AutoSize = true;
            labTipoUser.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTipoUser.Location = new Point(571, 165);
            labTipoUser.Margin = new Padding(4, 0, 4, 0);
            labTipoUser.Name = "labTipoUser";
            labTipoUser.Size = new Size(107, 17);
            labTipoUser.TabIndex = 3;
            labTipoUser.Text = "Tipo de usuario";
            // 
            // comboTipoUsuario
            // 
            comboTipoUsuario.DisplayMember = "1";
            comboTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUsuario.FormattingEnabled = true;
            comboTipoUsuario.Items.AddRange(new object[] { "Cliente", "Grupo", "Admin" });
            comboTipoUsuario.Location = new Point(714, 165);
            comboTipoUsuario.Margin = new Padding(4, 3, 4, 3);
            comboTipoUsuario.MaxDropDownItems = 3;
            comboTipoUsuario.Name = "comboTipoUsuario";
            comboTipoUsuario.Size = new Size(140, 23);
            comboTipoUsuario.TabIndex = 8;
            comboTipoUsuario.UseWaitCursor = true;
            comboTipoUsuario.SelectedIndexChanged += comboTipoUsuario_SelectedIndexChanged;
            // 
            // textBoxUsConfigContrasenya
            // 
            textBoxUsConfigContrasenya.Location = new Point(714, 128);
            textBoxUsConfigContrasenya.Name = "textBoxUsConfigContrasenya";
            textBoxUsConfigContrasenya.Size = new Size(140, 23);
            textBoxUsConfigContrasenya.TabIndex = 7;
            // 
            // LabUsConfigContraseña
            // 
            LabUsConfigContraseña.AutoSize = true;
            LabUsConfigContraseña.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsConfigContraseña.Location = new Point(571, 128);
            LabUsConfigContraseña.Margin = new Padding(4, 0, 4, 0);
            LabUsConfigContraseña.Name = "LabUsConfigContraseña";
            LabUsConfigContraseña.Size = new Size(144, 17);
            LabUsConfigContraseña.TabIndex = 9;
            LabUsConfigContraseña.Text = "Confirmar contraseña";
            // 
            // textBoxUsContrasenya
            // 
            textBoxUsContrasenya.Location = new Point(714, 90);
            textBoxUsContrasenya.Name = "textBoxUsContrasenya";
            textBoxUsContrasenya.Size = new Size(140, 23);
            textBoxUsContrasenya.TabIndex = 6;
            // 
            // LabUsContrasenya
            // 
            LabUsContrasenya.AutoSize = true;
            LabUsContrasenya.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsContrasenya.Location = new Point(571, 90);
            LabUsContrasenya.Margin = new Padding(4, 0, 4, 0);
            LabUsContrasenya.Name = "LabUsContrasenya";
            LabUsContrasenya.Size = new Size(81, 17);
            LabUsContrasenya.TabIndex = 11;
            LabUsContrasenya.Text = "Contraseña";
            // 
            // textBoxUsApellidos
            // 
            textBoxUsApellidos.Location = new Point(382, 165);
            textBoxUsApellidos.Name = "textBoxUsApellidos";
            textBoxUsApellidos.Size = new Size(168, 23);
            textBoxUsApellidos.TabIndex = 3;
            // 
            // labUsApellido
            // 
            labUsApellido.AutoSize = true;
            labUsApellido.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsApellido.Location = new Point(240, 165);
            labUsApellido.Margin = new Padding(4, 0, 4, 0);
            labUsApellido.Name = "labUsApellido";
            labUsApellido.Size = new Size(65, 17);
            labUsApellido.TabIndex = 13;
            labUsApellido.Text = "Apellidos";
            // 
            // txtBoxUsNombre
            // 
            txtBoxUsNombre.Location = new Point(382, 128);
            txtBoxUsNombre.Name = "txtBoxUsNombre";
            txtBoxUsNombre.Size = new Size(168, 23);
            txtBoxUsNombre.TabIndex = 2;
            // 
            // lavUsNombre
            // 
            lavUsNombre.AutoSize = true;
            lavUsNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lavUsNombre.Location = new Point(4, 94);
            lavUsNombre.Margin = new Padding(4, 0, 4, 0);
            lavUsNombre.Name = "lavUsNombre";
            lavUsNombre.Size = new Size(0, 17);
            lavUsNombre.TabIndex = 15;
            // 
            // ButtonUsAnyadir
            // 
            ButtonUsAnyadir.BackColor = Color.DarkOrange;
            ButtonUsAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonUsAnyadir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ButtonUsAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonUsAnyadir.Location = new Point(757, 304);
            ButtonUsAnyadir.Name = "ButtonUsAnyadir";
            ButtonUsAnyadir.Size = new Size(96, 38);
            ButtonUsAnyadir.TabIndex = 17;
            ButtonUsAnyadir.Text = "Añadir";
            ButtonUsAnyadir.UseVisualStyleBackColor = false;
            ButtonUsAnyadir.Click += ButtonUsAñadir_Click;
            // 
            // labelTituoCrearUsuario
            // 
            labelTituoCrearUsuario.AutoSize = true;
            labelTituoCrearUsuario.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituoCrearUsuario.ForeColor = SystemColors.ControlDarkDark;
            labelTituoCrearUsuario.Location = new Point(230, 32);
            labelTituoCrearUsuario.Name = "labelTituoCrearUsuario";
            labelTituoCrearUsuario.Size = new Size(225, 41);
            labelTituoCrearUsuario.TabIndex = 18;
            labelTituoCrearUsuario.Text = "Añadir usuario";
            // 
            // labelUsNombre
            // 
            labelUsNombre.AutoSize = true;
            labelUsNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsNombre.Location = new Point(240, 128);
            labelUsNombre.Margin = new Padding(4, 0, 4, 0);
            labelUsNombre.Name = "labelUsNombre";
            labelUsNombre.Size = new Size(62, 17);
            labelUsNombre.TabIndex = 19;
            labelUsNombre.Text = "Nombre ";
            // 
            // panelUsGrupo
            // 
            panelUsGrupo.Controls.Add(tboxUserTurno);
            panelUsGrupo.Controls.Add(tboxUserCurso);
            panelUsGrupo.Controls.Add(labUserTurno);
            panelUsGrupo.Controls.Add(labUserCurso);
            panelUsGrupo.Location = new Point(240, 201);
            panelUsGrupo.Name = "panelUsGrupo";
            panelUsGrupo.Size = new Size(612, 75);
            panelUsGrupo.TabIndex = 14;
            panelUsGrupo.Visible = false;
            // 
            // tboxUserTurno
            // 
            tboxUserTurno.Location = new Point(142, 52);
            tboxUserTurno.Name = "tboxUserTurno";
            tboxUserTurno.Size = new Size(168, 23);
            tboxUserTurno.TabIndex = 11;
            // 
            // tboxUserCurso
            // 
            tboxUserCurso.Location = new Point(142, 15);
            tboxUserCurso.Name = "tboxUserCurso";
            tboxUserCurso.Size = new Size(168, 23);
            tboxUserCurso.TabIndex = 9;
            // 
            // labUserTurno
            // 
            labUserTurno.AutoSize = true;
            labUserTurno.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserTurno.Location = new Point(0, 52);
            labUserTurno.Margin = new Padding(4, 0, 4, 0);
            labUserTurno.Name = "labUserTurno";
            labUserTurno.Size = new Size(46, 17);
            labUserTurno.TabIndex = 10;
            labUserTurno.Text = "Turno";
            // 
            // labUserCurso
            // 
            labUserCurso.AutoSize = true;
            labUserCurso.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserCurso.Location = new Point(0, 15);
            labUserCurso.Margin = new Padding(4, 0, 4, 0);
            labUserCurso.Name = "labUserCurso";
            labUserCurso.Size = new Size(45, 17);
            labUserCurso.TabIndex = 9;
            labUserCurso.Text = "Curso";
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(tboxUserEspec);
            panelAdmin.Controls.Add(labUserEspecialidad);
            panelAdmin.Location = new Point(240, 201);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(356, 65);
            panelAdmin.TabIndex = 21;
            panelAdmin.Visible = false;
            // 
            // tboxUserEspec
            // 
            tboxUserEspec.Location = new Point(142, 15);
            tboxUserEspec.Name = "tboxUserEspec";
            tboxUserEspec.Size = new Size(168, 23);
            tboxUserEspec.TabIndex = 9;
            // 
            // labUserEspecialidad
            // 
            labUserEspecialidad.AutoSize = true;
            labUserEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserEspecialidad.Location = new Point(0, 15);
            labUserEspecialidad.Margin = new Padding(4, 0, 4, 0);
            labUserEspecialidad.Name = "labUserEspecialidad";
            labUserEspecialidad.Size = new Size(88, 17);
            labUserEspecialidad.TabIndex = 9;
            labUserEspecialidad.Text = "Especialidad";
            // 
            // panelCliente
            // 
            panelCliente.BackColor = SystemColors.ControlDarkDark;
            panelCliente.BorderStyle = BorderStyle.FixedSingle;
            panelCliente.Controls.Add(labUserObserv);
            panelCliente.Controls.Add(textUserObserv);
            panelCliente.Controls.Add(tboxUserAlerg);
            panelCliente.Controls.Add(labUserAlerg);
            panelCliente.Controls.Add(textBoxUsTel);
            panelCliente.Controls.Add(labUsTel);
            panelCliente.Controls.Add(textBoxUsEmail);
            panelCliente.Controls.Add(labUsEmail);
            panelCliente.ForeColor = SystemColors.ControlLightLight;
            panelCliente.Location = new Point(228, 201);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(639, 90);
            panelCliente.TabIndex = 12;
            panelCliente.Visible = false;
            // 
            // labUserObserv
            // 
            labUserObserv.AutoSize = true;
            labUserObserv.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserObserv.Location = new Point(346, 52);
            labUserObserv.Margin = new Padding(4, 0, 4, 0);
            labUserObserv.Name = "labUserObserv";
            labUserObserv.Size = new Size(103, 17);
            labUserObserv.TabIndex = 48;
            labUserObserv.Text = "Observaciones";
            // 
            // textUserObserv
            // 
            textUserObserv.Location = new Point(486, 52);
            textUserObserv.Name = "textUserObserv";
            textUserObserv.Size = new Size(140, 23);
            textUserObserv.TabIndex = 47;
            // 
            // tboxUserAlerg
            // 
            tboxUserAlerg.Location = new Point(486, 15);
            tboxUserAlerg.Name = "tboxUserAlerg";
            tboxUserAlerg.Size = new Size(140, 23);
            tboxUserAlerg.TabIndex = 9;
            // 
            // labUserAlerg
            // 
            labUserAlerg.AutoSize = true;
            labUserAlerg.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserAlerg.Location = new Point(346, 15);
            labUserAlerg.Margin = new Padding(4, 0, 4, 0);
            labUserAlerg.Name = "labUserAlerg";
            labUserAlerg.Size = new Size(72, 17);
            labUserAlerg.TabIndex = 10;
            labUserAlerg.Text = "Alergenos";
            // 
            // textBoxUsTel
            // 
            textBoxUsTel.Location = new Point(154, 52);
            textBoxUsTel.Name = "textBoxUsTel";
            textBoxUsTel.Size = new Size(168, 23);
            textBoxUsTel.TabIndex = 5;
            // 
            // labUsTel
            // 
            labUsTel.AutoSize = true;
            labUsTel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsTel.Location = new Point(13, 52);
            labUsTel.Margin = new Padding(4, 0, 4, 0);
            labUsTel.Name = "labUsTel";
            labUsTel.Size = new Size(64, 17);
            labUsTel.TabIndex = 42;
            labUsTel.Text = "Teléfono";
            // 
            // textBoxUsEmail
            // 
            textBoxUsEmail.Location = new Point(154, 15);
            textBoxUsEmail.Name = "textBoxUsEmail";
            textBoxUsEmail.Size = new Size(168, 23);
            textBoxUsEmail.TabIndex = 4;
            // 
            // labUsEmail
            // 
            labUsEmail.AutoSize = true;
            labUsEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsEmail.Location = new Point(13, 15);
            labUsEmail.Margin = new Padding(4, 0, 4, 0);
            labUsEmail.Name = "labUsEmail";
            labUsEmail.Size = new Size(42, 17);
            labUsEmail.TabIndex = 46;
            labUsEmail.Text = "Email";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.BackColor = SystemColors.Control;
            checkBoxEstado.Checked = true;
            checkBoxEstado.CheckState = CheckState.Checked;
            checkBoxEstado.Font = new Font("Segoe UI", 10F);
            checkBoxEstado.ForeColor = SystemColors.ControlText;
            checkBoxEstado.Location = new Point(242, 310);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(66, 23);
            checkBoxEstado.TabIndex = 41;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = false;
            // 
            // ButtonUsGuardar
            // 
            ButtonUsGuardar.BackColor = Color.DarkOrange;
            ButtonUsGuardar.FlatStyle = FlatStyle.Flat;
            ButtonUsGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ButtonUsGuardar.ForeColor = SystemColors.ControlLightLight;
            ButtonUsGuardar.Location = new Point(686, 304);
            ButtonUsGuardar.Name = "ButtonUsGuardar";
            ButtonUsGuardar.Size = new Size(167, 38);
            ButtonUsGuardar.TabIndex = 47;
            ButtonUsGuardar.Text = "Guardar cambios";
            ButtonUsGuardar.UseVisualStyleBackColor = false;
            ButtonUsGuardar.Visible = false;
            ButtonUsGuardar.Click += ButtonUsGuardar_Click;
            // 
            // ButtonUsVolver
            // 
            ButtonUsVolver.BackColor = Color.DarkOrange;
            ButtonUsVolver.FlatStyle = FlatStyle.Flat;
            ButtonUsVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ButtonUsVolver.ForeColor = SystemColors.ControlLightLight;
            ButtonUsVolver.Location = new Point(757, 304);
            ButtonUsVolver.Name = "ButtonUsVolver";
            ButtonUsVolver.Size = new Size(96, 38);
            ButtonUsVolver.TabIndex = 48;
            ButtonUsVolver.Text = "Volver";
            ButtonUsVolver.UseVisualStyleBackColor = false;
            ButtonUsVolver.Visible = false;
            ButtonUsVolver.Click += ButtonUsVolver_Click;
            // 
            // labelTituoInfoUsuario
            // 
            labelTituoInfoUsuario.AutoSize = true;
            labelTituoInfoUsuario.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituoInfoUsuario.ForeColor = SystemColors.ControlDarkDark;
            labelTituoInfoUsuario.Location = new Point(230, 32);
            labelTituoInfoUsuario.Name = "labelTituoInfoUsuario";
            labelTituoInfoUsuario.Size = new Size(345, 41);
            labelTituoInfoUsuario.TabIndex = 49;
            labelTituoInfoUsuario.Text = "Información de usuario";
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(pictureBoxICon);
            panelUsuario.Controls.Add(buttonModificar);
            panelUsuario.Controls.Add(labelTituoInfoUsuario);
            panelUsuario.Controls.Add(panelCliente);
            panelUsuario.Controls.Add(panelAdmin);
            panelUsuario.Controls.Add(labNombreUsuario);
            panelUsuario.Controls.Add(ButtonUsVolver);
            panelUsuario.Controls.Add(tboxNombreUsuario);
            panelUsuario.Controls.Add(ButtonUsGuardar);
            panelUsuario.Controls.Add(labTipoUser);
            panelUsuario.Controls.Add(comboTipoUsuario);
            panelUsuario.Controls.Add(LabUsConfigContraseña);
            panelUsuario.Controls.Add(textBoxUsConfigContrasenya);
            panelUsuario.Controls.Add(LabUsContrasenya);
            panelUsuario.Controls.Add(textBoxUsContrasenya);
            panelUsuario.Controls.Add(labUsApellido);
            panelUsuario.Controls.Add(checkBoxEstado);
            panelUsuario.Controls.Add(textBoxUsApellidos);
            panelUsuario.Controls.Add(lavUsNombre);
            panelUsuario.Controls.Add(panelUsGrupo);
            panelUsuario.Controls.Add(txtBoxUsNombre);
            panelUsuario.Controls.Add(labelUsNombre);
            panelUsuario.Controls.Add(ButtonUsAnyadir);
            panelUsuario.Controls.Add(labelTituoCrearUsuario);
            panelUsuario.Dock = DockStyle.Fill;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Margin = new Padding(3, 2, 3, 2);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(902, 366);
            panelUsuario.TabIndex = 50;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(182, 366);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 51;
            pictureBoxICon.TabStop = false;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.DarkOrange;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificar.ForeColor = SystemColors.ControlLightLight;
            buttonModificar.Location = new Point(626, 304);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(116, 38);
            buttonModificar.TabIndex = 50;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Visible = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 366);
            Controls.Add(panelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1314, 760);
            MinimumSize = new Size(348, 85);
            Name = "Usuario";
            Text = "Añadir Usuario";
            Load += Usuario_Load;
            panelUsGrupo.ResumeLayout(false);
            panelUsGrupo.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labNombreUsuario;
        private TextBox tboxNombreUsuario;
        private Label labTipoUser;
        private ComboBox comboTipoUsuario;
        private TextBox textBoxUsConfigContrasenya;
        private Label LabUsConfigContraseña;
        private TextBox textBoxUsContrasenya;
        private Label LabUsContrasenya;
        private TextBox textBoxUsApellidos;
        private Label labUsApellido;
        private TextBox txtBoxUsNombre;
        private Label lavUsNombre;
        private Button ButtonUsAnyadir;
        private Label labelTituoCrearUsuario;
        private Label labelUsNombre;
        private Panel panelGrupo;
        private Panel panelUsGrupo;
        private TextBox tboxUserTurno;
        private TextBox tboxUserCurso;
        private Label labUserTurno;
        private Label labUserCurso;
        private Panel panelCliente;
        private TextBox tboxUserObserv;
        private TextBox tboxUserAlerg;
        private Label labUserAlerg;
        private Label labUserComCitas;
        private Panel panelAdmin;
        private TextBox tboxUserEspec;
        private Label labUserEspecialidad;
        private CheckBox checkBoxEstado;
        private Label labUsEmail;
        private TextBox textBoxUsEmail;
        private Label label2;
        private TextBox textBoxUsTel;
        private Label labUsTel;
        private Button ButtonUsGuardar;
        private long id;
        private string contrasenya;
        private Button ButtonUsVolver;
        private Label labelTituoInfoUsuario;
        private Panel panelUsuario;
        private Button buttonModificar;
        private RichTextBox richTextBox1;
        private PictureBox pictureBoxICon;
        private TextBox textUserObserv;
        private Label labUserObserv;

        public Panel PanelAdmin
        {
            get
            {
                return this.panelAdmin;
            }
            set
            {
                this.panelAdmin = value;
            }
        }
        public Panel PanelUsGrupo
        {
            get
            {
                return this.panelUsGrupo;
            }
            set
            {
                this.panelUsGrupo = value;
            }
        }
        public Panel PanelCliente
        {
            get
            {
                return this.panelCliente;
            }
            set
            {
                this.panelCliente = value;
            }
        }
        
        public TextBox TboxNombreUsuario
        {
            get
            {
                return this.tboxNombreUsuario;
            }
            set
            {
                this.tboxNombreUsuario = value;
            }
        }
        public TextBox TextBoxUsEmail
        {
            get
            {
                return this.textBoxUsEmail;
            }
            set
            {
                this.textBoxUsEmail = value;
            }
        }

        public TextBox TxtBoxUsNombre
        {
            get
            {
                return this.txtBoxUsNombre;
            }
            set
            {
                this.txtBoxUsNombre = value;
            }
        }

        public TextBox TextBoxUsApellidos
        {
            get
            {
                return this.textBoxUsApellidos;
            }
            set
            {
                this.textBoxUsApellidos = value;
            }
        }
        public TextBox TextBoxUsTel
        {
            get
            {
                return this.textBoxUsTel;
            }
            set
            {
                this.textBoxUsTel = value;
            }
        }
        public TextBox TextBoxUsContrasenya
        {
            get
            {
                return this.textBoxUsContrasenya;
            }
            set
            {
                this.textBoxUsContrasenya = value;
            }
        }
        public TextBox TextBoxUsConfigContrasenya
        {
            get
            {
                return this.textBoxUsConfigContrasenya;
            }
            set
            {
                this.textBoxUsConfigContrasenya = value;
            }
        }

        public TextBox TboxUserAlerg
        {
            get
            {
                return this.tboxUserAlerg;
            }
            set
            {
                this.tboxUserAlerg = value;
            }
        }
        public TextBox TboxUserObserv
        {
            get
            {
                return this.textUserObserv;
            }
            set
            {
                this.textUserObserv = value;
            }
        }
        public TextBox TboxUserCurso
        {
            get
            {
                return this.tboxUserCurso;
            }
            set
            {
                this.tboxUserCurso = value;
            }
        }
        public TextBox TboxUserTurno
        {
            get
            {
                return this.tboxUserTurno;
            }
            set
            {
                this.tboxUserTurno = value;
            }
        }
        public TextBox TboxUserEspec
        {
            get
            {
                return this.tboxUserEspec;
            }
            set
            {
                this.tboxUserEspec = value;
            }
        }

        public ComboBox ComboTipoUsuario
        {
            get
            {
                return this.comboTipoUsuario;
            }
            set
            {
                this.comboTipoUsuario = value;
            }
        }

        public ComboBox TipoUsuario
        {
            get
            {
                return this.comboTipoUsuario;
            }
            set
            {
                this.comboTipoUsuario = value;
            }
        }

        public Label LabelTituoCrearUsuario
        {
            get
            {
                return this.labelTituoCrearUsuario;
            }
            set
            {
                this.labelTituoCrearUsuario = value;
            }
        }

        public Label LabelTituoInfoUsuario
        {
            get
            {
                return this.labelTituoInfoUsuario;
            }
            set
            {
                this.labelTituoInfoUsuario = value;
            }
        }

        public bool buttonUsAnyadir
        {
            get
            {
                return this.ButtonUsAnyadir.Visible;
            }
            set
            {
                this.ButtonUsAnyadir.Visible = value;
            }
        }
        public bool ButtonUsModificar
        {
            get
            {
                return this.buttonModificar.Visible;
            }
            set
            {
                this.buttonModificar.Visible = value;
            }
        }
        public bool buttonUsVolver
        {
            get
            {
                return this.ButtonUsVolver.Visible;
            }
            set
            {
                this.ButtonUsVolver.Visible = value;
            }
        }
        public bool buttonUsGuardar
        {
            get
            {
                return this.ButtonUsGuardar.Visible;
            }
            set
            {
                this.ButtonUsGuardar.Visible = value;
            }
        }



        public CheckBox CheckBoxEstado
        {
            get
            {
                return this.checkBoxEstado;
            }
            set
            {
                this.checkBoxEstado = value;
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