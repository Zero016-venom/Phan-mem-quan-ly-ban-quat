using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class VaiTro
    {
        public VaiTro()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public Guid IdVaiTro { get; set; }
        public string? Ten { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
