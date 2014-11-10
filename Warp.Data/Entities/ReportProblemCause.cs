using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ReportProblemCause
    {
        public ReportProblemCause()
        {
            this.ReportProblemTrackings = new List<ReportProblemTracking>();
        }

        public short ReportProblemCauseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
    }
}
