using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ScheduleMonthly
    {
        public ScheduleMonthly()
        {
            ScheduleMonthlyMonths = new List<ScheduleMonthlyMonth>();
        }

        public int ScheduleMonthlyId { get; set; }
        public int? ScheduleId { get; set; }
        public int? DayOrdinal { get; set; }
        public int? DayNo { get; set; }
        public int? DayOfWeekId { get; set; }
        public int? MonthInterval { get; set; }
        public int? ScheduleSubTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleMonthlyMonth> ScheduleMonthlyMonths { get; set; }
    }
}