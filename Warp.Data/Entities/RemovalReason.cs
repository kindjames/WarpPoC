using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class RemovalReason
    {
        public RemovalReason()
        {
            VisitAssessors = new List<VisitAssessor>();
        }

        public short RemovalReasonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VisitAssessor> VisitAssessors { get; set; }
    }
}