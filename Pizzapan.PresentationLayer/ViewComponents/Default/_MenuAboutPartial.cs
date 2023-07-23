using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _MenuAboutPartial : ViewComponent
    {
        private readonly IAboutMenuService _aboutMenuService;

        public _MenuAboutPartial(IAboutMenuService aboutMenuService)
        {
            _aboutMenuService = aboutMenuService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _aboutMenuService.TGetList();
            return View(values);
        }


    }
}
