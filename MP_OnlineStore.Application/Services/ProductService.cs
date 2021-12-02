using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.Application.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using MP_OnlineStore.Core.Interfaces;

namespace MP_OnlineStore.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task CreateAsync(ProductDto product)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int productId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAsync(int categoryId)
        {
            var products = await _unitOfWork.ProductsRepository.GetAsync( p => p.CategoryId == categoryId);
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<IEnumerable<ProductDto>> GetAsync()
        {
            var products = await _unitOfWork.ProductsRepository.GetAsync(includeProperties:"Category");
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public Task UpdateAsync(ProductDto product)
        {
            throw new System.NotImplementedException();
        }
    }
}