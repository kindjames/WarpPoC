using System;

namespace Warp.Data.Entities
{
    public class SubscriptionReportParameter
    {
        public int SubscriptionReportParameterId { get; set; }
        public int SubscriptionReportId { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public bool Loop { get; set; }
        public bool UseAll { get; set; }
        public bool UseDynamicValue { get; set; }
        public int? ReportParameterTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ReportParameterType ReportParameterType { get; set; }
        public virtual SubscriptionReport SubscriptionReport { get; set; }
    }
}