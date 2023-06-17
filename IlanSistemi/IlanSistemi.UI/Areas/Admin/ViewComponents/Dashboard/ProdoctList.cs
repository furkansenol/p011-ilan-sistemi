using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.ViewComponents.Dashboard
{
	public class ProdoctList : ViewComponent
	{
		AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
		public IViewComponentResult Invoke()
		{
			var values = _advertManager.TGetList();
			return View(values);
			
		}
	}
}
