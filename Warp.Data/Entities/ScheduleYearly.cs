using System;

namespace Warp.Data.Entities
{
    public class ScheduleYearly
    {
        public int ScheduleYearlyId { get; set; }
        public int ScheduleId { get; set; }
        public int YearInterval { get; set; }
        public int? MonthId { get; set; }
        public int? DayNumber { get; set; }
        public int? DayOrdinal { get; set; }
        public int? DayOfWeekId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Month Month { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}