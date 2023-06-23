using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly ICategoryAdvertService _categoryAdvertService;
        private readonly DataContext _dataContext;

        public AdvertController(IAdvertService advertService, IUserService userService, ICategoryService categoryService, DataContext dataContext, ICategoryAdvertService categoryAdvertService)
        {
            _advertService = advertService;
            _userService = userService;
            _categoryService = categoryService;
            _dataContext = dataContext;
            _categoryAdvertService = categoryAdvertService;
        }

        [Route("advert/{advertId}")]
        public IActionResult Index(int advertId)
        {
            var advert = _advertService.GetAllAdvertsWithImage().Find(x => x.Advert.Id == advertId);


            var user = _userService.TGetByID(advert.UserId);

            AdvertSingleVM advertSingleVM = new AdvertSingleVM
            {
                Advert = advert.Advert,
                AdvertImages = advert.AdvertImages,
                User = user,
            };
                
            if (advert is null)
                return RedirectToAction("Error");

            return View(advertSingleVM);
        }
    }
}
