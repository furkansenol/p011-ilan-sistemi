using IlanSistemi.Business.Abstract;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IlanSistemi.UI.ViewComponents
{
	public class AdvertCommentList : ViewComponent
	{
		private readonly IAdvertCommentService _advertCommentService;
		private readonly UserManager<Users> _userManager;

		public AdvertCommentList(IAdvertCommentService advertCommentService, UserManager<Users> userManager)
		{
			_advertCommentService = advertCommentService;
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.GetUserAsync(HttpContext.User);

			var viewModel = new AdvertCommentListViewModel
			{
				User = user,
				AdvertComments = _advertCommentService.TGetList()
			};

			return View(viewModel);
		}
	}
}
