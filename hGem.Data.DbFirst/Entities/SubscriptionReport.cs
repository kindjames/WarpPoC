using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class SubscriptionReport
    {
        public SubscriptionReport()
        {
            SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
            SubscriptionReportParameters = new List<SubscriptionReportParameter>();
            TriggerInstanceReports = new List<TriggerInstanceReport>();
        }

        public int SubscriptionReportId { get; set; }
        public int SubscriptionId { get; set; }
        public int ReportId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Report Report { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
        public virtual ICollection<SubscriptionReportParameter> SubscriptionReportParameters { get; set; }
        public virtual ICollection<TriggerInstanceReport> TriggerInstanceReports { get; set; }
    }
}