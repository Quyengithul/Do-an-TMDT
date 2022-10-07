using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Hang
    {
        public Hang()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string IdHang { get; set; }
        public string Name { get; set; }
        public string IdKieu { get; set; }
        public string IdSp { get; set; }

        public virtual Kieu IdKieuNavigation { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
