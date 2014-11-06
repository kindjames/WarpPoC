using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BroadcastMessageUser
    {
        public int BroadcastMessageUserID { get; set; }
        public int BroadcastMessageID { get; set; }
        public int UserID { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<bool> UserRead { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
        public virtual BroadcastMessage BroadcastMessage { get; set; }
        public virtual User User { get; set; }
    }
}
