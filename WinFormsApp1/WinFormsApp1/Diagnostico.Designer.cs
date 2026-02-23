using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Diagnostico
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
            panelDiagnostico = new Panel();
            panelDatos = new Panel();
            richTextBoxAlergenos = new RichTextBox();
            labelAlergenos = new Label();
            label = new Label();
            comboBoxTexturaPelo = new ComboBox();
            labelTipoPiel = new Label();
            labelTipoPelo = new Label();
            comboBoxTipoPiel = new ComboBox();
            comboBoxTipoPelo = new ComboBox();
            panelTituloDiagnostico = new Panel();
            labelTituloDiagnostico = new Label();
            panelDiagnostico.SuspendLayout();
            panelDatos.SuspendLayout();
            panelTituloDiagnostico.SuspendLayout();
            SuspendLayout();
            // 
            // panelDiagnostico
            // 
            panelDiagnostico.Controls.Add(panelDatos);
            panelDiagnostico.Controls.Add(panelTituloDiagnostico);
            panelDiagnostico.Dock = DockStyle.Fill;
            panelDiagnostico.Location = new Point(0, 0);
            panelDiagnostico.Name = "panelDiagnostico";
            panelDiagnostico.Padding = new Padding(25);
            panelDiagnostico.Size = new Size(744, 677);
            panelDiagnostico.TabIndex = 2;
            // 
            // panelDatos
            // 
            panelDatos.AutoScroll = true;
            panelDatos.BackColor = SystemColors.ControlLightLight;
            panelDatos.Controls.Add(richTextBoxAlergenos);
            panelDatos.Controls.Add(labelAlergenos);
            panelDatos.Controls.Add(label);
            panelDatos.Controls.Add(comboBoxTexturaPelo);
            panelDatos.Controls.Add(labelTipoPiel);
            panelDatos.Controls.Add(labelTipoPelo);
            panelDatos.Controls.Add(comboBoxTipoPiel);
            panelDatos.Controls.Add(comboBoxTipoPelo);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(25, 55);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(694, 597);
            panelDatos.TabIndex = 3;
            // 
            // richTextBoxAlergenos
            // 
            richTextBoxAlergenos.Location = new Point(173, 31);
            richTextBoxAlergenos.Name = "richTextBoxAlergenos";
            richTextBoxAlergenos.Size = new Size(151, 63);
            richTextBoxAlergenos.TabIndex = 65;
            richTextBoxAlergenos.Text = "Acaros";
            // 
            // labelAlergenos
            // 
            labelAlergenos.AutoSize = true;
            labelAlergenos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlergenos.ForeColor = SystemColors.ControlText;
            labelAlergenos.Location = new Point(76, 31);
            labelAlergenos.Margin = new Padding(5, 0, 5, 0);
            labelAlergenos.Name = "labelAlergenos";
            labelAlergenos.Size = new Size(84, 20);
            labelAlergenos.TabIndex = 64;
            labelAlergenos.Text = "Alergenos";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(41, 113);
            label.Margin = new Padding(5, 0, 5, 0);
            label.Name = "label";
            label.Size = new Size(124, 20);
            label.TabIndex = 63;
            label.Text = "Textura de pelo";
            // 
            // comboBoxTexturaPelo
            // 
            comboBoxTexturaPelo.Enabled = false;
            comboBoxTexturaPelo.FormattingEnabled = true;
            comboBoxTexturaPelo.Items.AddRange(new object[] { "", "Rizado", "Ondulado", "Liso" });
            comboBoxTexturaPelo.Location = new Point(173, 110);
            comboBoxTexturaPelo.Name = "comboBoxTexturaPelo";
            comboBoxTexturaPelo.Size = new Size(151, 28);
            comboBoxTexturaPelo.TabIndex = 62;
            // 
            // labelTipoPiel
            // 
            labelTipoPiel.AutoSize = true;
            labelTipoPiel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipoPiel.ForeColor = SystemColors.ControlText;
            labelTipoPiel.Location = new Point(65, 210);
            labelTipoPiel.Margin = new Padding(5, 0, 5, 0);
            labelTipoPiel.Name = "labelTipoPiel";
            labelTipoPiel.Size = new Size(95, 20);
            labelTipoPiel.TabIndex = 61;
            labelTipoPiel.Text = "Tipo de piel";
            // 
            // labelTipoPelo
            // 
            labelTipoPelo.AutoSize = true;
            labelTipoPelo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipoPelo.ForeColor = SystemColors.ControlText;
            labelTipoPelo.Location = new Point(65, 160);
            labelTipoPelo.Margin = new Padding(5, 0, 5, 0);
            labelTipoPelo.Name = "labelTipoPelo";
            labelTipoPelo.Size = new Size(100, 20);
            labelTipoPelo.TabIndex = 60;
            labelTipoPelo.Text = "Tipo de pelo";
            // 
            // comboBoxTipoPiel
            // 
            comboBoxTipoPiel.Enabled = false;
            comboBoxTipoPiel.FormattingEnabled = true;
            comboBoxTipoPiel.Items.AddRange(new object[] { "", "Seca", "Grasa" });
            comboBoxTipoPiel.Location = new Point(173, 202);
            comboBoxTipoPiel.Name = "comboBoxTipoPiel";
            comboBoxTipoPiel.Size = new Size(151, 28);
            comboBoxTipoPiel.TabIndex = 1;
            // 
            // comboBoxTipoPelo
            // 
            comboBoxTipoPelo.Enabled = false;
            comboBoxTipoPelo.FormattingEnabled = true;
            comboBoxTipoPelo.Items.AddRange(new object[] { "", "Seco", "Graso" });
            comboBoxTipoPelo.Location = new Point(173, 157);
            comboBoxTipoPelo.Name = "comboBoxTipoPelo";
            comboBoxTipoPelo.Size = new Size(151, 28);
            comboBoxTipoPelo.TabIndex = 0;
            // 
            // panelTituloDiagnostico
            // 
            panelTituloDiagnostico.Controls.Add(labelTituloDiagnostico);
            panelTituloDiagnostico.Dock = DockStyle.Top;
            panelTituloDiagnostico.Location = new Point(25, 25);
            panelTituloDiagnostico.Name = "panelTituloDiagnostico";
            panelTituloDiagnostico.Size = new Size(694, 30);
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
            // Diagnostico
            // 
            ClientSize = new Size(744, 677);
            Controls.Add(panelDiagnostico);
            Name = "Diagnostico";
            Load += Diagnostico_Load;
            panelDiagnostico.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panelTituloDiagnostico.ResumeLayout(false);
            panelTituloDiagnostico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDiagnostico;
        private Panel panelDatos;
        private ComboBox comboBoxTipoPiel;
        private ComboBox comboBoxTipoPelo;
        private Panel panelTituloDiagnostico;
        private Label labelTituloDiagnostico;
        private Label labelTipoPiel;
        private Label labelTipoPelo;
        private Label label;
        private ComboBox comboBoxTexturaPelo;
        private RichTextBox richTextBoxAlergenos;
        private Label labelAlergenos;
    }
}
