using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.ViewComponents.Dashboard
{
    public class UserList : ViewComponent
    {
        UserManager _userManager = new UserManager(new EfUserDal());

        public IViewComponentResult Invoke()
        {
            var values = _userManager.TGetList();
            return View(values);    
        }
    }
}
