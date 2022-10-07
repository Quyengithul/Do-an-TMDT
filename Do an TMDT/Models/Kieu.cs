using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Kieu
    {
        public Kieu()
        {
            Hangs = new HashSet<Hang>();
        }

        public string Id { get; set; }
        public string TenKieu { get; set; }
        public string ChitietId { get; set; }

        public virtual Chitiet Chitiet { get; set; }
        public virtual ICollection<Hang> Hangs { get; set; }
    }
}
