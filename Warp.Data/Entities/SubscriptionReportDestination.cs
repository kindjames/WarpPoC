using System;

namespace Warp.Data.Entities
{
    public class SubscriptionReportDestination
    {
        public int SubscriptionReportDestinationId { get; set; }
        public int? SubscriptionReportId { get; set; }
        public int? DestinationId { get; set; }
        public int? ReportFormatId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual ReportFormat ReportFormat { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
    }
}