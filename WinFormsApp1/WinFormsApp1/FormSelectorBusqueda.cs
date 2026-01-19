using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormSelectorBusqueda : Form
    {
        public object ItemSeleccionado { get; set; }

        // Variable para guardar la lista original y poder filtrar
        private List<object> _listaOriginal;

        public FormSelectorBusqueda(string titulo, object listaParaMostrar)
        {
            InitializeComponent();
            this.Text = titulo;

            // Convertimos el 'object' que recibimos en una lista real para poder usar LINQ
            _listaOriginal = ((IEnumerable)listaParaMostrar).Cast<object>().ToList();

            // 1. Asignamos la lista
            dgvSelector.DataSource = _listaOriginal;

            // 2. Limpiamos columnas
            OcultarColumnasInnecesarias();

            // 3. Estética profesional
            dgvSelector.ReadOnly = true;
            dgvSelector.AllowUserToAddRows = false;
            dgvSelector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelector.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelector.RowHeadersVisible = false;

            // 4. Suscribir eventos
            dgvSelector.CellDoubleClick += dgvSelector_CellDoubleClick;

            // Suscribimos el evento de búsqueda de tu TextBox
            textBoxHoBuscar.TextChanged += textBoxHoBuscar_TextChanged;
        }

        private void textBoxHoBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxHoBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                // Si borra el texto, mostramos la lista completa original
                dgvSelector.DataSource = _listaOriginal;
            }
            else
            {
                // Filtramos buscando en todas las propiedades visibles del objeto
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
            string[] columnasAOcultar = { "Id", "IdServicio", "IdGrupo", "Descripcion", "Imagen", "Activo" };

            foreach (string nombre in columnasAOcultar)
            {
                if (dgvSelector.Columns.Contains(nombre))
                {
                    dgvSelector.Columns[nombre].Visible = false;
                }
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