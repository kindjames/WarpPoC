using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleMonthly
    {
        public ScheduleMonthly()
        {
            this.ScheduleMonthlyMonths = new List<ScheduleMonthlyMonth>();
        }

        public int ScheduleMonthlyId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<int> DayOrdinal { get; set; }
        public Nullable<int> DayNo { get; set; }
        public Nullable<int> DayOfWeekId { get; set; }
        public Nullable<int> MonthInterval { get; set; }
        public Nullable<int> ScheduleSubTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleMonthlyMonth> ScheduleMonthlyMonths { get; set; }
    }
}
