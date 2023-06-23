using IlanSistemi.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.ViewComponents
{
    public class TrendingAdds : ViewComponent 
	{
        private readonly IAdvertService _advertManager;

        public TrendingAdds(IAdvertService advertManager)
        {
            _advertManager = advertManager;
        }

        public IViewComponentResult Invoke()
        {
            var adverts = _advertManager.GetAllAdvertsWithImage();

            return View(adverts);
        }
    }
}
