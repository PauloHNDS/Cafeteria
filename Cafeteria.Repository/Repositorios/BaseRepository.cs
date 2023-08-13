
using Cafeteria.Business;
using Cafeteria.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Repository.Repositorios
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        private readonly Contexto _contexto;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(Contexto contexto)
        {
            _contexto = contexto;
            _dbSet = contexto.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> Get() => await _dbSet.ToListAsync();

        public virtual async Task Insert(TEntity entity) =>  await _dbSet.AddAsync(entity);
        
        public virtual async Task<TEntity?> Get(int Id) => await _dbSet.FindAsync(Id);

        public virtual async Task Delete(int Id)
        {
            var entity = await _dbSet.FindAsync(Id);

            if (entity is not null)
            {
                _dbSet.Remove(entity);
            }
        }

        public virtual void Update(TEntity entity) => _contexto.Entry(entity);

        public virtual async Task Persistir() => await _contexto.SaveChangesAsync();
    }
}
