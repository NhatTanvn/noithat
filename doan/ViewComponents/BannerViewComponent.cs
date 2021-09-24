using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        private MainDbContext db;
        public BannerViewComponent(MainDbContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Banner> banner = db.Banners.Where(c => c.Status).ToList();
            return View("Index", banner);
        }
    }
}
