using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ScheduleType
    {
        public ScheduleType()
        {
            this.Schedules = new List<Schedule>();
        }

        public int ScheduleTypeId { get; set; }
        public string ScheduleTypeName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
