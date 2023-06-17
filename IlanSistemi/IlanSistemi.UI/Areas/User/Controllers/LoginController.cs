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
        private readonly SignInManager<AdminUser> _signInManager;

        public LoginController(SignInManager<AdminUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Hatali kullanici adi veya sifre");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }
    }
}

