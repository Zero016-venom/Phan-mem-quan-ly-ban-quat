using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            BaoHanhs = new HashSet<BaoHanh>();
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid IdNv { get; set; }
        public string? Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? Sdt { get; set; }
        public bool? GioiTinh { get; set; }
        public bool? TrangThai { get; set; }
        public Guid? IdTk { get; set; }

        public virtual TaiKhoan? IdTkNavigation { get; set; }
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
