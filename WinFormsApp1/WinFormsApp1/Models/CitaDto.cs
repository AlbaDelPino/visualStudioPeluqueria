using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using UsersInfo.Models;

namespace CitasInfo.Models
{
    public class CitaDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("fecha")]
        public LocalDate Fecha { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("tratamientos")]
        public string Tratamientos { get; set; }

        [JsonProperty("productos")]
        public string Productos { get; set; }

        [JsonProperty("observaciones")]
        public string Observaciones { get; set; }

        [JsonProperty("horario")]
        public HorarioSemanalDto Horario { get; set; }

        [JsonProperty("horaInicio")]
        public LocalTime HoraInicio { get; set; }

        [JsonProperty("cliente")]
        public UsersDto Cliente { get; set; }

        [JsonProperty("valoracion")]
        public ValoracionDto Valoracion { get; set; }

    }

    public class HorarioSemanalDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("diaSemana")]
        public string DiaSemana { get; set; }

        [JsonProperty("horaInicio")]
        public LocalTime HoraInicio { get; set; }

        [JsonProperty("horaFin")]
        public LocalTime HoraFin { get; set; }

        [JsonProperty("plazas")]
        public long Plazas { get; set; }

        [JsonProperty("servicio")]
        public ServicioDto Servicio { get; set; }

        [JsonProperty("grupo")]
        public GrupoDto Grupo { get; set; }

        [JsonProperty("bloqueoHorario")]
        public BloqueoHorarioDto Bloqueo { get; set; }
    }

    public class BloqueDto
    {
        public string Hora { get; set; }
        public int Plazas { get; set; }
        public HorarioSemanalDto Horario { get; set; } // El objeto que contiene el ID
    }


    public class BloqueoHorarioDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("fecha")]
        public LocalDate Fecha { get; set; }

        [JsonProperty("recurrente")]
        public bool Recurrente { get; set; }

        [JsonProperty("motivo")]
        public string Motivo { get; set; }

        [JsonProperty("horarios")]
        public List<HorarioSemanalDto> Horarios { get; set; }

    }
    public class ValoracionDto
    {
        [JsonProperty("id_valoracion")]
        public long Id { get; set; }

        [JsonProperty("comentario")]
        public string Comentario { get; set; }

        [JsonProperty("puntuacion")]
        public int Puntuacion { get; set; }

        [JsonProperty("trato")]
        public int Trato { get; set; }

        [JsonProperty("desarrollo")]
        public int Desarrollo { get; set; }

        [JsonProperty("comunicacion")]
        public int Comunicacion { get; set; }

        [JsonProperty("organizacion")]
        public int Organizacion { get; set; }

        [JsonProperty("imagen")]
        public byte[] Imagen { get; set; }
    }
}