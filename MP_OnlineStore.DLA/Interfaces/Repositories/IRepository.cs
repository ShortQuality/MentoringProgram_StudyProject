using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MP_OnlineStore.DAL.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        Task AddAsync(T category);
        Task<T> FirstOrDefaultAsync(int id);
        Task<List<T>> ListAllAsync();
        Task UpdateAsync(T category);
        Task DeleteAsync(T category);
    }
}