using ServiciosInfo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;
using CitasInfo.Models;

namespace WinFormsApp1
{
    public partial class Busqueda : Form
    {
        public object ItemSeleccionado { get; set; }

        // Variables para guardar las listas
        private List<ServicioDto> _listaServicios;
        private List<UsersDto> _listaGrupos;
        private List<UsersDto> _listaClientes;
        private List<HorarioSemanalDto> _listaHorarios;
        private List<object> _listaOriginal;
        private Type _tipoLista; // Para saber qué tipo de lista estamos manejando

        public Busqueda(string titulo, object listaParaMostrar)
        {
            InitializeComponent();
            this.Text = titulo;

            _listaOriginal = ((IEnumerable)listaParaMostrar).Cast<object>().ToList();
            
            // Primero, configurar las columnas del DataGridView
            ConfigurarColumnasIniciales();
            
            // Convertimos el 'object' que recibimos en una lista real para poder usar LINQ
            if (listaParaMostrar is IEnumerable<ServicioDto> listaServicios)
            {
                _listaServicios = listaServicios.ToList();
                _tipoLista = typeof(ServicioDto);
                TablaServicios();
            }
            else if (listaParaMostrar is IEnumerable<UsersDto> listaUsuarios)
            {
                foreach (UsersDto u in listaUsuarios)
                {
                    if (u.Role.Equals("ROLE_GRUPO"))
                    {
                        _listaGrupos = listaUsuarios.ToList();
                        _tipoLista = typeof(GrupoDto);
                        TablaGrupos();
                        break;
                    } else if (u.Role.Equals("ROLE_CLIENTE"))
                    {
                        _listaClientes = listaUsuarios.ToList();
                        _tipoLista = typeof(ClienteDto);
                        TablaClientes();
                        break;
                    }
                }
                
            }

            // Estética profesional
            Tabla.ReadOnly = true;
            Tabla.AllowUserToAddRows = false;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.RowHeadersVisible = false;

            // Suscribir eventos
            Tabla.CellDoubleClick += Tabla_CellDoubleClick;

            // Suscribimos el evento de búsqueda de tu TextBox
            textBoxHoBuscar.TextChanged += textBoxHoBuscar_TextChanged;
        }

        private void ConfigurarColumnasIniciales()
        {
            Tabla.Columns.Clear();
            
            // Podemos detectar el tipo aquí o configurar columnas vacías inicialmente
            // Luego se configurarán en TablaServicios() o TablaGrupos()
        }

        private void textBoxHoBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxHoBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                // Si borra el texto, mostramos la lista completa original
                Tabla.Rows.Clear();
                
                if (_tipoLista == typeof(ServicioDto) && _listaServicios != null)
                {
                    TablaServicios();
                }
                else if (_tipoLista == typeof(GrupoDto) && _listaGrupos != null)
                {
                    TablaGrupos();
                }
                else if (_tipoLista == typeof(ClienteDto) && _listaGrupos != null)
                {
                    TablaClientes();
                }
            }
            else
            {
                // Filtramos según el tipo
                Tabla.Rows.Clear();
                
                if (_tipoLista == typeof(ServicioDto) && _listaServicios != null)
                {
                    var filtrados = _listaServicios.Where(s =>
                        (s.Nombre?.ToLower().Contains(busqueda) == true) ||
                        (s.Descripcion?.ToLower().Contains(busqueda) == true) ||
                        (s.TipoServicio?.Nombre?.ToLower().Contains(busqueda) == true) ||
                        (s.Precio.ToString().Contains(busqueda)) ||
                        (s.Duracion.ToString().Contains(busqueda))
                    ).ToList();
                    
                    foreach (var s in filtrados)
                    {
                        var precio = s.Precio.ToString() + " €";
                        var duracion = s.Duracion.ToString() + " minutos";
                        int index = Tabla.Rows.Add(
                            s.Nombre,
                            s.Descripcion,
                            duracion,
                            precio,
                            s.TipoServicio?.Nombre
                        );
                        Tabla.Rows[index].Tag = s;
                    }
                }
                else if (_tipoLista == typeof(GrupoDto) && _listaGrupos != null)
                {
                    var filtrados = _listaGrupos.Where(u =>
                        (u.Nombre?.ToLower().Contains(busqueda) == true) ||
                        (u.Username?.ToLower().Contains(busqueda) == true) ||
                        (u.Estado?.ToLower().Contains(busqueda) == true)
                    ).ToList();
                    
                    foreach (var u in filtrados)
                    {
                        string estado = u.Estado?.Equals("true", StringComparison.OrdinalIgnoreCase) == true 
                            ? "Activo" 
                            : "Inactivo";
                            
                        int index = Tabla.Rows.Add(
                            u.Nombre,
                            u.Username,
                            estado
                        );
                        Tabla.Rows[index].Tag = u;
                    }
                }
                else if (_tipoLista == typeof(ClienteDto) && _listaClientes != null)
                {
                    var filtrados = _listaClientes.Where(u =>
                        (u.Nombre?.ToLower().Contains(busqueda) == true) ||
                        (u.Username?.ToLower().Contains(busqueda) == true) ||
                        (u.Estado?.ToLower().Contains(busqueda) == true) ||
                        (u.Email?.ToLower().Contains(busqueda) == true)
                    ).ToList();

                    foreach (var u in filtrados)
                    {
                        string estado = u.Estado?.Equals("true", StringComparison.OrdinalIgnoreCase) == true
                            ? "Activo"
                            : "Inactivo";

                        int index = Tabla.Rows.Add(
                            u.Nombre,
                            u.Username,
                            u.Email,
                            estado
                        );
                        Tabla.Rows[index].Tag = u;
                    }
                }
            }
        }

        private void Tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItemSeleccionado = Tabla.Rows[e.RowIndex].Tag;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TablaServicios()
        {
            // Configurar columnas para Servicios
            Tabla.Columns.Clear();
            
            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Descripcion", "Descripción");
            Tabla.Columns.Add("Duracion", "Duración");
            Tabla.Columns.Add("Precio", "Precio");
            Tabla.Columns.Add("TipoServicio", "Tipo de Servicio");
            
            // Limpiar filas existentes
            Tabla.Rows.Clear();
            
            foreach (var s in _listaServicios)
            {
                var precio = s.Precio.ToString() + " €";
                var duracion = s.Duracion.ToString() + " minutos";
                int index = Tabla.Rows.Add(
                    s.Nombre,
                    s.Descripcion,
                    duracion,
                    precio,
                    s.TipoServicio?.Nombre
                );

                Tabla.Rows[index].Tag = s;
            }
        }
        
        private void TablaGrupos()
        {
            // Configurar columnas para Grupos/Usuarios
            Tabla.Columns.Clear();
            
            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Username", "Usuario");
            Tabla.Columns.Add("Estado", "Estado");
            
            // Limpiar filas existentes
            Tabla.Rows.Clear();
            
            foreach (var u in _listaGrupos)
            {
                string estado = u.Estado?.Equals("true", StringComparison.OrdinalIgnoreCase) == true 
                    ? "Activo" 
                    : "Inactivo";

                int index = Tabla.Rows.Add(
                    u.Nombre,
                    u.Username,
                    estado
                );

                Tabla.Rows[index].Tag = u;
            }
        }
        private void TablaClientes()
        {
            // Configurar columnas para Grupos/Usuarios
            Tabla.Columns.Clear();

            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Username", "Usuario");
            Tabla.Columns.Add("Email", "Email");
            Tabla.Columns.Add("Estado", "Estado");

            // Limpiar filas existentes
            Tabla.Rows.Clear();

            foreach (var u in _listaClientes)
            {
                string estado = u.Estado?.Equals("true", StringComparison.OrdinalIgnoreCase) == true
                    ? "Activo"
                    : "Inactivo";

                int index = Tabla.Rows.Add(
                    u.Nombre,
                    u.Username,
                    u.Email, 
                    estado
                );

                Tabla.Rows[index].Tag = u;
            }
        }
    }
}