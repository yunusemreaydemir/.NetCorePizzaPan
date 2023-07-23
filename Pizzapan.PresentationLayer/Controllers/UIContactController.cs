using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class UIContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
