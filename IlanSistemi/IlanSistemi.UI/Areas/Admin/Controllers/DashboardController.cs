using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.Concrete;
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
		public IActionResult Index()
		{


			return View();
		}
	}
}
