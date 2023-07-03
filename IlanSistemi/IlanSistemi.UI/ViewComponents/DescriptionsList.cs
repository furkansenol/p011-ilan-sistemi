using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
    public class DescriptionsList : ViewComponent
    {
        PageManager _pageManager = new PageManager(new EfPageDal());

        public IViewComponentResult Invoke()
        {
            var values = _pageManager.TGetList();
            return View(values);
        }
    }
}
