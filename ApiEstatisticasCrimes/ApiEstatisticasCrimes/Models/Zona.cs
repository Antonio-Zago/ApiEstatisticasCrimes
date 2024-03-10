namespace ApiEstatisticasCrimes.Models
{
    public class Zona
    {
        public int ZonaId { get; set; }

        public string? LatitudeCentral { get; set; }

        public string? LongitudeCentral { get; set; }

        public double Raio { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<IndiceAssalto>? IndicesAssalto { get; set; }

        public IEnumerable<IndiceFurto>? IndicesFurto { get; set; }

        public IEnumerable<IndiceAgressao>? IndicesAgressao { get; set; }
    }
}
