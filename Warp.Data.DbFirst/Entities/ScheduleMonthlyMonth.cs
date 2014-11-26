using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ScheduleMonthlyMonth
    {
        public int ScheduleMonthlyMonthId { get; set; }
        public int? ScheduleMonthlyId { get; set; }
        public int? MonthId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Month Month { get; set; }
        public virtual ScheduleMonthly ScheduleMonthly { get; set; }
    }
}