using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
	public class CategoryList : ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var values = categoryManager.TGetList();
			return View(values);
		}
	}
}
