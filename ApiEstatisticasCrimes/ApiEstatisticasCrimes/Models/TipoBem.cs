namespace ApiEstatisticasCrimes.Models
{
    public class TipoBem
    {
        public int TipoBemId { get; set; }

        public string? Nome { get; set; }

        public IEnumerable<Assalto>? Assaltos { get; set; }

        public IEnumerable<Roubo>? Roubos { get; set; }
    }
}
