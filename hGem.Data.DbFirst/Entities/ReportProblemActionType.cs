using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportProblemActionType
    {
        public ReportProblemActionType()
        {
            ReportProblemActions = new List<ReportProblemAction>();
        }

        public short ReportProblemActionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemAction> ReportProblemActions { get; set; }
    }
}