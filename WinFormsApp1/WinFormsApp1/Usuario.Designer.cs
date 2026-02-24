using System.Drawing.Drawing2D;
using System.IO;


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
            tboxNombreUsuario = new RoundedTextBox();
            labTipoUser = new Label();
            comboTipoUsuario = new ComboBox();
            textBoxUsConfigContrasenya = new RoundedTextBox();
            LabUsConfigContraseña = new Label();
            textBoxUsContrasenya = new RoundedTextBox();
            LabUsContrasenya = new Label();
            textBoxUsApellidos = new RoundedTextBox();
            labUsApellido = new Label();
            txtBoxUsNombre = new RoundedTextBox();
            lavUsNombre = new Label();
            ButtonUsAnyadir = new WinFormsApp1.Bloqueo.RoundedButton();
            labelTituoCrearUsuario = new Label();
            labelUsNombre = new Label();
            panelUsGrupo = new Panel();
            tboxUserTurno = new RoundedTextBox();
            tboxUserCurso = new RoundedTextBox();
            labUserTurno = new Label();
            labUserCurso = new Label();
            panelAdmin = new Panel();
            tboxUserEspec = new RoundedTextBox();
            labUserEspecialidad = new Label();
            panelCliente = new Panel();
            labUserObserv = new Label();
            tboxUserAlerg = new RoundedTextBox();
            labUserAlerg = new Label();
            textBoxUsTel = new RoundedTextBox();
            labUsTel = new Label();
            textBoxUsEmail = new RoundedTextBox();
            labUsEmail = new Label();
            checkBoxEstado = new CheckBox();
            ButtonUsGuardar = new WinFormsApp1.Bloqueo.RoundedButton();
            ButtonUsVolver = new WinFormsApp1.Bloqueo.RoundedButton();
            labelTituoInfoUsuario = new Label();
            panelUsuario = new Panel();
            pictureBoxICon = new PictureBox();
            buttonModificar = new WinFormsApp1.Bloqueo.RoundedButton();
            roundedTextBoxObservaciones = new RoundedTextBox();
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
            tboxNombreUsuario.BackColor = Color.White;
            tboxNombreUsuario.BorderColor = Color.Gray;
            tboxNombreUsuario.BorderRadius = 10;
            tboxNombreUsuario.BorderSize = 1;
            tboxNombreUsuario.Location = new Point(382, 90);
            tboxNombreUsuario.Name = "tboxNombreUsuario";
            tboxNombreUsuario.PasswordChar = '\0';
            tboxNombreUsuario.ReadOnly = false;
            tboxNombreUsuario.Size = new Size(168, 24);
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
            comboTipoUsuario.Location = new Point(718, 165);
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
            textBoxUsConfigContrasenya.BackColor = Color.White;
            textBoxUsConfigContrasenya.BorderColor = Color.Gray;
            textBoxUsConfigContrasenya.BorderRadius = 10;
            textBoxUsConfigContrasenya.BorderSize = 1;
            textBoxUsConfigContrasenya.Location = new Point(718, 128);
            textBoxUsConfigContrasenya.Name = "textBoxUsConfigContrasenya";
            textBoxUsConfigContrasenya.Padding = new Padding(9, 8, 9, 8);
            textBoxUsConfigContrasenya.PasswordChar = '\0';
            textBoxUsConfigContrasenya.ReadOnly = false;
            textBoxUsConfigContrasenya.Size = new Size(140, 24);
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
            textBoxUsContrasenya.BackColor = Color.White;
            textBoxUsContrasenya.BorderColor = Color.Gray;
            textBoxUsContrasenya.BorderRadius = 10;
            textBoxUsContrasenya.BorderSize = 1;
            textBoxUsContrasenya.Location = new Point(718, 90);
            textBoxUsContrasenya.Name = "textBoxUsContrasenya";
            textBoxUsContrasenya.Padding = new Padding(9, 8, 9, 8);
            textBoxUsContrasenya.PasswordChar = '\0';
            textBoxUsContrasenya.ReadOnly = false;
            textBoxUsContrasenya.Size = new Size(140, 24);
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
            textBoxUsApellidos.BackColor = Color.White;
            textBoxUsApellidos.BorderColor = Color.Gray;
            textBoxUsApellidos.BorderRadius = 10;
            textBoxUsApellidos.BorderSize = 1;
            textBoxUsApellidos.Location = new Point(382, 165);
            textBoxUsApellidos.Name = "textBoxUsApellidos";
            textBoxUsApellidos.PasswordChar = '\0';
            textBoxUsApellidos.ReadOnly = false;
            textBoxUsApellidos.Size = new Size(168, 24);
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
            txtBoxUsNombre.BackColor = Color.White;
            txtBoxUsNombre.BorderColor = Color.Gray;
            txtBoxUsNombre.BorderRadius = 10;
            txtBoxUsNombre.BorderSize = 1;
            txtBoxUsNombre.Location = new Point(382, 128);
            txtBoxUsNombre.Name = "txtBoxUsNombre";
            txtBoxUsNombre.PasswordChar = '\0';
            txtBoxUsNombre.ReadOnly = false;
            txtBoxUsNombre.Size = new Size(168, 24);
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
            ButtonUsAnyadir.BorderColor = Color.Gray;
            ButtonUsAnyadir.BorderRadius = 10;
            ButtonUsAnyadir.BorderSize = 1;
            ButtonUsAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonUsAnyadir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ButtonUsAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonUsAnyadir.HoverColor = Color.FromArgb(235, 120, 0);
            ButtonUsAnyadir.Location = new Point(757, 304);
            ButtonUsAnyadir.Name = "ButtonUsAnyadir";
            ButtonUsAnyadir.PaddingHorizontal = 12;
            ButtonUsAnyadir.PaddingVertical = 8;
            ButtonUsAnyadir.PressedColor = Color.FromArgb(255, 192, 128);
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
            panelUsGrupo.BackColor = Color.DarkKhaki;
            panelUsGrupo.Controls.Add(tboxUserTurno);
            panelUsGrupo.Controls.Add(tboxUserCurso);
            panelUsGrupo.Controls.Add(labUserTurno);
            panelUsGrupo.Controls.Add(labUserCurso);
            panelUsGrupo.ForeColor = SystemColors.ControlLightLight;
            panelUsGrupo.Location = new Point(228, 201);
            panelUsGrupo.Name = "panelUsGrupo";
            panelUsGrupo.Size = new Size(643, 89);
            panelUsGrupo.TabIndex = 14;
            panelUsGrupo.Visible = false;
            // 
            // tboxUserTurno
            // 
            tboxUserTurno.BackColor = Color.White;
            tboxUserTurno.BorderColor = Color.Gray;
            tboxUserTurno.BorderRadius = 10;
            tboxUserTurno.BorderSize = 1;
            tboxUserTurno.Location = new Point(154, 52);
            tboxUserTurno.Name = "tboxUserTurno";
            tboxUserTurno.Padding = new Padding(9, 8, 9, 8);
            tboxUserTurno.PasswordChar = '\0';
            tboxUserTurno.ReadOnly = false;
            tboxUserTurno.Size = new Size(168, 24);
            tboxUserTurno.TabIndex = 11;
            // 
            // tboxUserCurso
            // 
            tboxUserCurso.BackColor = Color.White;
            tboxUserCurso.BorderColor = Color.Gray;
            tboxUserCurso.BorderRadius = 10;
            tboxUserCurso.BorderSize = 1;
            tboxUserCurso.Location = new Point(154, 15);
            tboxUserCurso.Name = "tboxUserCurso";
            tboxUserCurso.Padding = new Padding(9, 8, 9, 8);
            tboxUserCurso.PasswordChar = '\0';
            tboxUserCurso.ReadOnly = false;
            tboxUserCurso.Size = new Size(168, 24);
            tboxUserCurso.TabIndex = 9;
            // 
            // labUserTurno
            // 
            labUserTurno.AutoSize = true;
            labUserTurno.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserTurno.Location = new Point(13, 52);
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
            labUserCurso.Location = new Point(13, 15);
            labUserCurso.Margin = new Padding(4, 0, 4, 0);
            labUserCurso.Name = "labUserCurso";
            labUserCurso.Size = new Size(45, 17);
            labUserCurso.TabIndex = 9;
            labUserCurso.Text = "Curso";
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.DarkKhaki;
            panelAdmin.Controls.Add(tboxUserEspec);
            panelAdmin.Controls.Add(labUserEspecialidad);
            panelAdmin.ForeColor = SystemColors.ControlLightLight;
            panelAdmin.Location = new Point(228, 201);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(643, 89);
            panelAdmin.TabIndex = 21;
            panelAdmin.Visible = false;
            // 
            // tboxUserEspec
            // 
            tboxUserEspec.BackColor = Color.White;
            tboxUserEspec.BorderColor = Color.Gray;
            tboxUserEspec.BorderRadius = 10;
            tboxUserEspec.BorderSize = 1;
            tboxUserEspec.Location = new Point(154, 15);
            tboxUserEspec.Name = "tboxUserEspec";
            tboxUserEspec.Padding = new Padding(9, 8, 9, 8);
            tboxUserEspec.PasswordChar = '\0';
            tboxUserEspec.ReadOnly = false;
            tboxUserEspec.Size = new Size(168, 24);
            tboxUserEspec.TabIndex = 9;
            // 
            // labUserEspecialidad
            // 
            labUserEspecialidad.AutoSize = true;
            labUserEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserEspecialidad.Location = new Point(13, 15);
            labUserEspecialidad.Margin = new Padding(4, 0, 4, 0);
            labUserEspecialidad.Name = "labUserEspecialidad";
            labUserEspecialidad.Size = new Size(88, 17);
            labUserEspecialidad.TabIndex = 9;
            labUserEspecialidad.Text = "Especialidad";
            // 
            // panelCliente
            // 
            panelCliente.BackColor = Color.DarkKhaki;
            panelCliente.Controls.Add(roundedTextBoxObservaciones);
            panelCliente.Controls.Add(labUserObserv);
            panelCliente.Controls.Add(tboxUserAlerg);
            panelCliente.Controls.Add(labUserAlerg);
            panelCliente.Controls.Add(textBoxUsTel);
            panelCliente.Controls.Add(labUsTel);
            panelCliente.Controls.Add(textBoxUsEmail);
            panelCliente.Controls.Add(labUsEmail);
            panelCliente.ForeColor = SystemColors.ControlLightLight;
            panelCliente.Location = new Point(228, 201);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(643, 89);
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
            // tboxUserAlerg
            // 
            tboxUserAlerg.BackColor = Color.White;
            tboxUserAlerg.BorderColor = Color.Gray;
            tboxUserAlerg.BorderRadius = 10;
            tboxUserAlerg.BorderSize = 1;
            tboxUserAlerg.Location = new Point(489, 15);
            tboxUserAlerg.Name = "tboxUserAlerg";
            tboxUserAlerg.Padding = new Padding(9, 8, 9, 8);
            tboxUserAlerg.PasswordChar = '\0';
            tboxUserAlerg.ReadOnly = false;
            tboxUserAlerg.Size = new Size(140, 24);
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
            textBoxUsTel.BackColor = Color.White;
            textBoxUsTel.BorderColor = Color.Gray;
            textBoxUsTel.BorderRadius = 10;
            textBoxUsTel.BorderSize = 1;
            textBoxUsTel.Location = new Point(154, 52);
            textBoxUsTel.Name = "textBoxUsTel";
            textBoxUsTel.Padding = new Padding(9, 8, 9, 8);
            textBoxUsTel.PasswordChar = '\0';
            textBoxUsTel.ReadOnly = false;
            textBoxUsTel.Size = new Size(168, 24);
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
            textBoxUsEmail.BackColor = Color.White;
            textBoxUsEmail.BorderColor = Color.Gray;
            textBoxUsEmail.BorderRadius = 10;
            textBoxUsEmail.BorderSize = 1;
            textBoxUsEmail.Location = new Point(154, 15);
            textBoxUsEmail.Name = "textBoxUsEmail";
            textBoxUsEmail.Padding = new Padding(9, 8, 9, 8);
            textBoxUsEmail.PasswordChar = '\0';
            textBoxUsEmail.ReadOnly = false;
            textBoxUsEmail.Size = new Size(168, 24);
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
            ButtonUsGuardar.BorderColor = Color.Gray;
            ButtonUsGuardar.BorderRadius = 10;
            ButtonUsGuardar.BorderSize = 1;
            ButtonUsGuardar.FlatStyle = FlatStyle.Flat;
            ButtonUsGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ButtonUsGuardar.ForeColor = SystemColors.ControlLightLight;
            ButtonUsGuardar.HoverColor = Color.FromArgb(235, 120, 0);
            ButtonUsGuardar.Location = new Point(686, 304);
            ButtonUsGuardar.Name = "ButtonUsGuardar";
            ButtonUsGuardar.PaddingHorizontal = 12;
            ButtonUsGuardar.PaddingVertical = 8;
            ButtonUsGuardar.PressedColor = Color.FromArgb(255, 192, 128);
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
            ButtonUsVolver.BorderColor = Color.Gray;
            ButtonUsVolver.BorderRadius = 10;
            ButtonUsVolver.BorderSize = 1;
            ButtonUsVolver.FlatStyle = FlatStyle.Flat;
            ButtonUsVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ButtonUsVolver.ForeColor = SystemColors.ControlLightLight;
            ButtonUsVolver.HoverColor = Color.FromArgb(235, 120, 0);
            ButtonUsVolver.Location = new Point(757, 304);
            ButtonUsVolver.Name = "ButtonUsVolver";
            ButtonUsVolver.PaddingHorizontal = 12;
            ButtonUsVolver.PaddingVertical = 8;
            ButtonUsVolver.PressedColor = Color.FromArgb(255, 192, 128);
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
            buttonModificar.BorderColor = Color.Gray;
            buttonModificar.BorderRadius = 10;
            buttonModificar.BorderSize = 1;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificar.ForeColor = SystemColors.ControlLightLight;
            buttonModificar.HoverColor = Color.FromArgb(235, 120, 0);
            buttonModificar.Location = new Point(626, 304);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.PaddingHorizontal = 12;
            buttonModificar.PaddingVertical = 8;
            buttonModificar.PressedColor = Color.FromArgb(255, 192, 128);
            buttonModificar.Size = new Size(116, 38);
            buttonModificar.TabIndex = 50;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Visible = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // roundedTextBoxObservaciones
            // 
            roundedTextBoxObservaciones.BackColor = Color.White;
            roundedTextBoxObservaciones.BorderColor = Color.Gray;
            roundedTextBoxObservaciones.BorderRadius = 10;
            roundedTextBoxObservaciones.BorderSize = 1;
            roundedTextBoxObservaciones.Location = new Point(490, 52);
            roundedTextBoxObservaciones.Name = "roundedTextBoxObservaciones";
            roundedTextBoxObservaciones.Padding = new Padding(9, 8, 9, 8);
            roundedTextBoxObservaciones.PasswordChar = '\0';
            roundedTextBoxObservaciones.ReadOnly = false;
            roundedTextBoxObservaciones.Size = new Size(140, 24);
            roundedTextBoxObservaciones.TabIndex = 49;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 366);
            Controls.Add(panelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1314, 758);
            MinimumSize = new Size(348, 83);
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
        private RoundedTextBox tboxNombreUsuario;
        private Label labTipoUser;
        private ComboBox comboTipoUsuario;
        private RoundedTextBox textBoxUsConfigContrasenya;
        private Label LabUsConfigContraseña;
        private RoundedTextBox textBoxUsContrasenya;
        private Label LabUsContrasenya;
        private RoundedTextBox textBoxUsApellidos;
        private Label labUsApellido;
        private RoundedTextBox txtBoxUsNombre;
        private Label lavUsNombre;
        private Bloqueo.RoundedButton ButtonUsAnyadir;
        private Label labelTituoCrearUsuario;
        private Label labelUsNombre;
        private Panel panelGrupo;
        private Panel panelUsGrupo;
        private RoundedTextBox tboxUserTurno;
        private Label labUserTurno;
        private Label labUserCurso;
        private Panel panelCliente;
        private RoundedTextBox tboxUserObserv;
        private RoundedTextBox tboxUserAlerg;
        private RoundedTextBox tboxUserCurso;
        private Label labUserAlerg;
        private Label labUserComCitas;
        private Panel panelAdmin;
        private RoundedTextBox tboxUserEspec;
        private Label labUserEspecialidad;
        private CheckBox checkBoxEstado;
        private Label labUsEmail;
        private RoundedTextBox textBoxUsEmail;
        private Label label2;
        private RoundedTextBox textBoxUsTel;
        private Label labUsTel;
        private long id;
        private string contrasenya;
        private Bloqueo.RoundedButton ButtonUsGuardar;
        private Bloqueo.RoundedButton ButtonUsVolver;
        private Label labelTituoInfoUsuario;
        private Panel panelUsuario;
        private Bloqueo.RoundedButton buttonModificar;
        private RichTextBox richTextBox1;
        private PictureBox pictureBoxICon;
        private Label labUserObserv;
        public class RoundedTextBox : UserControl
        {
            private TextBox textBox = new TextBox();

            private int borderRadius = 10;
            private int borderSize = 1;
            private Color borderColor = SystemColors.ControlDarkDark;
            private bool isReadOnly = false;

            // Evento TextChanged
            public event EventHandler TextChanged
            {
                add { textBox.TextChanged += value; }
                remove { textBox.TextChanged -= value; }
            }

            public bool ReadOnly
            {
                get => isReadOnly;
                set
                {
                    isReadOnly = value;
                    textBox.ReadOnly = value;

                    if (value)
                    {
                        Color readOnlyColor = SystemColors.Control;

                        textBox.BackColor = readOnlyColor;
                        this.BackColor = readOnlyColor;
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        Color normalColor = Color.White;

                        textBox.BackColor = normalColor;
                        this.BackColor = normalColor;
                        this.Cursor = Cursors.IBeam;
                    }

                    Invalidate();
                }
            }

            private char passwordChar = '\0';

            public char PasswordChar
            {
                get => passwordChar;
                set
                {
                    passwordChar = value;
                    textBox.PasswordChar = value;
                }
            }

            public int BorderRadius
            {
                get => borderRadius;
                set { borderRadius = value; Invalidate(); }
            }

            public int BorderSize
            {
                get => borderSize;
                set
                {
                    borderSize = value;
                    AjustarTextBox();
                    Invalidate();
                }
            }

            public Color BorderColor
            {
                get => borderColor;
                set { borderColor = value; Invalidate(); }
            }

            public override string Text
            {
                get => textBox.Text;
                set => textBox.Text = value;
            }

            public RoundedTextBox()
            {
                this.DoubleBuffered = true;
                this.BackColor = SystemColors.ControlLightLight;

                textBox.BorderStyle = BorderStyle.None;
                textBox.Font = new Font("Segoe UI", 10F);
                textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                this.Controls.Add(textBox);

                this.Size = new Size(200, 40);

                this.Resize += RoundedTextBox_Resize;

                AjustarTextBox();
            }

            private void AjustarTextBox()
            {
                int margenHorizontal = 10 + borderSize;

                textBox.Width = this.Width - (margenHorizontal * 2);

                textBox.Location = new Point(
                    margenHorizontal,
                    (this.Height - textBox.PreferredHeight) / 2
                );
            }

            private void RoundedTextBox_Resize(object sender, EventArgs e)
            {
                textBox.Width = this.Width - 20;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle surfaceRect = this.ClientRectangle;

                // 1️⃣ Path completo para la region (forma del control)
                using (GraphicsPath surfacePath = GetRoundedPath(surfaceRect, borderRadius))
                {
                    this.Region = new Region(surfacePath);

                    // 2️⃣ Rect más pequeño SOLO para el borde
                    Rectangle borderRect = Rectangle.Inflate(surfaceRect, -borderSize, -borderSize);

                    using (GraphicsPath borderPath = GetRoundedPath(borderRect, borderRadius - borderSize))
                    {
                        using (Pen pen = new Pen(
                            isReadOnly ? SystemColors.ControlDark : borderColor,
                            borderSize))
                        {
                            pen.Alignment = PenAlignment.Center; // ahora sí funciona
                            e.Graphics.DrawPath(pen, borderPath);
                        }
                    }
                }
            }

            private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();

                if (radius <= 0)
                {
                    path.AddRectangle(rect);
                    return path;
                }

                radius = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

                path.StartFigure();
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                return path;
            }
        }
        private RoundedTextBox roundedTextBoxObservaciones;
    } 
    }