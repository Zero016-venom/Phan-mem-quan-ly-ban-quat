using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class SoCanh
    {
        public SoCanh()
        {
            BienThes = new HashSet<BienThe>();
        }

        public Guid IdCanh { get; set; }
        public int? SoCanh1 { get; set; }

        public virtual ICollection<BienThe> BienThes { get; set; }
    }
}
