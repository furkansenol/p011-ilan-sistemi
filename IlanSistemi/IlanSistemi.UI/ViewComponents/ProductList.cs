using IlanSistemi.Business.Abstract;
using IlanSistemi.Entities.ViewModels;
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

        public IViewComponentResult Invoke(string query)
		{		
			var values = _advertManager.TGetList();
			if (!String.IsNullOrEmpty(query))
				values = values.Where(v => v.Title.ToLower().Contains(query.ToLower())).ToList();

            return View(values);
		}
	}
}
