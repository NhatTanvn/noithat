using DoAn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace DoAn.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [Area("admin")]
    [Route("admin/banner")]
    public class BannerController : Controller
    {
        private MainDbContext db = new MainDbContext();
        public BannerController(MainDbContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.banners = db.Banners.ToList();
            return View();
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var banner = new Banner();
            return View("Add", banner);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Banner banner, IFormFile images)
        {

            string rootPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwRoot/upload");
            if (images == null || images.Length == 0)
            {
                ViewBag.Message = "File not found";
            }
            else
            {
                string filename = images.FileName;
                using (var stream = new FileStream(rootPath + @"\" + filename, FileMode.Create))
                {
                    images.CopyTo(stream);
                    ViewBag.Message = "Images upload success"+rootPath;
                }
                banner.Path = "/upload/"+filename;
                db.Add(banner);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Banner", new { area = "admin" });
        }
        [HttpGet]
        [Route("edit")]
        public IActionResult Edit(int id)
        {
            var banner = db.Banners.Find(id);
            return View("Edit", banner);
        }
        [HttpPost]
        [Route("edit")]
        public IActionResult Edit(int id, Banner banner, IFormFile images)
        {
            var current = db.Banners.Find(banner.Id);
            if (images != null && !string.IsNullOrEmpty(images.FileName)){
                string rootPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwRoot/upload");
                string filename = images.FileName;
                using (var stream = new FileStream(rootPath + @"\" + filename, FileMode.Create))
                {
                    images.CopyTo(stream);
                    ViewBag.Message = "Images upload success" + rootPath;
                }
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Banner", new { area = "admin" });
        }
        [HttpGet]
        [Route("delete/id")]
        public IActionResult Delete(int id)
        {
            var banner = db.Banners.Find(id);
            db.Banners.Remove(banner);
            db.SaveChanges();
            return RedirectToAction("Index", "Banner", new { area = "admin" });
        }
    }
}
