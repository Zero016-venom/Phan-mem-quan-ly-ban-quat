using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class LichSuTt
    {
        public Guid IdLstt { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? Ngay { get; set; }
        public Guid? IdPttt { get; set; }
        public Guid? IdHoaDon { get; set; }

        public virtual HoaDon? IdHoaDonNavigation { get; set; }
        public virtual Pttt? IdPtttNavigation { get; set; }
    }
}
