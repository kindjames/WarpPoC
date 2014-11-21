using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ScheduleType
    {
        public ScheduleType()
        {
            Schedules = new List<Schedule>();
        }

        public int ScheduleTypeId { get; set; }
        public string ScheduleTypeName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}