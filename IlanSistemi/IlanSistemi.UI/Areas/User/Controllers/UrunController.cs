using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IlanSistemi.UI.Areas.User.Controllers
{
	[Area("User")]
	[Route("User/[controller]/[action]")]
	public class UrunController : Controller
	{
		private readonly DataContext _dataContext;

		public UrunController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		private readonly AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
		private readonly CategoryAdvertManager _categoryAdvertManager = new CategoryAdvertManager(new EfCategoryAdvertDal());
		private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
		private readonly UserManager _userManager = new UserManager(new EfUserDal());
		private readonly AdvertImageManager _advertImageManager = new AdvertImageManager(new EfAdvertImageDal());


		public IActionResult Index()
		{
			var userId = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name)
									 .FirstOrDefault()?.Id;

			if (userId == null)
			{
				return RedirectToAction("Error");
			}

			var adverts = _advertManager.TGetListbyFilter(ad => ad.UsersId == userId);
			var categoryAdverts = _categoryAdvertManager.TGetList();
			var categories = _categoryManager.TGetList();

			var values = adverts.Select(ad => new AdvertViewModel
			{
				Advert = ad,
				Categories = categoryAdverts.Where(ca => ca.AdvertId == ad.Id)
											.Join(categories, ca => ca.CategoryId, c => c.Id, (ca, c) => c)
											.ToList()
			}).ToList();

			return View(values);
		}

		[HttpGet]
		public IActionResult EditAdvert(int id)
		{
			var user = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name).FirstOrDefault();
			TempData["User"] = user;
			TempData["Category"] = _categoryManager.TGetList();
			var values = _advertManager.TGetByID(id);
			var F = _dataContext.adverts.Include(a => a.categoryAdverts).Include(a => a.advertImages).Where(x => x.UsersId == user.Id && x.Id == id).FirstOrDefault();

			var model = new AddAdvertViewModel
			{
				Title = values.Title,
				Description = values.Description,
				AdvertId = id,
				CategoryAdvertId = F.categoryAdverts.Where(z => z.AdvertId == id).FirstOrDefault().Id,
				ImageId = F.advertImages.Where(z => z.AdvertId == id).FirstOrDefault().Id,
				

            };
			return View(model);
		}


		[HttpPost]
		public async Task<IActionResult> EditAdvert(AddAdvertViewModel model, IFormFile ImagePath)
		{

			var resource = Directory.GetCurrentDirectory();
			var extension = Path.GetExtension(ImagePath.FileName);
			var Imagename = Guid.NewGuid() + extension;
			var SaveLocation = resource + "/wwwroot/UrunResimleri/" + Imagename;
			var Stream = new FileStream(SaveLocation, FileMode.Create);
			await ImagePath.CopyToAsync(Stream);

			var image = _advertImageManager.TGetByID(model.ImageId);
			image.ImagePath = $"/{Imagename}";
			_advertImageManager.TUpdate(image);


			var advert = _advertManager.TGetByID(model.AdvertId);
			advert.Title = model.Title;
			advert.Description = model.Description;	
			_advertManager.TUpdate(advert);

            var category = _categoryAdvertManager.TGetByID(model.CategoryId);
            if (category != null)
            {
                category.CategoryId = model.CategoryId;
                category.AdvertId = model.AdvertId;
                _categoryAdvertManager.TUpdate(category);
            }
           

            

			return RedirectToAction("Index", "Urun");
		}

		[HttpGet]
		public IActionResult AddAdvert()
		{
			var user = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name).FirstOrDefault();
			TempData["User"] = user;
			TempData["Category"] = _categoryManager.TGetList();

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddAdvert(AddAdvertViewModel model, IFormFile ImagePath)
		{

			var resource = Directory.GetCurrentDirectory();
			var extension = Path.GetExtension(ImagePath.FileName);
			var Imagename = Guid.NewGuid() + extension;
			var SaveLocation = resource + "/wwwroot/UrunResimleri/" + Imagename;
			var Stream = new FileStream(SaveLocation, FileMode.Create);
			await ImagePath.CopyToAsync(Stream);



			Advert advert = new Advert
			{
				UsersId = model.userId,
				Title = model.Title,
				Description = model.Description,
				CreatedAt = DateTime.Now

			};
			_advertManager.TAdd(advert);
			CategoryAdvert categoryAdvert = new CategoryAdvert
			{
				AdvertId = advert.Id,
				CategoryId = model.CategoryId
			};

			_categoryAdvertManager.TAdd(categoryAdvert);

			AdvertImage advertImage = new AdvertImage
			{
				AdvertId = advert.Id,
				ImagePath = $"/{Imagename}"
			};

			_advertImageManager.TAdd(advertImage);



			return RedirectToAction("Index", "Urun");
		}

		public IActionResult DeleteAdvert(int id)
		{

			var advertImages = _advertImageManager.TGetListbyFilter(ai => ai.AdvertId == id);
			foreach (var advertImage in advertImages)
			{
				_advertImageManager.TDelete(advertImage);
			}

			var categoryAdverts = _categoryAdvertManager.TGetListbyFilter(ca => ca.AdvertId == id);
			foreach (var categoryAdvert in categoryAdverts)
			{
				_categoryAdvertManager.TDelete(categoryAdvert);
			}


			var advert = _advertManager.TGetByID(id);
			_advertManager.TDelete(advert);

			return RedirectToAction("Index");
		}





	}

}
