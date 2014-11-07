using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleQuarterly
    {
        public ScheduleQuarterly()
        {
            this.ScheduleQuarterlyQuarters = new List<ScheduleQuarterlyQuarter>();
        }

        public int ScheduleQuarterlyId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<int> MonthOrdinal { get; set; }
        public Nullable<int> DayNumber { get; set; }
        public Nullable<int> DayOrdinal { get; set; }
        public Nullable<int> DayOfWeekId { get; set; }
        public Nullable<int> ScheduleSubTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ScheduleQuarterlyQuarter> ScheduleQuarterlyQuarters { get; set; }
    }
}
