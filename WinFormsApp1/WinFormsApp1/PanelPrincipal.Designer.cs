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
            panel1 = new Panel();
            buttonFiltros = new Button();
            panelCitasHoy = new Panel();
            labelNumCitasHoy = new Label();
            labelCitasHoy = new Label();
            pictureBoxCitasHoy = new PictureBox();
            comboBoxGrupos = new ComboBox();
            buttonCitas = new Button();
            panelCitas = new Panel();
            panelUsuario = new Panel();
            panelUsuarioContainer = new Panel();
            panelCitasProximas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasProximas).BeginInit();
            panelGrande.SuspendLayout();
            panel1.SuspendLayout();
            panelCitasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasHoy).BeginInit();
            panelCitas.SuspendLayout();
            panelUsuario.SuspendLayout();
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
            panelCitasProximas.Location = new Point(21, 26);
            panelCitasProximas.Margin = new Padding(4, 3, 4, 3);
            panelCitasProximas.Name = "panelCitasProximas";
            panelCitasProximas.Size = new Size(142, 85);
            panelCitasProximas.TabIndex = 15;
            // 
            // labelNumCitasProximas
            // 
            labelNumCitasProximas.AutoSize = true;
            labelNumCitasProximas.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasProximas.ForeColor = SystemColors.ControlText;
            labelNumCitasProximas.Location = new Point(58, 42);
            labelNumCitasProximas.Margin = new Padding(4, 0, 4, 0);
            labelNumCitasProximas.Name = "labelNumCitasProximas";
            labelNumCitasProximas.Size = new Size(34, 25);
            labelNumCitasProximas.TabIndex = 2;
            labelNumCitasProximas.Text = "23";
            // 
            // labelCitasProximas
            // 
            labelCitasProximas.AutoSize = true;
            labelCitasProximas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasProximas.Location = new Point(16, 18);
            labelCitasProximas.Margin = new Padding(4, 0, 4, 0);
            labelCitasProximas.Name = "labelCitasProximas";
            labelCitasProximas.Size = new Size(95, 17);
            labelCitasProximas.TabIndex = 0;
            labelCitasProximas.Text = "Póximas Citas";
            // 
            // pictureBoxCitasProximas
            // 
            pictureBoxCitasProximas.Image = Properties.Resources.cita_previa;
            pictureBoxCitasProximas.Location = new Point(20, 33);
            pictureBoxCitasProximas.Margin = new Padding(4, 3, 4, 3);
            pictureBoxCitasProximas.Name = "pictureBoxCitasProximas";
            pictureBoxCitasProximas.Size = new Size(38, 38);
            pictureBoxCitasProximas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCitasProximas.TabIndex = 1;
            pictureBoxCitasProximas.TabStop = false;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendarFiltrar.Location = new Point(27, 194);
            monthCalendarFiltrar.Margin = new Padding(8, 7, 8, 7);
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
            panelCitasContainer.Location = new Point(26, 22);
            panelCitasContainer.Margin = new Padding(3, 2, 3, 2);
            panelCitasContainer.Name = "panelCitasContainer";
            panelCitasContainer.Size = new Size(598, 724);
            panelCitasContainer.TabIndex = 19;
            // 
            // panelGrande
            // 
            panelGrande.Controls.Add(panelUsuario);
            panelGrande.Controls.Add(panel1);
            panelGrande.Controls.Add(panelCitas);
            panelGrande.Dock = DockStyle.Fill;
            panelGrande.Location = new Point(0, 0);
            panelGrande.Margin = new Padding(3, 2, 3, 2);
            panelGrande.Name = "panelGrande";
            panelGrande.Size = new Size(1375, 768);
            panelGrande.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonFiltros);
            panel1.Controls.Add(monthCalendarFiltrar);
            panel1.Controls.Add(panelCitasHoy);
            panel1.Controls.Add(comboBoxGrupos);
            panel1.Controls.Add(panelCitasProximas);
            panel1.Controls.Add(buttonCitas);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(401, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 768);
            panel1.TabIndex = 22;
            // 
            // buttonFiltros
            // 
            buttonFiltros.Location = new Point(51, 585);
            buttonFiltros.Margin = new Padding(3, 2, 3, 2);
            buttonFiltros.Name = "buttonFiltros";
            buttonFiltros.Size = new Size(226, 22);
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
            panelCitasHoy.Location = new Point(182, 26);
            panelCitasHoy.Margin = new Padding(4, 3, 4, 3);
            panelCitasHoy.Name = "panelCitasHoy";
            panelCitasHoy.Size = new Size(142, 85);
            panelCitasHoy.TabIndex = 20;
            // 
            // labelNumCitasHoy
            // 
            labelNumCitasHoy.AutoSize = true;
            labelNumCitasHoy.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasHoy.ForeColor = SystemColors.ControlText;
            labelNumCitasHoy.Location = new Point(58, 42);
            labelNumCitasHoy.Margin = new Padding(4, 0, 4, 0);
            labelNumCitasHoy.Name = "labelNumCitasHoy";
            labelNumCitasHoy.Size = new Size(34, 25);
            labelNumCitasHoy.TabIndex = 2;
            labelNumCitasHoy.Text = "23";
            // 
            // labelCitasHoy
            // 
            labelCitasHoy.AutoSize = true;
            labelCitasHoy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasHoy.Location = new Point(16, 18);
            labelCitasHoy.Margin = new Padding(4, 0, 4, 0);
            labelCitasHoy.Name = "labelCitasHoy";
            labelCitasHoy.Size = new Size(68, 17);
            labelCitasHoy.TabIndex = 0;
            labelCitasHoy.Text = "Citas Hoy";
            // 
            // pictureBoxCitasHoy
            // 
            pictureBoxCitasHoy.Image = Properties.Resources.citas;
            pictureBoxCitasHoy.Location = new Point(20, 33);
            pictureBoxCitasHoy.Margin = new Padding(4, 3, 4, 3);
            pictureBoxCitasHoy.Name = "pictureBoxCitasHoy";
            pictureBoxCitasHoy.Size = new Size(38, 38);
            pictureBoxCitasHoy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCitasHoy.TabIndex = 1;
            pictureBoxCitasHoy.TabStop = false;
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.FormattingEnabled = true;
            comboBoxGrupos.Location = new Point(51, 548);
            comboBoxGrupos.Margin = new Padding(3, 2, 3, 2);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(226, 23);
            comboBoxGrupos.TabIndex = 24;
            comboBoxGrupos.SelectedIndexChanged += comboBoxGrupos_SelectedIndexChanged;
            // 
            // buttonCitas
            // 
            buttonCitas.Location = new Point(51, 622);
            buttonCitas.Margin = new Padding(3, 2, 3, 2);
            buttonCitas.Name = "buttonCitas";
            buttonCitas.Size = new Size(226, 22);
            buttonCitas.TabIndex = 23;
            buttonCitas.Text = "Ir al panel de citas";
            buttonCitas.UseVisualStyleBackColor = true;
            buttonCitas.Click += buttonCitas_Click;
            // 
            // panelCitas
            // 
            panelCitas.Controls.Add(panelCitasContainer);
            panelCitas.Dock = DockStyle.Right;
            panelCitas.Location = new Point(725, 0);
            panelCitas.Margin = new Padding(3, 2, 3, 2);
            panelCitas.Name = "panelCitas";
            panelCitas.Padding = new Padding(26, 22, 26, 22);
            panelCitas.Size = new Size(650, 768);
            panelCitas.TabIndex = 21;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(panelUsuarioContainer);
            panelUsuario.Dock = DockStyle.Right;
            panelUsuario.Location = new Point(-255, 0);
            panelUsuario.Margin = new Padding(3, 2, 3, 2);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Padding = new Padding(26, 22, 26, 22);
            panelUsuario.Size = new Size(656, 768);
            panelUsuario.TabIndex = 23;
            // 
            // panelUsuarioContainer
            // 
            panelUsuarioContainer.BackColor = Color.White;
            panelUsuarioContainer.Dock = DockStyle.Fill;
            panelUsuarioContainer.Location = new Point(26, 22);
            panelUsuarioContainer.Margin = new Padding(3, 2, 3, 2);
            panelUsuarioContainer.Name = "panelUsuarioContainer";
            panelUsuarioContainer.Size = new Size(604, 724);
            panelUsuarioContainer.TabIndex = 19;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 768);
            Controls.Add(panelGrande);
            Name = "PanelPrincipal";
            Text = "PanelPrincipal";
            Load += PanelPrincipal_Load;
            panelCitasProximas.ResumeLayout(false);
            panelCitasProximas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasProximas).EndInit();
            panelGrande.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelCitasHoy.ResumeLayout(false);
            panelCitasHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasHoy).EndInit();
            panelCitas.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
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
        private Panel panel1;
        private Button buttonFiltros;
        private Panel panel2;
        private Panel panel3;
        private Panel panelUsuario;
        private Panel panelUsuarioContainer;
    }
}