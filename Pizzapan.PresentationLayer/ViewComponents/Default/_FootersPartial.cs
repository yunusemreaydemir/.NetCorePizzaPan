using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FootersPartial : ViewComponent
    {
        private readonly IFootersService _footersService;

        public _FootersPartial(IFootersService footersService)
        {
            _footersService = footersService;
        }

        public IViewComponentResult Invoke()
        {

            var values = _footersService.TGetList();
            //ViewBag.address = values.Select(x => x.Address).ToList();
            //ViewBag.mail = values.Select(x => x.Email).ToList();
            ////ViewBag.reservation = values
            //ViewBag.telephoneNumber = values
            //ViewBag.workingDay = values.WorkingDay
            //ViewBag.workingHours = values.WorkingHours
            return View(values);
        }
    }
}
