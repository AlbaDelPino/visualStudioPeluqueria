namespace WinFormsApp1
{
    partial class PanelCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCita));
            panelVisualCitas = new Panel();
            comboBoxCitFiltrar = new ComboBox();
            panelCitasProx = new Panel();
            labelNumCitasProx = new Label();
            labelCitasProx = new Label();
            pictureCitasProx = new PictureBox();
            textBoxCitBuscar = new TextBox();
            anyadirCita = new Button();
            panelCitasHoy = new Panel();
            labelNumCitasHoy = new Label();
            labelCitasHoy = new Label();
            pictureCitasHoy = new PictureBox();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelMargenes = new Panel();
            dataGridViewCitas = new DataGridView();
            dataGridViewTextBoxColumnCitCliente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCitServicio = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCitFecha = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCitHora = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCitEstado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCitGrupo = new DataGridViewTextBoxColumn();
            dataGridViewImageColumnModificar = new DataGridViewImageColumn();
            dataGridViewImageColumnEliminar = new DataGridViewImageColumn();
            panelVisualCitas.SuspendLayout();
            panelCitasProx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitasProx).BeginInit();
            panelCitasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitasHoy).BeginInit();
            panelPaginacion.SuspendLayout();
            panelMargenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            SuspendLayout();
            // 
            // panelVisualCitas
            // 
            panelVisualCitas.Controls.Add(comboBoxCitFiltrar);
            panelVisualCitas.Controls.Add(panelCitasProx);
            panelVisualCitas.Controls.Add(textBoxCitBuscar);
            panelVisualCitas.Controls.Add(anyadirCita);
            panelVisualCitas.Controls.Add(panelCitasHoy);
            panelVisualCitas.Dock = DockStyle.Top;
            panelVisualCitas.Location = new Point(0, 0);
            panelVisualCitas.Margin = new Padding(4, 3, 4, 3);
            panelVisualCitas.Name = "panelVisualCitas";
            panelVisualCitas.Size = new Size(1375, 192);
            panelVisualCitas.TabIndex = 6;
            // 
            // comboBoxCitFiltrar
            // 
            comboBoxCitFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCitFiltrar.DisplayMember = "1";
            comboBoxCitFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCitFiltrar.Items.AddRange(new object[] { "", "Depilación", "Manicura y Pedicura", "Maquillaje", "Masajes", "Micropigmentación", "Peluquería", "Pestañas y Cejas", "Tratamientos Corporales", "Tratamientos Faciales" });
            comboBoxCitFiltrar.Location = new Point(1204, 155);
            comboBoxCitFiltrar.Margin = new Padding(4, 3, 4, 3);
            comboBoxCitFiltrar.Name = "comboBoxCitFiltrar";
            comboBoxCitFiltrar.Size = new Size(134, 23);
            comboBoxCitFiltrar.TabIndex = 6;
            // 
            // panelCitasProx
            // 
            panelCitasProx.BackColor = SystemColors.Control;
            panelCitasProx.BorderStyle = BorderStyle.FixedSingle;
            panelCitasProx.Controls.Add(labelNumCitasProx);
            panelCitasProx.Controls.Add(labelCitasProx);
            panelCitasProx.Controls.Add(pictureCitasProx);
            panelCitasProx.ForeColor = SystemColors.ControlDarkDark;
            panelCitasProx.Location = new Point(180, 13);
            panelCitasProx.Margin = new Padding(4, 3, 4, 3);
            panelCitasProx.Name = "panelCitasProx";
            panelCitasProx.Size = new Size(160, 85);
            panelCitasProx.TabIndex = 11;
            // 
            // labelNumCitasProx
            // 
            labelNumCitasProx.AutoSize = true;
            labelNumCitasProx.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasProx.ForeColor = SystemColors.ControlText;
            labelNumCitasProx.Location = new Point(58, 42);
            labelNumCitasProx.Margin = new Padding(4, 0, 4, 0);
            labelNumCitasProx.Name = "labelNumCitasProx";
            labelNumCitasProx.Size = new Size(23, 25);
            labelNumCitasProx.TabIndex = 2;
            labelNumCitasProx.Text = "3";
            // 
            // labelCitasProx
            // 
            labelCitasProx.AutoSize = true;
            labelCitasProx.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasProx.Location = new Point(16, 18);
            labelCitasProx.Margin = new Padding(4, 0, 4, 0);
            labelCitasProx.Name = "labelCitasProx";
            labelCitasProx.Size = new Size(98, 17);
            labelCitasProx.TabIndex = 0;
            labelCitasProx.Text = "Próximas citas";
            // 
            // pictureCitasProx
            // 
            pictureCitasProx.Image = Properties.Resources.servicio;
            pictureCitasProx.Location = new Point(30, 40);
            pictureCitasProx.Margin = new Padding(4, 3, 4, 3);
            pictureCitasProx.Name = "pictureCitasProx";
            pictureCitasProx.Size = new Size(30, 30);
            pictureCitasProx.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCitasProx.TabIndex = 1;
            pictureCitasProx.TabStop = false;
            // 
            // textBoxCitBuscar
            // 
            textBoxCitBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCitBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxCitBuscar.Location = new Point(30, 155);
            textBoxCitBuscar.Margin = new Padding(4, 3, 4, 3);
            textBoxCitBuscar.Name = "textBoxCitBuscar";
            textBoxCitBuscar.PlaceholderText = "Buscar por nombre o descripción...";
            textBoxCitBuscar.Size = new Size(1143, 23);
            textBoxCitBuscar.TabIndex = 0;
            // 
            // anyadirCita
            // 
            anyadirCita.Location = new Point(30, 126);
            anyadirCita.Name = "anyadirCita";
            anyadirCita.Size = new Size(59, 23);
            anyadirCita.TabIndex = 10;
            anyadirCita.Text = "Añadir";
            anyadirCita.UseVisualStyleBackColor = true;
            // 
            // panelCitasHoy
            // 
            panelCitasHoy.BackColor = SystemColors.Control;
            panelCitasHoy.BorderStyle = BorderStyle.FixedSingle;
            panelCitasHoy.Controls.Add(labelNumCitasHoy);
            panelCitasHoy.Controls.Add(labelCitasHoy);
            panelCitasHoy.Controls.Add(pictureCitasHoy);
            panelCitasHoy.ForeColor = SystemColors.ControlDarkDark;
            panelCitasHoy.Location = new Point(30, 13);
            panelCitasHoy.Margin = new Padding(4, 3, 4, 3);
            panelCitasHoy.Name = "panelCitasHoy";
            panelCitasHoy.Size = new Size(142, 85);
            panelCitasHoy.TabIndex = 4;
            // 
            // labelNumCitasHoy
            // 
            labelNumCitasHoy.AutoSize = true;
            labelNumCitasHoy.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumCitasHoy.ForeColor = SystemColors.ControlText;
            labelNumCitasHoy.Location = new Point(58, 42);
            labelNumCitasHoy.Margin = new Padding(4, 0, 4, 0);
            labelNumCitasHoy.Name = "labelNumCitasHoy";
            labelNumCitasHoy.Size = new Size(23, 25);
            labelNumCitasHoy.TabIndex = 2;
            labelNumCitasHoy.Text = "3";
            // 
            // labelCitasHoy
            // 
            labelCitasHoy.AutoSize = true;
            labelCitasHoy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitasHoy.Location = new Point(16, 18);
            labelCitasHoy.Margin = new Padding(4, 0, 4, 0);
            labelCitasHoy.Name = "labelCitasHoy";
            labelCitasHoy.Size = new Size(88, 17);
            labelCitasHoy.TabIndex = 0;
            labelCitasHoy.Text = "Citas de Hoy";
            // 
            // pictureCitasHoy
            // 
            pictureCitasHoy.Image = Properties.Resources.servicio;
            pictureCitasHoy.Location = new Point(30, 40);
            pictureCitasHoy.Margin = new Padding(4, 3, 4, 3);
            pictureCitasHoy.Name = "pictureCitasHoy";
            pictureCitasHoy.Size = new Size(30, 30);
            pictureCitasHoy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCitasHoy.TabIndex = 1;
            pictureCitasHoy.TabStop = false;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 668);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1375, 100);
            panelEspaciado.TabIndex = 14;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 638);
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
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(dataGridViewCitas);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 192);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1375, 446);
            panelMargenes.TabIndex = 16;
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitas.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCitas.BorderStyle = BorderStyle.None;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnCitCliente, dataGridViewTextBoxColumnCitServicio, dataGridViewTextBoxColumnCitFecha, dataGridViewTextBoxColumnCitHora, dataGridViewTextBoxColumnCitEstado, dataGridViewTextBoxColumnCitGrupo, dataGridViewImageColumnModificar, dataGridViewImageColumnEliminar });
            dataGridViewCitas.Dock = DockStyle.Fill;
            dataGridViewCitas.Location = new Point(30, 0);
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.RowHeadersWidth = 51;
            dataGridViewCitas.Size = new Size(1315, 446);
            dataGridViewCitas.TabIndex = 11;
            dataGridViewCitas.CellContentClick += dataGridViewCitas_CellContentClick;
            // 
            // dataGridViewTextBoxColumnCitCliente
            // 
            dataGridViewTextBoxColumnCitCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnCitCliente.FillWeight = 100.10363F;
            dataGridViewTextBoxColumnCitCliente.HeaderText = "Cliente";
            dataGridViewTextBoxColumnCitCliente.MinimumWidth = 6;
            dataGridViewTextBoxColumnCitCliente.Name = "dataGridViewTextBoxColumnCitCliente";
            dataGridViewTextBoxColumnCitCliente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCitServicio
            // 
            dataGridViewTextBoxColumnCitServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnCitServicio.HeaderText = "Servicio";
            dataGridViewTextBoxColumnCitServicio.MinimumWidth = 6;
            dataGridViewTextBoxColumnCitServicio.Name = "dataGridViewTextBoxColumnCitServicio";
            dataGridViewTextBoxColumnCitServicio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCitFecha
            // 
            dataGridViewTextBoxColumnCitFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnCitFecha.FillWeight = 99.89638F;
            dataGridViewTextBoxColumnCitFecha.HeaderText = "Fecha";
            dataGridViewTextBoxColumnCitFecha.MinimumWidth = 6;
            dataGridViewTextBoxColumnCitFecha.Name = "dataGridViewTextBoxColumnCitFecha";
            dataGridViewTextBoxColumnCitFecha.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCitHora
            // 
            dataGridViewTextBoxColumnCitHora.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumnCitHora.HeaderText = "Hora";
            dataGridViewTextBoxColumnCitHora.MinimumWidth = 6;
            dataGridViewTextBoxColumnCitHora.Name = "dataGridViewTextBoxColumnCitHora";
            dataGridViewTextBoxColumnCitHora.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnCitEstado
            // 
            dataGridViewTextBoxColumnCitEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnCitEstado.HeaderText = "Estado";
            dataGridViewTextBoxColumnCitEstado.MinimumWidth = 6;
            dataGridViewTextBoxColumnCitEstado.Name = "dataGridViewTextBoxColumnCitEstado";
            dataGridViewTextBoxColumnCitEstado.ReadOnly = true;
            dataGridViewTextBoxColumnCitEstado.Width = 67;
            // 
            // dataGridViewTextBoxColumnCitGrupo
            // 
            dataGridViewTextBoxColumnCitGrupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumnCitGrupo.HeaderText = "Grupo";
            dataGridViewTextBoxColumnCitGrupo.Name = "dataGridViewTextBoxColumnCitGrupo";
            dataGridViewTextBoxColumnCitGrupo.ReadOnly = true;
            dataGridViewTextBoxColumnCitGrupo.Width = 65;
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
            dataGridViewImageColumnModificar.Width = 83;
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
            dataGridViewImageColumnEliminar.Width = 75;
            // 
            // PanelCita
            // 
            ClientSize = new Size(1375, 768);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualCitas);
            Name = "PanelCita";
            panelVisualCitas.ResumeLayout(false);
            panelVisualCitas.PerformLayout();
            panelCitasProx.ResumeLayout(false);
            panelCitasProx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitasProx).EndInit();
            panelCitasHoy.ResumeLayout(false);
            panelCitasHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCitasHoy).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelMargenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelVisualCitas;
        private ComboBox comboBoxCitFiltrar;
        private Panel panelCitasProx;
        private Label labelNumCitasProx;
        private Label labelCitasProx;
        private PictureBox pictureCitasProx;
        private TextBox textBoxCitBuscar;
        private Button anyadirCita;
        private Panel panelCitasHoy;
        private Label labelNumCitasHoy;
        private Label labelCitasHoy;
        private PictureBox pictureCitasHoy;
        private Panel panelEspaciado;
        private Panel panelPaginacion;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelMargenes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitServicio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitFecha;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitHora;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCitGrupo;
        private DataGridViewImageColumn dataGridViewImageColumnModificar;
        private DataGridViewImageColumn dataGridViewImageColumnEliminar;
        private DataGridView dataGridViewCitas;
    }
}
