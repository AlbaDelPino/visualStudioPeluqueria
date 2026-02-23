using CitasInfo.Models;
using ServiciosInfo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersInfo.Models;

namespace WinFormsApp1
{
    public partial class Busqueda : Form
    {
        public object ItemSeleccionado { get; set; }
        public List<HorarioSemanalDto> ItemsSeleccionados { get; set; }

        private List<ServicioDto> _listaServicios;
        private List<UsersDto> _listaGrupos;
        private List<UsersDto> _listaClientes;
        private List<HorarioSemanalDto> _listaHorarios;
        private List<object> _listaOriginal;
        private Type _tipoLista;

        public Busqueda(string titulo, object listaParaMostrar)
        {
            InitializeComponent();
            this.Text = titulo;

            _listaOriginal = ((IEnumerable)listaParaMostrar).Cast<object>().ToList();
            ConfigurarColumnasIniciales();
            ItemsSeleccionados = new List<HorarioSemanalDto>();
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
                    }
                    else if (u.Role.Equals("ROLE_CLIENTE"))
                    {
                        _listaClientes = listaUsuarios.ToList();
                        _tipoLista = typeof(ClienteDto);
                        TablaClientes();
                        break;
                    }
                }
            }
            else if (listaParaMostrar is IEnumerable<HorarioSemanalDto> listaHorarios)
            {
                _listaHorarios = listaHorarios.ToList();
                _tipoLista = typeof(HorarioSemanalDto);
                TablaHorarios();
            }

            Tabla.ReadOnly = true;
            Tabla.AllowUserToAddRows = false;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.RowHeadersVisible = false;

            Tabla.CellDoubleClick += Tabla_CellDoubleClick;

            textBoxBuscar.TextChanged += textBoxHoBuscar_TextChanged;
        }

        public Busqueda(string titulo, object listaParaMostrar, BloqueoHorarioDto bloqueo)
        {
            InitializeComponent();
            this.Text = titulo;

            _listaOriginal = ((IEnumerable)listaParaMostrar).Cast<object>().ToList();
            ConfigurarColumnasIniciales();
            ItemsSeleccionados = new List<HorarioSemanalDto>();

            if (listaParaMostrar is IEnumerable<HorarioSemanalDto> listaHorarios)
            {
                _listaHorarios = listaHorarios.ToList();
                foreach (HorarioSemanalDto h in bloqueo.Horarios)
                {
                    foreach (HorarioSemanalDto o in _listaHorarios)
                    {
                        if (h.Id == o.Id)
                        {
                            ItemsSeleccionados.Add(o);
                        }
                    }
                }
                _tipoLista = typeof(HorarioSemanalDto);
                TablaHorarios();
            }


            Tabla.ReadOnly = true;
            Tabla.AllowUserToAddRows = false;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.RowHeadersVisible = false;

            textBoxBuscar.TextChanged += textBoxHoBuscar_TextChanged;
        }
        



        private void ConfigurarColumnasIniciales()
        {
            Tabla.Columns.Clear();
        }

        private void textBoxHoBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                Tabla.Rows.Clear();

                if (_tipoLista == typeof(ServicioDto) && _listaServicios != null)
                {
                    TablaServicios();
                }
                else if (_tipoLista == typeof(GrupoDto) && _listaGrupos != null)
                {
                    TablaGrupos();
                }
                else if (_tipoLista == typeof(ClienteDto) && _listaClientes != null)
                {
                    TablaClientes();
                }
                else if (_tipoLista == typeof(HorarioSemanalDto) && _listaHorarios != null)
                {
                    TablaHorarios();
                }
            }
            else
            {
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
                else if (_tipoLista == typeof(HorarioSemanalDto) && _listaHorarios != null)
                {
                    var filtrados = _listaHorarios.Where(h =>
                        (h.Servicio?.Nombre.ToLower().Contains(busqueda) == true) ||
                        (h.Servicio?.TipoServicio.Nombre.ToLower().Contains(busqueda) == true) ||
                        (h.Grupo?.Curso.ToLower().Contains(busqueda) == true)
                    ).ToList();

                    foreach (var h in filtrados)
                    {
                        string inicioHora = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                        string finHora = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);
                        bool seleccionado = ItemsSeleccionados.Any(o => h.Id == o.Id);
                        int index = Tabla.Rows.Add(
                            seleccionado,
                                    h.DiaSemana,
                            inicioHora + " - " + finHora,
                            h.Servicio?.Nombre ?? "Sin Servicio",
                            h.Grupo?.Curso ?? "Sin Grupo"
                        );
                        Tabla.Rows[index].Tag = h;
                    }
                }
            }
        }

        private void Tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((_tipoLista == typeof(ClienteDto) && _listaClientes != null) || (_tipoLista == typeof(GrupoDto) && _listaGrupos != null) || (_tipoLista == typeof(ServicioDto) && _listaServicios != null))
            {
                if (e.RowIndex >= 0)
                {
                    ItemSeleccionado = Tabla.Rows[e.RowIndex].Tag;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void TablaServicios()
        {
            buttonSeleccionar.Visible = false;
            buttonTodoDia.Visible = false;
            Tabla.Columns.Clear();

            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Descripcion", "Descripción");
            Tabla.Columns.Add("Duracion", "Duración");
            Tabla.Columns.Add("Precio", "Precio");
            Tabla.Columns.Add("TipoServicio", "Tipo de Servicio");

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
            buttonSeleccionar.Visible = false;
            buttonTodoDia.Visible = false;
            Tabla.Columns.Clear();

            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Username", "Usuario");
            Tabla.Columns.Add("Estado", "Estado");

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
            buttonSeleccionar.Visible = false;
            buttonTodoDia.Visible = false;
            Tabla.Columns.Clear();

            Tabla.Columns.Add("Nombre", "Nombre");
            Tabla.Columns.Add("Username", "Usuario");
            Tabla.Columns.Add("Email", "Email");
            Tabla.Columns.Add("Estado", "Estado");

            Tabla.Rows.Clear();

            foreach (var u in _listaClientes)
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

        private void TablaHorarios()
        {
            buttonSeleccionar.Visible = true;
            buttonTodoDia.Visible = true;
            Tabla.Columns.Clear();

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Seleccionado";
            checkColumn.HeaderText = "Seleccionado";
            checkColumn.ReadOnly = false;

            Tabla.Columns.Add(checkColumn);
            Tabla.Columns.Add("diaSemana", "Dia de la semana");
            Tabla.Columns.Add("hora", "Hora");
            Tabla.Columns.Add("servicio", "Servicio");
            Tabla.Columns.Add("grupo", "Grupo");

            Tabla.Rows.Clear();

            foreach (var h in _listaHorarios)
            {
                string inicioHora = h.HoraInicio.ToString("HH:mm", CultureInfo.InvariantCulture);
                string finHora = h.HoraFin.ToString("HH:mm", CultureInfo.InvariantCulture);
                bool seleccionado = ItemsSeleccionados.Any(o => h.Id == o.Id);
                int index = Tabla.Rows.Add(
                    seleccionado,
                    h.DiaSemana,
                    inicioHora + " - " + finHora,
                    h.Servicio?.Nombre ?? "Sin Servicio",
                    h.Grupo?.Curso ?? "Sin Grupo"
                );
                Tabla.Rows[index].Tag = h;
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonTodoDia_Click(object sender, EventArgs e)
        {
            ItemsSeleccionados = _listaHorarios;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_tipoLista == typeof(HorarioSemanalDto) && _listaHorarios != null)
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    var columna = Tabla.Columns[e.ColumnIndex].Name;
                    var row = Tabla.Rows[e.RowIndex];

                    if (columna == "Seleccionado")
                    {
                        if ((bool)row.Cells[0].Value == true)
                        {
                            ItemsSeleccionados.Remove(_listaHorarios[e.RowIndex]);
                            TablaHorarios();
                            Tabla.ClearSelection();
                            Tabla.Rows[e.RowIndex].Selected = true;
                        }
                        else if ((bool)row.Cells[0].Value == false)
                        {
                            ItemsSeleccionados.Add(_listaHorarios[e.RowIndex]);
                            TablaHorarios();
                            Tabla.ClearSelection();
                            Tabla.Rows[e.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        
    }
}