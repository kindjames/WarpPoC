using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Report
    {
        public Report()
        {
            this.ReportParameterValues = new List<ReportParameterValue>();
            this.ReportReportTypes = new List<ReportReportType>();
            this.ReportRestrictionClients = new List<ReportRestrictionClient>();
            this.SubscriptionReports = new List<SubscriptionReport>();
        }

        public int ReportId { get; set; }
        public string Name { get; set; }
        public int ReportCategoryId { get; set; }
        public string SSRSName { get; set; }
        public int ReportSourceId { get; set; }
        public System.DateTime DateLastChecked { get; set; }
        public int DefaultReportSectionId { get; set; }
        public string Description { get; set; }
        public bool HideDescription { get; set; }
        public string Purpose { get; set; }
        public bool HidePurpose { get; set; }
        public string Notes { get; set; }
        public string PreviewImagePath { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int CreatedByUserRoleId { get; set; }
        public Nullable<System.DateTime> DateRemoved { get; set; }
        public Nullable<int> RemovedbyUserRoleId { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserRole UserRole1 { get; set; }
        public virtual ReportCategory ReportCategory { get; set; }
        public virtual ReportSection ReportSection { get; set; }
        public virtual ReportSource ReportSource { get; set; }
        public virtual ICollection<ReportParameterValue> ReportParameterValues { get; set; }
        public virtual ICollection<ReportReportType> ReportReportTypes { get; set; }
        public virtual ICollection<ReportRestrictionClient> ReportRestrictionClients { get; set; }
        public virtual ICollection<SubscriptionReport> SubscriptionReports { get; set; }
    }
}
