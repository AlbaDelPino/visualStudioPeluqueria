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
            NombreUsuario = new Label();
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
            tboxUserObserv = new TextBox();
            tboxUserAlerg = new TextBox();
            tboxUserDirecc = new TextBox();
            labUserObser = new Label();
            labUserAlerg = new Label();
            labUserDirrec = new Label();
            checkBoxEstado = new CheckBox();
            labUsEmail = new Label();
            textBoxUsEmail = new TextBox();
            label2 = new Label();
            textBoxUsTel = new TextBox();
            labUsTel = new Label();
            ButtonUsModificar = new Button();
            ButtonUsVolver = new Button();
            labelTituoInfoUsuario = new Label();
            panelUsuario = new Panel();
            panelUsGrupo.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelCliente.SuspendLayout();
            panelUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreUsuario.Location = new Point(26, 74);
            NombreUsuario.Margin = new Padding(4, 0, 4, 0);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(132, 17);
            NombreUsuario.TabIndex = 1;
            NombreUsuario.Text = "Nombre del usuario";
            // 
            // tboxNombreUsuario
            // 
            tboxNombreUsuario.Location = new Point(169, 72);
            tboxNombreUsuario.Name = "tboxNombreUsuario";
            tboxNombreUsuario.Size = new Size(140, 23);
            tboxNombreUsuario.TabIndex = 1;
            // 
            // labTipoUser
            // 
            labTipoUser.AutoSize = true;
            labTipoUser.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTipoUser.Location = new Point(26, 266);
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
            comboTipoUsuario.Location = new Point(169, 264);
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
            textBoxUsConfigContrasenya.Location = new Point(169, 235);
            textBoxUsConfigContrasenya.Name = "textBoxUsConfigContrasenya";
            textBoxUsConfigContrasenya.Size = new Size(140, 23);
            textBoxUsConfigContrasenya.TabIndex = 7;
            // 
            // LabUsConfigContraseña
            // 
            LabUsConfigContraseña.AutoSize = true;
            LabUsConfigContraseña.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsConfigContraseña.Location = new Point(26, 237);
            LabUsConfigContraseña.Margin = new Padding(4, 0, 4, 0);
            LabUsConfigContraseña.Name = "LabUsConfigContraseña";
            LabUsConfigContraseña.Size = new Size(144, 17);
            LabUsConfigContraseña.TabIndex = 9;
            LabUsConfigContraseña.Text = "Confirmar contraseña";
            // 
            // textBoxUsContrasenya
            // 
            textBoxUsContrasenya.Location = new Point(169, 208);
            textBoxUsContrasenya.Name = "textBoxUsContrasenya";
            textBoxUsContrasenya.Size = new Size(140, 23);
            textBoxUsContrasenya.TabIndex = 6;
            // 
            // LabUsContrasenya
            // 
            LabUsContrasenya.AutoSize = true;
            LabUsContrasenya.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsContrasenya.Location = new Point(26, 210);
            LabUsContrasenya.Margin = new Padding(4, 0, 4, 0);
            LabUsContrasenya.Name = "LabUsContrasenya";
            LabUsContrasenya.Size = new Size(81, 17);
            LabUsContrasenya.TabIndex = 11;
            LabUsContrasenya.Text = "Contraseña";
            // 
            // textBoxUsApellidos
            // 
            textBoxUsApellidos.Location = new Point(169, 126);
            textBoxUsApellidos.Name = "textBoxUsApellidos";
            textBoxUsApellidos.Size = new Size(140, 23);
            textBoxUsApellidos.TabIndex = 3;
            // 
            // labUsApellido
            // 
            labUsApellido.AutoSize = true;
            labUsApellido.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsApellido.Location = new Point(26, 128);
            labUsApellido.Margin = new Padding(4, 0, 4, 0);
            labUsApellido.Name = "labUsApellido";
            labUsApellido.Size = new Size(65, 17);
            labUsApellido.TabIndex = 13;
            labUsApellido.Text = "Apellidos";
            // 
            // txtBoxUsNombre
            // 
            txtBoxUsNombre.Location = new Point(169, 99);
            txtBoxUsNombre.Name = "txtBoxUsNombre";
            txtBoxUsNombre.Size = new Size(140, 23);
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
            ButtonUsAnyadir.Location = new Point(234, 427);
            ButtonUsAnyadir.Name = "ButtonUsAnyadir";
            ButtonUsAnyadir.Size = new Size(75, 23);
            ButtonUsAnyadir.TabIndex = 17;
            ButtonUsAnyadir.Text = "Añadir";
            ButtonUsAnyadir.UseVisualStyleBackColor = true;
            ButtonUsAnyadir.Click += ButtonUsAñadir_Click;
            // 
            // labelTituoCrearUsuario
            // 
            labelTituoCrearUsuario.AutoSize = true;
            labelTituoCrearUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoCrearUsuario.Location = new Point(73, 21);
            labelTituoCrearUsuario.Name = "labelTituoCrearUsuario";
            labelTituoCrearUsuario.Size = new Size(174, 25);
            labelTituoCrearUsuario.TabIndex = 18;
            labelTituoCrearUsuario.Text = "AÑADIR USUARIO";
            // 
            // labelUsNombre
            // 
            labelUsNombre.AutoSize = true;
            labelUsNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsNombre.Location = new Point(26, 101);
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
            panelUsGrupo.Location = new Point(26, 290);
            panelUsGrupo.Name = "panelUsGrupo";
            panelUsGrupo.Size = new Size(283, 131);
            panelUsGrupo.TabIndex = 14;
            panelUsGrupo.Visible = false;
            // 
            // tboxUserTurno
            // 
            tboxUserTurno.Location = new Point(139, 45);
            tboxUserTurno.Name = "tboxUserTurno";
            tboxUserTurno.Size = new Size(140, 23);
            tboxUserTurno.TabIndex = 11;
            // 
            // tboxUserCurso
            // 
            tboxUserCurso.Location = new Point(139, 16);
            tboxUserCurso.Name = "tboxUserCurso";
            tboxUserCurso.Size = new Size(140, 23);
            tboxUserCurso.TabIndex = 9;
            // 
            // labUserTurno
            // 
            labUserTurno.AutoSize = true;
            labUserTurno.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserTurno.Location = new Point(3, 45);
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
            labUserCurso.Location = new Point(4, 22);
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
            panelAdmin.Location = new Point(26, 290);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(283, 131);
            panelAdmin.TabIndex = 21;
            panelAdmin.Visible = false;
            // 
            // tboxUserEspec
            // 
            tboxUserEspec.Location = new Point(134, 28);
            tboxUserEspec.Name = "tboxUserEspec";
            tboxUserEspec.Size = new Size(145, 23);
            tboxUserEspec.TabIndex = 9;
            // 
            // labUserEspecialidad
            // 
            labUserEspecialidad.AutoSize = true;
            labUserEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserEspecialidad.Location = new Point(4, 28);
            labUserEspecialidad.Margin = new Padding(4, 0, 4, 0);
            labUserEspecialidad.Name = "labUserEspecialidad";
            labUserEspecialidad.Size = new Size(88, 17);
            labUserEspecialidad.TabIndex = 9;
            labUserEspecialidad.Text = "Especialidad";
            // 
            // panelCliente
            // 
            panelCliente.Controls.Add(tboxUserObserv);
            panelCliente.Controls.Add(tboxUserAlerg);
            panelCliente.Controls.Add(tboxUserDirecc);
            panelCliente.Controls.Add(labUserObser);
            panelCliente.Controls.Add(labUserAlerg);
            panelCliente.Controls.Add(labUserDirrec);
            panelCliente.Location = new Point(26, 290);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(283, 131);
            panelCliente.TabIndex = 12;
            panelCliente.Visible = false;
            // 
            // tboxUserObserv
            // 
            tboxUserObserv.Location = new Point(139, 81);
            tboxUserObserv.Name = "tboxUserObserv";
            tboxUserObserv.Size = new Size(140, 23);
            tboxUserObserv.TabIndex = 13;
            // 
            // tboxUserAlerg
            // 
            tboxUserAlerg.Location = new Point(139, 51);
            tboxUserAlerg.Name = "tboxUserAlerg";
            tboxUserAlerg.Size = new Size(140, 23);
            tboxUserAlerg.TabIndex = 12;
            // 
            // tboxUserDirecc
            // 
            tboxUserDirecc.Location = new Point(139, 22);
            tboxUserDirecc.Name = "tboxUserDirecc";
            tboxUserDirecc.Size = new Size(140, 23);
            tboxUserDirecc.TabIndex = 9;
            // 
            // labUserObser
            // 
            labUserObser.AutoSize = true;
            labUserObser.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserObser.Location = new Point(0, 83);
            labUserObser.Margin = new Padding(4, 0, 4, 0);
            labUserObser.Name = "labUserObser";
            labUserObser.Size = new Size(103, 17);
            labUserObser.TabIndex = 11;
            labUserObser.Text = "Observaciones";
            // 
            // labUserAlerg
            // 
            labUserAlerg.AutoSize = true;
            labUserAlerg.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserAlerg.Location = new Point(0, 53);
            labUserAlerg.Margin = new Padding(4, 0, 4, 0);
            labUserAlerg.Name = "labUserAlerg";
            labUserAlerg.Size = new Size(72, 17);
            labUserAlerg.TabIndex = 10;
            labUserAlerg.Text = "Alergenos";
            // 
            // labUserDirrec
            // 
            labUserDirrec.AutoSize = true;
            labUserDirrec.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserDirrec.Location = new Point(0, 22);
            labUserDirrec.Margin = new Padding(4, 0, 4, 0);
            labUserDirrec.Name = "labUserDirrec";
            labUserDirrec.Size = new Size(67, 17);
            labUserDirrec.TabIndex = 9;
            labUserDirrec.Text = "Dirección";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Checked = true;
            checkBoxEstado.CheckState = CheckState.Checked;
            checkBoxEstado.Font = new Font("Segoe UI", 10F);
            checkBoxEstado.Location = new Point(30, 427);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(66, 23);
            checkBoxEstado.TabIndex = 41;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // labUsEmail
            // 
            labUsEmail.AutoSize = true;
            labUsEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsEmail.Location = new Point(26, 155);
            labUsEmail.Margin = new Padding(4, 0, 4, 0);
            labUsEmail.Name = "labUsEmail";
            labUsEmail.Size = new Size(42, 17);
            labUsEmail.TabIndex = 46;
            labUsEmail.Text = "Email";
            // 
            // textBoxUsEmail
            // 
            textBoxUsEmail.Location = new Point(169, 153);
            textBoxUsEmail.Name = "textBoxUsEmail";
            textBoxUsEmail.Size = new Size(140, 23);
            textBoxUsEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 44;
            // 
            // textBoxUsTel
            // 
            textBoxUsTel.Location = new Point(169, 180);
            textBoxUsTel.Name = "textBoxUsTel";
            textBoxUsTel.Size = new Size(140, 23);
            textBoxUsTel.TabIndex = 5;
            // 
            // labUsTel
            // 
            labUsTel.AutoSize = true;
            labUsTel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsTel.Location = new Point(26, 182);
            labUsTel.Margin = new Padding(4, 0, 4, 0);
            labUsTel.Name = "labUsTel";
            labUsTel.Size = new Size(64, 17);
            labUsTel.TabIndex = 42;
            labUsTel.Text = "Teléfono";
            // 
            // ButtonUsModificar
            // 
            ButtonUsModificar.Location = new Point(181, 428);
            ButtonUsModificar.Name = "ButtonUsModificar";
            ButtonUsModificar.Size = new Size(128, 23);
            ButtonUsModificar.TabIndex = 47;
            ButtonUsModificar.Text = "Guardar cambios";
            ButtonUsModificar.UseVisualStyleBackColor = true;
            ButtonUsModificar.Visible = false;
            ButtonUsModificar.Click += ButtonUsModificar_Click;
            // 
            // ButtonUsVolver
            // 
            ButtonUsVolver.Location = new Point(233, 428);
            ButtonUsVolver.Name = "ButtonUsVolver";
            ButtonUsVolver.Size = new Size(75, 23);
            ButtonUsVolver.TabIndex = 48;
            ButtonUsVolver.Text = "Volver";
            ButtonUsVolver.UseVisualStyleBackColor = true;
            ButtonUsVolver.Visible = false;
            ButtonUsVolver.Click += ButtonUsVolver_Click;
            // 
            // labelTituoInfoUsuario
            // 
            labelTituoInfoUsuario.AutoSize = true;
            labelTituoInfoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoInfoUsuario.Location = new Point(30, 21);
            labelTituoInfoUsuario.Name = "labelTituoInfoUsuario";
            labelTituoInfoUsuario.Size = new Size(265, 25);
            labelTituoInfoUsuario.TabIndex = 49;
            labelTituoInfoUsuario.Text = "INFORMACIÓN DE USUARIO";
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(labelTituoInfoUsuario);
            panelUsuario.Controls.Add(NombreUsuario);
            panelUsuario.Controls.Add(ButtonUsVolver);
            panelUsuario.Controls.Add(tboxNombreUsuario);
            panelUsuario.Controls.Add(ButtonUsModificar);
            panelUsuario.Controls.Add(labTipoUser);
            panelUsuario.Controls.Add(labUsEmail);
            panelUsuario.Controls.Add(comboTipoUsuario);
            panelUsuario.Controls.Add(textBoxUsEmail);
            panelUsuario.Controls.Add(LabUsConfigContraseña);
            panelUsuario.Controls.Add(panelAdmin);
            panelUsuario.Controls.Add(textBoxUsConfigContrasenya);
            panelUsuario.Controls.Add(label2);
            panelUsuario.Controls.Add(LabUsContrasenya);
            panelUsuario.Controls.Add(textBoxUsTel);
            panelUsuario.Controls.Add(textBoxUsContrasenya);
            panelUsuario.Controls.Add(labUsTel);
            panelUsuario.Controls.Add(labUsApellido);
            panelUsuario.Controls.Add(checkBoxEstado);
            panelUsuario.Controls.Add(textBoxUsApellidos);
            panelUsuario.Controls.Add(panelCliente);
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
            panelUsuario.Size = new Size(332, 470);
            panelUsuario.TabIndex = 50;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 470);
            Controls.Add(panelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(348, 509);
            MinimizeBox = false;
            MinimumSize = new Size(348, 509);
            Name = "Usuario";
            Text = "Añadir Usuario";
            panelUsGrupo.ResumeLayout(false);
            panelUsGrupo.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label NombreUsuario;
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
        private TextBox tboxUserDirecc;
        private Label labUserObser;
        private Label labUserAlerg;
        private Label labUserDirrec;
        private Panel panelAdmin;
        private TextBox tboxUserEspec;
        private Label labUserEspecialidad;
        private CheckBox checkBoxEstado;
        private Label labUsEmail;
        private TextBox textBoxUsEmail;
        private Label label2;
        private TextBox textBoxUsTel;
        private Label labUsTel;
        private Button ButtonUsModificar;
        private long id;
        private string contrasenya;
        private Button ButtonUsVolver;
        private Label labelTituoInfoUsuario;
        private Panel panelUsuario;

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

        public TextBox TboxUserDirecc
        {
            get
            {
                return this.tboxUserDirecc;
            }
            set
            {
                this.tboxUserDirecc = value;
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
                return this.tboxUserObserv;
            }
            set
            {
                this.tboxUserObserv = value;
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
        public bool buttonUsModificar
        {
            get
            {
                return this.ButtonUsModificar.Visible;
            }
            set
            {
                this.ButtonUsModificar.Visible = value;
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