using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Hoadon
    {
        public string MaHd { get; set; }
        public string MaKh { get; set; }
        public string MaSp { get; set; }
        public int? Soluong { get; set; }
        public string Donvi { get; set; }
        public int? TongTienTt { get; set; }
        public DateTime? TimeHd { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
