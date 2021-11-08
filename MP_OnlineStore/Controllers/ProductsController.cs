using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.Core.Entities;
using MP_OnlineStore.Core.Interfaces;
using MP_OnlineStore.WEB.ViewModels;

namespace MP_OnlineStore.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ProductsController(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ProductsList(int categoryId)
        {
            var category = _unitOfWork.CategoriesRepository.Get(x => x.CategoryId == categoryId, includeProperties: "Products");

            int.TryParse(_configuration.GetValue<string>("ViewSideConfig:ProductsAmountOnPage"), out int maxProductsOnPage);

            var categoryDto = _mapper.Map<CategoryDto>(category.FirstOrDefault());

            var categoryViewModel = _mapper.Map<CategoryViewModel>(categoryDto);

            var productsList = new ProductsListViewModel
            {
                Category = categoryViewModel,
                Products = categoryViewModel.Products,
                MaxProductsOnPage = maxProductsOnPage
            };

            return View(productsList);
        }
    }
}
