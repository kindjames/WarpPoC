using System;

namespace Warp.Data.Entities
{
    public partial class SubscriptionReportDestination
    {
        public int SubscriptionReportDestinationId { get; set; }
        public Nullable<int> SubscriptionReportId { get; set; }
        public Nullable<int> DestinationId { get; set; }
        public Nullable<int> ReportFormatId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual ReportFormat ReportFormat { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
    }
}
