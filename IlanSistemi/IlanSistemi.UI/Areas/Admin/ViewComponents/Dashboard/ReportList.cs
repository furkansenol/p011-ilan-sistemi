using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.ViewComponents.Dashboard
{
    public class ReportList: ViewComponent
    {
        UserManager _userManager;
        CategoryManager _categoryManager;
        AdvertManager _advertManager;

        public ReportList()
        {
            _userManager = new UserManager(new EfUserDal());
            _categoryManager = new CategoryManager(new EfCategoryDal());
            _advertManager = new AdvertManager(new EfAdvertDal());
        }

        public IViewComponentResult Invoke()
        {
            var users = _userManager.TGetList();
            var categories = _categoryManager.TGetList();
            var adverts = _advertManager.TGetList();

            var model = new ReportListViewModel
            {
                Users = users,
                Categories = categories,
                Adverts = adverts

            };

            return View(model);
        }
    }
}
