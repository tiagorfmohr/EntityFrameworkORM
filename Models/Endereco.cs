using System.ComponentModel.DataAnnotations.Schema;

namespace Trento.Models
{
    public enum UF
    {
        AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO
    }
    public class Endereco
    {
        public int Id { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        public UF UF { get; set; }
        public string Pais { get; set; } = "Brasil";

        public string? CEP { get; set; }

        public long ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente{ get; set; }

    }
}