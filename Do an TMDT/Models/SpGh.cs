using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class SpGh
    {
        public string IdGh { get; set; }
        public int? SpId { get; set; }

        public virtual Giohang IdGhNavigation { get; set; }
        public virtual Sanpham Sp { get; set; }
    }
}
