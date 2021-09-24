using System;
using System.Collections.Generic;

#nullable disable

namespace DoAn.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool isNew { get; set; }
        public bool Status { get; set; }

    }
}
