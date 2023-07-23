using Microsoft.AspNetCore.Mvc;
using Pizzapan.DataAccessLayer.Abstract;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _OurTeamPartial : ViewComponent
    {
        private readonly IOurTeamService _ourTeamService;

        public _OurTeamPartial(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
    }
}
