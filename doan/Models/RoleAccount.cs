﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class RoleAccount
    {
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public bool? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
