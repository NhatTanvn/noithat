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
    [Route("admin/branche")]
    public class BrancheController : Controller
    {
        private MainDbContext db = new MainDbContext();
        public BrancheController(MainDbContext _db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.branche = db.Branches.ToList();
            return View();
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var branch = new Branch();
            return View("Add", branch);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Branch branch)
        {            
            db.Branches.Add(branch);
            db.SaveChanges();
            return RedirectToAction("Index", "Branche", new { area = "admin" });
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var branch = db.Branches.Find(id);
            return View("edit", branch);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Branch branch)
        {
            var curBranch = db.Branches.Find(id);
            curBranch.Title = branch.Title;
            curBranch.Address = branch.Address;
            curBranch.Phone = branch.Phone;
            curBranch.Email = branch.Email;
            curBranch.Fax = branch.Fax;
            curBranch.Website = branch.Website;
            curBranch.Hotline = branch.Hotline;
            db.SaveChanges();
            return RedirectToAction("Index", "Branche", new { area = "admin" });
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var branch = db.Branches.Find(id);
            db.Branches.Remove(branch);
            db.SaveChanges();
            return RedirectToAction("index", "Branche", new { area = "admin" });
        }
    }
}
