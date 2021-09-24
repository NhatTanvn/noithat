using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
         private MainDbContext db = new MainDbContext();

        public NewsController(MainDbContext _db)
        {
            db = _db;
        }
        [Route("")]
        public IActionResult Index()
        {
            List<Article> articles = db.Articles.Where(c => c.Status == true).ToList();
            return View(articles);
        }
        [HttpGet]
        [Route("detalis/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.newsDetails = db.Articles.Where(c=>c.Id == id).ToList();
            return View();
        }
    }
}
