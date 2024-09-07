namespace Trento.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Endereco>? Enderecos { get; set; }
    }
}
