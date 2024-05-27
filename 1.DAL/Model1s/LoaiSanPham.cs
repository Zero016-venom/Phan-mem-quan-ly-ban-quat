using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public Guid IdLoaiSanPham { get; set; }
        public string? TenLoai { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
