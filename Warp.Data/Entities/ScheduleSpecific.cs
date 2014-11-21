using System;

namespace Warp.Data.Entities
{
    public class ScheduleSpecific
    {
        public int ScheduleSpecificId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}