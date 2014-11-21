using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class BroadcastMessage
    {
        public BroadcastMessage()
        {
            BroadcastMessageUsers = new List<BroadcastMessageUser>();
        }

        public int BroadcastMessageId { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime? DateChecked { get; set; }
        public int? CheckedByAdminId { get; set; }
        public string Message { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int? RemovedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
    }
}