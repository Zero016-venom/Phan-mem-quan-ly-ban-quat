using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class BaoHanh
    {
        public BaoHanh()
        {
            LichSuBaoHanhs = new HashSet<LichSuBaoHanh>();
        }

        public Guid IdBaoHanh { get; set; }
        public Guid? IdNv { get; set; }

        public virtual NhanVien? IdNvNavigation { get; set; }
        public virtual ICollection<LichSuBaoHanh> LichSuBaoHanhs { get; set; }
    }
}
