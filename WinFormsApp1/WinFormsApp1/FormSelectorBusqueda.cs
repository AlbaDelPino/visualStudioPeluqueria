using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormSelectorBusqueda : Form
    {
        public object ItemSeleccionado { get; set; }
        private List<object> _listaOriginal;

        public FormSelectorBusqueda(string titulo, object listaParaMostrar)
        {
            InitializeComponent();
            this.Text = titulo;

            // Convertimos la entrada a lista de objetos
            _listaOriginal = ((IEnumerable)listaParaMostrar).Cast<object>().ToList();

            ConfigurarDataGridView();

            // Suscribir eventos
            dgvSelector.CellDoubleClick += dgvSelector_CellDoubleClick;
            textBoxHoBuscar.TextChanged += textBoxHoBuscar_TextChanged;
        }

        private void ConfigurarDataGridView()
        {
            // 1. Estética profesional
            dgvSelector.ReadOnly = true;
            dgvSelector.AllowUserToAddRows = false;
            dgvSelector.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelector.RowHeadersVisible = false;
            dgvSelector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Comprobar si los objetos de la lista son Clientes
            // (Asumiendo que tu clase tiene las propiedades 'Nombre' y 'Email' o 'Gmail')
            var primerItem = _listaOriginal.FirstOrDefault();

            if (primerItem != null && (primerItem.GetType().Name.Contains("Cliente") || primerItem.GetType().Name.Contains("User")))
            {
                dgvSelector.AutoGenerateColumns = false;
                dgvSelector.Columns.Clear();

                // Columna Nombre
                dgvSelector.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre del Cliente",
                    Name = "Nombre"
                });

                // Columna Email (ajusta "Email" al nombre exacto de la propiedad en tu DTO, ej: "Gmail" o "Email")
                dgvSelector.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Email",
                    HeaderText = "Correo Electrónico",
                    Name = "Email"
                });
            }
            else
            {
                // Si no es cliente, usamos el comportamiento por defecto pero ocultando IDs
                dgvSelector.AutoGenerateColumns = true;
            }

            dgvSelector.DataSource = _listaOriginal;

            // Si no fue cliente, ejecutamos la limpieza de columnas innecesarias
            if (dgvSelector.AutoGenerateColumns)
            {
                OcultarColumnasInnecesarias();
            }
        }

        private void textBoxHoBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxHoBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                dgvSelector.DataSource = _listaOriginal;
            }
            else
            {
                var filtrados = _listaOriginal.Where(item =>
                    item.GetType().GetProperties().Any(p =>
                        p.GetValue(item)?.ToString().ToLower().Contains(busqueda) == true
                    )
                ).ToList();

                dgvSelector.DataSource = filtrados;
            }
        }

        private void OcultarColumnasInnecesarias()
        {
            string[] ocultar = { "Id", "Password", "Token", "Activo", "IdServicio", "IdGrupo" };
            foreach (string col in ocultar)
            {
                if (dgvSelector.Columns.Contains(col))
                    dgvSelector.Columns[col].Visible = false;
            }
        }

        private void dgvSelector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItemSeleccionado = dgvSelector.Rows[e.RowIndex].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}