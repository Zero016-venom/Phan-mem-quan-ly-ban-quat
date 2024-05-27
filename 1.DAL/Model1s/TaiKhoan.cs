using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public Guid IdTk { get; set; }
        public string? MatKhau { get; set; }
        public string? TaiKhoan1 { get; set; }
        public bool? TrangThai { get; set; }
        public Guid? IdVaiTro { get; set; }

        public virtual VaiTro? IdVaiTroNavigation { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
