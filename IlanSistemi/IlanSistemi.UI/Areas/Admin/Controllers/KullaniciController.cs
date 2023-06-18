using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class KullaniciController : Controller
	{
		UserManager _userManager = new UserManager(new EfUserDal());
	

        public IActionResult Index()
		{

			var values = _userManager.TGetList();
			
			return View(values);
		}
	}
}
