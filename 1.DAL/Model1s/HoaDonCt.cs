using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class HoaDonCt
    {
        public HoaDonCt()
        {
            LichSuBaoHanhs = new HashSet<LichSuBaoHanh>();
            LichSuDoiTras = new HashSet<LichSuDoiTra>();
        }

        public Guid IdHoaDonCt { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public Guid? IdBienThe { get; set; }
        public Guid? IdGiamGia { get; set; }
        public Guid? IdHoaDon { get; set; }

        public virtual BienThe? IdBienTheNavigation { get; set; }
        public virtual GiamGium? IdGiamGiaNavigation { get; set; }
        public virtual HoaDon? IdHoaDonNavigation { get; set; }
        public virtual ICollection<LichSuBaoHanh> LichSuBaoHanhs { get; set; }
        public virtual ICollection<LichSuDoiTra> LichSuDoiTras { get; set; }
    }
}
