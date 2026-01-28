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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            panelCitHoy = new Panel();
            labelNumCitHoy = new Label();
            labelCitHoy = new Label();
            pictureCitHoy = new PictureBox();
            panelCit = new Panel();
            labelNumCit = new Label();
            labelCit = new Label();
            pictureCit = new PictureBox();
            panelGrup = new Panel();
            labelNumGrup = new Label();
            labelGrup = new Label();
            pictureGrup = new PictureBox();
            panelAdm = new Panel();
            labelNumAdm = new Label();
            labelAdm = new Label();
            pictureAdm = new PictureBox();
            panelCli = new Panel();
            labelNumCli = new Label();
            labelCli = new Label();
            pictureCli = new PictureBox();
            panelSer = new Panel();
            labelNumSer = new Label();
            labelSer = new Label();
            pictureSer = new PictureBox();
            labelBienvenido = new Label();
            monthCalendarFiltrar = new MyMonthCalendar();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panelCitHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitHoy).BeginInit();
            panelCit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCit).BeginInit();
            panelGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGrup).BeginInit();
            panelAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdm).BeginInit();
            panelCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCli).BeginInit();
            panelSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCitHoy
            // 
            panelCitHoy.BackColor = SystemColors.Control;
            panelCitHoy.BorderStyle = BorderStyle.FixedSingle;
            panelCitHoy.Controls.Add(labelNumCitHoy);
            panelCitHoy.Controls.Add(labelCitHoy);
            panelCitHoy.Controls.Add(pictureCitHoy);
            panelCitHoy.ForeColor = SystemColors.ControlDarkDark;
            panelCitHoy.Location = new Point(883, 16);
            panelCitHoy.Margin = new Padding(5, 4, 5, 4);
            panelCitHoy.Name = "panelCitHoy";
            panelCitHoy.Size = new Size(162, 113);
            panelCitHoy.TabIndex = 16;
            // 
            // labelNumCitHoy
            // 
            labelNumCitHoy.AutoSize = true;
            labelNumCitHoy.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitHoy.ForeColor = SystemColors.ControlText;
            labelNumCitHoy.Location = new Point(66, 56);
            labelNumCitHoy.Margin = new Padding(5, 0, 5, 0);
            labelNumCitHoy.Name = "labelNumCitHoy";
            labelNumCitHoy.Size = new Size(27, 29);
            labelNumCitHoy.TabIndex = 2;
            labelNumCitHoy.Text = "5";
            // 
            // labelCitHoy
            // 
            labelCitHoy.AutoSize = true;
            labelCitHoy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitHoy.Location = new Point(18, 24);
            labelCitHoy.Margin = new Padding(5, 0, 5, 0);
            labelCitHoy.Name = "labelCitHoy";
            labelCitHoy.Size = new Size(83, 20);
            labelCitHoy.TabIndex = 0;
            labelCitHoy.Text = "Citas Hoy";
            // 
            // pictureCitHoy
            // 
            pictureCitHoy.Image = Properties.Resources.cita_previa;
            pictureCitHoy.Location = new Point(23, 44);
            pictureCitHoy.Margin = new Padding(5, 4, 5, 4);
            pictureCitHoy.Name = "pictureCitHoy";
            pictureCitHoy.Size = new Size(43, 51);
            pictureCitHoy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCitHoy.TabIndex = 1;
            pictureCitHoy.TabStop = false;
            // 
            // panelCit
            // 
            panelCit.BackColor = SystemColors.Control;
            panelCit.BorderStyle = BorderStyle.FixedSingle;
            panelCit.Controls.Add(labelNumCit);
            panelCit.Controls.Add(labelCit);
            panelCit.Controls.Add(pictureCit);
            panelCit.ForeColor = SystemColors.ControlDarkDark;
            panelCit.Location = new Point(712, 16);
            panelCit.Margin = new Padding(5, 4, 5, 4);
            panelCit.Name = "panelCit";
            panelCit.Size = new Size(162, 113);
            panelCit.TabIndex = 15;
            // 
            // labelNumCit
            // 
            labelNumCit.AutoSize = true;
            labelNumCit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCit.ForeColor = SystemColors.ControlText;
            labelNumCit.Location = new Point(66, 56);
            labelNumCit.Margin = new Padding(5, 0, 5, 0);
            labelNumCit.Name = "labelNumCit";
            labelNumCit.Size = new Size(41, 29);
            labelNumCit.TabIndex = 2;
            labelNumCit.Text = "23";
            // 
            // labelCit
            // 
            labelCit.AutoSize = true;
            labelCit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCit.Location = new Point(18, 24);
            labelCit.Margin = new Padding(5, 0, 5, 0);
            labelCit.Name = "labelCit";
            labelCit.Size = new Size(117, 20);
            labelCit.TabIndex = 0;
            labelCit.Text = "Póximas Citas";
            // 
            // pictureCit
            // 
            pictureCit.Image = Properties.Resources.cita_previa;
            pictureCit.Location = new Point(23, 44);
            pictureCit.Margin = new Padding(5, 4, 5, 4);
            pictureCit.Name = "pictureCit";
            pictureCit.Size = new Size(43, 51);
            pictureCit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCit.TabIndex = 1;
            pictureCit.TabStop = false;
            // 
            // panelGrup
            // 
            panelGrup.BackColor = SystemColors.Control;
            panelGrup.BorderStyle = BorderStyle.FixedSingle;
            panelGrup.Controls.Add(labelNumGrup);
            panelGrup.Controls.Add(labelGrup);
            panelGrup.Controls.Add(pictureGrup);
            panelGrup.ForeColor = SystemColors.ControlDarkDark;
            panelGrup.Location = new Point(541, 16);
            panelGrup.Margin = new Padding(5, 4, 5, 4);
            panelGrup.Name = "panelGrup";
            panelGrup.Size = new Size(162, 113);
            panelGrup.TabIndex = 14;
            // 
            // labelNumGrup
            // 
            labelNumGrup.AutoSize = true;
            labelNumGrup.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumGrup.ForeColor = SystemColors.ControlText;
            labelNumGrup.Location = new Point(66, 56);
            labelNumGrup.Margin = new Padding(5, 0, 5, 0);
            labelNumGrup.Name = "labelNumGrup";
            labelNumGrup.Size = new Size(27, 29);
            labelNumGrup.TabIndex = 2;
            labelNumGrup.Text = "3";
            // 
            // labelGrup
            // 
            labelGrup.AutoSize = true;
            labelGrup.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGrup.Location = new Point(18, 24);
            labelGrup.Margin = new Padding(5, 0, 5, 0);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(106, 20);
            labelGrup.TabIndex = 0;
            labelGrup.Text = "Total Grupos";
            // 
            // pictureGrup
            // 
            pictureGrup.Image = (Image)resources.GetObject("pictureGrup.Image");
            pictureGrup.Location = new Point(23, 44);
            pictureGrup.Margin = new Padding(5, 4, 5, 4);
            pictureGrup.Name = "pictureGrup";
            pictureGrup.Size = new Size(43, 51);
            pictureGrup.SizeMode = PictureBoxSizeMode.Zoom;
            pictureGrup.TabIndex = 1;
            pictureGrup.TabStop = false;
            // 
            // panelAdm
            // 
            panelAdm.BackColor = SystemColors.Control;
            panelAdm.BorderStyle = BorderStyle.FixedSingle;
            panelAdm.Controls.Add(labelNumAdm);
            panelAdm.Controls.Add(labelAdm);
            panelAdm.Controls.Add(pictureAdm);
            panelAdm.ForeColor = SystemColors.ControlDarkDark;
            panelAdm.Location = new Point(369, 16);
            panelAdm.Margin = new Padding(5, 4, 5, 4);
            panelAdm.Name = "panelAdm";
            panelAdm.Size = new Size(162, 113);
            panelAdm.TabIndex = 13;
            // 
            // labelNumAdm
            // 
            labelNumAdm.AutoSize = true;
            labelNumAdm.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAdm.ForeColor = SystemColors.ControlText;
            labelNumAdm.Location = new Point(66, 56);
            labelNumAdm.Margin = new Padding(5, 0, 5, 0);
            labelNumAdm.Name = "labelNumAdm";
            labelNumAdm.Size = new Size(27, 29);
            labelNumAdm.TabIndex = 2;
            labelNumAdm.Text = "3";
            // 
            // labelAdm
            // 
            labelAdm.AutoSize = true;
            labelAdm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdm.Location = new Point(18, 24);
            labelAdm.Margin = new Padding(5, 0, 5, 0);
            labelAdm.Name = "labelAdm";
            labelAdm.Size = new Size(107, 20);
            labelAdm.TabIndex = 0;
            labelAdm.Text = "Total Admins";
            // 
            // pictureAdm
            // 
            pictureAdm.Image = (Image)resources.GetObject("pictureAdm.Image");
            pictureAdm.Location = new Point(23, 44);
            pictureAdm.Margin = new Padding(5, 4, 5, 4);
            pictureAdm.Name = "pictureAdm";
            pictureAdm.Size = new Size(43, 51);
            pictureAdm.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAdm.TabIndex = 1;
            pictureAdm.TabStop = false;
            // 
            // panelCli
            // 
            panelCli.BackColor = SystemColors.Control;
            panelCli.BorderStyle = BorderStyle.FixedSingle;
            panelCli.Controls.Add(labelNumCli);
            panelCli.Controls.Add(labelCli);
            panelCli.Controls.Add(pictureCli);
            panelCli.ForeColor = SystemColors.ControlDarkDark;
            panelCli.Location = new Point(198, 16);
            panelCli.Margin = new Padding(5, 4, 5, 4);
            panelCli.Name = "panelCli";
            panelCli.Size = new Size(162, 113);
            panelCli.TabIndex = 12;
            // 
            // labelNumCli
            // 
            labelNumCli.AutoSize = true;
            labelNumCli.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCli.ForeColor = SystemColors.ControlText;
            labelNumCli.Location = new Point(66, 56);
            labelNumCli.Margin = new Padding(5, 0, 5, 0);
            labelNumCli.Name = "labelNumCli";
            labelNumCli.Size = new Size(27, 29);
            labelNumCli.TabIndex = 2;
            labelNumCli.Text = "3";
            // 
            // labelCli
            // 
            labelCli.AutoSize = true;
            labelCli.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCli.Location = new Point(18, 24);
            labelCli.Margin = new Padding(5, 0, 5, 0);
            labelCli.Name = "labelCli";
            labelCli.Size = new Size(112, 20);
            labelCli.TabIndex = 0;
            labelCli.Text = "Total Clientes";
            // 
            // pictureCli
            // 
            pictureCli.Image = (Image)resources.GetObject("pictureCli.Image");
            pictureCli.Location = new Point(23, 44);
            pictureCli.Margin = new Padding(5, 4, 5, 4);
            pictureCli.Name = "pictureCli";
            pictureCli.Size = new Size(43, 51);
            pictureCli.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCli.TabIndex = 1;
            pictureCli.TabStop = false;
            // 
            // panelSer
            // 
            panelSer.BackColor = SystemColors.Control;
            panelSer.BorderStyle = BorderStyle.FixedSingle;
            panelSer.Controls.Add(labelNumSer);
            panelSer.Controls.Add(labelSer);
            panelSer.Controls.Add(pictureSer);
            panelSer.ForeColor = SystemColors.ControlDarkDark;
            panelSer.Location = new Point(26, 16);
            panelSer.Margin = new Padding(5, 4, 5, 4);
            panelSer.Name = "panelSer";
            panelSer.Size = new Size(162, 113);
            panelSer.TabIndex = 11;
            // 
            // labelNumSer
            // 
            labelNumSer.AutoSize = true;
            labelNumSer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumSer.ForeColor = SystemColors.ControlText;
            labelNumSer.Location = new Point(66, 56);
            labelNumSer.Margin = new Padding(5, 0, 5, 0);
            labelNumSer.Name = "labelNumSer";
            labelNumSer.Size = new Size(27, 29);
            labelNumSer.TabIndex = 2;
            labelNumSer.Text = "3";
            // 
            // labelSer
            // 
            labelSer.AutoSize = true;
            labelSer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSer.Location = new Point(18, 24);
            labelSer.Margin = new Padding(5, 0, 5, 0);
            labelSer.Name = "labelSer";
            labelSer.Size = new Size(120, 20);
            labelSer.TabIndex = 0;
            labelSer.Text = "Total Servicios";
            // 
            // pictureSer
            // 
            pictureSer.Image = Properties.Resources.servicio;
            pictureSer.InitialImage = Properties.Resources.servicio;
            pictureSer.Location = new Point(34, 53);
            pictureSer.Margin = new Padding(5, 4, 5, 4);
            pictureSer.Name = "pictureSer";
            pictureSer.Size = new Size(34, 40);
            pictureSer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSer.TabIndex = 1;
            pictureSer.TabStop = false;
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenido.Location = new Point(627, 495);
            labelBienvenido.Margin = new Padding(5, 0, 5, 0);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(666, 48);
            labelBienvenido.TabIndex = 17;
            labelBienvenido.Text = "Bienvenido a la gestión de datos!";
            labelBienvenido.TextAlign = ContentAlignment.BottomCenter;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 14F);
            monthCalendarFiltrar.Location = new Point(1171, 18);
            monthCalendarFiltrar.MaxSelectionCount = 31;
            monthCalendarFiltrar.Name = "monthCalendarFiltrar";
            monthCalendarFiltrar.ShowToday = false;
            monthCalendarFiltrar.TabIndex = 0;
            monthCalendarFiltrar.TitleBackColor = Color.DarkOrange;
            monthCalendarFiltrar.TrailingForeColor = SystemColors.ButtonShadow;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(45, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 603);
            panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(494, 603);
            dataGridView1.TabIndex = 0;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 873);
            Controls.Add(panel1);
            Controls.Add(monthCalendarFiltrar);
            Controls.Add(labelBienvenido);
            Controls.Add(panelCitHoy);
            Controls.Add(panelCit);
            Controls.Add(panelGrup);
            Controls.Add(panelAdm);
            Controls.Add(panelCli);
            Controls.Add(panelSer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelPrincipal";
            Text = "PanelPrincipal";
            Load += PanelPrincipal_Load;
            panelCitHoy.ResumeLayout(false);
            panelCitHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitHoy).EndInit();
            panelCit.ResumeLayout(false);
            panelCit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCit).EndInit();
            panelGrup.ResumeLayout(false);
            panelGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGrup).EndInit();
            panelAdm.ResumeLayout(false);
            panelAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdm).EndInit();
            panelCli.ResumeLayout(false);
            panelCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCli).EndInit();
            panelSer.ResumeLayout(false);
            panelSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSer).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCitHoy;
        private Label labelNumCitHoy;
        private Label labelCitHoy;
        private PictureBox pictureCitHoy;
        private Panel panelCit;
        private Label labelNumCit;
        private Label labelCit;
        private PictureBox pictureCit;
        private Panel panelGrup;
        private Label labelNumGrup;
        private Label labelGrup;
        private PictureBox pictureGrup;
        private Panel panelAdm;
        private Label labelNumAdm;
        private Label labelAdm;
        private PictureBox pictureAdm;
        private Panel panelCli;
        private Label labelNumCli;
        private Label labelCli;
        private PictureBox pictureCli;
        private Panel panelSer;
        private Label labelNumSer;
        private Label labelSer;
        private PictureBox pictureSer;
        private Label labelBienvenido;
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
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}