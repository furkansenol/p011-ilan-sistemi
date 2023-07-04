using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.UI.Controllers
{
	public class AdvertController : Controller
	{
		private readonly IAdvertService _advertService;
		private readonly IUserService _userService;
		private readonly ICategoryService _categoryService;
		private readonly ICategoryAdvertService _categoryAdvertService;
		private readonly IAdvertCommentService _advertCommentService;
		private readonly DataContext _dataContext;

		public AdvertController(IAdvertService advertService, IUserService userService, ICategoryService categoryService, DataContext dataContext, ICategoryAdvertService categoryAdvertService, IAdvertCommentService advertCommentService)
		{
			_advertService = advertService;
			_userService = userService;
			_categoryService = categoryService;
			_dataContext = dataContext;
			_categoryAdvertService = categoryAdvertService;
			_advertCommentService = advertCommentService;
		}

		[Route("advert/{advertId}")]
		public IActionResult Index(int advertId)
		{
			var advert = _advertService.GetAllAdvertsWithImage().Find(x => x.Advert.Id == advertId);

			if (advert == null)
			{
				return RedirectToAction("Error");
			}

			var user = _userService.TGetByID(advert.UserId);

			var advertComment = _dataContext.advertComments
				.FirstOrDefault(c => c.AdvertId == advertId);

			var advertComentList = _dataContext.advertComments.ToList();
			

			AdvertSingleVM advertSingleVM = new AdvertSingleVM
			{
				Advert = advert.Advert,
				AdvertImages = advert.AdvertImages,
				User = user,
				comment = advertComment,
				mert = advertComentList,
				SelectedAdvert = advert.Advert
			};

			return View(advertSingleVM);
		}



		[HttpPost]
		[Route("advert/{advertId}")]
		public IActionResult Comment(int advertId, string comment)
		{
			var advert = _advertService.GetAllAdvertsWithImage().FirstOrDefault(x => x.Advert.Id == advertId);

			if (advert is null)
				return RedirectToAction("Error");

			var user = _userService.TGetByID(advert.Advert.UsersId);

			if (user is null)
				return RedirectToAction("Error");

			AdvertComment newComment = new AdvertComment
			{
				AdvertId = advertId,
				UsersId = user.Id,
				Comment = comment,
				CreatedAt = DateTime.Now,
				IsActive = true
			};

			_advertCommentService.TAdd(newComment);

			return RedirectToAction("Index", new { advertId = advertId });
		}




	}
}
