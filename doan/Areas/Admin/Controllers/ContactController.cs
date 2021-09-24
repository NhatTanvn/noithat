using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [Area("admin")]
    [Route("admin/contact")]
    public class ContactController : Controller
    {
        private MainDbContext db = new MainDbContext();
        public ContactController(MainDbContext _db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.contact = db.Contacts.ToList();
            return View();
        }
        [HttpGet]
        [Route("view/{id}")]
        public IActionResult View(int id)
        {
            var category = db.Contacts.Find(id);
            return View("view", category);
        }

        [HttpPost]
        [Route("view/{id}")]
        public IActionResult View(int id, Contact contact)
        {
            var currentContact = db.Contacts.Find(id);
            currentContact.Name = contact.Name;
            currentContact.Email = contact.Email;
            currentContact.Phone = contact.Phone;
            currentContact.Desciption = contact.Desciption;

            db.SaveChanges();
            return RedirectToAction("Index", "Contact", new { area = "admin" });
        }
    }
}
