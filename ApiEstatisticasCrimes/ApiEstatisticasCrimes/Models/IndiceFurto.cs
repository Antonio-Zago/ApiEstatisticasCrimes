namespace ApiEstatisticasCrimes.Models
{
    public class IndiceFurto
    {
        public int IndiceFurtoId { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public DateTime DataAgendamento { get; set; }

        public double IndiceFurtoValor { get; set; }

        public int ZonaId { get; set; }

        public Zona? Zona { get; set; }
    }
}
