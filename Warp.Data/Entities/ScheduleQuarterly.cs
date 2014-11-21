using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ScheduleQuarterly
    {
        public ScheduleQuarterly()
        {
            ScheduleQuarterlyQuarters = new List<ScheduleQuarterlyQuarter>();
        }

        public int ScheduleQuarterlyId { get; set; }
        public int? ScheduleId { get; set; }
        public int? MonthOrdinal { get; set; }
        public int? DayNumber { get; set; }
        public int? DayOrdinal { get; set; }
        public int? DayOfWeekId { get; set; }
        public int? ScheduleSubTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleQuarterlyQuarter> ScheduleQuarterlyQuarters { get; set; }
    }
}