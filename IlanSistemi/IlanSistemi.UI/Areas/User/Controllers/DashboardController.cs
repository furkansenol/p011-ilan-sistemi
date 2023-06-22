using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.User.Controllers
{
    public class AdvertViewModel
    {
        public Advert Advert { get; set; }
        public List<Category> Categories { get; set; }
    }

    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
        private readonly CategoryAdvertManager _categoryAdvertManager = new CategoryAdvertManager(new EfCategoryAdvertDal());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var adverts = _advertManager.TGetList();
            var categoryAdverts = _categoryAdvertManager.TGetList();

            var categoryIds = categoryAdverts.Select(ca => ca.CategoryId).Distinct().ToList();
            var categories = _categoryManager.TGetListbyFilter(c => categoryIds.Contains(c.Id));

            var values = adverts.Select(ad => new AdvertViewModel
            {
                Advert = ad,
                Categories = categoryAdverts.Where(ca => ca.AdvertId == ad.Id)
                                            .Join(categories, ca => ca.CategoryId, c => c.Id, (ca, c) => c)
                                            .ToList()
            }).ToList();

            return View(values);

        }
    }
}
