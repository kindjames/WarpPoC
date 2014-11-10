using System;

namespace Warp.Data.Entities
{
    public partial class ScheduleQuarterlyQuarter
    {
        public int ScheduleQuarterlyQuarterId { get; set; }
        public Nullable<int> ScheduleQuarterlyId { get; set; }
        public Nullable<int> QuarterId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Quarter Quarter { get; set; }
        public virtual ScheduleQuarterly ScheduleQuarterly { get; set; }
    }
}
