using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientHistory
    {
        public int ClientHistoryID { get; set; }
        public int ClientID { get; set; }
        public short ClientStatusID { get; set; }
        public string ClientName { get; set; }
        public string Code { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientStatu ClientStatu { get; set; }
    }
}
