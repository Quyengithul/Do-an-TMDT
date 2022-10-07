using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Phanquyen
    {
        public Phanquyen()
        {
            Users = new HashSet<User>();
        }

        public string RoleId { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
