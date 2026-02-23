using CitasInfo.Models;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO; // Imprescindible para MemoryStream
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Valoracion : Form
    {
        private readonly CitaDto _cita;
        private readonly ValoracionDto _valoracion;
        private List<TipoServicioDto> _tiposServicio;
        private readonly string _token;

        public Valoracion(ValoracionDto valoracion, string token)
        {
            InitializeComponent();
            this._valoracion = valoracion; // Corregido: eliminado el punto inicial
            this._token = token;

            // Suscribimos la carga de datos al evento Load
            this.Load += (s, e) => CargarDatos(_valoracion);
        }

        private void Valoracion_Load(object sender, EventArgs e)
        {
            // Espacio para lógica adicional al cargar el formulario
        }

        private void labelImagen_Click(object sender, EventArgs e)
        {
            // Lógica opcional para ampliar imagen
        }

        private void CargarDatos(ValoracionDto v)
        {
            if (v == null) return;

            // --- ENCABEZADO PRINCIPAL ---
            // Si tienes un Label de título arriba, podemos poner el resumen
            // labelTituloPrincipal.Text = $"Valoración: {v.Puntuacion}/5 - {v.Comentario}";

            // --- COMENTARIO (EL TRATO) ---
            richTextBoxComentario.Text = string.IsNullOrEmpty(v.Comentario) ? "Sin comentario" : v.Comentario;

            // --- PUNTUACIONES DETALLADAS ---
            // Aquí mapeamos cada nota a sus respectivos Labels (ajusta los nombres a los tuyos)

            labelGeneral.Text = $"{v.Puntuacion}/5"; // Puntuación general
            labelTrato.Text = $"{v.Trato}/5"; // Trato Personal
            labelDesarrollo.Text = $"{v.Desarrollo}/5"; // Desarrollo del servicio
            labelComunicacion.Text = $"{v.Comunicacion}/5"; // Claridad comunicación
            labelOrganizacion.Text = $"{v.Organizacion}/5"; // Limpieza y organización

            // --- IMAGEN ---
            if (v.Imagen != null && v.Imagen.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(v.Imagen))
                    {
                        pictureBoxResultado.Image = Image.FromStream(ms);
                        pictureBoxResultado.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                pictureBoxResultado.Visible = false;
                if (labelImagen != null) labelImagen.Text = "No se adjuntó imagen";
            }
        }

        private void Puntuacion_Click(object sender, EventArgs e)
        {

        }
    } // Cierre de la clase
} // Cierre del namespace