using DoAn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}
