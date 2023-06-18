

using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<Users> _userManager;

        public Navbar(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync ()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v=values.ImageUrl;

            return View();
        }
    }
}
