using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class DayOfWeek
    {
        public DayOfWeek()
        {
            ScheduleMonthlies = new List<ScheduleMonthly>();
            ScheduleQuarterlies = new List<ScheduleQuarterly>();
            ScheduleWeeklyDayOfWeeks = new List<ScheduleWeeklyDayOfWeek>();
            ScheduleYearlies = new List<ScheduleYearly>();
        }

        public int DayOfWeekId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleMonthly> ScheduleMonthlies { get; set; }
        public virtual ICollection<ScheduleQuarterly> ScheduleQuarterlies { get; set; }
        public virtual ICollection<ScheduleWeeklyDayOfWeek> ScheduleWeeklyDayOfWeeks { get; set; }
        public virtual ICollection<ScheduleYearly> ScheduleYearlies { get; set; }
    }
}