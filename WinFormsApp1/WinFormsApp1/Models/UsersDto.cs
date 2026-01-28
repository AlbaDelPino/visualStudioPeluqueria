using Newtonsoft.Json;
using ServiciosInfo.Models;


namespace UsersInfo.Models
{
    public class UsersDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("contrasenya")]
        public string Contrasenya { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefono")]
        public long Telefono { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }
    }

    public class AdminDto
    {
        [JsonProperty("especialidad")]
        public string Especialidad { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public class ClienteDto
    {
        [JsonProperty("alergenos")]
        public string Alergenos { get; set; }

        [JsonProperty("comentarioCitas")]
        public string Comentario { get; set; }

        [JsonProperty("observacion")]
        public string Observacion { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imagen")]
        public byte[] Imagen { get; set; }
    }

    public class GrupoDto
    {
        [JsonProperty("curso")]
        public string Curso { get; set; }

        [JsonProperty("turno")]
        public string Turno { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

       
    }
}
