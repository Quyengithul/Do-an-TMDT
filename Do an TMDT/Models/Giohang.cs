using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Giohang
    {
        public int UserId { get; set; }
        public string IdGh { get; set; }

        public virtual User User { get; set; }
    }
}
