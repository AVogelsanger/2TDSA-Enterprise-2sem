namespace Fiap.NAC.Correcao.Models
{
    public class Bicicleta
    {
        public int BicicletaId { get; set; }
        public string Modelo { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}