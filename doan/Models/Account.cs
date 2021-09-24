using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Account
    {
        public Account()
        {
            RoleAccounts = new HashSet<RoleAccount>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
