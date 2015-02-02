using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class TriggerInstanceReportStatusType
    {
        public TriggerInstanceReportStatusType()
        {
            TriggerInstanceReports = new List<TriggerInstanceReport>();
        }

        public int TriggerInstanceReportStatusTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TriggerInstanceReport> TriggerInstanceReports { get; set; }
    }
}