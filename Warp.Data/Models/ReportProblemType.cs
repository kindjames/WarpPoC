using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemType
    {
        public ReportProblemType()
        {
            this.ReportProblemTrackings = new List<ReportProblemTracking>();
        }

        public short ReportProblemTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
    }
}
