using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
            LichSuTts = new HashSet<LichSuTt>();
        }

        public Guid IdHoaDon { get; set; }
        public bool? TrangThai { get; set; }
        public Guid? IdVc { get; set; }
        public Guid? IdNv { get; set; }
        public Guid? IdKh { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? NgayGd { get; set; }

        public virtual KhachHang? IdKhNavigation { get; set; }
        public virtual NhanVien? IdNvNavigation { get; set; }
        public virtual VanChuyen? IdVcNavigation { get; set; }
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
        public virtual ICollection<LichSuTt> LichSuTts { get; set; }
    }
}
