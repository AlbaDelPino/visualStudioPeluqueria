using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Cita
    {
        //// <summary>
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
        public Label LabelTituoModificarCita
        {
            get
            {
                return this.labelTituoModificarCita;
            }
            set
            {
                this.labelTituoModificarCita = value;
            }
        }

        public bool buttonCitModificar
        {
            get
            {
                // Si el botón es nulo, devolvemos false en lugar de dar error
                return this.ButtonCitModificar != null && this.ButtonCitModificar.Visible;
            }
            set
            {
                // Solo intentamos cambiar la visibilidad si el botón existe
                if (this.ButtonCitModificar != null)
                {
                    this.ButtonCitModificar.Visible = value;
                }
            }
        }

        // Haz lo mismo para el botón de Añadir por seguridad
        public bool buttonCitAnyadir
        {
            get { return this.ButtonCitAnyadir != null && this.ButtonCitAnyadir.Visible; }
            set { if (this.ButtonCitAnyadir != null) this.ButtonCitAnyadir.Visible = value; }
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
        public ComboBox ComboBoxServivioCita
        {
            get
            {
                return this.comboServivioCita;
            }
            set
            {
                this.comboServivioCita = value;
            }
        }
        public ComboBox ComboBoxHoraCita
        {
            get
            {
                return this.comboHoraCita;
            }
            set
            {
                this.comboHoraCita = value;
            }
        }
        public ComboBox ComboBoxGrupoCita
        {
            get
            {
                return this.comboGrupoCita;
            }
            set
            {
                this.comboGrupoCita = value;
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



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita));
            labelCitFecha = new Label();
            labelTituoCrearCita = new Label();
            panelCita = new Panel();
            comboServivioCita = new ComboBox();
            comboGrupoCita = new ComboBox();
            comboHoraCita = new ComboBox();
            labelTituoModificarCita = new Label();
            ButtonCitAnyadir = new Button();
            ButtonCitModificar = new Button();
            checkBoxEstado = new CheckBox();
            labelCitGrupo = new Label();
            labelCitHora = new Label();
            labelCitCliente = new Label();
            labelCitServicio = new Label();
            monthCalendar1 = new MonthCalendar();
            comboClienteCita = new ComboBox();
            panelCita.SuspendLayout();
            SuspendLayout();
            // 
            // labelCitFecha
            // 
            labelCitFecha.AutoSize = true;
            labelCitFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitFecha.Location = new Point(162, 92);
            labelCitFecha.Margin = new Padding(5, 0, 5, 0);
            labelCitFecha.Name = "labelCitFecha";
            labelCitFecha.Size = new Size(55, 20);
            labelCitFecha.TabIndex = 50;
            labelCitFecha.Text = "Fecha";
            // 
            // labelTituoCrearCita
            // 
            labelTituoCrearCita.AutoSize = true;
            labelTituoCrearCita.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoCrearCita.Location = new Point(118, 30);
            labelTituoCrearCita.Name = "labelTituoCrearCita";
            labelTituoCrearCita.Size = new Size(150, 32);
            labelTituoCrearCita.TabIndex = 53;
            labelTituoCrearCita.Text = "CREAR CITA";
            // 
            // panelCita
            // 
            panelCita.Controls.Add(comboClienteCita);
            panelCita.Controls.Add(comboServivioCita);
            panelCita.Controls.Add(comboGrupoCita);
            panelCita.Controls.Add(comboHoraCita);
            panelCita.Controls.Add(labelTituoModificarCita);
            panelCita.Controls.Add(ButtonCitAnyadir);
            panelCita.Controls.Add(ButtonCitModificar);
            panelCita.Controls.Add(checkBoxEstado);
            panelCita.Controls.Add(labelCitGrupo);
            panelCita.Controls.Add(labelCitHora);
            panelCita.Controls.Add(labelCitCliente);
            panelCita.Controls.Add(labelCitServicio);
            panelCita.Controls.Add(monthCalendar1);
            panelCita.Controls.Add(labelTituoCrearCita);
            panelCita.Controls.Add(labelCitFecha);
            panelCita.Dock = DockStyle.Fill;
            panelCita.Location = new Point(0, 0);
            panelCita.Name = "panelCita";
            panelCita.Size = new Size(377, 624);
            panelCita.TabIndex = 55;
            // 
            // comboServivioCita
            // 
            comboServivioCita.DisplayMember = "1";
            comboServivioCita.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServivioCita.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboServivioCita.Location = new Point(170, 348);
            comboServivioCita.Margin = new Padding(5, 4, 5, 4);
            comboServivioCita.MaxDropDownItems = 3;
            comboServivioCita.Name = "comboServivioCita";
            comboServivioCita.Size = new Size(159, 28);
            comboServivioCita.TabIndex = 73;
            comboServivioCita.UseWaitCursor = true;
            // 
            // comboGrupoCita
            // 
            comboGrupoCita.DisplayMember = "1";
            comboGrupoCita.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGrupoCita.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboGrupoCita.Location = new Point(170, 451);
            comboGrupoCita.Margin = new Padding(5, 4, 5, 4);
            comboGrupoCita.MaxDropDownItems = 3;
            comboGrupoCita.Name = "comboGrupoCita";
            comboGrupoCita.Size = new Size(159, 28);
            comboGrupoCita.TabIndex = 72;
            comboGrupoCita.UseWaitCursor = true;
            // 
            // comboHoraCita
            // 
            comboHoraCita.DisplayMember = "1";
            comboHoraCita.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHoraCita.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboHoraCita.Location = new Point(170, 391);
            comboHoraCita.Margin = new Padding(5, 4, 5, 4);
            comboHoraCita.MaxDropDownItems = 3;
            comboHoraCita.Name = "comboHoraCita";
            comboHoraCita.Size = new Size(159, 28);
            comboHoraCita.TabIndex = 71;
            comboHoraCita.UseWaitCursor = true;
            // 
            // labelTituoModificarCita
            // 
            labelTituoModificarCita.AutoSize = true;
            labelTituoModificarCita.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTituoModificarCita.Location = new Point(83, 30);
            labelTituoModificarCita.Name = "labelTituoModificarCita";
            labelTituoModificarCita.Size = new Size(208, 32);
            labelTituoModificarCita.TabIndex = 67;
            labelTituoModificarCita.Text = "MODIFICAR CITA";
            // 
            // ButtonCitAnyadir
            // 
            ButtonCitAnyadir.Location = new Point(262, 573);
            ButtonCitAnyadir.Margin = new Padding(3, 4, 3, 4);
            ButtonCitAnyadir.Name = "ButtonCitAnyadir";
            ButtonCitAnyadir.Size = new Size(86, 31);
            ButtonCitAnyadir.TabIndex = 66;
            ButtonCitAnyadir.Text = "Añadir";
            ButtonCitAnyadir.UseVisualStyleBackColor = true;
            // 
            // ButtonCitModificar
            // 
            ButtonCitModificar.Location = new Point(202, 573);
            ButtonCitModificar.Margin = new Padding(3, 4, 3, 4);
            ButtonCitModificar.Name = "ButtonCitModificar";
            ButtonCitModificar.Size = new Size(146, 31);
            ButtonCitModificar.TabIndex = 65;
            ButtonCitModificar.Text = "Guardar cambios";
            ButtonCitModificar.UseVisualStyleBackColor = true;
            ButtonCitModificar.Visible = false;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Checked = true;
            checkBoxEstado.CheckState = CheckState.Checked;
            checkBoxEstado.Font = new Font("Segoe UI", 10F);
            checkBoxEstado.Location = new Point(47, 573);
            checkBoxEstado.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(121, 27);
            checkBoxEstado.TabIndex = 64;
            checkBoxEstado.Text = "Confirmada";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // labelCitGrupo
            // 
            labelCitGrupo.AutoSize = true;
            labelCitGrupo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitGrupo.Location = new Point(47, 454);
            labelCitGrupo.Margin = new Padding(5, 0, 5, 0);
            labelCitGrupo.Name = "labelCitGrupo";
            labelCitGrupo.Size = new Size(55, 20);
            labelCitGrupo.TabIndex = 63;
            labelCitGrupo.Text = "Grupo";
            // 
            // labelCitHora
            // 
            labelCitHora.AutoSize = true;
            labelCitHora.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitHora.Location = new Point(47, 391);
            labelCitHora.Margin = new Padding(5, 0, 5, 0);
            labelCitHora.Name = "labelCitHora";
            labelCitHora.Size = new Size(46, 20);
            labelCitHora.TabIndex = 61;
            labelCitHora.Text = "Hora";
            // 
            // labelCitCliente
            // 
            labelCitCliente.AutoSize = true;
            labelCitCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitCliente.Location = new Point(47, 517);
            labelCitCliente.Margin = new Padding(5, 0, 5, 0);
            labelCitCliente.Name = "labelCitCliente";
            labelCitCliente.Size = new Size(61, 20);
            labelCitCliente.TabIndex = 57;
            labelCitCliente.Text = "Cliente";
            // 
            // labelCitServicio
            // 
            labelCitServicio.AutoSize = true;
            labelCitServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitServicio.Location = new Point(47, 356);
            labelCitServicio.Margin = new Padding(5, 0, 5, 0);
            labelCitServicio.Name = "labelCitServicio";
            labelCitServicio.Size = new Size(69, 20);
            labelCitServicio.TabIndex = 59;
            labelCitServicio.Text = "Servicio";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FromArgb(255, 128, 0);
            monthCalendar1.Location = new Point(83, 121);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 55;
            // 
            // comboClienteCita
            // 
            comboClienteCita.DisplayMember = "1";
            comboClienteCita.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClienteCita.Items.AddRange(new object[] { "Peluquería", "Manicura y Pedicura", "Depilación", "Pestañas y Cejas", "Tratamientos Faciales", "Tratamientos Corporales", "Masajes", "Maquillaje", "Micropigmentación" });
            comboClienteCita.Location = new Point(170, 514);
            comboClienteCita.Margin = new Padding(5, 4, 5, 4);
            comboClienteCita.MaxDropDownItems = 3;
            comboClienteCita.Name = "comboClienteCita";
            comboClienteCita.Size = new Size(159, 28);
            comboClienteCita.TabIndex = 74;
            comboClienteCita.UseWaitCursor = true;
            // 
            // Cita
            // 
            ClientSize = new Size(377, 624);
            Controls.Add(panelCita);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cita";
            Text = "Añadir Cita";
            Load += Cita_Load_1;
            panelCita.ResumeLayout(false);
            panelCita.PerformLayout();
            ResumeLayout(false);

        }
        private ComboBox comboServivioCita;
        private ComboBox comboClienteCita;
    }
}