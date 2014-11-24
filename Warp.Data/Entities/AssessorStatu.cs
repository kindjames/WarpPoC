using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessorStatus
    {
        public AssessorStatus()
        {
            AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorStatusId { get; set; }
        public string InternalName { get; set; }
        public string ExternalName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}