using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Month
    {
        public Month()
        {
            ScheduleMonthlyMonths = new List<ScheduleMonthlyMonth>();
            ScheduleYearlies = new List<ScheduleYearly>();
        }

        public int MonthId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleMonthlyMonth> ScheduleMonthlyMonths { get; set; }
        public virtual ICollection<ScheduleYearly> ScheduleYearlies { get; set; }
    }
}