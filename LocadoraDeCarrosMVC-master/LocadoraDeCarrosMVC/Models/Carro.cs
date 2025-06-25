namespace LocadoraDeCarrosMVC.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public decimal PrecoDiaria { get; set; }
    }
}
