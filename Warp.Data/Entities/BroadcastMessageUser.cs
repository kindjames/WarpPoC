using System;

namespace Warp.Data.Entities
{
    public class BroadcastMessageUser
    {
        public int BroadcastMessageUserId { get; set; }
        public int BroadcastMessageId { get; set; }
        public int UserId { get; set; }
        public int AddedByAdminId { get; set; }
        public bool? UserRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual BroadcastMessage BroadcastMessage { get; set; }
    }
}