using Cafeteria.Business;
using Cafeteria.Repository.Context;

namespace Cafeteria.Repository.Repositorios
{
    public class EstruturaRepository : BaseRepository<Estrutura>
    {
        public EstruturaRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
