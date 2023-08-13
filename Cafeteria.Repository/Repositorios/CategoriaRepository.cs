using Cafeteria.Business;
using Cafeteria.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Repository.Repositorios
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public CategoriaRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
