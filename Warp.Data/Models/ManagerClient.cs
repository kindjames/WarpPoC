using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerClient
    {
        public int ManagerClientID { get; set; }
        public int ManagerID { get; set; }
        public int ClientID { get; set; }
        public virtual Client1 Client1 { get; set; }
    }
}
