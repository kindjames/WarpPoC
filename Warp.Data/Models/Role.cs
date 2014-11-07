using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            this.UserRoles = new List<UserRole>();
        }

        public int RoleID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
