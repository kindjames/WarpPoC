using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ScheduleWeekly
    {
        public ScheduleWeekly()
        {
            ScheduleWeeklyDayOfWeeks = new List<ScheduleWeeklyDayOfWeek>();
        }

        public int ScheduleWeeklyId { get; set; }
        public int? ScheduleId { get; set; }
        public int? RecurEveryXWeeks { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleWeeklyDayOfWeek> ScheduleWeeklyDayOfWeeks { get; set; }
    }
}