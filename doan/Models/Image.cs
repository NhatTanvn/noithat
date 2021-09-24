using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

#nullable disable

namespace DoAn.Models
{
    public partial class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string Path { get; set; }
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public bool Featured { get; set; }

        public virtual Product Product { get; set; }
    }
}
