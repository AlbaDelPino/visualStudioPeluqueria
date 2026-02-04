namespace WinFormsApp1
{
    partial class PanelGaleria
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
            panelVisualGaleria = new Panel();
            comboBoxSerFiltrar = new ComboBox();
            textBoxSerBuscar = new TextBox();
            anyadirGaleria = new Button();
            panelMargenes = new Panel();
            flowLayoutPanelGaleria = new FlowLayoutPanel();
            panelPaginacion = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelEspaciado = new Panel();
            panelVisualGaleria.SuspendLayout();
            panelMargenes.SuspendLayout();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualGaleria
            // 
            panelVisualGaleria.Controls.Add(comboBoxSerFiltrar);
            panelVisualGaleria.Controls.Add(textBoxSerBuscar);
            panelVisualGaleria.Controls.Add(anyadirGaleria);
            panelVisualGaleria.Dock = DockStyle.Top;
            panelVisualGaleria.Location = new Point(0, 0);
            panelVisualGaleria.Margin = new Padding(3, 2, 3, 2);
            panelVisualGaleria.Name = "panelVisualGaleria";
            panelVisualGaleria.Size = new Size(1375, 164);
            panelVisualGaleria.TabIndex = 0;
            panelVisualGaleria.Paint += panelVisualGaleria_Paint;
            // 
            // comboBoxSerFiltrar
            // 
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSerFiltrar.DisplayMember = "1";
            comboBoxSerFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSerFiltrar.FlatStyle = FlatStyle.Flat;
            comboBoxSerFiltrar.Items.AddRange(new object[] { "", "Depilación", "Manicura y Pedicura", "Maquillaje", "Masajes", "Micropigmentación", "Peluquería", "Pestañas y Cejas", "Tratamientos Corporales", "Tratamientos Faciales" });
            comboBoxSerFiltrar.Location = new Point(930, 116);
            comboBoxSerFiltrar.Margin = new Padding(4, 3, 4, 3);
            comboBoxSerFiltrar.Name = "comboBoxSerFiltrar";
            comboBoxSerFiltrar.Size = new Size(134, 23);
            comboBoxSerFiltrar.TabIndex = 12;
            comboBoxSerFiltrar.SelectedIndexChanged += comboBoxSerFiltrar_SelectedIndexChanged;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.BorderStyle = BorderStyle.None;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(36, 122);
            textBoxSerBuscar.Margin = new Padding(4, 3, 4, 3);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(829, 16);
            textBoxSerBuscar.TabIndex = 11;
            textBoxSerBuscar.TextChanged += textBoxSerBuscar_TextChanged;
            // 
            // anyadirGaleria
            // 
            anyadirGaleria.BackColor = Color.FromArgb(255, 128, 0);
            anyadirGaleria.FlatStyle = FlatStyle.Flat;
            anyadirGaleria.Location = new Point(1271, 109);
            anyadirGaleria.Name = "anyadirGaleria";
            anyadirGaleria.Size = new Size(59, 23);
            anyadirGaleria.TabIndex = 13;
            anyadirGaleria.Text = ".";
            anyadirGaleria.UseVisualStyleBackColor = false;
            anyadirGaleria.Click += anyadirGaleria_Click;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(flowLayoutPanelGaleria);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 164);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1375, 523);
            panelMargenes.TabIndex = 17;
            // 
            // flowLayoutPanelGaleria
            // 
            flowLayoutPanelGaleria.Location = new Point(13, 5);
            flowLayoutPanelGaleria.Name = "flowLayoutPanelGaleria";
            flowLayoutPanelGaleria.Size = new Size(1363, 515);
            flowLayoutPanelGaleria.TabIndex = 0;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 687);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(30, 0, 0, 0);
            panelPaginacion.Size = new Size(1375, 30);
            panelPaginacion.TabIndex = 15;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(105, 0);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(75, 30);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(30, 0);
            buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            buttonPaginacionAtras.Size = new Size(75, 30);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            buttonPaginacionAtras.Click += buttonPaginacionAtras_Click;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 717);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1375, 51);
            panelEspaciado.TabIndex = 16;
            // 
            // PanelGaleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 768);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualGaleria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelGaleria";
            Text = "PanelGaleria";
            Load += PanelGaleria_Load;
            panelVisualGaleria.ResumeLayout(false);
            panelVisualGaleria.PerformLayout();
            panelMargenes.ResumeLayout(false);
            panelPaginacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualGaleria;
        private ComboBox comboBoxSerFiltrar;
        private TextBox textBoxSerBuscar;
        private Button anyadirGaleria;
        private Panel panelMargenes;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelEspaciado;
        private FlowLayoutPanel flowLayoutPanelGaleria;
    }
}