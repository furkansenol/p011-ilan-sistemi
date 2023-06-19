using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.User.Controllers
{
	[Area("User")]
	[Route("User/[controller]/[action]")]
	public class UrunController : Controller
	{
		private readonly AdvertManager advertManager;

		public UrunController()
		{
			advertManager = new AdvertManager(new EfAdvertDal());
		}

		public IActionResult Index()
		{
			var values = advertManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult EditAdvert(int id)
		{
			var advert = advertManager.TGetByID(id);

			if (advert == null)
			{
				return RedirectToAction("Index");
			}

			return View(advert);
		}

		[HttpPost]
		public IActionResult EditAdvert(Advert advert)
		{
			advert.UpdatedAt = DateTime.Now;
			advertManager.TUpdate(advert);
			return RedirectToAction("Index");
		}

		public IActionResult AddAdvert() 
		{
			return View(); 
		}

		[HttpPost]
		public async Task<IActionResult> AddExperience(Advert advert, IFormFile picture)
		{
			if (advert.CreatedAt == null)
			{
				advert.CreatedAt = DateTime.Now;
			}

			advertManager.TAdd(advert);

			if (picture != null)
			{
				var extension = Path.GetExtension(picture.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Productimage", imageName);

				using (var stream = new FileStream(saveLocation, FileMode.Create))
				{
					await picture.CopyToAsync(stream);
				}

				var advertImage = new AdvertImage
				{
					ImagePath = imageName,
					
				};

				if (advert.advertImages == null)
				{
					advert.advertImages = new List<AdvertImage>();
				}

				advert.advertImages.Add(advertImage);
			}

			return RedirectToAction("Index");
		}

		public IActionResult DeleteAdvert(int id)
		{
			var values = advertManager.TGetByID(id);
			advertManager.TDelete(values);
			return RedirectToAction("Index");
		}





	}

}
