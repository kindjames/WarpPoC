using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionUser
    {
        public int ActionUserID { get; set; }
        public int ActionID { get; set; }
        public int UserID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool CommentPermission { get; set; }
        public bool Active { get; set; }
        public int AddedByUserID { get; set; }
        public virtual Action Action { get; set; }
        public virtual User User { get; set; }
    }
}
