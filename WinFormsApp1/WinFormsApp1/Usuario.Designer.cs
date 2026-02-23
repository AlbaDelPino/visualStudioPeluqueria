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
            ButtonUsAnyadir = new Button();
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
            textBoxObservaciones = new RoundedTextBox();
            labUserObserv = new Label();
            tboxUserAlerg = new RoundedTextBox();
            labUserAlerg = new Label();
            textBoxUsTel = new RoundedTextBox();
            labUsTel = new Label();
            textBoxUsEmail = new RoundedTextBox();
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
            labNombreUsuario.Location = new Point(274, 120);
            labNombreUsuario.Margin = new Padding(5, 0, 5, 0);
            labNombreUsuario.Name = "labNombreUsuario";
            labNombreUsuario.Size = new Size(155, 20);
            labNombreUsuario.TabIndex = 1;
            labNombreUsuario.Text = "Nombre del usuario";
            // 
            // tboxNombreUsuario
            // 
            tboxNombreUsuario.BackColor = Color.White;
            tboxNombreUsuario.BorderColor = Color.Gray;
            tboxNombreUsuario.BorderRadius = 10;
            tboxNombreUsuario.BorderSize = 1;
            tboxNombreUsuario.Location = new Point(437, 120);
            tboxNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            tboxNombreUsuario.Name = "tboxNombreUsuario";
            tboxNombreUsuario.ReadOnly = false;
            tboxNombreUsuario.Size = new Size(192, 32);
            tboxNombreUsuario.TabIndex = 1;
            // 
            // labTipoUser
            // 
            labTipoUser.AutoSize = true;
            labTipoUser.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTipoUser.Location = new Point(653, 220);
            labTipoUser.Margin = new Padding(5, 0, 5, 0);
            labTipoUser.Name = "labTipoUser";
            labTipoUser.Size = new Size(124, 20);
            labTipoUser.TabIndex = 3;
            labTipoUser.Text = "Tipo de usuario";
            // 
            // comboTipoUsuario
            // 
            comboTipoUsuario.DisplayMember = "1";
            comboTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUsuario.FormattingEnabled = true;
            comboTipoUsuario.Items.AddRange(new object[] { "Cliente", "Grupo", "Admin" });
            comboTipoUsuario.Location = new Point(820, 220);
            comboTipoUsuario.Margin = new Padding(5, 4, 5, 4);
            comboTipoUsuario.MaxDropDownItems = 3;
            comboTipoUsuario.Name = "comboTipoUsuario";
            comboTipoUsuario.Size = new Size(159, 28);
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
            textBoxUsConfigContrasenya.Location = new Point(820, 171);
            textBoxUsConfigContrasenya.Margin = new Padding(3, 4, 3, 4);
            textBoxUsConfigContrasenya.Name = "textBoxUsConfigContrasenya";
            textBoxUsConfigContrasenya.Padding = new Padding(10);
            textBoxUsConfigContrasenya.ReadOnly = false;
            textBoxUsConfigContrasenya.Size = new Size(160, 32);
            textBoxUsConfigContrasenya.TabIndex = 7;
            // 
            // LabUsConfigContraseña
            // 
            LabUsConfigContraseña.AutoSize = true;
            LabUsConfigContraseña.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsConfigContraseña.Location = new Point(653, 171);
            LabUsConfigContraseña.Margin = new Padding(5, 0, 5, 0);
            LabUsConfigContraseña.Name = "LabUsConfigContraseña";
            LabUsConfigContraseña.Size = new Size(171, 20);
            LabUsConfigContraseña.TabIndex = 9;
            LabUsConfigContraseña.Text = "Confirmar contraseña";
            // 
            // textBoxUsContrasenya
            // 
            textBoxUsContrasenya.BackColor = Color.White;
            textBoxUsContrasenya.BorderColor = Color.Gray;
            textBoxUsContrasenya.BorderRadius = 10;
            textBoxUsContrasenya.BorderSize = 1;
            textBoxUsContrasenya.Location = new Point(820, 120);
            textBoxUsContrasenya.Margin = new Padding(3, 4, 3, 4);
            textBoxUsContrasenya.Name = "textBoxUsContrasenya";
            textBoxUsContrasenya.Padding = new Padding(10);
            textBoxUsContrasenya.ReadOnly = false;
            textBoxUsContrasenya.Size = new Size(160, 32);
            textBoxUsContrasenya.TabIndex = 6;
            // 
            // LabUsContrasenya
            // 
            LabUsContrasenya.AutoSize = true;
            LabUsContrasenya.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabUsContrasenya.Location = new Point(653, 120);
            LabUsContrasenya.Margin = new Padding(5, 0, 5, 0);
            LabUsContrasenya.Name = "LabUsContrasenya";
            LabUsContrasenya.Size = new Size(95, 20);
            LabUsContrasenya.TabIndex = 11;
            LabUsContrasenya.Text = "Contraseña";
            // 
            // textBoxUsApellidos
            // 
            textBoxUsApellidos.BackColor = Color.White;
            textBoxUsApellidos.BorderColor = Color.Gray;
            textBoxUsApellidos.BorderRadius = 10;
            textBoxUsApellidos.BorderSize = 1;
            textBoxUsApellidos.Location = new Point(437, 220);
            textBoxUsApellidos.Margin = new Padding(3, 4, 3, 4);
            textBoxUsApellidos.Name = "textBoxUsApellidos";
            textBoxUsApellidos.ReadOnly = false;
            textBoxUsApellidos.Size = new Size(192, 32);
            textBoxUsApellidos.TabIndex = 3;
            // 
            // labUsApellido
            // 
            labUsApellido.AutoSize = true;
            labUsApellido.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsApellido.Location = new Point(274, 220);
            labUsApellido.Margin = new Padding(5, 0, 5, 0);
            labUsApellido.Name = "labUsApellido";
            labUsApellido.Size = new Size(77, 20);
            labUsApellido.TabIndex = 13;
            labUsApellido.Text = "Apellidos";
            // 
            // txtBoxUsNombre
            // 
            txtBoxUsNombre.BackColor = Color.White;
            txtBoxUsNombre.BorderColor = Color.Gray;
            txtBoxUsNombre.BorderRadius = 10;
            txtBoxUsNombre.BorderSize = 1;
            txtBoxUsNombre.Location = new Point(437, 171);
            txtBoxUsNombre.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsNombre.Name = "txtBoxUsNombre";
            txtBoxUsNombre.ReadOnly = false;
            txtBoxUsNombre.Size = new Size(192, 32);
            txtBoxUsNombre.TabIndex = 2;
            // 
            // lavUsNombre
            // 
            lavUsNombre.AutoSize = true;
            lavUsNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lavUsNombre.Location = new Point(5, 125);
            lavUsNombre.Margin = new Padding(5, 0, 5, 0);
            lavUsNombre.Name = "lavUsNombre";
            lavUsNombre.Size = new Size(0, 20);
            lavUsNombre.TabIndex = 15;
            // 
            // ButtonUsAnyadir
            // 
            ButtonUsAnyadir.BackColor = Color.DarkOrange;
            ButtonUsAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonUsAnyadir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ButtonUsAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonUsAnyadir.Location = new Point(865, 405);
            ButtonUsAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonUsAnyadir.Name = "ButtonUsAnyadir";
            ButtonUsAnyadir.Size = new Size(110, 51);
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
            labelTituoCrearUsuario.Location = new Point(263, 43);
            labelTituoCrearUsuario.Name = "labelTituoCrearUsuario";
            labelTituoCrearUsuario.Size = new Size(278, 50);
            labelTituoCrearUsuario.TabIndex = 18;
            labelTituoCrearUsuario.Text = "Añadir usuario";
            // 
            // labelUsNombre
            // 
            labelUsNombre.AutoSize = true;
            labelUsNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsNombre.Location = new Point(274, 171);
            labelUsNombre.Margin = new Padding(5, 0, 5, 0);
            labelUsNombre.Name = "labelUsNombre";
            labelUsNombre.Size = new Size(73, 20);
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
            panelUsGrupo.Location = new Point(261, 268);
            panelUsGrupo.Margin = new Padding(3, 4, 3, 4);
            panelUsGrupo.Name = "panelUsGrupo";
            panelUsGrupo.Size = new Size(735, 119);
            panelUsGrupo.TabIndex = 14;
            panelUsGrupo.Visible = false;
            // 
            // tboxUserTurno
            // 
            tboxUserTurno.BackColor = Color.White;
            tboxUserTurno.BorderColor = Color.Gray;
            tboxUserTurno.BorderRadius = 10;
            tboxUserTurno.BorderSize = 1;
            tboxUserTurno.Location = new Point(176, 69);
            tboxUserTurno.Margin = new Padding(3, 4, 3, 4);
            tboxUserTurno.Name = "tboxUserTurno";
            tboxUserTurno.Padding = new Padding(10);
            tboxUserTurno.ReadOnly = false;
            tboxUserTurno.Size = new Size(192, 32);
            tboxUserTurno.TabIndex = 11;
            // 
            // tboxUserCurso
            // 
            tboxUserCurso.BackColor = Color.White;
            tboxUserCurso.BorderColor = Color.Gray;
            tboxUserCurso.BorderRadius = 10;
            tboxUserCurso.BorderSize = 1;
            tboxUserCurso.Location = new Point(176, 20);
            tboxUserCurso.Margin = new Padding(3, 4, 3, 4);
            tboxUserCurso.Name = "tboxUserCurso";
            tboxUserCurso.Padding = new Padding(10);
            tboxUserCurso.ReadOnly = false;
            tboxUserCurso.Size = new Size(192, 32);
            tboxUserCurso.TabIndex = 9;
            // 
            // labUserTurno
            // 
            labUserTurno.AutoSize = true;
            labUserTurno.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserTurno.Location = new Point(15, 69);
            labUserTurno.Margin = new Padding(5, 0, 5, 0);
            labUserTurno.Name = "labUserTurno";
            labUserTurno.Size = new Size(52, 20);
            labUserTurno.TabIndex = 10;
            labUserTurno.Text = "Turno";
            // 
            // labUserCurso
            // 
            labUserCurso.AutoSize = true;
            labUserCurso.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserCurso.Location = new Point(15, 20);
            labUserCurso.Margin = new Padding(5, 0, 5, 0);
            labUserCurso.Name = "labUserCurso";
            labUserCurso.Size = new Size(54, 20);
            labUserCurso.TabIndex = 9;
            labUserCurso.Text = "Curso";
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.DarkKhaki;
            panelAdmin.Controls.Add(tboxUserEspec);
            panelAdmin.Controls.Add(labUserEspecialidad);
            panelAdmin.ForeColor = SystemColors.ControlLightLight;
            panelAdmin.Location = new Point(261, 268);
            panelAdmin.Margin = new Padding(3, 4, 3, 4);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(735, 119);
            panelAdmin.TabIndex = 21;
            panelAdmin.Visible = false;
            // 
            // tboxUserEspec
            // 
            tboxUserEspec.BackColor = Color.White;
            tboxUserEspec.BorderColor = Color.Gray;
            tboxUserEspec.BorderRadius = 10;
            tboxUserEspec.BorderSize = 1;
            tboxUserEspec.Location = new Point(176, 20);
            tboxUserEspec.Margin = new Padding(3, 4, 3, 4);
            tboxUserEspec.Name = "tboxUserEspec";
            tboxUserEspec.Padding = new Padding(10);
            tboxUserEspec.ReadOnly = false;
            tboxUserEspec.Size = new Size(192, 32);
            tboxUserEspec.TabIndex = 9;
            // 
            // labUserEspecialidad
            // 
            labUserEspecialidad.AutoSize = true;
            labUserEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserEspecialidad.Location = new Point(15, 20);
            labUserEspecialidad.Margin = new Padding(5, 0, 5, 0);
            labUserEspecialidad.Name = "labUserEspecialidad";
            labUserEspecialidad.Size = new Size(104, 20);
            labUserEspecialidad.TabIndex = 9;
            labUserEspecialidad.Text = "Especialidad";
            // 
            // panelCliente
            // 
            panelCliente.BackColor = Color.DarkKhaki;
            panelCliente.Controls.Add(textBoxObservaciones);
            panelCliente.Controls.Add(labUserObserv);
            panelCliente.Controls.Add(tboxUserAlerg);
            panelCliente.Controls.Add(labUserAlerg);
            panelCliente.Controls.Add(textBoxUsTel);
            panelCliente.Controls.Add(labUsTel);
            panelCliente.Controls.Add(textBoxUsEmail);
            panelCliente.Controls.Add(labUsEmail);
            panelCliente.ForeColor = SystemColors.ControlLightLight;
            panelCliente.Location = new Point(261, 268);
            panelCliente.Margin = new Padding(3, 4, 3, 4);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(735, 119);
            panelCliente.TabIndex = 12;
            panelCliente.Visible = false;
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.BackColor = Color.White;
            textBoxObservaciones.BorderColor = Color.Gray;
            textBoxObservaciones.BorderRadius = 10;
            textBoxObservaciones.BorderSize = 1;
            textBoxObservaciones.Location = new Point(558, 69);
            textBoxObservaciones.Margin = new Padding(3, 4, 3, 4);
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Padding = new Padding(10);
            textBoxObservaciones.ReadOnly = false;
            textBoxObservaciones.Size = new Size(160, 32);
            textBoxObservaciones.TabIndex = 49;
            // 
            // labUserObserv
            // 
            labUserObserv.AutoSize = true;
            labUserObserv.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserObserv.Location = new Point(395, 69);
            labUserObserv.Margin = new Padding(5, 0, 5, 0);
            labUserObserv.Name = "labUserObserv";
            labUserObserv.Size = new Size(121, 20);
            labUserObserv.TabIndex = 48;
            labUserObserv.Text = "Observaciones";
            // 
            // tboxUserAlerg
            // 
            tboxUserAlerg.BackColor = Color.White;
            tboxUserAlerg.BorderColor = Color.Gray;
            tboxUserAlerg.BorderRadius = 10;
            tboxUserAlerg.BorderSize = 1;
            tboxUserAlerg.Location = new Point(559, 20);
            tboxUserAlerg.Margin = new Padding(3, 4, 3, 4);
            tboxUserAlerg.Name = "tboxUserAlerg";
            tboxUserAlerg.Padding = new Padding(10);
            tboxUserAlerg.ReadOnly = false;
            tboxUserAlerg.Size = new Size(160, 32);
            tboxUserAlerg.TabIndex = 9;
            // 
            // labUserAlerg
            // 
            labUserAlerg.AutoSize = true;
            labUserAlerg.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUserAlerg.Location = new Point(395, 20);
            labUserAlerg.Margin = new Padding(5, 0, 5, 0);
            labUserAlerg.Name = "labUserAlerg";
            labUserAlerg.Size = new Size(84, 20);
            labUserAlerg.TabIndex = 10;
            labUserAlerg.Text = "Alergenos";
            // 
            // textBoxUsTel
            // 
            textBoxUsTel.BackColor = Color.White;
            textBoxUsTel.BorderColor = Color.Gray;
            textBoxUsTel.BorderRadius = 10;
            textBoxUsTel.BorderSize = 1;
            textBoxUsTel.Location = new Point(176, 69);
            textBoxUsTel.Margin = new Padding(3, 4, 3, 4);
            textBoxUsTel.Name = "textBoxUsTel";
            textBoxUsTel.Padding = new Padding(10);
            textBoxUsTel.ReadOnly = false;
            textBoxUsTel.Size = new Size(192, 32);
            textBoxUsTel.TabIndex = 5;
            // 
            // labUsTel
            // 
            labUsTel.AutoSize = true;
            labUsTel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsTel.Location = new Point(15, 69);
            labUsTel.Margin = new Padding(5, 0, 5, 0);
            labUsTel.Name = "labUsTel";
            labUsTel.Size = new Size(73, 20);
            labUsTel.TabIndex = 42;
            labUsTel.Text = "Teléfono";
            // 
            // textBoxUsEmail
            // 
            textBoxUsEmail.BackColor = Color.White;
            textBoxUsEmail.BorderColor = Color.Gray;
            textBoxUsEmail.BorderRadius = 10;
            textBoxUsEmail.BorderSize = 1;
            textBoxUsEmail.Location = new Point(176, 20);
            textBoxUsEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxUsEmail.Name = "textBoxUsEmail";
            textBoxUsEmail.Padding = new Padding(10);
            textBoxUsEmail.ReadOnly = false;
            textBoxUsEmail.Size = new Size(192, 32);
            textBoxUsEmail.TabIndex = 4;
            // 
            // labUsEmail
            // 
            labUsEmail.AutoSize = true;
            labUsEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labUsEmail.Location = new Point(15, 20);
            labUsEmail.Margin = new Padding(5, 0, 5, 0);
            labUsEmail.Name = "labUsEmail";
            labUsEmail.Size = new Size(51, 20);
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
            checkBoxEstado.Location = new Point(277, 413);
            checkBoxEstado.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(79, 27);
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
            ButtonUsGuardar.Location = new Point(784, 405);
            ButtonUsGuardar.Margin = new Padding(3, 4, 3, 4);
            ButtonUsGuardar.Name = "ButtonUsGuardar";
            ButtonUsGuardar.Size = new Size(191, 51);
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
            ButtonUsVolver.Location = new Point(865, 405);
            ButtonUsVolver.Margin = new Padding(3, 4, 3, 4);
            ButtonUsVolver.Name = "ButtonUsVolver";
            ButtonUsVolver.Size = new Size(110, 51);
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
            labelTituoInfoUsuario.Location = new Point(263, 43);
            labelTituoInfoUsuario.Name = "labelTituoInfoUsuario";
            labelTituoInfoUsuario.Size = new Size(428, 50);
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
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(1031, 488);
            panelUsuario.TabIndex = 50;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 488);
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
            buttonModificar.Location = new Point(715, 405);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(133, 51);
            buttonModificar.TabIndex = 50;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Visible = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 488);
            Controls.Add(panelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1499, 998);
            MinimumSize = new Size(395, 98);
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
        private Button ButtonUsAnyadir;
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
        private Button ButtonUsGuardar;
        private Button ButtonUsVolver;
        private Label labelTituoInfoUsuario;
        private Panel panelUsuario;
        private Button buttonModificar;
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
        private RoundedTextBox textBoxObservaciones;
    }
}