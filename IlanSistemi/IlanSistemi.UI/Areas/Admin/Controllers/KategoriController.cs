using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class KategoriController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
