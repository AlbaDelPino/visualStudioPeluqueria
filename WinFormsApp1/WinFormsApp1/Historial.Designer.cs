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
            richTextBoxObservaciones = new RichTextBox();
            labelObservaciones = new Label();
            labelTratamientos = new Label();
            richTextBoxProductos = new RichTextBox();
            labelProductos = new Label();
            richTextBoxTratamientos = new RichTextBox();
            buttonCompletar = new Button();
            SuspendLayout();
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(30, 254);
            richTextBoxObservaciones.Margin = new Padding(3, 2, 3, 2);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.Size = new Size(280, 103);
            richTextBoxObservaciones.TabIndex = 62;
            richTextBoxObservaciones.Text = "";
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObservaciones.ForeColor = SystemColors.ControlDarkDark;
            labelObservaciones.Location = new Point(42, 230);
            labelObservaciones.Margin = new Padding(4, 0, 4, 0);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(130, 22);
            labelObservaciones.TabIndex = 61;
            labelObservaciones.Text = "Observaciones";
            // 
            // labelTratamientos
            // 
            labelTratamientos.AutoSize = true;
            labelTratamientos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTratamientos.ForeColor = SystemColors.ControlDarkDark;
            labelTratamientos.Location = new Point(30, 40);
            labelTratamientos.Margin = new Padding(4, 0, 4, 0);
            labelTratamientos.Name = "labelTratamientos";
            labelTratamientos.Size = new Size(115, 22);
            labelTratamientos.TabIndex = 57;
            labelTratamientos.Text = "Tratamientos";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.Location = new Point(30, 150);
            richTextBoxProductos.Margin = new Padding(3, 2, 3, 2);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(280, 66);
            richTextBoxProductos.TabIndex = 60;
            richTextBoxProductos.Text = "";
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductos.ForeColor = SystemColors.ControlDarkDark;
            labelProductos.Location = new Point(42, 126);
            labelProductos.Margin = new Padding(4, 0, 4, 0);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(91, 22);
            labelProductos.TabIndex = 59;
            labelProductos.Text = "Productos";
            // 
            // richTextBoxTratamientos
            // 
            richTextBoxTratamientos.Location = new Point(30, 64);
            richTextBoxTratamientos.Margin = new Padding(3, 2, 3, 2);
            richTextBoxTratamientos.Name = "richTextBoxTratamientos";
            richTextBoxTratamientos.Size = new Size(280, 48);
            richTextBoxTratamientos.TabIndex = 58;
            richTextBoxTratamientos.Text = "";
            // 
            // buttonCompletar
            // 
            buttonCompletar.BackColor = Color.DarkOrange;
            buttonCompletar.ForeColor = SystemColors.ControlLightLight;
            buttonCompletar.Location = new Point(112, 391);
            buttonCompletar.Margin = new Padding(3, 2, 3, 2);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(154, 52);
            buttonCompletar.TabIndex = 63;
            buttonCompletar.Text = "Completar";
            buttonCompletar.UseVisualStyleBackColor = false;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // Historial
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(409, 794);
            Controls.Add(buttonCompletar);
            Controls.Add(richTextBoxObservaciones);
            Controls.Add(labelObservaciones);
            Controls.Add(richTextBoxProductos);
            Controls.Add(labelProductos);
            Controls.Add(richTextBoxTratamientos);
            Controls.Add(labelTratamientos);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labNombreUsuario;
        private Label labUsApellido;
        private Label labelUsNombre;
        private Label labUserObserv;
        private Label labUserAlerg;
        private Label labUsTel;
        private Label labelObservaciones;
        private Label labelProductos;
        private Label labelTratamientos;
        public TextBox textUserObserv;
        public TextBox tboxNombreUsuario;
        public TextBox textBoxUsApellidos;
        public TextBox txtBoxUsNombre;
        public TextBox tboxUserAlerg;
        public TextBox textBoxUsTel;
        public RichTextBox richTextBoxObservaciones;
        public RichTextBox richTextBoxProductos;
        public RichTextBox richTextBoxTratamientos;
        private Button buttonCompletar;
    }

}
