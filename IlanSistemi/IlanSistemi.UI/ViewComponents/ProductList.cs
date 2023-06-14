using IlanSistemi.Business.Abstract;
using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
	public class ProductList : ViewComponent
	{
		IAdvertService _advertManager;

        public ProductList(IAdvertService advertManager)
        {
            _advertManager = advertManager;
        }

        public IViewComponentResult Invoke()
		{
			var values = _advertManager.TGetList();
			return View(values);
		}
	}
}
