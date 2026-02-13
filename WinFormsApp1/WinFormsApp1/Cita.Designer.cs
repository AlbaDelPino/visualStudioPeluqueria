using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    partial class Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita));
            panelCita = new Panel();
            panelIcon = new Panel();
            pictureBoxICon = new PictureBox();
            textBoxCitGrupo = new TextBox();
            textBoxCitFecha = new TextBox();
            comboBoxCitHora = new ComboBox();
            buttonCitCliente = new Button();
            textBoxCitCliente = new TextBox();
            labelCitCliente = new Label();
            labelCitGrupo = new Label();
            buttonCitServicio = new Button();
            labelCitHora = new Label();
            textBoxCitServicio = new TextBox();
            ButtonCitAnyadir = new Button();
            labelCitServicio = new Label();
            CalendarCitas = new MyMonthCalendar();
            labelTituoCrearCita = new Label();
            labelCitFecha = new Label();
            panelCita.SuspendLayout();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // panelCita
            // 
            panelCita.Controls.Add(panelIcon);
            panelCita.Controls.Add(textBoxCitGrupo);
            panelCita.Controls.Add(textBoxCitFecha);
            panelCita.Controls.Add(comboBoxCitHora);
            panelCita.Controls.Add(buttonCitCliente);
            panelCita.Controls.Add(textBoxCitCliente);
            panelCita.Controls.Add(labelCitCliente);
            panelCita.Controls.Add(labelCitGrupo);
            panelCita.Controls.Add(buttonCitServicio);
            panelCita.Controls.Add(labelCitHora);
            panelCita.Controls.Add(textBoxCitServicio);
            panelCita.Controls.Add(ButtonCitAnyadir);
            panelCita.Controls.Add(labelCitServicio);
            panelCita.Controls.Add(CalendarCitas);
            panelCita.Controls.Add(labelTituoCrearCita);
            panelCita.Controls.Add(labelCitFecha);
            panelCita.Dock = DockStyle.Fill;
            panelCita.Location = new Point(0, 0);
            panelCita.Name = "panelCita";
            panelCita.Size = new Size(879, 433);
            panelCita.TabIndex = 56;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(241, 123, 35);
            panelIcon.Controls.Add(pictureBoxICon);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(208, 433);
            panelIcon.TabIndex = 93;
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.Dock = DockStyle.Fill;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 433);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 0;
            pictureBoxICon.TabStop = false;
            // 
            // textBoxCitGrupo
            // 
            textBoxCitGrupo.Location = new Point(357, 228);
            textBoxCitGrupo.Margin = new Padding(3, 4, 3, 4);
            textBoxCitGrupo.Name = "textBoxCitGrupo";
            textBoxCitGrupo.ReadOnly = true;
            textBoxCitGrupo.Size = new Size(114, 27);
            textBoxCitGrupo.TabIndex = 92;
            // 
            // textBoxCitFecha
            // 
            textBoxCitFecha.Location = new Point(664, 81);
            textBoxCitFecha.Name = "textBoxCitFecha";
            textBoxCitFecha.ReadOnly = true;
            textBoxCitFecha.Size = new Size(145, 27);
            textBoxCitFecha.TabIndex = 91;
            // 
            // comboBoxCitHora
            // 
            comboBoxCitHora.FormattingEnabled = true;
            comboBoxCitHora.Location = new Point(357, 170);
            comboBoxCitHora.Name = "comboBoxCitHora";
            comboBoxCitHora.Size = new Size(175, 28);
            comboBoxCitHora.TabIndex = 89;
            comboBoxCitHora.SelectedIndexChanged += comboBoxCitHora_SelectedIndexChanged;
            // 
            // buttonCitCliente
            // 
            buttonCitCliente.Location = new Point(482, 286);
            buttonCitCliente.Margin = new Padding(3, 4, 3, 4);
            buttonCitCliente.Name = "buttonCitCliente";
            buttonCitCliente.Size = new Size(50, 30);
            buttonCitCliente.TabIndex = 87;
            buttonCitCliente.UseVisualStyleBackColor = true;
            buttonCitCliente.Click += buttonCitCliente_Click;
            buttonCitCliente.Paint += buttonCitCliente_Paint;
            // 
            // textBoxCitCliente
            // 
            textBoxCitCliente.Location = new Point(357, 286);
            textBoxCitCliente.Margin = new Padding(3, 4, 3, 4);
            textBoxCitCliente.Name = "textBoxCitCliente";
            textBoxCitCliente.ReadOnly = true;
            textBoxCitCliente.Size = new Size(114, 27);
            textBoxCitCliente.TabIndex = 86;
            // 
            // labelCitCliente
            // 
            labelCitCliente.AutoSize = true;
            labelCitCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitCliente.Location = new Point(280, 289);
            labelCitCliente.Margin = new Padding(5, 0, 5, 0);
            labelCitCliente.Name = "labelCitCliente";
            labelCitCliente.Size = new Size(61, 20);
            labelCitCliente.TabIndex = 85;
            labelCitCliente.Text = "Cliente";
            // 
            // labelCitGrupo
            // 
            labelCitGrupo.AutoSize = true;
            labelCitGrupo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitGrupo.Location = new Point(280, 231);
            labelCitGrupo.Margin = new Padding(5, 0, 5, 0);
            labelCitGrupo.Name = "labelCitGrupo";
            labelCitGrupo.Size = new Size(55, 20);
            labelCitGrupo.TabIndex = 88;
            labelCitGrupo.Text = "Grupo";
            // 
            // buttonCitServicio
            // 
            buttonCitServicio.Location = new Point(482, 113);
            buttonCitServicio.Margin = new Padding(3, 4, 3, 4);
            buttonCitServicio.Name = "buttonCitServicio";
            buttonCitServicio.Size = new Size(50, 30);
            buttonCitServicio.TabIndex = 81;
            buttonCitServicio.UseVisualStyleBackColor = true;
            buttonCitServicio.Click += buttonCitServicio_Click;
            buttonCitServicio.Paint += buttonCitServicio_Paint;
            // 
            // labelCitHora
            // 
            labelCitHora.AutoSize = true;
            labelCitHora.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitHora.Location = new Point(280, 173);
            labelCitHora.Margin = new Padding(5, 0, 5, 0);
            labelCitHora.Name = "labelCitHora";
            labelCitHora.Size = new Size(46, 20);
            labelCitHora.TabIndex = 85;
            labelCitHora.Text = "Hora";
            // 
            // textBoxCitServicio
            // 
            textBoxCitServicio.Location = new Point(357, 113);
            textBoxCitServicio.Margin = new Padding(3, 4, 3, 4);
            textBoxCitServicio.Name = "textBoxCitServicio";
            textBoxCitServicio.ReadOnly = true;
            textBoxCitServicio.Size = new Size(114, 27);
            textBoxCitServicio.TabIndex = 80;
            // 
            // ButtonCitAnyadir
            // 
            ButtonCitAnyadir.BackColor = Color.DarkOrange;
            ButtonCitAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonCitAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonCitAnyadir.Location = new Point(714, 364);
            ButtonCitAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonCitAnyadir.Name = "ButtonCitAnyadir";
            ButtonCitAnyadir.Size = new Size(95, 37);
            ButtonCitAnyadir.TabIndex = 66;
            ButtonCitAnyadir.Text = "Añadir";
            ButtonCitAnyadir.UseVisualStyleBackColor = false;
            ButtonCitAnyadir.Click += ButtonCitAnyadir_Click;
            // 
            // labelCitServicio
            // 
            labelCitServicio.AutoSize = true;
            labelCitServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitServicio.Location = new Point(280, 116);
            labelCitServicio.Margin = new Padding(5, 0, 5, 0);
            labelCitServicio.Name = "labelCitServicio";
            labelCitServicio.Size = new Size(69, 20);
            labelCitServicio.TabIndex = 59;
            labelCitServicio.Text = "Servicio";
            // 
            // CalendarCitas
            // 
            CalendarCitas.FirstDayOfWeek = Day.Monday;
            CalendarCitas.Location = new Point(589, 113);
            CalendarCitas.MaxSelectionCount = 1;
            CalendarCitas.MinDate = new DateTime(2026, 2, 4, 0, 0, 0, 0);
            CalendarCitas.Name = "CalendarCitas";
            CalendarCitas.ShowToday = false;
            CalendarCitas.TabIndex = 55;
            CalendarCitas.TitleBackColor = Color.DarkOrange;
            CalendarCitas.TrailingForeColor = SystemColors.ButtonShadow;
            CalendarCitas.DateSelected += CalendarCitas_SelectedChanged;
            // 
            // labelTituoCrearCita
            // 
            labelTituoCrearCita.AutoSize = true;
            labelTituoCrearCita.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTituoCrearCita.ForeColor = SystemColors.ControlDarkDark;
            labelTituoCrearCita.Location = new Point(272, 27);
            labelTituoCrearCita.Name = "labelTituoCrearCita";
            labelTituoCrearCita.Size = new Size(188, 50);
            labelTituoCrearCita.TabIndex = 53;
            labelTituoCrearCita.Text = "Crear cita";
            // 
            // labelCitFecha
            // 
            labelCitFecha.AutoSize = true;
            labelCitFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitFecha.Location = new Point(589, 84);
            labelCitFecha.Margin = new Padding(5, 0, 5, 0);
            labelCitFecha.Name = "labelCitFecha";
            labelCitFecha.Size = new Size(55, 20);
            labelCitFecha.TabIndex = 50;
            labelCitFecha.Text = "Fecha";
            // 
            // Cita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 433);
            Controls.Add(panelCita);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cita";
            Text = "Cita";
            panelCita.ResumeLayout(false);
            panelCita.PerformLayout();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCita;
        private ComboBox comboClienteCita;
        private Button ButtonCitAnyadir;
        private Label labelCitServicio;
        private MyMonthCalendar CalendarCitas;
        private Label labelTituoCrearCita;
        private Label labelCitFecha;
        private Label label1;
        private Button buttonCitServicio;
        private TextBox textBoxCitServicio;
        private Button buttonCitCliente;
        private TextBox textBoxCitCliente;
        private Label labelCitCliente;
        private Label labelCitGrupo;
        private Label labelCitHora;
        private ComboBox comboBoxCitHora;
        private TextBox textBoxCitFecha;
        private TextBox textBoxCitGrupo;
        private Panel panelIcon;
        private PictureBox pictureBoxICon;
        private FlowLayoutPanel flowLayoutPanel1;
        public class MyMonthCalendar : MonthCalendar
        {
            [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
            static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
            protected override void OnHandleCreated(EventArgs e)
            {
                SetWindowTheme(Handle, string.Empty, string.Empty);
                base.OnHandleCreated(e);
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

        public Label LabelTituoCrearCita
        {
            get
            {
                return this.labelTituoCrearCita;
            }
            set
            {
                this.labelTituoCrearCita = value;
            }
        }
       
        public ComboBox ComboBoxClienteCita
        {
            get
            {
                return this.comboClienteCita;
            }
            set
            {
                this.comboClienteCita = value;
            }
        }

        public Button buttonCitAnyadir
        {
            get
            {
                return this.ButtonCitAnyadir;
            }
            set
            {
                this.ButtonCitAnyadir = value;
            }
        }
        public ComboBox ComboBoxCitHora
        {
            get
            {
                return this.comboBoxCitHora;
            }
            set
            {
                this.comboBoxCitHora = value;
            }
        }
    }

}