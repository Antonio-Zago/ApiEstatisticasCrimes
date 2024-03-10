

namespace ApiEstatisticasCrimes.Models
{
    public class LocalizacaoOcorrencia
    {
        public int LocalizacaoOcorrenciaId { get; set; }

        public string? Cep { get; set; }

        public string? Latitude { get; set; }

        public string? Longitude { get; set; }

        public string? Cidade { get; set; }

        public string? Bairro { get; set; }

        public string? Rua { get; set; }

        public int Numero { get; set; }

        public IEnumerable<Ocorrencia>? Ocorrencias { get; set; }
    }
}
