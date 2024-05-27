using System;
using System.Collections.Generic;

namespace _1.DAL.Model1s
{
    public partial class ChatLieu
    {
        public ChatLieu()
        {
            BienThes = new HashSet<BienThe>();
        }

        public Guid IdChatLieu { get; set; }
        public string? TenChatLieu { get; set; }

        public virtual ICollection<BienThe> BienThes { get; set; }
    }
}
