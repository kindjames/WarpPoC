using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GroupUser
    {
        public int GroupUserID { get; set; }
        public int GroupID { get; set; }
        public int UserID { get; set; }
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
