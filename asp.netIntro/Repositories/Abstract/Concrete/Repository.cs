using System.Linq.Expressions;
using asp.netIntro.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.netIntro.Repositories.Abstract.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();  
        }
        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Remove(entity);
            });
            
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Update(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Update(entity);
            });
            _context.SaveChanges();
        }
    }

}

