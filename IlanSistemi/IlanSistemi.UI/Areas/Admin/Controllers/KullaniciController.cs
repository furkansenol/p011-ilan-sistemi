using IlanSistemi.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class KullaniciController : Controller
	{
	

        public IActionResult Index()
		{
			
			return View();
		}
	}
}
