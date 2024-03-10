

namespace ApiEstatisticasCrimes.Models
{
    public class Roubo : TipoOcorrenciaBase
    {
        public int RouboId { get; set; }

        public int OcorrenciaId { get; set; }
        public Ocorrencia? Ocorrencia { get; set; }

        public IEnumerable<TipoBem>? TipoBens { get; set; }

    }
}
