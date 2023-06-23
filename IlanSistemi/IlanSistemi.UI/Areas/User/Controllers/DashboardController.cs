using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.User.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.UI.Areas.User.Controllers
{
	

	[Area("User")]
	[Route("User/[controller]/[action]")]
	public class DashboardController : Controller
	{
		private readonly DataContext _dataContext;

		public DashboardController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		private readonly AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
		private readonly CategoryAdvertManager _categoryAdvertManager = new CategoryAdvertManager(new EfCategoryAdvertDal());
		private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
		private readonly UserManager _userManager = new UserManager(new EfUserDal());

		public IActionResult Index()
		{

			var userId = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name)
									 .FirstOrDefault()?.Id;
			var model = _dataContext.adverts.Include(a => a.advertImages).Include(a => a.categoryAdverts).ThenInclude(a => a.Category).Where(a => a.UsersId == userId).ToList();
			if (userId == null)
			{
				return RedirectToAction("Error");
			}

			var adverts = _advertManager.TGetListbyFilter(ad => ad.UsersId == userId);
			var categoryAdverts = _categoryAdvertManager.TGetList();
			var categories = _categoryManager.TGetList();

			

			var values = adverts.Select(ad => new AdvertViewModel
			{
				Advert = ad,
				Categories = categoryAdverts.Where(ca => ca.AdvertId == ad.Id)
											.Join(categories, ca => ca.CategoryId, c => c.Id, (ca, c) => c)
											.ToList(),
				
			}).ToList();

			

			return View(values);
		}

	}
}
