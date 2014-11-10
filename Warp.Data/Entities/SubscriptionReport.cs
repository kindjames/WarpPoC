using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SubscriptionReport
    {
        public SubscriptionReport()
        {
            this.SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
            this.SubscriptionReportParameters = new List<SubscriptionReportParameter>();
            this.TriggerInstanceReports = new List<TriggerInstanceReport>();
        }

        public int SubscriptionReportId { get; set; }
        public int SubscriptionId { get; set; }
        public int ReportId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Report Report { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
        public virtual ICollection<SubscriptionReportParameter> SubscriptionReportParameters { get; set; }
        public virtual ICollection<TriggerInstanceReport> TriggerInstanceReports { get; set; }
    }
}
