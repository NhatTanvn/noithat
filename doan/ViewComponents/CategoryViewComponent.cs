using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {

        private MainDbContext db;
        public CategoryViewComponent(MainDbContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> category = db.Categories.Where(c => c.Status && c.ParentId == null).ToList();
            return View("Index", category);
        }
    }
}
