using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Bloqueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloqueo));
            pictureBoxICon = new PictureBox();
            textBoxCitFecha = new TextBox();
            buttonHorarios = new Button();
            textBoxHorarios = new TextBox();
            ButtonAnyadir = new Button();
            labelHorarios = new Label();
            CalendarCitas = new WinFormsApp1.Cita.MyMonthCalendar();
            labelTituo = new Label();
            labelCitFecha = new Label();
            radioButtonAnual = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 403);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 1;
            pictureBoxICon.TabStop = false;
            // 
            // textBoxCitFecha
            // 
            textBoxCitFecha.Location = new Point(616, 109);
            textBoxCitFecha.Name = "textBoxCitFecha";
            textBoxCitFecha.ReadOnly = true;
            textBoxCitFecha.Size = new Size(145, 27);
            textBoxCitFecha.TabIndex = 106;
            // 
            // buttonHorarios
            // 
            buttonHorarios.Location = new Point(616, 165);
            buttonHorarios.Margin = new Padding(3, 4, 3, 4);
            buttonHorarios.Name = "buttonHorarios";
            buttonHorarios.Size = new Size(50, 30);
            buttonHorarios.TabIndex = 99;
            buttonHorarios.UseVisualStyleBackColor = true;
            buttonHorarios.Paint += buttonHorarios_Paint;
            // 
            // textBoxHorarios
            // 
            textBoxHorarios.Location = new Point(539, 203);
            textBoxHorarios.Margin = new Padding(3, 4, 3, 4);
            textBoxHorarios.Name = "textBoxHorarios";
            textBoxHorarios.ReadOnly = true;
            textBoxHorarios.Size = new Size(222, 27);
            textBoxHorarios.TabIndex = 98;
            // 
            // ButtonAnyadir
            // 
            ButtonAnyadir.BackColor = Color.DarkOrange;
            ButtonAnyadir.FlatStyle = FlatStyle.Flat;
            ButtonAnyadir.ForeColor = SystemColors.ControlLightLight;
            ButtonAnyadir.Location = new Point(666, 322);
            ButtonAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonAnyadir.Name = "ButtonAnyadir";
            ButtonAnyadir.Size = new Size(95, 37);
            ButtonAnyadir.TabIndex = 97;
            ButtonAnyadir.Text = "Añadir";
            ButtonAnyadir.UseVisualStyleBackColor = false;
            ButtonAnyadir.Click += ButtonAnyadir_Click;
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHorarios.Location = new Point(539, 170);
            labelHorarios.Margin = new Padding(5, 0, 5, 0);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(74, 20);
            labelHorarios.TabIndex = 96;
            labelHorarios.Text = "Horarios";
            // 
            // CalendarCitas
            // 
            CalendarCitas.FirstDayOfWeek = Day.Monday;
            CalendarCitas.Font = new Font("Segoe UI", 10F);
            CalendarCitas.Location = new Point(260, 109);
            CalendarCitas.MaxSelectionCount = 1;
            CalendarCitas.MinDate = new DateTime(2026, 2, 4, 0, 0, 0, 0);
            CalendarCitas.Name = "CalendarCitas";
            CalendarCitas.ShowToday = false;
            CalendarCitas.TabIndex = 95;
            CalendarCitas.TitleBackColor = Color.DarkOrange;
            CalendarCitas.TrailingForeColor = SystemColors.ButtonShadow;
            // 
            // labelTituo
            // 
            labelTituo.AutoSize = true;
            labelTituo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTituo.ForeColor = SystemColors.ControlDarkDark;
            labelTituo.Location = new Point(260, 29);
            labelTituo.Name = "labelTituo";
            labelTituo.Size = new Size(270, 50);
            labelTituo.TabIndex = 94;
            labelTituo.Text = "Crear bloqueo";
            // 
            // labelCitFecha
            // 
            labelCitFecha.AutoSize = true;
            labelCitFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitFecha.Location = new Point(539, 112);
            labelCitFecha.Margin = new Padding(5, 0, 5, 0);
            labelCitFecha.Name = "labelCitFecha";
            labelCitFecha.Size = new Size(55, 20);
            labelCitFecha.TabIndex = 93;
            labelCitFecha.Text = "Fecha";
            // 
            // radioButtonAnual
            // 
            radioButtonAnual.AutoSize = true;
            radioButtonAnual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAnual.Location = new Point(539, 291);
            radioButtonAnual.Name = "radioButtonAnual";
            radioButtonAnual.RightToLeft = RightToLeft.No;
            radioButtonAnual.Size = new Size(72, 24);
            radioButtonAnual.TabIndex = 109;
            radioButtonAnual.Text = "Anual";
            radioButtonAnual.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(539, 261);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.No;
            radioButton1.Size = new Size(86, 24);
            radioButton1.TabIndex = 110;
            radioButton1.TabStop = true;
            radioButton1.Text = "Puntual";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Bloqueo
            // 
            ClientSize = new Size(818, 403);
            Controls.Add(radioButton1);
            Controls.Add(radioButtonAnual);
            Controls.Add(textBoxCitFecha);
            Controls.Add(buttonHorarios);
            Controls.Add(textBoxHorarios);
            Controls.Add(ButtonAnyadir);
            Controls.Add(labelHorarios);
            Controls.Add(CalendarCitas);
            Controls.Add(labelTituo);
            Controls.Add(labelCitFecha);
            Controls.Add(pictureBoxICon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bloqueo";
            Text = "Bloqueo Horario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxICon;
        private TextBox textBoxCitFecha;
        private Button buttonHorarios;
        private TextBox textBoxHorarios;
        private Button ButtonAnyadir;
        private Label labelHorarios;
        private Cita.MyMonthCalendar CalendarCitas;
        private Label labelTituo;
        private Label labelCitFecha;
        private RadioButton radioButtonAnual;
        private RadioButton radioButton1;
    }
}
