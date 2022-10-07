using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Danhgium
    {
        public int? UserId { get; set; }
        public int? SpId { get; set; }
        public string NoiDung { get; set; }
        public int? DanhGia { get; set; }

        public virtual Sanpham Sp { get; set; }
    }
}
