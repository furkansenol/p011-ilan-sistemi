using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.ViewComponents.Dashboard
{
    public class CatagoryList : ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.TGetList();
            return View(values);

        }
    }
}
