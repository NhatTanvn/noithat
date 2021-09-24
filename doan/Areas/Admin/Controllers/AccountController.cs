using DoAn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Area("admin")]
    [Route("admin/account")]
    public class AccountController : Controller
    {
        private MainDbContext db = new MainDbContext();
        public AccountController(MainDbContext _db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.account = db.Accounts.ToList();
            return View();
        }

    }
}
