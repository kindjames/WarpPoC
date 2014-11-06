using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefClient
    {
        public int BriefClientID { get; set; }
        public int ClientID { get; set; }
        public int BriefID { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Brief Brief { get; set; }
    }
}
