using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            this.People = new List<Person>();
            this.ContactAddressUserRoles = new List<ContactAddressUserRole>();
            this.Notifications = new List<Notification>();
            this.PermissionGroupUsers = new List<PermissionGroupUser>();
            this.TourUserRoles = new List<TourUserRole>();
            this.UserImpersonationUserRoles = new List<UserImpersonationUserRole>();
        }

        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int RoleID { get; set; }
        public int LegacyUserID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<TourUserRole> TourUserRoles { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserImpersonationUserRole> UserImpersonationUserRoles { get; set; }
    }
}
