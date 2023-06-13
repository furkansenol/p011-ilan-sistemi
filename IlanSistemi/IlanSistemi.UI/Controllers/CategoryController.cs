using IlanSistemi.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("category/elektronik-aletler")]
        public IActionResult Elektronik()
        { 
            return View(); 
        }

    }
}
