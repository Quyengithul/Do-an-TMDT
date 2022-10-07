using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Nhapkho
    {
        public string MaNv { get; set; }
        public string MaSp { get; set; }
        public int? SoLuongNhap { get; set; }
        public string Donvi { get; set; }
        public int? GiaNhap { get; set; }
        public DateTime? Tgnhap { get; set; }

        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
