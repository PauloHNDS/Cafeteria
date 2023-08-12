namespace Cafeteria.Business
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; } = String.Empty;

        public string Imagem { get; set; } = String.Empty;

        public virtual List<Alimento> Alimentos { get; set; } = new List<Alimento>();
    }
}