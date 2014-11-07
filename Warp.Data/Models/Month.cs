using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Month
    {
        public Month()
        {
            this.ScheduleMonthlyMonths = new List<ScheduleMonthlyMonth>();
            this.ScheduleYearlies = new List<ScheduleYearly>();
        }

        public int MonthId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleMonthlyMonth> ScheduleMonthlyMonths { get; set; }
        public virtual ICollection<ScheduleYearly> ScheduleYearlies { get; set; }
    }
}
