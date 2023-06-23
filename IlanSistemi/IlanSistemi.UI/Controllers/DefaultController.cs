using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult FooterBottomPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterSectionPartial() 
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial() 
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial() 
        {
            return PartialView();
        }
        public PartialViewResult HeadContentPartial()
        {
            return PartialView();
        }
    }
}
