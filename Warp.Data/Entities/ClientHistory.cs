using System;

namespace Warp.Data.Entities
{
    public partial class ClientHistory
    {
        public int ClientHistoryID { get; set; }
        public int ClientID { get; set; }
        public short ClientStatusID { get; set; }
        public string ClientName { get; set; }
        public string Code { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public int EnteredByUserRoleID { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientStatu ClientStatu { get; set; }
    }
}
