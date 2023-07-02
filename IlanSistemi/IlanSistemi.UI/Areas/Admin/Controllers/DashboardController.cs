using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Xml.Linq;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	
	public class DashboardController : Controller
	{
        UserManager _userManager = new UserManager(new EfUserDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());

        public IActionResult Index()
		{
            var users = _userManager.TGetList();
            var categories = _categoryManager.TGetList();
            var adverts = _advertManager.TGetList();

            var model = new ReportListViewModel
            {
                Users = users,
                Categories = categories,
                Adverts = adverts

            };

            return View(model);
		}
	}
}
