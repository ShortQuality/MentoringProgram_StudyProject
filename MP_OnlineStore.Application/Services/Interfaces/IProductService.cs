using System.Collections.Generic;
using System.Threading.Tasks;
using MP_OnlineStore.Application.Data.Models;

namespace MP_OnlineStore.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductDto product);
        Task<IEnumerable<ProductDto>> GetAsync(int categoryId);
        Task<IEnumerable<ProductDto>> GetAsync();
        Task UpdateAsync(ProductDto product);
        Task DeleteAsync(int productId);
    }
}