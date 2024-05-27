using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class Mau
    {
        public Mau()
        {
            BienThes = new HashSet<BienThe>();
        }

        public Guid IdMau { get; set; }
        public string? TenMau { get; set; }

        public virtual ICollection<BienThe> BienThes { get; set; }
    }
}
