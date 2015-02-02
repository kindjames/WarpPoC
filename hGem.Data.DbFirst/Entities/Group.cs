using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Group
    {
        public Group()
        {
            GroupUsers = new List<GroupUser>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}