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
            panelDiagnostico = new Panel();
            panelHistorial = new Panel();
            panelCitas = new Panel();
            panelTituloCitas = new Panel();
            labelTituloCitas = new Label();
            panelTodo.SuspendLayout();
            panelHistorial.SuspendLayout();
            panelTituloCitas.SuspendLayout();
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
            // panelDiagnostico
            // 
            panelDiagnostico.Dock = DockStyle.Fill;
            panelDiagnostico.Location = new Point(0, 0);
            panelDiagnostico.Name = "panelDiagnostico";
            panelDiagnostico.Size = new Size(409, 252);
            panelDiagnostico.TabIndex = 1;
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(panelCitas);
            panelHistorial.Controls.Add(panelTituloCitas);
            panelHistorial.Dock = DockStyle.Bottom;
            panelHistorial.Location = new Point(0, 252);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(25, 0, 25, 25);
            panelHistorial.Size = new Size(409, 425);
            panelHistorial.TabIndex = 0;
            // 
            // panelCitas
            // 
            panelCitas.BackColor = SystemColors.ControlLightLight;
            panelCitas.Dock = DockStyle.Fill;
            panelCitas.Location = new Point(25, 30);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(359, 370);
            panelCitas.TabIndex = 0;
            // 
            // panelTituloCitas
            // 
            panelTituloCitas.Controls.Add(labelTituloCitas);
            panelTituloCitas.Dock = DockStyle.Top;
            panelTituloCitas.Location = new Point(25, 0);
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
            // Historial
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(409, 677);
            Controls.Add(panelTodo);
            Name = "Historial";
            Text = "Historial";
            Resize += Historial_Resize;
            panelTodo.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            panelTituloCitas.ResumeLayout(false);
            panelTituloCitas.PerformLayout();
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
    }

}
