using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Group
    {
        public Group()
        {
            this.GroupUsers = new List<GroupUser>();
        }

        public int GroupID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
