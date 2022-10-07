using System;
using System.Collections.Generic;

#nullable disable

namespace Do_an_TMDT.Models
{
    public partial class Sanpham
    {
        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public string Slug { get; set; }
        public string Gia { get; set; }
        public int? GhId { get; set; }
        public string IsActive { get; set; }
        public string BanChay { get; set; }
        public string DaBan { get; set; }
        public double? DanhGia { get; set; }
        public string Anh { get; set; }
        public string IdHang { get; set; }
        public string MoTa { get; set; }
        public string Anh2 { get; set; }

        public virtual Hang IdHangNavigation { get; set; }
    }
}
