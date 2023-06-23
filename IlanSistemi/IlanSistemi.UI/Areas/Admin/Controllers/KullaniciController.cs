using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	[Authorize(Roles = "Admin")]
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

		public IActionResult SuspendUser(int Id) 
		{
			var values = _userManager.TGetByID(Id);
			return View(values);
		}

        [HttpPost]
        public async Task<IActionResult> SuspendUser(Users model, DateTime date)
        {
            var user = _userManager.TGetByID(model.Id);

            if (user == null)
            {
                return NotFound();
            }

             var values =  DateTime.UtcNow.Subtract(date);

             await _userManager.SuspendUserForDuration(user.Id, values);

            return RedirectToAction("Index");
        }
	
		public async Task <IActionResult> UnSuspendUser(Users users)
		{
			var valuses = _userManager.TGetByID(users.Id);
			if (users == null)
			{
				return NotFound();
			}
			await _userManager.UnsuspendUser(valuses.Id);
			return RedirectToAction("Index");
		}






	}
}
