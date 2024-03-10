namespace ApiEstatisticasCrimes.Models
{
    public class IndiceAssalto
    {
        public int IndiceAssaltoId { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public DateTime DataAgendamento { get; set; }

        public double IndiceAssaltoValor { get; set; }

        public int ZonaId { get; set; }

        public Zona? Zona { get; set; }
    }
}
