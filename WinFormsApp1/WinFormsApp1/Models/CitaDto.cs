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

        [JsonProperty("horario")]
        public HorarioSemanalDto Horario { get; set; }

        [JsonProperty("cliente")] // En Java: private Cliente cliente;
        public UsersDto Cliente { get; set; }
    }

    public class HorarioSemanalDto
    {
        [JsonProperty("id")] // El error indica que Java busca 'id' o 'id_horario'
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

        [JsonProperty("grupo")] // Asegúrate que en Java el campo se llame 'grupo'
    public GrupoDto Grupo { get; set; }
    }

    public class HorarioBloqueDTO
    {
        public string Hora { get; set; }
        public int Plazas { get; set; }
        public HorarioSemanalDto HorarioObj { get; set; } // El objeto que contiene el ID
    }


}