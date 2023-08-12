namespace Cafeteria.Business
{
    public class Variacao
    {
        public int Id { get; set; }

        public string Nome { get; set; } = String.Empty;

        public string Imagem { get; set; } = String.Empty;

        public Alimento? Alimento { get; set; } 
    }
}
