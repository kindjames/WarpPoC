using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ForumAdminReply
    {
        public int ForumAdminReply1 { get; set; }
        public int ForumThreadID { get; set; }
        public int AdminID { get; set; }
        public string ReplyText { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool Display { get; set; }
        public virtual ForumThread ForumThread { get; set; }
    }
}
