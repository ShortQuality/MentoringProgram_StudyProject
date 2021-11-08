using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MP_OnlineStore.Core.Interfaces;

namespace MP_OnlineStore.WEB.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult AllCategories()
        {
            var categories = _unitOfWork.CategoriesRepository.GetAll().AsEnumerable();
            return View(categories);
        }
    }
}
