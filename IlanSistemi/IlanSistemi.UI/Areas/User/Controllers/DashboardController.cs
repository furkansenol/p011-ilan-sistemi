using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace IlanSistemi.UI.Areas.User.Controllers
{
	[Area("User")]
	[Route("User/[controller]/[action]")]
	public class DashboardController : Controller
	{
		private readonly UserManager<Users> _userManager;

		public DashboardController(UserManager<Users> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.v = values.Name + " " + values.Surname;
			//Havadurumu Apisi
			string api = "f8db5e52cb843c912f0cf385811e4977";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=Antalya&mode=xml&lang=tr&units=metric&appid=" + api;
			XDocument document = XDocument.Load(connection);
			ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			//istatislikler
			DataContext c = new DataContext();
			ViewBag.v1 = c.adverts.Count();
			ViewBag.v2 = c.categories.Count();
			ViewBag.v3 = c.Users.Count();

			return View();
		}
	}
}
