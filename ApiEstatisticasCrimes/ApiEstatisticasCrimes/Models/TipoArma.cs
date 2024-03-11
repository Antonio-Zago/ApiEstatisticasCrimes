using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace ApiEstatisticasCrimes.Models
{
    public class TipoArma
    {
        public int TipoArmaId { get; set; }

        public string? Nome { get; set; }

        public bool ArmaFogo { get; set; }


        [JsonIgnore]
        public IEnumerable<Assalto>? Assaltos { get; set; }
    }
}
