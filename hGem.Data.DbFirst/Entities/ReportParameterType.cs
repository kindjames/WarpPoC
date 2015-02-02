using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportParameterType
    {
        public ReportParameterType()
        {
            ReportParameterValues = new List<ReportParameterValue>();
            SubscriptionReportParameters = new List<SubscriptionReportParameter>();
        }

        public int ReportParameterTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool HideByDefault { get; set; }
        public bool UseDefaultValueByDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportParameterValue> ReportParameterValues { get; set; }
        public virtual ICollection<SubscriptionReportParameter> SubscriptionReportParameters { get; set; }
    }
}