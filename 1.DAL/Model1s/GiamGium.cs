using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public Guid IdGiamGia { get; set; }
        public double? GiaTri { get; set; }
        public string? DieuKien { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
