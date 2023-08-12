using Cafeteria.Business;
using Cafeteria.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Repository.Repositorios
{
    public class CategoriaRepository
    {
        private readonly Contexto _contexto;
        
        public CategoriaRepository(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public virtual async  Task<List<Categoria>> Get()
        {
            return await _contexto.Categorias.OrderBy(x => x.Id).ToListAsync();
        }

        public virtual async Task<Categoria?> Get(int Id)
        {
            return await _contexto.Categorias.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public virtual async Task Delete(int Id)
        {
            var categoria = await _contexto.Categorias.FirstOrDefaultAsync(x => x.Id == Id);

            if (categoria is not null)
            {
                _contexto.Categorias.Remove(categoria);
            }

        }

        public virtual void Update(Categoria categoria)
        {
            _contexto.Entry(categoria);
        }
       

    }
}
