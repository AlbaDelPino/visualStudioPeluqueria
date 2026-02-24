using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class PanelPrincipal
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
            panelCitasProximas = new Panel();
            labelNumCitasProximas = new Label();
            labelCitasProximas = new Label();
            pictureBoxCitasProximas = new PictureBox();
            monthCalendarFiltrar = new MyMonthCalendar();
            panelCitasContainer = new Panel();
            panelGrande = new Panel();
            panelUsuario = new Panel();
            panelHistorial = new Panel();
            panelFiltros = new Panel();
            buttonFiltros = new Button();
            panelCitasHoy = new Panel();
            labelNumCitasHoy = new Label();
            labelCitasHoy = new Label();
            pictureBoxCitasHoy = new PictureBox();
            comboBoxGrupos = new ComboBox();
            buttonCitas = new Button();
            panelCitas = new Panel();
            panelCitasProximas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasProximas).BeginInit();
            panelGrande.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelCitasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasHoy).BeginInit();
            panelCitas.SuspendLayout();
            SuspendLayout();
            // 
            // panelCitasProximas
            // 
            panelCitasProximas.BackColor = SystemColors.Control;
            panelCitasProximas.BorderStyle = BorderStyle.FixedSingle;
            panelCitasProximas.Controls.Add(labelNumCitasProximas);
            panelCitasProximas.Controls.Add(labelCitasProximas);
            panelCitasProximas.Controls.Add(pictureBoxCitasProximas);
            panelCitasProximas.ForeColor = SystemColors.ControlDarkDark;
            panelCitasProximas.Location = new Point(24, 35);
            panelCitasProximas.Margin = new Padding(5, 4, 5, 4);
            panelCitasProximas.Name = "panelCitasProximas";
            panelCitasProximas.Size = new Size(162, 113);
            panelCitasProximas.TabIndex = 15;
            // 
            // labelNumCitasProximas
            // 
            labelNumCitasProximas.AutoSize = true;
            labelNumCitasProximas.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasProximas.ForeColor = SystemColors.ControlText;
            labelNumCitasProximas.Location = new Point(66, 56);
            labelNumCitasProximas.Margin = new Padding(5, 0, 5, 0);
            labelNumCitasProximas.Name = "labelNumCitasProximas";
            labelNumCitasProximas.Size = new Size(41, 29);
            labelNumCitasProximas.TabIndex = 2;
            labelNumCitasProximas.Text = "23";
            // 
            // labelCitasProximas
            // 
            labelCitasProximas.AutoSize = true;
            labelCitasProximas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasProximas.Location = new Point(18, 24);
            labelCitasProximas.Margin = new Padding(5, 0, 5, 0);
            labelCitasProximas.Name = "labelCitasProximas";
            labelCitasProximas.Size = new Size(117, 20);
            labelCitasProximas.TabIndex = 0;
            labelCitasProximas.Text = "Póximas Citas";
            // 
            // pictureBoxCitasProximas
            // 
            pictureBoxCitasProximas.Image = Properties.Resources.cita_previa;
            pictureBoxCitasProximas.Location = new Point(23, 44);
            pictureBoxCitasProximas.Margin = new Padding(5, 4, 5, 4);
            pictureBoxCitasProximas.Name = "pictureBoxCitasProximas";
            pictureBoxCitasProximas.Size = new Size(43, 51);
            pictureBoxCitasProximas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCitasProximas.TabIndex = 1;
            pictureBoxCitasProximas.TabStop = false;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendarFiltrar.Location = new Point(31, 259);
            monthCalendarFiltrar.MaxSelectionCount = 31;
            monthCalendarFiltrar.Name = "monthCalendarFiltrar";
            monthCalendarFiltrar.RightToLeft = RightToLeft.Yes;
            monthCalendarFiltrar.ShowToday = false;
            monthCalendarFiltrar.TabIndex = 0;
            monthCalendarFiltrar.TitleBackColor = Color.DarkOrange;
            monthCalendarFiltrar.TrailingForeColor = SystemColors.ButtonShadow;
            monthCalendarFiltrar.DateChanged += monthCalendarFiltrar_DateChanged;
            // 
            // panelCitasContainer
            // 
            panelCitasContainer.BackColor = Color.White;
            panelCitasContainer.Dock = DockStyle.Fill;
            panelCitasContainer.Location = new Point(30, 30);
            panelCitasContainer.Name = "panelCitasContainer";
            panelCitasContainer.Size = new Size(740, 964);
            panelCitasContainer.TabIndex = 19;
            // 
            // panelGrande
            // 
            panelGrande.Controls.Add(panelUsuario);
            panelGrande.Controls.Add(panelFiltros);
            panelGrande.Controls.Add(panelCitas);
            panelGrande.Dock = DockStyle.Fill;
            panelGrande.Location = new Point(0, 0);
            panelGrande.Name = "panelGrande";
            panelGrande.Size = new Size(2082, 1024);
            panelGrande.TabIndex = 24;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(panelHistorial);
            panelUsuario.Dock = DockStyle.Right;
            panelUsuario.Location = new Point(92, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Padding = new Padding(30, 29, 30, 29);
            panelUsuario.Size = new Size(800, 1024);
            panelUsuario.TabIndex = 23;
            // 
            // panelHistorial
            // 
            panelHistorial.BackColor = Color.White;
            panelHistorial.Dock = DockStyle.Fill;
            panelHistorial.Location = new Point(30, 29);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(740, 966);
            panelHistorial.TabIndex = 19;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(buttonFiltros);
            panelFiltros.Controls.Add(monthCalendarFiltrar);
            panelFiltros.Controls.Add(panelCitasHoy);
            panelFiltros.Controls.Add(comboBoxGrupos);
            panelFiltros.Controls.Add(panelCitasProximas);
            panelFiltros.Controls.Add(buttonCitas);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(892, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(390, 1024);
            panelFiltros.TabIndex = 22;
            // 
            // buttonFiltros
            // 
            buttonFiltros.Location = new Point(58, 780);
            buttonFiltros.Name = "buttonFiltros";
            buttonFiltros.Size = new Size(258, 29);
            buttonFiltros.TabIndex = 25;
            buttonFiltros.Text = "Ver todas las citas de hoy";
            buttonFiltros.UseVisualStyleBackColor = true;
            buttonFiltros.Click += buttonFiltros_Click;
            // 
            // panelCitasHoy
            // 
            panelCitasHoy.BackColor = SystemColors.Control;
            panelCitasHoy.BorderStyle = BorderStyle.FixedSingle;
            panelCitasHoy.Controls.Add(labelNumCitasHoy);
            panelCitasHoy.Controls.Add(labelCitasHoy);
            panelCitasHoy.Controls.Add(pictureBoxCitasHoy);
            panelCitasHoy.ForeColor = SystemColors.ControlDarkDark;
            panelCitasHoy.Location = new Point(208, 35);
            panelCitasHoy.Margin = new Padding(5, 4, 5, 4);
            panelCitasHoy.Name = "panelCitasHoy";
            panelCitasHoy.Size = new Size(162, 113);
            panelCitasHoy.TabIndex = 20;
            // 
            // labelNumCitasHoy
            // 
            labelNumCitasHoy.AutoSize = true;
            labelNumCitasHoy.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasHoy.ForeColor = SystemColors.ControlText;
            labelNumCitasHoy.Location = new Point(66, 56);
            labelNumCitasHoy.Margin = new Padding(5, 0, 5, 0);
            labelNumCitasHoy.Name = "labelNumCitasHoy";
            labelNumCitasHoy.Size = new Size(41, 29);
            labelNumCitasHoy.TabIndex = 2;
            labelNumCitasHoy.Text = "23";
            // 
            // labelCitasHoy
            // 
            labelCitasHoy.AutoSize = true;
            labelCitasHoy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasHoy.Location = new Point(18, 24);
            labelCitasHoy.Margin = new Padding(5, 0, 5, 0);
            labelCitasHoy.Name = "labelCitasHoy";
            labelCitasHoy.Size = new Size(83, 20);
            labelCitasHoy.TabIndex = 0;
            labelCitasHoy.Text = "Citas Hoy";
            // 
            // pictureBoxCitasHoy
            // 
            pictureBoxCitasHoy.Image = Properties.Resources.citas;
            pictureBoxCitasHoy.Location = new Point(23, 44);
            pictureBoxCitasHoy.Margin = new Padding(5, 4, 5, 4);
            pictureBoxCitasHoy.Name = "pictureBoxCitasHoy";
            pictureBoxCitasHoy.Size = new Size(43, 51);
            pictureBoxCitasHoy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCitasHoy.TabIndex = 1;
            pictureBoxCitasHoy.TabStop = false;
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.FormattingEnabled = true;
            comboBoxGrupos.Location = new Point(58, 731);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(258, 28);
            comboBoxGrupos.TabIndex = 24;
            comboBoxGrupos.SelectedIndexChanged += comboBoxGrupos_SelectedIndexChanged;
            // 
            // buttonCitas
            // 
            buttonCitas.Location = new Point(58, 829);
            buttonCitas.Name = "buttonCitas";
            buttonCitas.Size = new Size(258, 29);
            buttonCitas.TabIndex = 23;
            buttonCitas.Text = "Ir al panel de citas";
            buttonCitas.UseVisualStyleBackColor = true;
            buttonCitas.Click += buttonCitas_Click;
            // 
            // panelCitas
            // 
            panelCitas.Controls.Add(panelCitasContainer);
            panelCitas.Dock = DockStyle.Right;
            panelCitas.Location = new Point(1282, 0);
            panelCitas.Name = "panelCitas";
            panelCitas.Padding = new Padding(30);
            panelCitas.Size = new Size(800, 1024);
            panelCitas.TabIndex = 21;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2082, 1024);
            Controls.Add(panelGrande);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelPrincipal";
            Text = "PanelPrincipal";
            Load += PanelPrincipal_Load;
            panelCitasProximas.ResumeLayout(false);
            panelCitasProximas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasProximas).EndInit();
            panelGrande.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelCitasHoy.ResumeLayout(false);
            panelCitasHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasHoy).EndInit();
            panelCitas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCitasProximas;
        private Label labelNumCitasProximas;
        private Label labelCitasProximas;
        private PictureBox pictureBoxCitasProximas;
        private MyMonthCalendar monthCalendarFiltrar;
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
        private Panel panelCitasContainer;
        private Panel panelCitasHoy;
        private Label labelNumCitasHoy;
        private Label labelCitasHoy;
        private PictureBox pictureBoxCitasHoy;
        private Panel panelCitas;
        private Button buttonCitas;
        private ComboBox comboBoxGrupos;
        private Panel panelGrande;
        private Panel panelFiltros;
        private Button buttonFiltros;
        private Panel panel2;
        private Panel panel3;
        private Panel panelUsuario;
        private Panel panelHistorial;
    }
}