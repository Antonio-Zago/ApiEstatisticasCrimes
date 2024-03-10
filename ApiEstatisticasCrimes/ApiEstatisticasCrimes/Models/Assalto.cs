namespace ApiEstatisticasCrimes.Models
{
    public class Assalto : TipoOcorrenciaBase
    {
        public int AssaltoId { get; set; }


        public int QuantidadeAgressores { get; set; }

        public bool EstavaArmado { get; set; }

        public int TipoArmaId { get; set; }

        public TipoArma? TipoArma { get; set; }

        public int OcorrenciaId { get; set; }
        public Ocorrencia? Ocorrencia { get; set; }

        public IEnumerable<TipoBem>? TipoBens { get; set; }


    }
}
