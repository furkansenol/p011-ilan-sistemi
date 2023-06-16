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
            ViewBag.Category = "Tüm kategorilerdeki ürünler";
            ViewBag.AdvertCount = _dataContext.adverts.Count();
            return View();
        }


        [Route("category/elektronik-aletler")]
        public async Task<IActionResult> Elektronik()
        {
            //Getting category with specific Id
            var category = await _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefaultAsync(c => c.Id == 1);

            var adverts = new List<Advert>();

            if (category?.categoryAdverts.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";
            else
                adverts = category?.categoryAdverts.Select(ca => ca.adverts).ToList();

            ViewBag.Category = "Elektronik kategorisindeki ürünler";
            ViewBag.AdvertCount = adverts?.Count;

            return View(adverts);
        }

        [Route("category/moda-giyim")]
        public async Task<IActionResult> Moda()
        {
            //Getting category with specific Id
            var category = await _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefaultAsync(c => c.Id == 2);

            var adverts = new List<Advert>();

            if (category?.categoryAdverts.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";
            else
                adverts = category?.categoryAdverts.Select(ca => ca.adverts).ToList();

            ViewBag.Category = "Moda kategorisindeki ürünler";
            ViewBag.AdvertCount = adverts?.Count;

            return View(adverts);
        }

        [Route("category/ev-yasam")]
        public async Task<IActionResult> EvYasam()
        {

            //Getting category with specific Id
            var category = await _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefaultAsync(c => c.Id == 3);

            var adverts = new List<Advert>();

            if (category?.categoryAdverts.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";
            else
                adverts = category?.categoryAdverts.Select(ca => ca.adverts).ToList();

            ViewBag.Category = "Ev, Yaşam kategorisindeki ürünler";
            ViewBag.AdvertCount = adverts?.Count;

            return View(adverts);
        }

        [Route("category/spor-outdoor")]
        public async  Task<IActionResult> SporOutdoor()
        {

            //Getting category with specific Id
            var category = await _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefaultAsync(c => c.Id == 4);
            var adverts = new List<Advert>();

            if (category?.categoryAdverts.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";
            else
                adverts = category?.categoryAdverts.Select(ca => ca.adverts).ToList();

            ViewBag.Category = "Spor, Outdoor kategorisindeki ürünler";
            ViewBag.AdvertCount = adverts?.Count;

            return View(adverts);
        }

        [Route("category/kisisel-bakim")]
        public async Task<IActionResult> Kozmetik()
        {

            //Getting category with specific Id
            var category = await _dataContext.categories
                    .Include(c => c.categoryAdverts)
                    .ThenInclude(ca => ca.adverts)
                    .FirstOrDefaultAsync(c => c.Id == 5);
            var adverts = new List<Advert>();

            if (category?.categoryAdverts.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";
            else
                adverts = category?.categoryAdverts.Select(ca => ca.adverts).ToList();

            ViewBag.Category = "Kozmetik kategorisindeki ürünler";
            ViewBag.AdvertCount = adverts?.Count;

            return View(adverts);
        }



    }
}
