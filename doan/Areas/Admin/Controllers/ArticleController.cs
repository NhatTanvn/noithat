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
    [Route("admin/article")]
    public class ArticleController : Controller
    {
        private MainDbContext db = new MainDbContext();
        public ArticleController(MainDbContext _db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.article = db.Articles.ToList();
            return View();
        }

        [HttpGet]
        [Route("view/{id}")]
        public IActionResult View(int id)
        {
            var article = db.Articles.Find(id);
            return View("View", article);
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var article = new Article();
            return View("Add", article);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Article article)
        {

            db.Articles.Add(article);
            db.SaveChanges();
            return RedirectToAction("Index", "Article", new { area = "admin" });
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var article = db.Articles.Find(id);
            return View("edit", article);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Article article)
        {
            var curArticle = db.Articles.Find(id);
            curArticle.Title = article.Title;
            curArticle.Description = article.Description;
            curArticle.Content = article.Content;
            curArticle.isNew = article.isNew;
            curArticle.Status = article.Status;
            db.SaveChanges();
            return RedirectToAction("Index", "Article", new { area = "admin" });
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("index", "Article", new { area = "admin" });
        }
    }
}
