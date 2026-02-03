using Newtonsoft.Json;
using ServiciosInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Models
{
    public class GaleriaDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("servicio")]
        public ServicioDto Servicio { get; set; }

        [JsonProperty("datos")] // "datos" es el nombre que viene del longtext en Java
        public string ImagenBase64 { get; set; } // Tu campo longtext

    }
}
