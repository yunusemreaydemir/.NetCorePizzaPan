using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class OurTeamsController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamsController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            _ourTeamService.TInsert(ourTeam);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteOurTeam(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            _ourTeamService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateOurTeam(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateOurTeam(OurTeam ourTeam)
        {
            _ourTeamService.TUpdate(ourTeam);
            return RedirectToAction("Index");
        }
    }
}

