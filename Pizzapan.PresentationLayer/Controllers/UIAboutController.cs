using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class UIAboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
