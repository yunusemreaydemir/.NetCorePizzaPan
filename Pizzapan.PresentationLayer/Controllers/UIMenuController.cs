using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class UIMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
