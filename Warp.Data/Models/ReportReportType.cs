using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportReportType
    {
        public int ReportReportTypeId { get; set; }
        public int ReportId { get; set; }
        public int ReportTypeId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CreatedByUserRoleId { get; set; }
        public Nullable<System.DateTime> DateRemoved { get; set; }
        public Nullable<int> RemovedByUserRoleId { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserRole UserRole1 { get; set; }
        public virtual Report Report { get; set; }
        public virtual ReportType ReportType { get; set; }
    }
}
