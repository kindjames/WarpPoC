using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class DayOfWeek
    {
        public DayOfWeek()
        {
            this.ScheduleMonthlies = new List<ScheduleMonthly>();
            this.ScheduleQuarterlies = new List<ScheduleQuarterly>();
            this.ScheduleWeeklyDayOfWeeks = new List<ScheduleWeeklyDayOfWeek>();
            this.ScheduleYearlies = new List<ScheduleYearly>();
        }

        public int DayOfWeekId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleMonthly> ScheduleMonthlies { get; set; }
        public virtual ICollection<ScheduleQuarterly> ScheduleQuarterlies { get; set; }
        public virtual ICollection<ScheduleWeeklyDayOfWeek> ScheduleWeeklyDayOfWeeks { get; set; }
        public virtual ICollection<ScheduleYearly> ScheduleYearlies { get; set; }
    }
}
