using Cafeteria.Business;
using Cafeteria.Repository.Context;

namespace Cafeteria.Repository.Repositorios
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
