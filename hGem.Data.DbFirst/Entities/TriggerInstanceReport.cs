using System;

namespace Warp.Data.DbFirst.Entities
{
    public class TriggerInstanceReport
    {
        public int TriggerInstanceReportId { get; set; }
        public int TriggerInstanceId { get; set; }
        public int SubscriptionReportId { get; set; }
        public int TriggerInstanceReportStatusTypeId { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
        public virtual TriggerInstance TriggerInstance { get; set; }
        public virtual TriggerInstanceReportStatusType TriggerInstanceReportStatusType { get; set; }
    }
}