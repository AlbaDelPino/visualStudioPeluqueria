using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class PanelServicios : Form
    {
        private readonly string _token;
        private static int pagSer;
        private static int contador = 1;
        public PanelServicios(string token)
        {
            InitializeComponent();
            _token = token;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dataGridViewServicios.ReadOnly = true;
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecargarServicios();

        }




        private void ModificarServicio(ServicioDto servicio)
        {

            Servicio pantallaModificar = new Servicio(servicio, _token);
            pantallaModificar.Form = "Modificar información de " + servicio.Nombre;
            pantallaModificar.LabelTituoCrearServicio = "MODIFICAR SERVICIO";
            pantallaModificar.buttonSerModificar = true;
            pantallaModificar.buttonSerAnyadir = false;

            pantallaModificar.TboxNombreServicio.Text = servicio.Nombre;
            pantallaModificar.TxtBoxDescripcion.Text = servicio.Descripcion;
            pantallaModificar.TextBoxPrecio.Text = servicio.Precio.ToString();
            pantallaModificar.TextBoxDuracion.Text = servicio.Duracion.ToString();
            pantallaModificar.ComboTipoServicio.SelectedIndex = Convert.ToInt32(servicio.TipoServicio?.Id - 1);

            if (pantallaModificar.ShowDialog() == DialogResult.OK)
            {
                RecargarServicios();
            }
        }


        private void EliminarServicio(ServicioDto servicio)
        {
            var confirmResult = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el servicio \"{servicio.Nombre}\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        var url = $"http://localhost:8082/servicio/{servicio.Id_Servicio}";
                        var request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "DELETE";
                        request.ContentType = "application/json";
                        request.Accept = "application/json";
                        request.Headers["Authorization"] = $"Bearer {_token}";

                        using (var response = (HttpWebResponse)request.GetResponse())
                        {
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                MessageBox.Show("Servicio eliminado correctamente", "Éxito",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refrescar la tabla
                                RecargarServicios();
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar: {response.StatusCode}", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error en la eliminación: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void anyadirServicio_Click(object sender, EventArgs e)
        {
            Servicio pantallaAnyadir = new Servicio(null, _token);
            pantallaAnyadir.Form = "Añadir servicio nuevo";
            pantallaAnyadir.LabelTituoCrearServicio = "AÑADIR SERVICIO";
            pantallaAnyadir.buttonSerModificar = false;
            pantallaAnyadir.buttonSerAnyadir = true;

            pantallaAnyadir.TboxNombreServicio.Text = "";
            pantallaAnyadir.TxtBoxDescripcion.Text = "";
            pantallaAnyadir.TextBoxPrecio.Text = "";
            pantallaAnyadir.TextBoxDuracion.Text = "";
            pantallaAnyadir.ComboTipoServicio.SelectedItem = "";

            if (pantallaAnyadir.ShowDialog() == DialogResult.OK)
            {
                RecargarServicios();
            }
        }


        private List<ServicioDto> ObtenerServicios()
        {

            var url = "http://localhost:8082/servicio";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            // Aquí añadimos el token
            request.Headers["Authorization"] = $"Bearer {_token}";

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                var servicios = JsonConvert.DeserializeObject<List<ServicioDto>>(json);
                return servicios;
            }
        }


        private void RecargarServicios()
        {
            var servicios = ObtenerServicios();

            dataGridViewServicios.Rows.Clear();

            var tope = 0;
            if (servicios.Count - ((contador - 1) * 20) < 20)
            {
                tope = ((contador - 1) * 20) + (servicios.Count - ((contador - 1) * 20)) - 1;
            }
            else
            {
                tope = contador * 20;
            }

            for (int i = (contador - 1) * 20; i <= tope; i++)
            {
                var precio = servicios[i].Precio.ToString() + " €";
                var duracion = servicios[i].Duracion.ToString() + " minutos";
                int index = dataGridViewServicios.Rows.Add(
                    servicios[i].Nombre,
                    servicios[i].Descripcion,
                    duracion,
                    precio,
                    servicios[i].TipoServicio?.Nombre

                );

                dataGridViewServicios.Rows[index].Tag = servicios[i];
            }

            labelNumServicios.Text = $" {servicios.Count}";
            labelNumTipoSer.Text = (comboBoxSerFiltrar.Items.Count - 1).ToString();

           
        }


        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 4) return;

            // Validar que la fila existe
            if (e.RowIndex >= dataGridViewServicios.Rows.Count) return;

            var fila = dataGridViewServicios.Rows[e.RowIndex];
            var servicio = fila.Tag as ServicioDto;
            if (servicio == null) return;

            var columna = dataGridViewServicios.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnModificar")
            {
                ModificarServicio(servicio);
            }
            else if (columna == "dataGridViewImageColumnEliminar")
            {
                EliminarServicio(servicio);
            }

        }

        private void filtrarServicios()
        {
            string texto = textBoxSerBuscar.Text.Trim().ToLower();
            string categoria = comboBoxSerFiltrar.SelectedItem?.ToString();

            var servicios = ObtenerServicios();
            if (servicios == null) return;

            var listaFiltrada = servicios.AsEnumerable();

            // --- FILTRO POR TEXTO ---
            if (!string.IsNullOrEmpty(texto))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    (s.Nombre != null && s.Nombre.ToLower().Contains(texto)) ||
                    (s.Descripcion != null && s.Descripcion.ToLower().Contains(texto))
                );
            }

            // --- FILTRO POR CATEGORÍA ---
            if (!string.IsNullOrEmpty(categoria))
            {
                listaFiltrada = listaFiltrada.Where(s =>
                    s.TipoServicio != null &&
                    s.TipoServicio.Nombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)
                );
            }

            // Limpiar tabla
            dataGridViewServicios.Rows.Clear();

            // Rellenar con los resultados
            foreach (var s in listaFiltrada)
            {
                var precio = s.Precio + " €";
                var duracion = s.Duracion + " minutos";

                int index = dataGridViewServicios.Rows.Add(
                    s.Nombre,
                    s.Descripcion,
                    duracion,
                    precio,
                    s.TipoServicio?.Nombre
                );

                dataGridViewServicios.Rows[index].Tag = s;
            }
        }

        private void comboBoxSerFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }


        private void textBoxSerBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarServicios();
        }
        private void PanelServicios_Load(object sender, EventArgs e)
        {

        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            var servicios = ObtenerServicios();
            if (servicios.Count % 20 != 0)
            {
                pagSer = (servicios.Count / 20) + 1;
            }
            else
            {
                pagSer = (servicios.Count / 20);
            }

            if (contador > 1)
            {
                contador--;
                RecargarServicios();
                if (contador != pagSer)
                {
                    buttonPaginacionDelante.ForeColor = Color.Black;
                }
                if (contador == 1) { buttonPaginacionAtras.ForeColor = Color.Silver; }
            }
        }

        private void buttonPaginacionDelante_Click(object sender, EventArgs e)
        {
            var servicios = ObtenerServicios();
            if (servicios.Count % 20 != 0)
            {
                pagSer = (servicios.Count / 20) + 1;
            }
            else
            {
                pagSer = (servicios.Count / 20);
            }

            if (contador < pagSer)
            {
                contador++;
                RecargarServicios();

                if (contador != 1)
                {
                    buttonPaginacionAtras.ForeColor = Color.Black;
                }
                if (contador == pagSer)
                {
                    buttonPaginacionDelante.ForeColor = Color.Silver;
                }
            }
        }
    }
}
