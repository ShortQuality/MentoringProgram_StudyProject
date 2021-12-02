using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.Application.Services.Interfaces;
using MP_OnlineStore.Core.Interfaces;
using MP_OnlineStore.WEB.ViewModels;

namespace MP_OnlineStore.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(
            IUnitOfWork unitOfWork,
            IConfiguration configuration,
            IMapper mapper,
            IProductService productService,
            ICategoryService categoryService)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductsList(string mode, int categoryId)
        {
            
            var category = await _unitOfWork.CategoriesRepository.GetAsync(x => x.CategoryId == categoryId, includeProperties: "Products");

            int.TryParse(_configuration.GetValue<string>("ViewSideConfig:ProductsAmountOnPage"), out int maxProductsOnPage);

            var categoryDto = _mapper.Map<CategoryDto>(category.FirstOrDefault());

            var categoryViewModel = _mapper.Map<CategoryViewModel>(categoryDto);

            var productsList = new ProductsListViewModel
            {
                CategoryName = categoryViewModel.CategoryName,
                Products = categoryViewModel.Products,
                MaxProductsOnPage = maxProductsOnPage
            };

            if (string.Equals(mode, "edit", StringComparison.OrdinalIgnoreCase))
                return View("Edit", productsList);

            return View(productsList);
        }

        [HttpGet]
        [Route("[Controller]/Edit")]
        public async Task<IActionResult> Edit()
        {
            var productsDto = await _productService.GetAsync();
            var categoriesDto = await _categoryService.GetAsync();

            var productsListViewModel = new ProductsListViewModel
            {
                Categories = _mapper.Map<IEnumerable<CategoryViewModel>>(categoriesDto),
                Products = _mapper.Map<IEnumerable<ProductViewModel>>(productsDto)
            };
            
            return View(productsListViewModel);
        }

        [HttpPost]
        [Route("[Controller]/Edit")]
        public HttpStatusCode Edit([Bind("Categories, Products")]ProductsListViewModel editedViewModel)
        {
            //var productsDto = await _productService.GetAsync();
            //var categoriesDto = await _categoryService.GetAsync();

            //var productsListViewModel = new ProductsListViewModel
            //{
            //    Categories = _mapper.Map<IEnumerable<CategoryViewModel>>(categoriesDto),
            //    Products = _mapper.Map<IEnumerable<ProductViewModel>>(productsDto)
            //};

            return HttpStatusCode.OK; /* View(productsListViewModel);*/
        }
    }
}
