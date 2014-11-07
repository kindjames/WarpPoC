using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportType
    {
        public ReportType()
        {
            this.ReportReportTypes = new List<ReportReportType>();
        }

        public int ReportTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportReportType> ReportReportTypes { get; set; }
    }
}
