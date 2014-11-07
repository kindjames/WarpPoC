using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TriggerInstanceReport
    {
        public int TriggerInstanceReportId { get; set; }
        public int TriggerInstanceId { get; set; }
        public int SubscriptionReportId { get; set; }
        public int TriggerInstanceReportStatusTypeId { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
        public virtual TriggerInstance TriggerInstance { get; set; }
        public virtual TriggerInstanceReportStatusType TriggerInstanceReportStatusType { get; set; }
    }
}
