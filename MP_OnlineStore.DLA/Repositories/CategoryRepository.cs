using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MP_OnlineStore.DAL.Entities;
using MP_OnlineStore.DAL.Interfaces.Repositories;

namespace MP_OnlineStore.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly NorthwindContext _dbContext;

        public CategoryRepository(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Category> FirstOrDefaultAsync(int id)
        {
            return await _dbContext.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task<List<Category>> ListAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
