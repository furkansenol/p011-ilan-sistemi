using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	[Authorize(Roles = "Admin")]
	public class KategoriController : Controller
	{
		CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
		public IActionResult Index()
		{
			var values = _categoryManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddKategori()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddKategori(Category category)
		{
			_categoryManager.TAdd(category);
			return RedirectToAction("Index");
		}

		[HttpGet]
        public IActionResult EditKategori(int id)
		{
			var values = _categoryManager.TGetByID(id);
			if (values == null)
			{
                return RedirectToAction("Index");
            }
			return View(values);
		}

		[HttpPost]

		public IActionResult EditKategori(Category category)
		{
			
            _categoryManager.TUpdate(category);
			return RedirectToAction("Index");
		}


        public IActionResult DeleteKategori(int id)
        {
            var values = _categoryManager.TGetByID(id);
            _categoryManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
