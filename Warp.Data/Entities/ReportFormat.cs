using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ReportFormat
    {
        public ReportFormat()
        {
            SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
        }

        public int ReportFormatId { get; set; }
        public string Type { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
    }
}