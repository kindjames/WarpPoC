using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Quarter
    {
        public Quarter()
        {
            this.ScheduleQuarterlyQuarters = new List<ScheduleQuarterlyQuarter>();
        }

        public int QuarterId { get; set; }
        public string QuarterName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ScheduleQuarterlyQuarter> ScheduleQuarterlyQuarters { get; set; }
    }
}
