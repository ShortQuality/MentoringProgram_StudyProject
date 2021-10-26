using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MP_OnlineStore.DAL.Interfaces;
using MP_OnlineStore.ViewModels;

namespace MP_OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ProductsList(int categoryId)
        {
            var productsViewModel = new ProductsListViewModel
            {
                Products = _unitOfWork.ProductsRepository.GetAll().Where(p => p.CategoryId == categoryId).ToList(),
                Category = _unitOfWork.CategoriesRepository.FirstOrDefaultAsync(categoryId).Result
            };
            return View(productsViewModel);
        }
    }
}
