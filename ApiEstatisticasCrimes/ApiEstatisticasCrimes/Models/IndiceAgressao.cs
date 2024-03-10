namespace ApiEstatisticasCrimes.Models
{
    public class IndiceAgressao
    {
        public int IndiceAgressaoId { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public DateTime DataAgendamento { get; set; }

        public double IndiceAgressaoValor { get; set; }

        public int ZonaId { get; set; }

        public Zona? Zona { get; set; }
    }
}
