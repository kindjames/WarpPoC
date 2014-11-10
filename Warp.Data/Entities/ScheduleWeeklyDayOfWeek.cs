using System;

namespace Warp.Data.Entities
{
    public partial class ScheduleWeeklyDayOfWeek
    {
        public int ScheduleWeeklyDayOfWeekId { get; set; }
        public Nullable<int> ScheduleWeeklyId { get; set; }
        public Nullable<int> DayOfWeekId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual ScheduleWeekly ScheduleWeekly { get; set; }
    }
}
