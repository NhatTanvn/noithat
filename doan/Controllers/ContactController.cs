using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public ContactController(MainDbContext _db)
        {
            db = _db;
        }
        [Route("")]
        public IActionResult Index()
        {
            List<Branch> branches = db.Branches.ToList();
            return View(branches);
        }
    }
}
