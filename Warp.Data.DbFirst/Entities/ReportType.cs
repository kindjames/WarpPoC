using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportType
    {
        public ReportType()
        {
            ReportReportTypes = new List<ReportReportType>();
        }

        public int ReportTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportReportType> ReportReportTypes { get; set; }
    }
}