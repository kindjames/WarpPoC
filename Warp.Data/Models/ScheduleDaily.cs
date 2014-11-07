using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleDaily
    {
        public int ScheduleDailyId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<bool> EveryWorkingWeekday { get; set; }
        public Nullable<bool> DayAfterEveryWorkingWeekday { get; set; }
        public Nullable<int> Interval { get; set; }
        public Nullable<int> ScheduleSubTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
