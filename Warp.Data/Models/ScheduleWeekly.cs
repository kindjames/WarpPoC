using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleWeekly
    {
        public ScheduleWeekly()
        {
            this.ScheduleWeeklyDayOfWeeks = new List<ScheduleWeeklyDayOfWeek>();
        }

        public int ScheduleWeeklyId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<int> RecurEveryXWeeks { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleWeeklyDayOfWeek> ScheduleWeeklyDayOfWeeks { get; set; }
    }
}
