using Cafeteria.Business;
using Cafeteria.Repository.Context;

namespace Cafeteria.Repository.Repositorios
{
    public class ContatoRepository : BaseRepository<Contato>
    {
        public ContatoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
