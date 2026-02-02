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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelGaleria));
            panelVisualGaleria = new Panel();
            comboBoxSerFiltrar = new ComboBox();
            textBoxSerBuscar = new TextBox();
            anyadirServicio = new Button();
            panelMargenes = new Panel();
            dataGridViewGaleria = new DataGridView();
            panelPaginacion = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelEspaciado = new Panel();
            dataGridViewTextBoxColumnSerNombre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnSerDescripcion = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnEliminar = new DataGridViewImageColumn();
            panelVisualGaleria.SuspendLayout();
            panelMargenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGaleria).BeginInit();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisualGaleria
            // 
            panelVisualGaleria.Controls.Add(comboBoxSerFiltrar);
            panelVisualGaleria.Controls.Add(textBoxSerBuscar);
            panelVisualGaleria.Controls.Add(anyadirServicio);
            panelVisualGaleria.Dock = DockStyle.Top;
            panelVisualGaleria.Location = new Point(0, 0);
            panelVisualGaleria.Name = "panelVisualGaleria";
            panelVisualGaleria.Size = new Size(1571, 219);
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
            comboBoxSerFiltrar.Location = new Point(1063, 155);
            comboBoxSerFiltrar.Margin = new Padding(5, 4, 5, 4);
            comboBoxSerFiltrar.Name = "comboBoxSerFiltrar";
            comboBoxSerFiltrar.Size = new Size(153, 28);
            comboBoxSerFiltrar.TabIndex = 12;
            // 
            // textBoxSerBuscar
            // 
            textBoxSerBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerBuscar.BorderStyle = BorderStyle.None;
            textBoxSerBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxSerBuscar.Location = new Point(41, 162);
            textBoxSerBuscar.Margin = new Padding(5, 4, 5, 4);
            textBoxSerBuscar.Name = "textBoxSerBuscar";
            textBoxSerBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxSerBuscar.Size = new Size(947, 20);
            textBoxSerBuscar.TabIndex = 11;
            // 
            // anyadirServicio
            // 
            anyadirServicio.BackColor = Color.FromArgb(255, 128, 0);
            anyadirServicio.FlatStyle = FlatStyle.Flat;
            anyadirServicio.Location = new Point(1453, 145);
            anyadirServicio.Margin = new Padding(3, 4, 3, 4);
            anyadirServicio.Name = "anyadirServicio";
            anyadirServicio.Size = new Size(67, 31);
            anyadirServicio.TabIndex = 13;
            anyadirServicio.Text = ".";
            anyadirServicio.UseVisualStyleBackColor = false;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewGaleria);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 219);
            panelMargenes.Margin = new Padding(3, 4, 3, 4);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(34, 0, 34, 0);
            panelMargenes.Size = new Size(1571, 697);
            panelMargenes.TabIndex = 17;
            // 
            // dataGridViewGaleria
            // 
            dataGridViewGaleria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGaleria.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewGaleria.BorderStyle = BorderStyle.None;
            dataGridViewGaleria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(7);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewGaleria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGaleria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGaleria.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnSerNombre, dataGridViewTextBoxColumnSerDescripcion, dataGridViewImageColumnModificar, dataGridViewImageColumnEliminar });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewGaleria.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGaleria.Dock = DockStyle.Fill;
            dataGridViewGaleria.EnableHeadersVisualStyles = false;
            dataGridViewGaleria.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewGaleria.Location = new Point(34, 0);
            dataGridViewGaleria.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGaleria.Name = "dataGridViewGaleria";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewGaleria.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewGaleria.RowHeadersVisible = false;
            dataGridViewGaleria.RowHeadersWidth = 51;
            dataGridViewGaleria.RowTemplate.Height = 35;
            dataGridViewGaleria.Size = new Size(1503, 697);
            dataGridViewGaleria.TabIndex = 11;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 916);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 40);
            panelPaginacion.TabIndex = 15;
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(120, 0);
            buttonPaginacionDelante.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(86, 40);
            buttonPaginacionDelante.TabIndex = 2;
            buttonPaginacionDelante.Text = ">>";
            buttonPaginacionDelante.UseVisualStyleBackColor = true;
            // 
            // buttonPaginacionAtras
            // 
            buttonPaginacionAtras.Dock = DockStyle.Left;
            buttonPaginacionAtras.ForeColor = SystemColors.ScrollBar;
            buttonPaginacionAtras.Location = new Point(34, 0);
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
            // dataGridViewTextBoxColumnSerNombre
            // 
            dataGridViewTextBoxColumnSerNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerNombre.FillWeight = 100.10363F;
            dataGridViewTextBoxColumnSerNombre.HeaderText = "Servicio";
            dataGridViewTextBoxColumnSerNombre.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerNombre.Name = "dataGridViewTextBoxColumnSerNombre";
            dataGridViewTextBoxColumnSerNombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSerDescripcion
            // 
            dataGridViewTextBoxColumnSerDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnSerDescripcion.FillWeight = 99.89638F;
            dataGridViewTextBoxColumnSerDescripcion.HeaderText = "Imagen";
            dataGridViewTextBoxColumnSerDescripcion.MinimumWidth = 6;
            dataGridViewTextBoxColumnSerDescripcion.Name = "dataGridViewTextBoxColumnSerDescripcion";
            dataGridViewTextBoxColumnSerDescripcion.ReadOnly = true;
            // 
            // dataGridViewImageColumnModificar
            // 
            dataGridViewImageColumnModificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewImageColumnModificar.HeaderText = "Modificar";
            dataGridViewImageColumnModificar.Image = (Image)resources.GetObject("dataGridViewImageColumnModificar.Image");
            dataGridViewImageColumnModificar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnModificar.MinimumWidth = 6;
            dataGridViewImageColumnModificar.Name = "dataGridViewImageColumnModificar";
            dataGridViewImageColumnModificar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnModificar.Width = 135;
            // 
            // dataGridViewImageColumnEliminar
            // 
            dataGridViewImageColumnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewImageColumnEliminar.HeaderText = "Eliminar";
            dataGridViewImageColumnEliminar.Image = (Image)resources.GetObject("dataGridViewImageColumnEliminar.Image");
            dataGridViewImageColumnEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumnEliminar.MinimumWidth = 6;
            dataGridViewImageColumnEliminar.Name = "dataGridViewImageColumnEliminar";
            dataGridViewImageColumnEliminar.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumnEliminar.Width = 123;
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
            panelMargenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGaleria).EndInit();
            panelPaginacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisualGaleria;
        private ComboBox comboBoxSerFiltrar;
        private TextBox textBoxSerBuscar;
        private Button anyadirServicio;
        private Panel panelMargenes;
        private DataGridView dataGridViewGaleria;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelEspaciado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerNombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnSerDescripcion;
        private DataGridViewImageColumn dataGridViewImageColumnModificar;
        private DataGridViewImageColumn dataGridViewImageColumnEliminar;
    }
}