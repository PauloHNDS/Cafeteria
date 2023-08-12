using Cafeteria.Business;
using Cafeteria.Repository.Context;

namespace Cafeteria.Repository.Repositorios
{
    public class AlimentoRepository : BaseRepository<Alimento>
    {
        public AlimentoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
