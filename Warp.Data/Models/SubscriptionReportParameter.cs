using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SubscriptionReportParameter
    {
        public int SubscriptionReportParameterId { get; set; }
        public int SubscriptionReportId { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public bool Loop { get; set; }
        public bool UseAll { get; set; }
        public bool UseDynamicValue { get; set; }
        public Nullable<int> ReportParameterTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ReportParameterType ReportParameterType { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
    }
}
