using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ScheduleQuarterlyQuarter
    {
        public int ScheduleQuarterlyQuarterId { get; set; }
        public int? ScheduleQuarterlyId { get; set; }
        public int? QuarterId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Quarter Quarter { get; set; }
        public virtual ScheduleQuarterly ScheduleQuarterly { get; set; }
    }
}