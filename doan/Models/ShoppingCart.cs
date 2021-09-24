using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class ShoppingCart
    {
        public long Id { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? Price { get; set; }
        public int? ProductId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Account Account { get; set; }
        public virtual Product Product { get; set; }
    }
}
