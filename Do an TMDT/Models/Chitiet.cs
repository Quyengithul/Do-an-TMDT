using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Chitiet
    {
        public Chitiet()
        {
            Kieus = new HashSet<Kieu>();
        }

        public string IdChiTiet { get; set; }
        public string Ten { get; set; }
        public int? GhId { get; set; }

        public virtual ICollection<Kieu> Kieus { get; set; }
    }
}
