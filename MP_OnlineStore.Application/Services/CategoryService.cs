using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.Application.Services.Interfaces;
using MP_OnlineStore.Core.Interfaces;

namespace MP_OnlineStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task CreateAsync(CategoryDto category)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAsync(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDto>> GetAsync()
        {
            var categories = await _unitOfWork.CategoriesRepository.GetAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public Task UpdateAsync(CategoryDto category)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}