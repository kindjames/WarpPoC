using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ReportParameterType
    {
        public ReportParameterType()
        {
            this.ReportParameterValues = new List<ReportParameterValue>();
            this.SubscriptionReportParameters = new List<SubscriptionReportParameter>();
        }

        public int ReportParameterTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool HideByDefault { get; set; }
        public bool UseDefaultValueByDefault { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportParameterValue> ReportParameterValues { get; set; }
        public virtual ICollection<SubscriptionReportParameter> SubscriptionReportParameters { get; set; }
    }
}
