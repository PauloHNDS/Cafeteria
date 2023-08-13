namespace Cafeteria.Business
{
    public class Alimento
    {
        public int Id { get; set; }

        public string Nome { get; set; } = String.Empty;

        public string Descricao { get; set; } = String.Empty;

        public decimal Valor { get; set; } = 0M;

        public int Categoria_Id { get; set; }

        public virtual Categoria? Categoria { get; set; }

        public virtual List<Variacao> Variacaos { get; set; } = new List<Variacao>();
    }
}
