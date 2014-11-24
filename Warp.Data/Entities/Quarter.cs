using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Quarter
    {
        public Quarter()
        {
            ScheduleQuarterlyQuarters = new List<ScheduleQuarterlyQuarter>();
        }

        public int QuarterId { get; set; }
        public string QuarterName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleQuarterlyQuarter> ScheduleQuarterlyQuarters { get; set; }
    }
}