using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult GetMessageByTesekkur()
        {
            var values = _contactService.TGetContactBySubjectWithTesekkur();
            return View(values);
        }
        public IActionResult AddMessage(Contact p)
        {
            _contactService.TInsert(p);
            p.SendDateMessage = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
            return RedirectToAction("Index", "Default");
        }
    }
}
