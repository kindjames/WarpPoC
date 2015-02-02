using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ActionUser
    {
        public int ActionUserId { get; set; }
        public int ActionId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool CommentPermission { get; set; }
        public bool Active { get; set; }
        public int AddedByUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual User User { get; set; }
        public virtual Action Action { get; set; }
    }
}