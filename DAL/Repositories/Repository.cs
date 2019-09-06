using DAL.Data;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly SqlContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(SqlContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<T> Get(string id) => await _dbSet.FindAsync(id);

        public async Task<T> Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity) {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return await _dbSet.FindAsync(entity.Id);
        }

        public async Task<bool> Delete(string id)
        {
            T entityToDelete = await _dbSet.FindAsync(id);

            try
            {
                _dbSet.Remove(entityToDelete);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
