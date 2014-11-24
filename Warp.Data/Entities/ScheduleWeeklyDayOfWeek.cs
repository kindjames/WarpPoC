using System;

namespace Warp.Data.Entities
{
    public class ScheduleWeeklyDayOfWeek
    {
        public int ScheduleWeeklyDayOfWeekId { get; set; }
        public int? ScheduleWeeklyId { get; set; }
        public int? DayOfWeekId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual ScheduleWeekly ScheduleWeekly { get; set; }
    }
}