using System;

namespace Warp.Data.Entities
{
    public class ForumAdminReply
    {
        public int ForumAdminReply1 { get; set; }
        public int ForumThreadId { get; set; }
        public int AdminId { get; set; }
        public string ReplyText { get; set; }
        public bool Display { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ForumThread ForumThread { get; set; }
    }
}