using Domain.Enum;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;


namespace Domain.Principal
{
    [JsonObject (MeberSerialization.OpIn)]
    public class ActivoFijo
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string CodigoActivo { get; set; }
        [JsonProperty]
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        [JsonProperty]
        public decimal ValorActivo { get; set; }
        [JsonProperty]
        public DateTime FechaAdquisicion { get; set; }
        [JsonProperty]
        public int VidaUtil { get; set; }
        [JsonProperty]
        public TipoActivoFijo tipoActivoFijo { get; set; }
        public MetodoDepreciacion metodoDepreciacion { get; set; }
    }
}
