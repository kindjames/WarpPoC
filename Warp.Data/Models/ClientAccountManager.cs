using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientAccountManager
    {
        public int ClientAccountManagerID { get; set; }
        public int ClientID { get; set; }
        public int AccountManagerID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
    }
}
