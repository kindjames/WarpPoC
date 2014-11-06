using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PeriodClient
    {
        public int PeriodClientID { get; set; }
        public int PeriodID { get; set; }
        public int ClientID { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Period Period { get; set; }
    }
}
