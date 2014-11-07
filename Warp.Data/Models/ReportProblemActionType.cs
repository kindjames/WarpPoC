using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemActionType
    {
        public ReportProblemActionType()
        {
            this.ReportProblemActions = new List<ReportProblemAction>();
        }

        public short ReportProblemActionTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ReportProblemAction> ReportProblemActions { get; set; }
    }
}
