using DoAn.Areas.Admin.ViewModels;
using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public ProductController(MainDbContext _db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.product = db.Products.Include(c => c.Category).ToList();
            return View();
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var productViewModel = new ProductViewModel();
            productViewModel.Product = new Product();
            productViewModel.Categories = new List<SelectListItem>();
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };
                if (category.InverseParent != null && category.InverseParent.Count > 0)
                {
                    foreach (var subcCategory in category.InverseParent)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subcCategory.Name,
                            Value = subcCategory.Id.ToString(),
                            Group = group
                        };
                        productViewModel.Categories.Add(selectListItem);
                    }
                }
            }
            return View("Add", productViewModel);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            productViewModel.Product.CreateDate = DateTime.Now;
            productViewModel.Product.UpdateDate = DateTime.Now;
            db.Products.Add(productViewModel.Product);
            db.SaveChanges();
            //var defaultImage = new Image
            //{
            //    Name = "pc-img-product.png",
            //    Desciption = "null",
            //    Path = "/upload/pc-img-product.png",
            //    ProductId= productViewModel.Product.Id,
            //    Status = true,
            //    Featured = true
            //};
            //db.Images.Add(defaultImage);
            //db.SaveChanges();

            return RedirectToAction("Index", "Product", new { areas = "admin" });
        
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var productViewModel = new ProductViewModel();
            productViewModel.Product = db.Products.Find(id);
            productViewModel.Categories = new List<SelectListItem>();
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };
                if (category.InverseParent != null && category.InverseParent.Count > 0)
                {
                    foreach (var subcCategory in category.InverseParent)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subcCategory.Name,
                            Value = subcCategory.Id.ToString(),
                            Group = group
                        };
                        productViewModel.Categories.Add(selectListItem);
                    }
                }
            }
            return View("Edit", productViewModel);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, ProductViewModel  productViewModel)
        {
            productViewModel.Product = db.Products.Find(id);
            productViewModel.Product.Name = productViewModel.Product.Name;
            productViewModel.Product.Size = productViewModel.Product.Size;
            productViewModel.Product.Material = productViewModel.Product.Material;
            productViewModel.Product.Price = productViewModel.Product.Price;
            productViewModel.Product.Content = productViewModel.Product.Content;
            productViewModel.Product.Quanlity = productViewModel.Product.Quanlity;
            productViewModel.Categories = new List<SelectListItem>();
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };
                if (category.InverseParent != null && category.InverseParent.Count > 0)
                {
                    foreach (var subcCategory in category.InverseParent)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subcCategory.Name,
                            Value = subcCategory.Id.ToString(),
                            Group = group
                        };
                        productViewModel.Categories.Add(selectListItem);
                    }
                }
            }
            
            db.SaveChanges();
            return RedirectToAction("Index", "Product", new { areas = "admin" });
        }

        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index", "Product", new { areas = "admin" });
        }
    }
}
