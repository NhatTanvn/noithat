using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string Path { get; set; }
        public bool Status { get; set; }
    }
}
