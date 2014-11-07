using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportParameterValue
    {
        public int ReportParameterValueId { get; set; }
        public int ReportId { get; set; }
        public string ParameterName { get; set; }
        public Nullable<int> ReportParameterTypeId { get; set; }
        public bool UseDefaultDynamicValue { get; set; }
        public bool Hidden { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Report Report { get; set; }
        public virtual ReportParameterType ReportParameterType { get; set; }
    }
}
