﻿using IlanSistemi.Business.Concrete;
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
    public class RegisterController : Controller
    {
        private readonly UserManager<Users> _userManager;

        public RegisterController(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                Users w = new Users()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                    CreatedAt = DateTime.Now,
                    ImageUrl = p.ImagURL

				};

                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(w, p.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }

                }
            }
            return View();
        }

    }
}
