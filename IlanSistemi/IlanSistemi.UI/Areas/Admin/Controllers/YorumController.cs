using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class YorumController : Controller
	{

		AdvertCommentManager _advertComment = new AdvertCommentManager (new EfAdvertCommentDal());
		public IActionResult Index()
		{
			var values = _advertComment.TGetList();
			return View(values);
		}

		public async Task<IActionResult> Active(int id)
		{
			await _advertComment.Active(id);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult AddYorum() 
		{

			return View();
		}

		[HttpPost]
		public IActionResult AddYorum(AdvertComment advert) 
		{
			_advertComment.TAdd(advert);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteYorum(int id)
		{
			var values = _advertComment.TGetByID(id);
			_advertComment.TDelete(values);
			return RedirectToAction("Index");
		}

		public IActionResult DetailsYorum(int id)
		{
			var values = _advertComment.TGetByID(id);
			_advertComment.TGetList().Add(values);
			return View(values);
		}
		public async Task<IActionResult> Passive(int id)
		{
			await _advertComment.Passive(id);
			return RedirectToAction("Index");
		}
	}
}
