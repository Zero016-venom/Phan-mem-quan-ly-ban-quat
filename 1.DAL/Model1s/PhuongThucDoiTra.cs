using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class PhuongThucDoiTra
    {
        public PhuongThucDoiTra()
        {
            LichSuDoiTras = new HashSet<LichSuDoiTra>();
        }

        public Guid IdPtdoiTra { get; set; }
        public string? Ten { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<LichSuDoiTra> LichSuDoiTras { get; set; }
    }
}
