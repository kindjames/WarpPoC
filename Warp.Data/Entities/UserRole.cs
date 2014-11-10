using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class UserRole
    {
        public UserRole()
        {
            this.PermissionGroupUsers = new List<PermissionGroupUser>();
            this.Notifications = new List<Notification>();
            this.People = new List<Person>();
            this.Reports = new List<Report>();
            this.Reports1 = new List<Report>();
            this.ReportReportTypes = new List<ReportReportType>();
            this.ReportReportTypes1 = new List<ReportReportType>();
            this.ReportRestrictionClients = new List<ReportRestrictionClient>();
            this.ReportRestrictionClients1 = new List<ReportRestrictionClient>();
            this.TourUserRoles = new List<TourUserRole>();
        }

        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int RoleID { get; set; }
        public int LegacyUserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
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
