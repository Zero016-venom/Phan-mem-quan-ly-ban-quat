using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class SanPham
    {
        public SanPham()
        {
            BienThes = new HashSet<BienThe>();
        }

        public Guid IdSanPham { get; set; }
        public string? MaSanPham { get; set; }
        public string? Ten { get; set; }
        public Guid? IdLoaiSanPham { get; set; }
        public int? SoLuong { get; set; }

        public virtual LoaiSanPham? IdLoaiSanPhamNavigation { get; set; }
        public virtual ICollection<BienThe> BienThes { get; set; }
    }
}
