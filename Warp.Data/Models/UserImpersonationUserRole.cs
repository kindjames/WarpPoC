using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class UserImpersonationUserRole
    {
        public int UserImpersonationUserRoleID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int UserID { get; set; }
        public int UserRoleID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
