using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Contact
{
    public class _MessagePartial : ViewComponent
    {
        private readonly IFootersService _footersService;
        private readonly IContactService _contactService;

        public _MessagePartial(IFootersService footersService, IContactService contactService)
        {
            _contactService = contactService;
            _footersService = footersService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _footersService.TGetByID(1);

            ViewBag.address = value.Address;
            ViewBag.phone = value.TelephoneNumber;
            ViewBag.workingDay = value.WorkingDay;
            ViewBag.workingHours = value.WorkingHours;
            ViewBag.mail = value.Email;

            return View();
        }
    }
}