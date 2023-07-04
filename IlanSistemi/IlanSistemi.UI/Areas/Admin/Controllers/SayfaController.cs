using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class SayfaController : Controller
	{
		PageManager _pageManager = new PageManager(new EfPageDal());
		public IActionResult Index()
		{
			var values = _pageManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult EditSayfa(int id)
		{
			var values = _pageManager.TGetByID(id);
			if (values == null)
			{
				return RedirectToAction("Index");
			}
			return View(values);
		}
		[HttpPost]
		public IActionResult EditSayfa(Page page) 
		{
			_pageManager.TUpdate(page);
			page.UpdatedAt = DateTime.Now;
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult AddSayfa()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddSayfa(Page page)
		{
			_pageManager.TAdd(page);
			page.CreatedAt = DateTime.Now;
			return RedirectToAction("Index");
		}


		public IActionResult DeleteSayfa(int id)
		{
			var values = _pageManager.TGetByID(id);
			_pageManager.TDelete(values);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> ActivePage(int id)
		{
			await _pageManager.ActivePage(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> PassivePage(int id)
		{
			await _pageManager.PassivePage(id);
			return RedirectToAction("Index");
		}
	}
}
