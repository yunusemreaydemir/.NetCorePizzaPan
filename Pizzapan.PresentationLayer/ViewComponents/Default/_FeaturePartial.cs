using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Tadı Damağınızda Kalacak";
            ViewBag.title2 = "SEVDİĞİNİZ PİZZALARI PAYLAŞIN";
            return View();
        }
    }
}
