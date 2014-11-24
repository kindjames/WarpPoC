using System;

namespace Warp.Data.Entities
{
    public class ScheduleDaily
    {
        public int ScheduleDailyId { get; set; }
        public int? ScheduleId { get; set; }
        public bool? EveryWorkingWeekday { get; set; }
        public bool? DayAfterEveryWorkingWeekday { get; set; }
        public int? Interval { get; set; }
        public int? ScheduleSubTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}