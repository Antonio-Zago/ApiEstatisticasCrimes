namespace ApiEstatisticasCrimes.Models
{
    public class Ocorrencia
    {
        public int OcorrenciaId { get; set; }

        public string? Descricao { get; set; }

        public DateTime DataHora { get; set; }

        public bool CadastrouBoletimOcorrencia { get; set; }

        public TipoOcorrencia TipoOcorrencia { get; set; }

        public Assalto? Assalto { get; set; }

        public Roubo? Roubo { get; set; }

        public int LocalizacaoOcorrenciaId { get; set; }

        public LocalizacaoOcorrencia? LocalizacaoOcorrencia { get; set; }

    }
}
