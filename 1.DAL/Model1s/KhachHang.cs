using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid IdKh { get; set; }
        public string? TenKh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public bool? GioiTinh { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
