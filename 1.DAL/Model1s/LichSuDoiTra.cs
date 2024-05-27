using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class LichSuDoiTra
    {
        public Guid IdLsdoiTra { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? SoLuong { get; set; }
        public string? LyDo { get; set; }
        public decimal? ThanhTien { get; set; }
        public Guid? IdPtdoiTra { get; set; }
        public Guid? IdDoiTra { get; set; }
        public Guid? IdHoaDonCt { get; set; }

        public virtual DoiTra? IdDoiTraNavigation { get; set; }
        public virtual HoaDonCt? IdHoaDonCtNavigation { get; set; }
        public virtual PhuongThucDoiTra? IdPtdoiTraNavigation { get; set; }
    }
}
