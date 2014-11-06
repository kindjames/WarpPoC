using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorStatusChangeReason
    {
        public AssessorStatusChangeReason()
        {
            this.AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorStatusChangeReasonID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}
