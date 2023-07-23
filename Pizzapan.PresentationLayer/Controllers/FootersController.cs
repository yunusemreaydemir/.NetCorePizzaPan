using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class FootersController : Controller
    {
        private readonly IFootersService _footersService;

        public FootersController(IFootersService footersService)
        {
            _footersService = footersService;
        }

        public IActionResult Index()
        {
            var values = _footersService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateFooters(int id)
        {
            var value = _footersService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFooters(Footers footers)
        {
            _footersService.TUpdate(footers);
            return RedirectToAction("Index");
        }
    }
}
