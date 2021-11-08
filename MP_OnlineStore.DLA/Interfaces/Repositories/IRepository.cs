using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MP_OnlineStore.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void AddAsync(TEntity entity);
        ValueTask<TEntity> FirstOrDefaultAsync(int id);
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}