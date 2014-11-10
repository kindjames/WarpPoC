using System;

namespace Warp.Data.Entities
{
    public partial class BroadcastMessageUser
    {
        public int BroadcastMessageUserID { get; set; }
        public int BroadcastMessageID { get; set; }
        public int UserID { get; set; }
        public int AddedByAdminID { get; set; }
        public Nullable<bool> UserRead { get; set; }
        public Nullable<System.DateTime> DateRead { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual BroadcastMessage BroadcastMessage { get; set; }
    }
}
