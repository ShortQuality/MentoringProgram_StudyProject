using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MP_OnlineStore.DAL;
using MP_OnlineStore.DAL.Interfaces;

namespace MP_OnlineStore.Controllers
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
