using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]")]
    [Area("Admin")]
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
    }
}
