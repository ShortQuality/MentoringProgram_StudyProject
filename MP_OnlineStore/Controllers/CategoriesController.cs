using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> AllCategories()
        {
            var categories = await _unitOfWork.CategoriesRepository.GetAsync();
            return View(categories);
        }
    }
}
