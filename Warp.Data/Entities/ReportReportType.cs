using System;

namespace Warp.Data.Entities
{
    public class ReportReportType
    {
        public int ReportReportTypeId { get; set; }
        public int ReportId { get; set; }
        public int ReportTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedByUserRoleId { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int? RemovedByUserRoleId { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserRole UserRole1 { get; set; }
        public virtual Report Report { get; set; }
        public virtual ReportType ReportType { get; set; }
    }
}