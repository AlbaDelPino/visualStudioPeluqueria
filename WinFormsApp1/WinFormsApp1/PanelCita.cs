using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CitasInfo.Models;
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
    public partial class PanelCita : Form
    {
        private readonly string _token;
        private static int pagSer;
        private static int contador = 1;
        private static List<CitaDto> _citas;

        public PanelCita(string token)
        {
            InitializeComponent();
            _token = token;
        }
        


        private void pasarPagina()
        {
            dataGridViewCitas.Rows.Clear();

            var tope = 0;
            if (_citas.Count - ((contador - 1) * 20) < 20)
            {
                tope = ((contador - 1) * 20) + (_citas.Count - ((contador - 1) * 20)) - 1;
            }
            else
            {
                tope = contador * 20;
            }

            for (int i = (contador - 1) * 20; i <= tope; i++)
            {
                var fecha = _citas[i].Horario.DiaSemana + " " + _citas[i].Fecha;
                var hora = _citas[i].Horario.HoraInicio + " - " + _citas[i].Horario.HoraFin;

                string estado = "";
                if (_citas[i].Estado.Equals("true"))
                {
                    estado = "Confirmada";
                }
                else if (_citas[i].Estado.Equals("false"))
                {
                    estado = "Cancelada";
                }

                int index = dataGridViewCitas.Rows.Add(
                    _citas[i].Cliente.Nombre,
                    _citas[i].Horario.Servicio.Nombre,
                    fecha,
                    hora,
                    estado,
                    _citas[i].Horario.Grupo.Nombre

                );

                dataGridViewCitas.Rows[index].Tag = _citas[i];
            }
        }
        private void dataGridViewCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 5) return;

            // Validar que la fila existe
            if (e.RowIndex >= dataGridViewCitas.Rows.Count) return;

            var fila = dataGridViewCitas.Rows[e.RowIndex];
            var servicio = fila.Tag as CitaDto;
            if (servicio == null) return;

            var columna = dataGridViewCitas.Columns[e.ColumnIndex].Name;

            if (columna == "dataGridViewImageColumnModificar")
            {
                //ModificarCitas(servicio);
            }
            else if (columna == "dataGridViewImageColumnEliminar")
            {
                //EliminarCitas(servicio);
            }
        }
    }
}
