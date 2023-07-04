using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
	public class CategoryAdds : ViewComponent
	{
		CategoryManager CategoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var values = CategoryManager.TGetList();
			return View(values);
		}
	}
}
