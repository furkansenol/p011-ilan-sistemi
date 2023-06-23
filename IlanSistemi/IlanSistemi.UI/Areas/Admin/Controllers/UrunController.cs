using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.User.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	[Authorize(Roles = "Admin")]
	public class UrunController : Controller
	{
		private readonly DataContext _dataContext;

		public UrunController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		private readonly AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
		private readonly CategoryAdvertManager _categoryAdvertManager = new CategoryAdvertManager(new EfCategoryAdvertDal());
		private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
		private readonly UserManager _userManager = new UserManager(new EfUserDal());
		private readonly AdvertImageManager _advertImageManager = new AdvertImageManager(new EfAdvertImageDal());


		public IActionResult Index()
		{
			var values = _advertManager.TGetList();
			return View(values);
		}


		public IActionResult DeleteAdvert(int id)
		{

			var advertImages = _advertImageManager.TGetListbyFilter(ai => ai.AdvertId == id);
			foreach (var advertImage in advertImages)
			{
				_advertImageManager.TDelete(advertImage);
			}

			var categoryAdverts = _categoryAdvertManager.TGetListbyFilter(ca => ca.AdvertId == id);
			foreach (var categoryAdvert in categoryAdverts)
			{
				_categoryAdvertManager.TDelete(categoryAdvert);
			}


			var advert = _advertManager.TGetByID(id);
			_advertManager.TDelete(advert);

			return RedirectToAction("Index");
		}
	}
}
