using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleYearly
    {
        public int ScheduleYearlyId { get; set; }
        public int ScheduleId { get; set; }
        public int YearInterval { get; set; }
        public Nullable<int> MonthId { get; set; }
        public Nullable<int> DayNumber { get; set; }
        public Nullable<int> DayOrdinal { get; set; }
        public Nullable<int> DayOfWeekId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Month Month { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
