using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersInfo.Models;

namespace WinFormsApp1
{
    partial class PanelBloqueo
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
        /// 
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelVisualBloqueos = new Panel();
            textBoxBloqueoBuscar = new TextBox();
            anyadirUsuario = new Button();
            panelEspaciado = new Panel();
            panelPaginacion = new Panel();
            labelPaginaActual = new Label();
            buttonPaginacionDelante = new Button();
            buttonPaginacionAtras = new Button();
            panelMargenes = new Panel();
            panelFiltros = new Panel();
            panelPuntuales = new Panel();
            labelNumPuntuales = new Label();
            labelPuntuales = new Label();
            pictureBoxPuntuales = new PictureBox();
            panelAnuales = new Panel();
            labelNumAnuales = new Label();
            labelAnuales = new Label();
            pictureBoxAnuales = new PictureBox();
            panelBotones = new Panel();
            anyadirBloqueo = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            monthCalendarFiltrar = new WinFormsApp1.PanelPrincipal.MyMonthCalendar();
            buttonTodos = new Button();
            comboBoxRecurrente = new ComboBox();
            dataGridViewBloqueos = new DataGridView();
            dataGridViewTextBoxFecha = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxHorarios = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxRecurrente = new DataGridViewCheckBoxColumn();
            panelVisualBloqueos.SuspendLayout();
            panelPaginacion.SuspendLayout();
            panelMargenes.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelPuntuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPuntuales).BeginInit();
            panelAnuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnuales).BeginInit();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBloqueos).BeginInit();
            SuspendLayout();
            // 
            // panelVisualBloqueos
            // 
            panelVisualBloqueos.Controls.Add(textBoxBloqueoBuscar);
            panelVisualBloqueos.Controls.Add(anyadirUsuario);
            panelVisualBloqueos.Dock = DockStyle.Top;
            panelVisualBloqueos.ForeColor = Color.FromArgb(255, 128, 0);
            panelVisualBloqueos.Location = new Point(0, 0);
            panelVisualBloqueos.Margin = new Padding(5, 4, 5, 4);
            panelVisualBloqueos.Name = "panelVisualBloqueos";
            panelVisualBloqueos.Padding = new Padding(17, 0, 0, 0);
            panelVisualBloqueos.Size = new Size(1571, 100);
            panelVisualBloqueos.TabIndex = 18;
            panelVisualBloqueos.Paint += panelVisualBloqueos_Paint;
            // 
            // textBoxBloqueoBuscar
            // 
            textBoxBloqueoBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBloqueoBuscar.BorderStyle = BorderStyle.None;
            textBoxBloqueoBuscar.ForeColor = SystemColors.WindowFrame;
            textBoxBloqueoBuscar.Location = new Point(441, 49);
            textBoxBloqueoBuscar.Margin = new Padding(6, 5, 6, 5);
            textBoxBloqueoBuscar.Name = "textBoxBloqueoBuscar";
            textBoxBloqueoBuscar.PlaceholderText = "Buscar por dia de la semana o servicio...";
            textBoxBloqueoBuscar.Size = new Size(947, 20);
            textBoxBloqueoBuscar.TabIndex = 19;
            textBoxBloqueoBuscar.TextChanged += textBoxBloqueoBuscar_TextChanged;
            // 
            // anyadirUsuario
            // 
            anyadirUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            anyadirUsuario.BackColor = Color.FromArgb(255, 128, 0);
            anyadirUsuario.FlatAppearance.BorderSize = 0;
            anyadirUsuario.FlatStyle = FlatStyle.Flat;
            anyadirUsuario.ForeColor = Color.White;
            anyadirUsuario.Location = new Point(4165, 175);
            anyadirUsuario.Margin = new Padding(3, 4, 3, 4);
            anyadirUsuario.Name = "anyadirUsuario";
            anyadirUsuario.Size = new Size(86, 31);
            anyadirUsuario.TabIndex = 15;
            anyadirUsuario.Text = "+";
            anyadirUsuario.UseVisualStyleBackColor = false;
            anyadirUsuario.Visible = false;
            // 
            // panelEspaciado
            // 
            panelEspaciado.Dock = DockStyle.Bottom;
            panelEspaciado.Location = new Point(0, 944);
            panelEspaciado.Margin = new Padding(3, 4, 3, 4);
            panelEspaciado.Name = "panelEspaciado";
            panelEspaciado.Size = new Size(1571, 80);
            panelEspaciado.TabIndex = 19;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Controls.Add(labelPaginaActual);
            panelPaginacion.Controls.Add(buttonPaginacionDelante);
            panelPaginacion.Controls.Add(buttonPaginacionAtras);
            panelPaginacion.Dock = DockStyle.Bottom;
            panelPaginacion.Location = new Point(0, 901);
            panelPaginacion.Margin = new Padding(3, 4, 3, 4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Padding = new Padding(34, 0, 0, 0);
            panelPaginacion.Size = new Size(1571, 43);
            panelPaginacion.TabIndex = 20;
            // 
            // labelPaginaActual
            // 
            labelPaginaActual.AutoSize = true;
            labelPaginaActual.Location = new Point(246, 11);
            labelPaginaActual.Name = "labelPaginaActual";
            labelPaginaActual.Size = new Size(17, 20);
            labelPaginaActual.TabIndex = 3;
            labelPaginaActual.Text = "1";
            // 
            // buttonPaginacionDelante
            // 
            buttonPaginacionDelante.Dock = DockStyle.Left;
            buttonPaginacionDelante.Location = new Point(120, 0);
            buttonPaginacionDelante.Margin = new Padding(3, 4, 3, 4);
            buttonPaginacionDelante.Name = "buttonPaginacionDelante";
            buttonPaginacionDelante.Size = new Size(86, 43);
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
            buttonPaginacionAtras.Size = new Size(86, 43);
            buttonPaginacionAtras.TabIndex = 1;
            buttonPaginacionAtras.Text = "<<";
            buttonPaginacionAtras.UseVisualStyleBackColor = true;
            // 
            // panelMargenes
            // 
            panelMargenes.Controls.Add(panelFiltros);
            panelMargenes.Controls.Add(dataGridViewBloqueos);
            panelMargenes.Dock = DockStyle.Fill;
            panelMargenes.Location = new Point(0, 100);
            panelMargenes.Name = "panelMargenes";
            panelMargenes.Padding = new Padding(30, 0, 30, 0);
            panelMargenes.Size = new Size(1571, 801);
            panelMargenes.TabIndex = 21;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(panelPuntuales);
            panelFiltros.Controls.Add(panelAnuales);
            panelFiltros.Controls.Add(panelBotones);
            panelFiltros.Controls.Add(monthCalendarFiltrar);
            panelFiltros.Controls.Add(buttonTodos);
            panelFiltros.Controls.Add(comboBoxRecurrente);
            panelFiltros.Dock = DockStyle.Right;
            panelFiltros.Location = new Point(30, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(411, 801);
            panelFiltros.TabIndex = 20;
            // 
            // panelPuntuales
            // 
            panelPuntuales.BackColor = SystemColors.Control;
            panelPuntuales.BorderStyle = BorderStyle.FixedSingle;
            panelPuntuales.Controls.Add(labelNumPuntuales);
            panelPuntuales.Controls.Add(labelPuntuales);
            panelPuntuales.Controls.Add(pictureBoxPuntuales);
            panelPuntuales.ForeColor = SystemColors.ControlDarkDark;
            panelPuntuales.Location = new Point(80, 550);
            panelPuntuales.Margin = new Padding(5, 4, 5, 4);
            panelPuntuales.Name = "panelPuntuales";
            panelPuntuales.Size = new Size(180, 110);
            panelPuntuales.TabIndex = 6;
            // 
            // labelNumPuntuales
            // 
            labelNumPuntuales.AutoSize = true;
            labelNumPuntuales.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumPuntuales.ForeColor = SystemColors.ControlText;
            labelNumPuntuales.Location = new Point(66, 51);
            labelNumPuntuales.Margin = new Padding(5, 0, 5, 0);
            labelNumPuntuales.Name = "labelNumPuntuales";
            labelNumPuntuales.Size = new Size(27, 29);
            labelNumPuntuales.TabIndex = 2;
            labelNumPuntuales.Text = "2";
            // 
            // labelPuntuales
            // 
            labelPuntuales.AutoSize = true;
            labelPuntuales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPuntuales.Location = new Point(17, 19);
            labelPuntuales.Margin = new Padding(5, 0, 5, 0);
            labelPuntuales.Name = "labelPuntuales";
            labelPuntuales.Size = new Size(156, 20);
            labelPuntuales.TabIndex = 0;
            labelPuntuales.Text = "Bloqueos puntuales";
            // 
            // pictureBoxPuntuales
            // 
            pictureBoxPuntuales.Image = Properties.Resources.citas;
            pictureBoxPuntuales.Location = new Point(23, 39);
            pictureBoxPuntuales.Margin = new Padding(5, 4, 5, 4);
            pictureBoxPuntuales.Name = "pictureBoxPuntuales";
            pictureBoxPuntuales.Size = new Size(43, 51);
            pictureBoxPuntuales.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPuntuales.TabIndex = 1;
            pictureBoxPuntuales.TabStop = false;
            // 
            // panelAnuales
            // 
            panelAnuales.BackColor = SystemColors.Control;
            panelAnuales.BorderStyle = BorderStyle.FixedSingle;
            panelAnuales.Controls.Add(labelNumAnuales);
            panelAnuales.Controls.Add(labelAnuales);
            panelAnuales.Controls.Add(pictureBoxAnuales);
            panelAnuales.ForeColor = SystemColors.ControlDarkDark;
            panelAnuales.Location = new Point(80, 668);
            panelAnuales.Margin = new Padding(5, 4, 5, 4);
            panelAnuales.Name = "panelAnuales";
            panelAnuales.Size = new Size(180, 110);
            panelAnuales.TabIndex = 5;
            // 
            // labelNumAnuales
            // 
            labelNumAnuales.AutoSize = true;
            labelNumAnuales.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumAnuales.ForeColor = SystemColors.ControlText;
            labelNumAnuales.Location = new Point(66, 51);
            labelNumAnuales.Margin = new Padding(5, 0, 5, 0);
            labelNumAnuales.Name = "labelNumAnuales";
            labelNumAnuales.Size = new Size(27, 29);
            labelNumAnuales.TabIndex = 2;
            labelNumAnuales.Text = "2";
            // 
            // labelAnuales
            // 
            labelAnuales.AutoSize = true;
            labelAnuales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAnuales.Location = new Point(17, 19);
            labelAnuales.Margin = new Padding(5, 0, 5, 0);
            labelAnuales.Name = "labelAnuales";
            labelAnuales.Size = new Size(142, 20);
            labelAnuales.TabIndex = 0;
            labelAnuales.Text = "Bloqueos anuales";
            // 
            // pictureBoxAnuales
            // 
            pictureBoxAnuales.Image = Properties.Resources.citas;
            pictureBoxAnuales.Location = new Point(23, 39);
            pictureBoxAnuales.Margin = new Padding(5, 4, 5, 4);
            pictureBoxAnuales.Name = "pictureBoxAnuales";
            pictureBoxAnuales.Size = new Size(43, 51);
            pictureBoxAnuales.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnuales.TabIndex = 1;
            pictureBoxAnuales.TabStop = false;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(anyadirBloqueo);
            panelBotones.Controls.Add(buttonModificar);
            panelBotones.Controls.Add(buttonEliminar);
            panelBotones.Dock = DockStyle.Right;
            panelBotones.Location = new Point(351, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(4);
            panelBotones.Size = new Size(60, 801);
            panelBotones.TabIndex = 22;
            // 
            // anyadirBloqueo
            // 
            anyadirBloqueo.BackColor = Color.FromArgb(255, 128, 0);
            anyadirBloqueo.Dock = DockStyle.Top;
            anyadirBloqueo.FlatAppearance.BorderSize = 0;
            anyadirBloqueo.FlatStyle = FlatStyle.Flat;
            anyadirBloqueo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyadirBloqueo.ForeColor = Color.White;
            anyadirBloqueo.Location = new Point(4, 114);
            anyadirBloqueo.Margin = new Padding(0, 5, 0, 0);
            anyadirBloqueo.Name = "anyadirBloqueo";
            anyadirBloqueo.Size = new Size(52, 55);
            anyadirBloqueo.TabIndex = 21;
            anyadirBloqueo.Text = "+";
            anyadirBloqueo.TextAlign = ContentAlignment.TopRight;
            anyadirBloqueo.UseVisualStyleBackColor = false;
            anyadirBloqueo.Click += anyadirBloqueo_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackgroundImage = Properties.Resources.edit;
            buttonModificar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonModificar.Dock = DockStyle.Top;
            buttonModificar.Location = new Point(4, 59);
            buttonModificar.Margin = new Padding(0);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Padding = new Padding(0, 8, 0, 0);
            buttonModificar.Size = new Size(52, 55);
            buttonModificar.TabIndex = 21;
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackgroundImage = Properties.Resources.trash;
            buttonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEliminar.Dock = DockStyle.Top;
            buttonEliminar.Location = new Point(4, 4);
            buttonEliminar.Margin = new Padding(0);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Padding = new Padding(0, 0, 0, 8);
            buttonEliminar.Size = new Size(52, 55);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // monthCalendarFiltrar
            // 
            monthCalendarFiltrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendarFiltrar.Location = new Point(40, 9);
            monthCalendarFiltrar.MaxSelectionCount = 31;
            monthCalendarFiltrar.Name = "monthCalendarFiltrar";
            monthCalendarFiltrar.RightToLeft = RightToLeft.Yes;
            monthCalendarFiltrar.ShowToday = false;
            monthCalendarFiltrar.TabIndex = 19;
            monthCalendarFiltrar.TitleBackColor = Color.DarkOrange;
            monthCalendarFiltrar.TrailingForeColor = SystemColors.ButtonShadow;
            monthCalendarFiltrar.DateSelected += monthCalendarFiltrar_DateSelected;
            // 
            // buttonTodos
            // 
            buttonTodos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(40, 440);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(282, 32);
            buttonTodos.TabIndex = 4;
            buttonTodos.Text = "Ver todos los horarios";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // comboBoxRecurrente
            // 
            comboBoxRecurrente.DisplayMember = "1";
            comboBoxRecurrente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRecurrente.FlatStyle = FlatStyle.Flat;
            comboBoxRecurrente.Items.AddRange(new object[] { "Todos los bloqueos", "Anuales", "Puntuales" });
            comboBoxRecurrente.Location = new Point(40, 390);
            comboBoxRecurrente.Margin = new Padding(6, 5, 6, 5);
            comboBoxRecurrente.Name = "comboBoxRecurrente";
            comboBoxRecurrente.Size = new Size(282, 28);
            comboBoxRecurrente.TabIndex = 20;
            comboBoxRecurrente.SelectedIndexChanged += comboBoxRecurrente_SelectedIndexChanged;
            // 
            // dataGridViewBloqueos
            // 
            dataGridViewBloqueos.AllowUserToOrderColumns = true;
            dataGridViewBloqueos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBloqueos.BackgroundColor = Color.White;
            dataGridViewBloqueos.BorderStyle = BorderStyle.None;
            dataGridViewBloqueos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBloqueos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBloqueos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBloqueos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxFecha, dataGridViewTextBoxHorarios, dataGridViewTextBoxRecurrente });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewBloqueos.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBloqueos.Dock = DockStyle.Right;
            dataGridViewBloqueos.EnableHeadersVisualStyles = false;
            dataGridViewBloqueos.GridColor = Color.Black;
            dataGridViewBloqueos.ImeMode = ImeMode.NoControl;
            dataGridViewBloqueos.Location = new Point(441, 0);
            dataGridViewBloqueos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBloqueos.MultiSelect = false;
            dataGridViewBloqueos.Name = "dataGridViewBloqueos";
            dataGridViewBloqueos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewBloqueos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBloqueos.RowHeadersVisible = false;
            dataGridViewBloqueos.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewBloqueos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewBloqueos.RowTemplate.Height = 35;
            dataGridViewBloqueos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewBloqueos.Size = new Size(1100, 801);
            dataGridViewBloqueos.TabIndex = 18;
            dataGridViewBloqueos.CellClick += dataGridViewBloqueos_CellClick;
            // 
            // dataGridViewTextBoxFecha
            // 
            dataGridViewTextBoxFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxFecha.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxFecha.HeaderText = "Fecha";
            dataGridViewTextBoxFecha.MinimumWidth = 6;
            dataGridViewTextBoxFecha.Name = "dataGridViewTextBoxFecha";
            dataGridViewTextBoxFecha.ReadOnly = true;
            // 
            // dataGridViewTextBoxHorarios
            // 
            dataGridViewTextBoxHorarios.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxHorarios.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxHorarios.HeaderText = "Horarios";
            dataGridViewTextBoxHorarios.MinimumWidth = 6;
            dataGridViewTextBoxHorarios.Name = "dataGridViewTextBoxHorarios";
            dataGridViewTextBoxHorarios.ReadOnly = true;
            dataGridViewTextBoxHorarios.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxRecurrente
            // 
            dataGridViewTextBoxRecurrente.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewTextBoxRecurrente.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxRecurrente.HeaderText = "Recurrente";
            dataGridViewTextBoxRecurrente.MinimumWidth = 6;
            dataGridViewTextBoxRecurrente.Name = "dataGridViewTextBoxRecurrente";
            dataGridViewTextBoxRecurrente.ReadOnly = true;
            dataGridViewTextBoxRecurrente.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxRecurrente.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxRecurrente.Width = 145;
            // 
            // PanelBloqueo
            // 
            ClientSize = new Size(1571, 1024);
            Controls.Add(panelMargenes);
            Controls.Add(panelPaginacion);
            Controls.Add(panelEspaciado);
            Controls.Add(panelVisualBloqueos);
            Name = "PanelBloqueo";
            Text = "PanelBloqueo";
            Load += PanelBloqueo_Load;
            panelVisualBloqueos.ResumeLayout(false);
            panelVisualBloqueos.PerformLayout();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            panelMargenes.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelPuntuales.ResumeLayout(false);
            panelPuntuales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPuntuales).EndInit();
            panelAnuales.ResumeLayout(false);
            panelAnuales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnuales).EndInit();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBloqueos).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Panel panelVisualBloqueos;
        private TextBox textBoxBloqueoBuscar;
        private Button anyadirUsuario;
        private Panel panelEspaciado;
        private Panel panelPaginacion;
        private Label labelPaginaActual;
        private Button buttonPaginacionDelante;
        private Button buttonPaginacionAtras;
        private Panel panelMargenes;
        private Panel panelFiltros;
        private Panel panelBotones;
        private Button anyadirBloqueo;
        private Button buttonModificar;
        private Button buttonEliminar;
        private PanelPrincipal.MyMonthCalendar monthCalendarFiltrar;
        private Button buttonTodos;
        private ComboBox comboBoxRecurrente;
        private DataGridView dataGridViewBloqueos;
        private Panel panelAnuales;
        private Label labelNumAnuales;
        private Label labelAnuales;
        private PictureBox pictureBoxAnuales;
        private Panel panelPuntuales;
        private Label labelNumPuntuales;
        private Label labelPuntuales;
        private PictureBox pictureBoxPuntuales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxFecha;
        private DataGridViewTextBoxColumn dataGridViewTextBoxHorarios;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxRecurrente;
    }
}
