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
            panelCitasHoy = new Panel();
            labelNumCitasHoy = new Label();
            labelCitasHoy = new Label();
            pictureBoxCitasHoy = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panelCitas = new Panel();
            panelCitasProximas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCitasProximas).BeginInit();
            panelGrande.SuspendLayout();
            panel1.SuspendLayout();
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
            panelCitasContainer.Size = new Size(690, 964);
            panelCitasContainer.TabIndex = 19;
            // 
            // panelGrande
            // 
            panelGrande.Controls.Add(panel1);
            panelGrande.Controls.Add(panelCitas);
            panelGrande.Dock = DockStyle.Fill;
            panelGrande.Location = new Point(0, 0);
            panelGrande.Name = "panelGrande";
            panelGrande.Size = new Size(1571, 1024);
            panelGrande.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendarFiltrar);
            panel1.Controls.Add(panelCitasHoy);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panelCitasProximas);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 1024);
            panel1.TabIndex = 22;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 780);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(58, 733);
            button1.Name = "button1";
            button1.Size = new Size(258, 29);
            button1.TabIndex = 23;
            button1.Text = "Ver todas las citas";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelCitas
            // 
            panelCitas.Controls.Add(panelCitasContainer);
            panelCitas.Dock = DockStyle.Right;
            panelCitas.Location = new Point(821, 0);
            panelCitas.Name = "panelCitas";
            panelCitas.Padding = new Padding(30);
            panelCitas.Size = new Size(750, 1024);
            panelCitas.TabIndex = 21;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelGrande);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private ComboBox comboBox1;
        private Panel panelGrande;
        private Panel panel1;
    }
}