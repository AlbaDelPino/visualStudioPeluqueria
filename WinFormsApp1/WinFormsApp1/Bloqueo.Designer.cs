using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Bloqueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloqueo));
            pictureBoxICon = new PictureBox();
            buttonHorarios = new Button();
            textBoxHorarios = new WinFormsApp1.Usuario.RoundedTextBox();
            buttonAnyadir = new RoundedButton();
            labelHorarios = new Label();
            CalendarCitas = new WinFormsApp1.Cita.MyMonthCalendar();
            labelTituo = new Label();
            labelCitFecha = new Label();
            radioButtonAnual = new RadioButton();
            radioButtonPuntual = new RadioButton();
            textBoxMotivo = new WinFormsApp1.Usuario.RoundedTextBox();
            labelMotivo = new Label();
            buttonModificar = new RoundedButton();
            textBoxCitFecha = new WinFormsApp1.Usuario.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxICon
            // 
            pictureBoxICon.BackColor = Color.FromArgb(241, 123, 35);
            pictureBoxICon.Dock = DockStyle.Left;
            pictureBoxICon.Image = Properties.Resources.iconPeluqueria;
            pictureBoxICon.Location = new Point(0, 0);
            pictureBoxICon.Margin = new Padding(3, 4, 3, 4);
            pictureBoxICon.Name = "pictureBoxICon";
            pictureBoxICon.Size = new Size(208, 433);
            pictureBoxICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxICon.TabIndex = 1;
            pictureBoxICon.TabStop = false;
            // 
            // buttonHorarios
            // 
            buttonHorarios.Location = new Point(585, 158);
            buttonHorarios.Margin = new Padding(3, 4, 3, 4);
            buttonHorarios.Name = "buttonHorarios";
            buttonHorarios.Size = new Size(50, 30);
            buttonHorarios.TabIndex = 99;
            buttonHorarios.UseVisualStyleBackColor = true;
            buttonHorarios.Click += buttonHorarios_Click;
            buttonHorarios.Paint += buttonHorarios_Paint;
            // 
            // textBoxHorarios
            // 
            textBoxHorarios.BackColor = SystemColors.Control;
            textBoxHorarios.BorderColor = SystemColors.ControlDarkDark;
            textBoxHorarios.BorderRadius = 10;
            textBoxHorarios.BorderSize = 1;
            textBoxHorarios.Location = new Point(508, 196);
            textBoxHorarios.Margin = new Padding(3, 4, 3, 4);
            textBoxHorarios.Name = "textBoxHorarios";
            textBoxHorarios.PasswordChar = '\0';
            textBoxHorarios.ReadOnly = true;
            textBoxHorarios.Size = new Size(222, 32);
            textBoxHorarios.TabIndex = 98;
            // 
            // buttonAnyadir
            // 
            buttonAnyadir.BackColor = Color.DarkOrange;
            buttonAnyadir.BorderRadius = 10;
            buttonAnyadir.FlatStyle = FlatStyle.Flat;
            buttonAnyadir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonAnyadir.ForeColor = SystemColors.ControlLightLight;
            buttonAnyadir.Location = new Point(635, 368);
            buttonAnyadir.Margin = new Padding(3, 4, 3, 4);
            buttonAnyadir.Name = "buttonAnyadir";
            buttonAnyadir.Size = new Size(95, 37);
            buttonAnyadir.TabIndex = 97;
            buttonAnyadir.Text = "Añadir";
            buttonAnyadir.UseVisualStyleBackColor = false;
            buttonAnyadir.Click += ButtonAnyadir_Click;
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHorarios.Location = new Point(508, 163);
            labelHorarios.Margin = new Padding(5, 0, 5, 0);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(74, 20);
            labelHorarios.TabIndex = 96;
            labelHorarios.Text = "Horarios";
            // 
            // CalendarCitas
            // 
            CalendarCitas.FirstDayOfWeek = Day.Monday;
            CalendarCitas.Font = new Font("Segoe UI", 10F);
            CalendarCitas.Location = new Point(260, 109);
            CalendarCitas.MaxSelectionCount = 1;
            CalendarCitas.MinDate = new DateTime(2026, 2, 4, 0, 0, 0, 0);
            CalendarCitas.Name = "CalendarCitas";
            CalendarCitas.ShowToday = false;
            CalendarCitas.TabIndex = 95;
            CalendarCitas.TitleBackColor = Color.DarkOrange;
            CalendarCitas.TrailingForeColor = SystemColors.ButtonShadow;
            CalendarCitas.DateSelected += CalendarCitas_DateSelected;
            // 
            // labelTituo
            // 
            labelTituo.AutoSize = true;
            labelTituo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTituo.ForeColor = SystemColors.ControlDarkDark;
            labelTituo.Location = new Point(260, 29);
            labelTituo.Name = "labelTituo";
            labelTituo.Size = new Size(270, 50);
            labelTituo.TabIndex = 94;
            labelTituo.Text = "Crear bloqueo";
            // 
            // labelCitFecha
            // 
            labelCitFecha.AutoSize = true;
            labelCitFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCitFecha.Location = new Point(508, 113);
            labelCitFecha.Margin = new Padding(5, 0, 5, 0);
            labelCitFecha.Name = "labelCitFecha";
            labelCitFecha.Size = new Size(55, 20);
            labelCitFecha.TabIndex = 93;
            labelCitFecha.Text = "Fecha";
            // 
            // radioButtonAnual
            // 
            radioButtonAnual.AutoSize = true;
            radioButtonAnual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAnual.Location = new Point(271, 368);
            radioButtonAnual.Name = "radioButtonAnual";
            radioButtonAnual.RightToLeft = RightToLeft.No;
            radioButtonAnual.Size = new Size(72, 24);
            radioButtonAnual.TabIndex = 109;
            radioButtonAnual.Text = "Anual";
            radioButtonAnual.UseVisualStyleBackColor = true;
            // 
            // radioButtonPuntual
            // 
            radioButtonPuntual.AutoSize = true;
            radioButtonPuntual.Checked = true;
            radioButtonPuntual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPuntual.Location = new Point(271, 338);
            radioButtonPuntual.Name = "radioButtonPuntual";
            radioButtonPuntual.RightToLeft = RightToLeft.No;
            radioButtonPuntual.Size = new Size(86, 24);
            radioButtonPuntual.TabIndex = 110;
            radioButtonPuntual.TabStop = true;
            radioButtonPuntual.Text = "Puntual";
            radioButtonPuntual.UseVisualStyleBackColor = true;
            // 
            // textBoxMotivo
            // 
            textBoxMotivo.BackColor = Color.White;
            textBoxMotivo.BorderColor = SystemColors.ControlDarkDark;
            textBoxMotivo.BorderRadius = 10;
            textBoxMotivo.BorderSize = 1;
            textBoxMotivo.Location = new Point(508, 283);
            textBoxMotivo.Margin = new Padding(3, 4, 3, 4);
            textBoxMotivo.Name = "textBoxMotivo";
            textBoxMotivo.PasswordChar = '\0';
            textBoxMotivo.ReadOnly = false;
            textBoxMotivo.Size = new Size(222, 32);
            textBoxMotivo.TabIndex = 112;
            // 
            // labelMotivo
            // 
            labelMotivo.AutoSize = true;
            labelMotivo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMotivo.Location = new Point(508, 249);
            labelMotivo.Margin = new Padding(5, 0, 5, 0);
            labelMotivo.Name = "labelMotivo";
            labelMotivo.Size = new Size(58, 20);
            labelMotivo.TabIndex = 111;
            labelMotivo.Text = "Motivo";
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.DarkOrange;
            buttonModificar.BorderRadius = 10;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonModificar.ForeColor = SystemColors.ControlLightLight;
            buttonModificar.Location = new Point(606, 368);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(124, 37);
            buttonModificar.TabIndex = 113;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxCitFecha
            // 
            textBoxCitFecha.BackColor = SystemColors.Control;
            textBoxCitFecha.BorderColor = SystemColors.ControlDarkDark;
            textBoxCitFecha.BorderRadius = 10;
            textBoxCitFecha.BorderSize = 1;
            textBoxCitFecha.Location = new Point(585, 110);
            textBoxCitFecha.Name = "textBoxCitFecha";
            textBoxCitFecha.PasswordChar = '\0';
            textBoxCitFecha.ReadOnly = true;
            textBoxCitFecha.Size = new Size(145, 32);
            textBoxCitFecha.TabIndex = 114;
            // 
            // Bloqueo
            // 
            ClientSize = new Size(779, 433);
            Controls.Add(textBoxCitFecha);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxMotivo);
            Controls.Add(labelMotivo);
            Controls.Add(radioButtonPuntual);
            Controls.Add(radioButtonAnual);
            Controls.Add(buttonHorarios);
            Controls.Add(textBoxHorarios);
            Controls.Add(buttonAnyadir);
            Controls.Add(labelHorarios);
            Controls.Add(CalendarCitas);
            Controls.Add(labelTituo);
            Controls.Add(labelCitFecha);
            Controls.Add(pictureBoxICon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(797, 480);
            Name = "Bloqueo";
            Text = "Bloqueo Horario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxICon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxICon;
        private Button buttonHorarios;
        private Usuario.RoundedTextBox textBoxHorarios;
        private RoundedButton buttonAnyadir;
        private Label labelHorarios;
        private Cita.MyMonthCalendar CalendarCitas;
        private Label labelTituo;
        private Label labelCitFecha;
        private RadioButton radioButtonAnual;
        private RadioButton radioButtonPuntual;
        private Usuario.RoundedTextBox textBoxMotivo;
        private Label labelMotivo;
        private RoundedButton buttonModificar;
        private Usuario.RoundedTextBox textBoxCitFecha;

public class RoundedButton : Button
    {
        private int _borderRadius = 10;
        private Color _borderColor = Color.Gray;
        private int _borderSize = 1;
        private int _paddingVertical = 8;
        private int _paddingHorizontal = 12;
        private Color _hoverColor = Color.FromArgb(Math.Max(Color.DarkOrange.R - 20, 0),Math.Max(Color.DarkOrange.G - 20, 0),Math.Max(Color.DarkOrange.B - 20, 0));
        private Color _pressedColor = Color.FromArgb(255, 192, 128);
        private bool _isHovered = false;
        private bool _isPressed = false;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        public int PaddingVertical
        {
            get { return _paddingVertical; }
            set
            {
                _paddingVertical = value;
                this.Invalidate();
            }
        }

        public int PaddingHorizontal
        {
            get { return _paddingHorizontal; }
            set
            {
                _paddingHorizontal = value;
                this.Invalidate();
            }
        }

        public Color HoverColor
        {
            get { return _hoverColor; }
            set
            {
                _hoverColor = value;
                this.Invalidate();
            }
        }

        public Color PressedColor
        {
            get { return _pressedColor; }
            set
            {
                _pressedColor = value;
                this.Invalidate();
            }
        }

        public RoundedButton()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, false);

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.DarkOrange; // Azul moderno por defecto
            this.ForeColor = Color.White;

            // Hacer el fondo transparente
            this.BackColor = SystemColors.Control;

            // Establecer una altura por defecto más grande
            this.Height = 40;

            // Configurar la fuente
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Habilitar eventos de mouse
            this.MouseEnter += (s, e) => { _isHovered = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { _isHovered = false; _isPressed = false; this.Invalidate(); };
            this.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { _isPressed = true; this.Invalidate(); } };
            this.MouseUp += (s, e) => { _isPressed = false; this.Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // No llamar a base.OnPaint para evitar pintar el fondo rectangular
            // base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;

            // Configurar la calidad del gráfico
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Limpiar el área con transparencia
            e.Graphics.Clear(SystemColors.Control);

            // Reducir ligeramente el rectángulo para el borde
            Rectangle drawRect = rect;
            if (_borderSize > 0)
            {
                drawRect.Inflate(-1, -1);
            }

            using (GraphicsPath path = GetRoundedRectangle(drawRect, _borderRadius))
            {
                // Determinar el color de fondo según el estado
                Color currentBackColor = GetCurrentBackColor();

                // Dibujar el fondo con el color correspondiente
                using (SolidBrush brush = new SolidBrush(currentBackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Dibujar el borde si es necesario
                if (_borderSize > 0)
                {
                    using (Pen pen = new Pen(this.Enabled ? _borderColor : SystemColors.Control, _borderSize))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            // Dibujar el texto
            DrawText(e.Graphics);
        }

        private Color GetCurrentBackColor()
        {
            if (!this.Enabled)
            {
                return SystemColors.Control;
            }
            else if (_isPressed)
            {
                return _pressedColor;
            }
            else if (_isHovered)
            {
                return _hoverColor;
            }

            // Color por defecto cuando no hay estados especiales
            return Color.DarkOrange; // Mismo azul que en el constructor
        }

        private void DrawText(Graphics graphics)
        {
            if (string.IsNullOrEmpty(this.Text)) return;

            Rectangle textRect = new Rectangle(
                _paddingHorizontal,
                _paddingVertical,
                this.Width - (_paddingHorizontal * 2),
                this.Height - (_paddingVertical * 2)
            );

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            using (SolidBrush textBrush = new SolidBrush(this.Enabled ? this.ForeColor : SystemColors.Control))
            {
                graphics.DrawString(this.Text, this.Font, textBrush, textRect, stringFormat);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            // Asegurar que el radio no sea mayor que la mitad del tamaño
            radius = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

            path.StartFigure();

            // Esquina superior izquierda
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);

            // Esquina superior derecha
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);

            // Esquina inferior derecha
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);

            // Esquina inferior izquierda
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Asegurar una altura mínima
            if (this.Height < 30)
            {
                this.Height = 30;
            }

            // Forzar redibujado
            this.Invalidate();
        }

        // Importante: Esto asegura que el fondo del control padre se pinte correctamente
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
    }
}
}
