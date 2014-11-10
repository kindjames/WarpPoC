using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ReportFormat
    {
        public ReportFormat()
        {
            this.SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
        }

        public int ReportFormatId { get; set; }
        public string Type { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
    }
}
