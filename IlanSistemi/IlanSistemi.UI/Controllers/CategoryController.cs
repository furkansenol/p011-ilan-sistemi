using IlanSistemi.Business.Abstract;
using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

namespace IlanSistemi.UI.Controllers
{
	[AllowAnonymous]
	public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _dataContext;

        public CategoryController(ICategoryService categoryService, DataContext dataContext)
        {
            _categoryService = categoryService;
            _dataContext = dataContext;
        }

        [Route("category/products")]
        public async Task<IActionResult> Index(string query)
        {
            ViewBag.Category = "Tüm kategorilerdeki ürünler";
            ViewBag.AdvertCount = _categoryService.TGetList().Count();
            var allAdverts = await _dataContext.categories
                .Include(c => c.CategoryAdverts)
                .ThenInclude(ca => ca.adverts)
                .ThenInclude(ca=> ca.advertImages)
                .ToListAsync();

            var adverts = allAdverts.SelectMany(a => a.CategoryAdverts)
                .Select(ca => ca.adverts).ToList();

            if (!String.IsNullOrEmpty(query))
            {
                adverts = adverts.Where(v => v.Title.ToLower().Contains(query.ToLower())).ToList();
                ViewBag.Category = $" '{query}' araması için ilanlar ";
            }
                
            return View(adverts);
        }

        

        [Route("category/elektronik-aletler")]
        public async Task<IActionResult> Elektronik()
        {

            var categoryAdverts = await _categoryService.GetCategoryAdverts(1);
            

            if (categoryAdverts?.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";

            ViewBag.Category = "Elektronik kategorisindeki ürünler";
            ViewBag.AdvertCount = categoryAdverts?.Count;
            return View(categoryAdverts);
        }

        [Route("category/moda-giyim")]
        public async Task<IActionResult> Moda()
        {
            var categoryAdverts = await _categoryService.GetCategoryAdverts(2);

            if (categoryAdverts?.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";

            ViewBag.Category = "Moda kategorisindeki ürünler";
            ViewBag.AdvertCount = categoryAdverts?.Count;

            return View(categoryAdverts);
        }

        [Route("category/ev-yasam")]
        public async Task<IActionResult> EvYasam()
        {

            //Getting Category with specific Id
            var categoryAdverts = await _categoryService.GetCategoryAdverts(3);

            if (categoryAdverts?.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";

            ViewBag.Category = "Ev Yaşam kategorisindeki ürünler";
            ViewBag.AdvertCount = categoryAdverts?.Count;

            return View(categoryAdverts);
        }

        [Route("category/spor-outdoor")]
        public async  Task<IActionResult> SporOutdoor()
        {

            //Getting Category with specific Id
            var categoryAdverts = await _categoryService.GetCategoryAdverts(4);

            if (categoryAdverts?.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";

            ViewBag.Category = "Spor, Outdoor kategorisindeki ürünler";
            ViewBag.AdvertCount = categoryAdverts?.Count;

            return View(categoryAdverts);
        }

        [Route("category/kisisel-bakim")]
        public async Task<IActionResult> Kozmetik()
        {

            //Getting Category with specific Id
            var categoryAdverts = await _categoryService.GetCategoryAdverts(5);

            if (categoryAdverts?.Count == 0)
                ViewData["message"] = "Bu kategoride gösterilecek herhangi bir ürün yok.";

            ViewBag.Category = "Kozmetik kategorisindeki ürünler";
            ViewBag.AdvertCount = categoryAdverts?.Count;

            return View(categoryAdverts);
        }



    }
}
