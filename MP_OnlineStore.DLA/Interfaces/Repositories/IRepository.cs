using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP_OnlineStore.DAL.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void AddAsync(TEntity entity);
        ValueTask<TEntity> FirstOrDefaultAsync(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}