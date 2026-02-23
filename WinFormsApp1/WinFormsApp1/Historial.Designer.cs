using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Historial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            panelTodo = new Panel();
            panelHistorial = new Panel();
            panelCitas = new Panel();
            panelTituloCitas = new Panel();
            labelTituloCitas = new Label();
            panelDiagnostico = new Panel();
            panelTituloDiagnostico = new Panel();
            labelTituloDiagnostico = new Label();
            panelDatos = new Panel();
            panelTodo.SuspendLayout();
            panelHistorial.SuspendLayout();
            panelTituloCitas.SuspendLayout();
            panelDiagnostico.SuspendLayout();
            panelTituloDiagnostico.SuspendLayout();
            SuspendLayout();
            // 
            // panelTodo
            // 
            panelTodo.Controls.Add(panelDiagnostico);
            panelTodo.Controls.Add(panelHistorial);
            panelTodo.Dock = DockStyle.Fill;
            panelTodo.Location = new Point(0, 0);
            panelTodo.Name = "panelTodo";
            panelTodo.Size = new Size(409, 677);
            panelTodo.TabIndex = 0;
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(panelCitas);
            panelHistorial.Controls.Add(panelTituloCitas);
            panelHistorial.Dock = DockStyle.Bottom;
            panelHistorial.Location = new Point(0, 227);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(25);
            panelHistorial.Size = new Size(409, 450);
            panelHistorial.TabIndex = 0;
            // 
            // panelCitas
            // 
            panelCitas.BackColor = SystemColors.ControlLightLight;
            panelCitas.Dock = DockStyle.Fill;
            panelCitas.Location = new Point(25, 55);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(359, 370);
            panelCitas.TabIndex = 0;
            // 
            // panelTituloCitas
            // 
            panelTituloCitas.Controls.Add(labelTituloCitas);
            panelTituloCitas.Dock = DockStyle.Top;
            panelTituloCitas.Location = new Point(25, 25);
            panelTituloCitas.Name = "panelTituloCitas";
            panelTituloCitas.Size = new Size(359, 30);
            panelTituloCitas.TabIndex = 1;
            // 
            // labelTituloCitas
            // 
            labelTituloCitas.AutoSize = true;
            labelTituloCitas.Dock = DockStyle.Left;
            labelTituloCitas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloCitas.Location = new Point(0, 0);
            labelTituloCitas.Name = "labelTituloCitas";
            labelTituloCitas.Size = new Size(61, 30);
            labelTituloCitas.TabIndex = 0;
            labelTituloCitas.Text = "Citas";
            // 
            // panelDiagnostico
            // 
            panelDiagnostico.Controls.Add(panelDatos);
            panelDiagnostico.Controls.Add(panelTituloDiagnostico);
            panelDiagnostico.Dock = DockStyle.Fill;
            panelDiagnostico.Location = new Point(0, 0);
            panelDiagnostico.Name = "panelDiagnostico";
            panelDiagnostico.Padding = new Padding(30, 30, 30, 0);
            panelDiagnostico.Size = new Size(409, 227);
            panelDiagnostico.TabIndex = 1;
            // 
            // panelTituloDiagnostico
            // 
            panelTituloDiagnostico.Controls.Add(labelTituloDiagnostico);
            panelTituloDiagnostico.Dock = DockStyle.Top;
            panelTituloDiagnostico.Location = new Point(30, 30);
            panelTituloDiagnostico.Name = "panelTituloDiagnostico";
            panelTituloDiagnostico.Size = new Size(349, 30);
            panelTituloDiagnostico.TabIndex = 2;
            // 
            // labelTituloDiagnostico
            // 
            labelTituloDiagnostico.AutoSize = true;
            labelTituloDiagnostico.Dock = DockStyle.Left;
            labelTituloDiagnostico.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloDiagnostico.Location = new Point(0, 0);
            labelTituloDiagnostico.Name = "labelTituloDiagnostico";
            labelTituloDiagnostico.Size = new Size(131, 30);
            labelTituloDiagnostico.TabIndex = 0;
            labelTituloDiagnostico.Text = "Diagnostico";
            // 
            // panelDatos
            // 
            panelDatos.BackColor = SystemColors.ControlLightLight;
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(30, 60);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(349, 167);
            panelDatos.TabIndex = 3;
            // 
            // Historial
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(409, 677);
            Controls.Add(panelTodo);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            panelTodo.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            panelTituloCitas.ResumeLayout(false);
            panelTituloCitas.PerformLayout();
            panelDiagnostico.ResumeLayout(false);
            panelTituloDiagnostico.ResumeLayout(false);
            panelTituloDiagnostico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labNombreUsuario;
        private Label labUsApellido;
        private Label labelUsNombre;
        private Label labUserObserv;
        private Label labUserAlerg;
        private Label labUsTel;
        public TextBox textUserObserv;
        public TextBox tboxNombreUsuario;
        public TextBox textBoxUsApellidos;
        public TextBox txtBoxUsNombre;
        public TextBox tboxUserAlerg;
        public TextBox textBoxUsTel;
        private Panel panelTodo;
        private Panel panelHistorial;
        private Panel panelCitas;
        private Panel panelTituloCitas;
        private Label labelTituloCitas;
        private Panel panelDiagnostico;
        private Panel panelDatos;
        private Panel panelTituloDiagnostico;
        private Label labelTituloDiagnostico;
    }

}
