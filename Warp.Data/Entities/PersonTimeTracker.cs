using System;

namespace Warp.Data.Entities
{
    public class PersonTimeTracker
    {
        public int PersonTimeTrackerId { get; set; }
        public int PersonId { get; set; }
        public int TimeTrackerId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}