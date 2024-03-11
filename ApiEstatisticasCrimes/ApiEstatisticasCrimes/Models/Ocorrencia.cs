using System.Text.Json.Serialization;

namespace ApiEstatisticasCrimes.Models
{
    public class Ocorrencia
    {
        public int OcorrenciaId { get; set; }

        public string? Descricao { get; set; }

        public DateTime DataHora { get; set; }

        public bool CadastrouBoletimOcorrencia { get; set; }

        public TipoOcorrencia TipoOcorrencia { get; set; }

        [JsonIgnore]
        public Assalto? Assalto { get; set; }

        [JsonIgnore]
        public Roubo? Roubo { get; set; }

        [JsonIgnore]
        public Agressao? Agressao { get; set; }

        public int LocalizacaoOcorrenciaId { get; set; }

        [JsonIgnore]
        public LocalizacaoOcorrencia? LocalizacaoOcorrencia { get; set; }

    }
}
