using DoAn.Helpers;
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
    [Route("admin/cart")]
    public class CartController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public CartController(MainDbContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
           List<Item> cart = SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.countItems = cart.Count;
            return View();
        }
        public IActionResult Buy(int id)
        {
            var product = db.Products.Find(id);
            var image = product.Images.SingleOrDefault(c => c.Status && c.Featured);
            var imageName = image.Name;
            if (SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = (decimal)product.Price,
                    Image = imageName,
                    Quantity = 1
                });
                SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper
                    .GetOjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = exists(id, cart);
                if(index == -1)
                {
                    cart.Add(new Item
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = (decimal)product.Price,
                        Image = imageName,
                        Quantity = 1
                    });
                }
                else
                {
                    int newQuantity = cart[index].Quantity++;
                    cart[index].Quantity = newQuantity;

                }
            }
            return RedirectToAction("Index", "Cart");
        }
        private int exists (int id, List<Item> cart)
        {
            for (var i=0; i<cart.Count; i++)
            {
                if (cart[i].Id == id)
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
