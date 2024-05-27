using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class BienThe
    {
        public BienThe()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public Guid IdBienThe { get; set; }
        public string? MaBienThe { get; set; }
        public decimal? GiaTien { get; set; }
        public int? TgbaoHanh { get; set; }
        public decimal? CongSuat { get; set; }
        public int? SoLuong { get; set; }
        public double? ChieuCao { get; set; }
        public double? BanKinh { get; set; }
        public byte[]? HinhAnh { get; set; }
        public Guid? IdChatLieu { get; set; }
        public Guid? IdMau { get; set; }
        public Guid? IdCanh { get; set; }
        public Guid? IdSanPham { get; set; }

        public virtual SoCanh? IdCanhNavigation { get; set; }
        public virtual ChatLieu? IdChatLieuNavigation { get; set; }
        public virtual Mau? IdMauNavigation { get; set; }
        public virtual SanPham? IdSanPhamNavigation { get; set; }
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
