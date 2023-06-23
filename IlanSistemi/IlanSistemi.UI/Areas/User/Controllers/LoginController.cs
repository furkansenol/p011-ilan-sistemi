using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.User.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.User.Controllers
{


    [AllowAnonymous]
    [Route("User/[controller]/[action]")]
    [Area("User")]
    public class LoginController : Controller
    {
        private readonly SignInManager<Users> _signInManager;

        public LoginController(SignInManager<Users> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _signInManager.UserManager.FindByNameAsync(model.Username);

				if (user != null && user.IsBanned.HasValue && user.IsBanned.Value)
				{
					ModelState.AddModelError(string.Empty, "Hesabınız banlanmıştır. Giriş yapmanız engellenmiştir.");
					
					TempData["BanAlert"] = "Hesabiniz banlanmistir. Giris yapmaniz engellenmistir.";

					return View("Index");
				}

				var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, lockoutOnFailure: false);

				if (result.Succeeded)
				{
					// Başarılı giriş durumunda yapılacak işlemler
					return RedirectToAction("Index", "Dashboard");
				}
				else
				{
					ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
				}
			}
            TempData["SuspendAlert"] = "Hesabiniz gecici olarak askıya alınmıştır. Lütfen daha sonra tekrar deneyin.";

            return View();
		}



		public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }
    }
}

