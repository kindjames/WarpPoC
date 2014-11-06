using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BroadcastMessage
    {
        public BroadcastMessage()
        {
            this.BroadcastMessageUsers = new List<BroadcastMessageUser>();
        }

        public int BroadcastMessageID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public Nullable<System.DateTime> DateChecked { get; set; }
        public Nullable<int> CheckedByAdminID { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> RemovedDate { get; set; }
        public Nullable<int> RemovedByAdminID { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
    }
}
