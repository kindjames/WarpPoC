using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ScheduleSubType
    {
        public int ScheduleSubTypeId { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}