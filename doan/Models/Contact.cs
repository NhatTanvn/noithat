﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Desciption { get; set; }
    }
}
