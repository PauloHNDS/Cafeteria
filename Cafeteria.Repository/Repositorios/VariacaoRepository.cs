using Cafeteria.Business;
using Cafeteria.Repository.Context;

namespace Cafeteria.Repository.Repositorios
{
    public class VariacaoRepository : BaseRepository<Variacao>
    {
        public VariacaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
