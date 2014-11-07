using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleSubType
    {
        public int ScheduleSubTypeId { get; set; }
        public string Description { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}
