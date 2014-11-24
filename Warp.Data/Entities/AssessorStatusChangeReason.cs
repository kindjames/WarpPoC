using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessorStatusChangeReason
    {
        public AssessorStatusChangeReason()
        {
            AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorStatusChangeReasonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}