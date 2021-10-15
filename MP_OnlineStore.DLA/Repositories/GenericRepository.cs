using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MP_OnlineStore.DAL.Interfaces.Repositories;

namespace MP_OnlineStore.DAL.Repositories
{
    // For Using generic repository it's needed to implement Base entity
    public class GenericRepository<T> : IRepository<T>
    {
        protected readonly NorthwindContext _dbContext;

        public GenericRepository(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(T category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T category)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefaultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T category)
        {
            throw new NotImplementedException();
        }
    }
}
