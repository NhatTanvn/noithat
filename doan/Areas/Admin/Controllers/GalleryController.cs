using DoAn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [Area("admin")]
    [Route("admin/gallery")]
    public class GalleryController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public GalleryController(MainDbContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index/{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.Product = db.Products.Find(id);
            ViewBag.Images = db.Images.Where(c => c.ProductId == id).ToList();
            return View();
        }
        [HttpGet]
        [Route("add/{id}")]
        public IActionResult Add(int id)
        {
            ViewBag.Product = db.Products.Find(id);
            var image = new Image
            {
                ProductId = id
            };
            return View("add", image);
        }
        [HttpPost]
        [Route("add/{id}")]
        public IActionResult Add(int id, Image image, IFormFile fileUpload)
        {
            string rootPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwRoot/upload");
            if (fileUpload == null || fileUpload.Length == 0)
            {
                ViewBag.Message = "File not found";
            }
            else
            {
                string filename = fileUpload.FileName;
                using (var stream = new FileStream(rootPath + @"\" + filename, FileMode.Create))
                {
                    fileUpload.CopyTo(stream);
                    ViewBag.Message = "Images upload success" + rootPath;
                }                
                image.Path = "/upload/" + filename;
                db.Add(image);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Gallery", new { area = "admin" });
        }
    }
}
