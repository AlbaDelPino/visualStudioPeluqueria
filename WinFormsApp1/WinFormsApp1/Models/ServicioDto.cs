using Newtonsoft.Json;

namespace ServiciosInfo.Models
{
    public class TipoServicioDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }

    public class ServicioDto
    {
        [JsonProperty("id_servicio")]
        public long Id_Servicio { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("precio")]
        public long Precio { get; set; }   // 👈 long

        [JsonProperty("duracion")]
        public long Duracion { get; set; } // 👈 long

        [JsonProperty("tipoServicio")]
        public TipoServicioDto TipoServicio { get; set; }
    }

}
