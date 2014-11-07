using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleMonthlyMonth
    {
        public int ScheduleMonthlyMonthId { get; set; }
        public Nullable<int> ScheduleMonthlyId { get; set; }
        public Nullable<int> MonthId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Month Month { get; set; }
        public virtual ScheduleMonthly ScheduleMonthly { get; set; }
    }
}
