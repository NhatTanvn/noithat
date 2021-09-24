using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public ProductController(MainDbContext _db)
        {
            db = _db;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            List<Product> product = db.Products.Include(c => c.Category).Where(c 
                            =>c.Status == true).ToList(); 
            return View(product);
        }
        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            Product product = db.Products.Where(c => c.Id == id).SingleOrDefault();
            return View("productDetails", product);
        }
    }
}
