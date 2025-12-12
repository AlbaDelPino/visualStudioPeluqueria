using Newtonsoft.Json;
using NodaTime;
using ServiciosInfo.Models;
using UsersInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasInfo.Models
{
    public class CitaDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("fecha")]
        public LocalDate Fecha { get; set; }

        [JsonProperty("estado")]
        public long Estado { get; set; }

        [JsonProperty("horarioSemanal")]
        public HorarioSemanalDto Horario { get; set; }

        [JsonProperty("users")]
        public UsersDto Cliente { get; set; }
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

        [JsonProperty("users")]
        public UsersDto Grupo { get; set; }

    }
}
