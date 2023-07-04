using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Areas.Admin.ViewComponents.Dashboard
{
	public class ProdoctList : ViewComponent
	{
		private readonly UserManager _userManager;
		private readonly AdvertManager _advertManager;

		public ProdoctList()
		{
			_userManager = new UserManager(new EfUserDal());
			_advertManager = new AdvertManager(new EfAdvertDal());
		}

		public IViewComponentResult Invoke()
		{
			var model = new List<ReportListViewModel>();

			var users = _userManager.TGetList();

			foreach (var user in users)
			{
				var userAdverts = _advertManager.TGetListbyFilter(a => a.UsersId == user.Id);

				foreach (var advert in userAdverts)
				{
					var reportListModel = new ReportListViewModel
					{
						_Users = user,
						_Advert = advert
					};

					model.Add(reportListModel);
				}
			}


			return View(model);
		}






	}



}



