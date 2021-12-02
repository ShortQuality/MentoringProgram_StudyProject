using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MP_OnlineStore.Core.Interfaces.Repositories;

namespace MP_OnlineStore.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private DbSet<TEntity> _entities { get; }

        public GenericRepository(DbSet<TEntity> entities)
        {
            _entities = entities;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
           await _entities.AddAsync(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public virtual async Task<TEntity> FirstOrDefaultAsync(int id)
        {
           return await _entities.FindAsync(id);
        }

        public virtual void Update(TEntity entity)
        {
            _entities.Update(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }
    }
}