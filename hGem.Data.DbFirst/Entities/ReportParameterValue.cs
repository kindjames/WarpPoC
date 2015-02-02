using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportParameterValue
    {
        public int ReportParameterValueId { get; set; }
        public int ReportId { get; set; }
        public string ParameterName { get; set; }
        public int? ReportParameterTypeId { get; set; }
        public bool UseDefaultDynamicValue { get; set; }
        public bool Hidden { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Report Report { get; set; }
        public virtual ReportParameterType ReportParameterType { get; set; }
    }
}