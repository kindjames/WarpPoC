using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Role
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}