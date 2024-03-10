using Microsoft.AspNetCore.Identity;

namespace ApiEstatisticasCrimes.Models
{
    public class TipoArma
    {
        public int TipoArmaId { get; set; }

        public string? Nome { get; set; }

        public bool ArmaFogo { get; set; }

        public IEnumerable<Assalto>? Assaltos { get; set; }
    }
}
