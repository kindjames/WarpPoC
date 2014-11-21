using System;

namespace Warp.Data.Entities
{
    public class VisitTimeTracker
    {
        public int VisitTimeTrackerId { get; set; }
        public int VisitId { get; set; }
        public int TimeTrackerId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
        public virtual Visit Visit { get; set; }
    }
}