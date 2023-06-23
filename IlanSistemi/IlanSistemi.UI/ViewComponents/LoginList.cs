using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
    public class LoginList : ViewComponent
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        public IViewComponentResult Invoke()
        {
            var user = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name)
                                     .FirstOrDefault();
            var values = _userManager.TGetList();
            return View(user);

        }
    }
}
