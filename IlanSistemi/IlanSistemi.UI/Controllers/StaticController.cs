using Microsoft.AspNetCore.Mvc;

namespace IlanSistemi.UI.Controllers
{
    public class StaticController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
