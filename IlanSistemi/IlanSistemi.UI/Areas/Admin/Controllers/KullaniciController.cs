using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
		public IActionResult DetailKullanici(int id) 
		{
			var values = _userManager.TGetByID(id);
			_userManager.TGetList().Add(values);
			return View(values);
		}
		public IActionResult DeleteKullanici(int id)
		{
			var values = _userManager.TGetByID(id);
			_userManager.TDelete(values);
			return RedirectToAction("Index");
		}
		
		public async Task<IActionResult> BanUser(int Id)
		{
			await _userManager.BanUser(Id);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> UnbanUser(int Id)
		{
			await _userManager.UnbanUser(Id);
			return RedirectToAction("Index"); 
		}

		//[HttpPost]
		//public async Task<IActionResult> SuspendUser(int Id)
		//{
		//	await _userManager.SuspendUser(Id);
		//	return RedirectToAction("Index"); // İstenilen bir sayfaya yönlendirme yapabilirsiniz
		//}



	}
}
