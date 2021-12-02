using System.Collections.Generic;
using System.Threading.Tasks;
using MP_OnlineStore.Application.Data.Models;

namespace MP_OnlineStore.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryDto category);
        Task<IEnumerable<CategoryDto>> GetAsync(int categoryId);
        Task<IEnumerable<CategoryDto>> GetAsync();
        Task UpdateAsync(CategoryDto category);
        Task DeleteAsync(int categoryId);
    }
}