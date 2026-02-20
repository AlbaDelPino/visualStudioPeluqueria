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
            panelFotos = new Panel();
            labelNumFotos = new Label();
            labelFotos = new Label();
            pictureFotos = new PictureBox();
            comboBoxSerFiltrar = new ComboBox();
            textBoxSerBuscar = new TextBox();
            anyadirGaleria = new Button();
            panelMargenes = new Panel();
            flowLayoutPanelGaleria = new FlowLayoutPanel();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelEspaciado = new Panel();
            panelVisualGaleria.SuspendLayout();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFotos).BeginInit();
            panelMargenes.SuspendLayout();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualGaleria
            // 
            panelVisualGaleria.Controls.Add(panelFotos);
            panelVisualGaleria.Controls.Add(comboBoxSerFiltrar);
            panelVisualGaleria.Controls.Add(textBoxSerBuscar);
            panelVisualGaleria.Controls.Add(anyadirGaleria);
            panelVisualGaleria.Dock = DockStyle.Top;
            panelVisualGaleria.Location = new Point(0, 0);
            panelVisualGaleria.Name = "panelVisualGaleria";
            panelVisualGaleria.Size = new Size(1571, 256);
            panelVisualGaleria.TabIndex = 0;
            panelVisualGaleria.Paint += panelVisualGaleria_Paint;
            // 
            // panelFotos
            // 
            panelFotos.BackColor = SystemColors.Control;
            panelFotos.BorderStyle = BorderStyle.FixedSingle;
            panelFotos.Controls.Add(labelNumFotos);
            panelFotos.Controls.Add(labelFotos);
            panelFotos.Controls.Add(pictureFotos);
            panelFotos.ForeColor = SystemColors.ControlDarkDark;
            panelFotos.Location = new Point(80, 30);
            panelFotos.Margin = new Padding(5, 4, 5, 4);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(162, 113);
            panelFotos.TabIndex = 14;
            // 
            // labelNumFotos
            // 
            labelNumFotos.AutoSize = true;
            labelNumFotos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumFotos.ForeColor = SystemColors.ControlText;
            labelNumFotos.Location = new Point(66, 56);
            labelNumFotos.Margin = new Padding(5, 0, 5, 0);
            labelNumFotos.Name = "labelNumFotos";
            labelNumFotos.Size = new Size(27, 29);
            labelNumFotos.TabIndex = 2;
            labelNumFotos.Text = "2";
            // 
            // labelFotos
            // 
            labelFotos.AutoSize = true;
            labelFotos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFotos.Location = new Point(18, 24);
            labelFotos.Margin = new Padding(5, 0, 5, 0);
            labelFotos.Name = "labelFotos";
            labelFotos.Size = new Size(93, 20);
            labelFotos.TabIndex = 0;
            labelFotos.Text = "Total Fotos";
            // 
            // pictureFotos
            // 
            pictureFotos.Image = Properties.Resources.foto;
            pictureFotos.Location = new Point(23, 44);
            pictureFotos.Margin = new Padding(5, 4, 5, 4);
            pictureFotos.Name = "pictureFotos";
            pictureFotos.Size = new Size(43, 51);
            pictureFotos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFotos.TabIndex = 1;
            pictureFotos.TabStop = false;
            // 
            // comboBoxSerFiltrar
            // 
            comboBoxSerFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSerFiltrar.DisplayMember = "1";
            comboBoxSerFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSerFiltrar.FlatStyle = FlatStyle.Flat;
            comboBoxSerFiltrar.Items.AddRange(new object[] { "Todas las fotos", "Belleza de la Mirada", "Depilación", "Drenaje Linfático", "Estética de Manos y Pies", "Maquillaje", "Masajes", "Micropigmentación", "Tratamientos Corporales", "Tratamientos Faciales" });
            comboBoxSerFiltrar.Location = new Point(1234, 187);
            comboBoxSerFiltrar.Margin = new Padding(5, 4, 5, 4);
            comboBoxSerFiltrar.Name = "comboBoxSerFiltrar";
            comboBoxSerFiltrar.Size = new Size(153, 28);
            comboBoxSerFiltrar.TabIndex = 12;
            comboBoxSerFiltrar.SelectedIndexChanged += comboBoxSerFiltrar_SelectedIndexChanged;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.BorderStyle = BorderStyle.None;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(80, 192);
            textBoxSerBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(947, 20);
            textBoxSerBuscar.TabIndex = 11;
            textBoxSerBuscar.TextChanged += textBoxSerBuscar_TextChanged;
            // 
            // anyadirGaleria
            // 
            anyadirGaleria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirGaleria.BackColor = Color.FromArgb(255, 128, 0);
            anyadirGaleria.FlatAppearance.BorderSize = 0;
            anyadirGaleria.FlatStyle = FlatStyle.Flat;
            anyadirGaleria.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            anyadirGaleria.ForeColor = Color.White;
            anyadirGaleria.Location = new Point(1451, 175);
            anyadirGaleria.Margin = new Padding(3, 4, 3, 4);
            anyadirGaleria.Name = "anyadirGaleria";
            anyadirGaleria.Size = new Size(52, 55);
            anyadirGaleria.TabIndex = 13;
            anyadirGaleria.Text = "+";
            anyadirGaleria.UseVisualStyleBackColor = false;
            anyadirGaleria.Click += anyadirGaleria_Click;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(flowLayoutPanelGaleria);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 256);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(80, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 660);
            panelMargenes.TabIndex = 17;
            // 
            // flowLayoutPanelGaleria
            // 
            flowLayoutPanelGaleria.BackColor = SystemColors.Control;
            flowLayoutPanelGaleria.Dock = DockStyle.Fill;
            flowLayoutPanelGaleria.Location = new Point(80, 0);
            flowLayoutPanelGaleria.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelGaleria.Name = "flowLayoutPanelGaleria";
            flowLayoutPanelGaleria.Size = new Size(1457, 660);
            flowLayoutPanelGaleria.TabIndex = 0;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(labelPaginaActual);
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 916);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(80, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 40);
            panelPaginacion.TabIndex = 15;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(823, 10);
            labelPaginaActual.Name = "labelPaginaActual";
            labelPaginaActual.Size = new Size(17, 20);
            labelPaginaActual.TabIndex = 6;
            labelPaginaActual.Text = "1";
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(166, 0);
            buttonPaginacionDelante.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(86, 40);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            buttonPaginacionDelante.Click += buttonPaginacionDelante_Click;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(80, 0);
            buttonPaginacionAtras.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            buttonPaginacionAtras.Size = new Size(86, 40);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            buttonPaginacionAtras.Click += buttonPaginacionAtras_Click;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 956);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 68);
            panelEspaciado.TabIndex = 16;
            // 
            // PanelGaleria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualGaleria);
            Name = "PanelGaleria";
            Text = "PanelGaleria";
            Load += PanelGaleria_Load;
            panelVisualGaleria.ResumeLayout(false);
            panelVisualGaleria.PerformLayout();
            panelFotos.ResumeLayout(false);
            panelFotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFotos).EndInit();
            panelMargenes.ResumeLayout(false);
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
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
        private Label labelPaginaActual;
        private Panel panelFotos;
        private Label labelNumFotos;
        private Label labelFotos;
        private PictureBox pictureFotos;
    }
}