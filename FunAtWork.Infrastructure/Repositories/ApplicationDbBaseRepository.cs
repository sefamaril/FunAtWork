using FunAtWork.Core.Repositories;
using FunAtWork.Infrastructure.FunAtWorkDb;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FunAtWork.Infrastructure.Repositories
{
    public class ApplicationDbBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly DbSet<TEntity> _dbSet;
        public ApplicationDbBaseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbSet = _applicationDbContext.Set<TEntity>();
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(FindOptions? findOptions = null)
        {
            var query = _dbSet.AsQueryable();
            if (findOptions != null)
            {
                if (findOptions.IsIgnoreAutoIncludes)
                    query = query.IgnoreAutoIncludes();

                if (findOptions.IsAsNoTracking)
                    query = query.AsNoTracking();
            }

            return await Task.FromResult(query);
        }

        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null)
        {
            var query = _dbSet.Where(predicate).AsQueryable();

            if (findOptions != null)
            {
                if (findOptions.IsIgnoreAutoIncludes)
                    query = query.IgnoreAutoIncludes();

                if (findOptions.IsAsNoTracking)
                    query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null)
        {
            var query = _dbSet.Where(predicate).AsQueryable();

            if (findOptions != null)
            {
                if (findOptions.IsIgnoreAutoIncludes)
                    query = query.IgnoreAutoIncludes();

                if (findOptions.IsAsNoTracking)
                    query = query.AsNoTracking();
            }

            return await Task.FromResult(query);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task AddManyAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entitiesToRemove = await _dbSet.Where(predicate).ToListAsync();
            _dbSet.RemoveRange(entitiesToRemove);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }
    }
}