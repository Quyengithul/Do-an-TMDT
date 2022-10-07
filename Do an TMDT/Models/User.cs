using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class User
    {
        public User()
        {
            Giohangs = new HashSet<Giohang>();
        }

        public int MaUs { get; set; }
        public string Ten { get; set; }
        public string Slug { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public bool? SdtHd { get; set; }
        public bool? EmailHd { get; set; }
        public string Salt { get; set; }
        public string HashMk { get; set; }
        public string RoleId { get; set; }
        public string Diachi { get; set; }
        public string Anhdaidien { get; set; }
        public string Username { get; set; }
        public string IdGh { get; set; }

        public virtual Phanquyen Role { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
    }
}
