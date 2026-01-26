namespace WinFormsApp1
{
    partial class FichaCita
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
            panel1 = new Panel();
            buttonCompletar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCompletar);
            panel1.Location = new Point(189, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 157);
            panel1.TabIndex = 0;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(147, 49);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(94, 29);
            buttonCompletar.TabIndex = 0;
            buttonCompletar.Text = "Completar";
            buttonCompletar.UseVisualStyleBackColor = true;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // FichaCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FichaCita";
            Text = "FichaCita";
            Load += FichaCita_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCompletar;
    }
}