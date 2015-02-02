using System;

namespace Warp.Data.DbFirst.Entities
{
    public class AssessorTimeTracker
    {
        public int AssessorTimeTrackerId { get; set; }
        public int AssessorId { get; set; }
        public int TimeTrackerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}