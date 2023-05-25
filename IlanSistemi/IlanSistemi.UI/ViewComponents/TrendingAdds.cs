using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
	public class TrendingAdds : ViewComponent //BURANIN ADVERT ENTITY'SI ILE OLMASI LAZIM AMA KATMANLARI CIKILMAMIS ONDAN DOLAYI CATEGORY ILE YAPTIM
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var values = categoryManager.TGetList();
			return View(values);
		}
	}
}
