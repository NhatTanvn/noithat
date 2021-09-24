using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Branch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Hotline { get; set; }
    }
}
