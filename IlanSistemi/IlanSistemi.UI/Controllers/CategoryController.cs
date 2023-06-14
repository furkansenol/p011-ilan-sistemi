using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _dataContext;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _dataContext = new DataContext();
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("category/elektronik-aletler")]
        public IActionResult Elektronik()
        {

            var model = _dataContext.adverts.Include(c => c.categoryAdverts).ThenInclude(c => c.category).Where(c => c.Id == 1).ToList();

            return View(model);
        }

        [Route("category/moda-giyim")]
        public IActionResult Moda()
        {

            var category = _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefault(c => c.Id == 2);
            var adverts = new List<Advert>();

            if (category != null)
            {
                adverts = category.categoryAdverts.Select(ca => ca.adverts).ToList();

            }
            return View(adverts);
        }

        [Route("category/ev-yasam")]
        public IActionResult EvYasam()
        {

            var model = _dataContext.adverts.Include(c => c.categoryAdverts).ThenInclude(c => c.category).Where(c => c.Id == 3).ToList();

            return View(model);
        }

        [Route("category/spor-outdoor")]
        public IActionResult SporOutdoor()
        {

            var model = _dataContext.adverts.Include(c => c.categoryAdverts).ThenInclude(c => c.category).Where(c => c.Id == 1).ToList();

            return View(model);
        }



    }
}
