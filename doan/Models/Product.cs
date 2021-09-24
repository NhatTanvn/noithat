using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Product
    {
        public Product()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public decimal? Price { get; set; }
        public string Content { get; set; }
        public int? Quanlity { get; set; }
        public int? CategoryId { get; set; }
        public bool Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
