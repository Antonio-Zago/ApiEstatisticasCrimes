namespace ApiEstatisticasCrimes.Models
{
    public class Agressao : TipoOcorrenciaBase
    {
        public int AgressaoId { get; set; }

        public int OcorrenciaId { get; set; }
        public Ocorrencia? Ocorrencia { get; set; }

    }
}
