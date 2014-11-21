using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ReportProblemType
    {
        public ReportProblemType()
        {
            ReportProblemTrackings = new List<ReportProblemTracking>();
        }

        public short ReportProblemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
    }
}