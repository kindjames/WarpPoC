using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class UserRole
    {
        public UserRole()
        {
            PermissionGroupUsers = new List<PermissionGroupUser>();
            Notifications = new List<Notification>();
            People = new List<Person>();
            Reports = new List<Report>();
            Reports1 = new List<Report>();
            ReportReportTypes = new List<ReportReportType>();
            ReportReportTypes1 = new List<ReportReportType>();
            ReportRestrictionClients = new List<ReportRestrictionClient>();
            ReportRestrictionClients1 = new List<ReportRestrictionClient>();
            TourUserRoles = new List<TourUserRole>();
        }

        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int RoleId { get; set; }
        public int LegacyUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Report> Reports1 { get; set; }
        public virtual ICollection<ReportReportType> ReportReportTypes { get; set; }
        public virtual ICollection<ReportReportType> ReportReportTypes1 { get; set; }
        public virtual ICollection<ReportRestrictionClient> ReportRestrictionClients { get; set; }
        public virtual ICollection<ReportRestrictionClient> ReportRestrictionClients1 { get; set; }
        public virtual ICollection<TourUserRole> TourUserRoles { get; set; }
    }
}