using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class Pttt
    {
        public Pttt()
        {
            LichSuTts = new HashSet<LichSuTt>();
        }

        public Guid IdPttt { get; set; }
        public string? Ten { get; set; }

        public virtual ICollection<LichSuTt> LichSuTts { get; set; }
    }
}
