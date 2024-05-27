using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class LichSuBaoHanh
    {
        public Guid IdLsbaoHanh { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? SoLuong { get; set; }
        public string? LyDo { get; set; }
        public decimal? ThanhTien { get; set; }
        public Guid? IdBaoHanh { get; set; }
        public Guid? IdHoaDonCt { get; set; }

        public virtual BaoHanh? IdBaoHanhNavigation { get; set; }
        public virtual HoaDonCt? IdHoaDonCtNavigation { get; set; }
    }
}
