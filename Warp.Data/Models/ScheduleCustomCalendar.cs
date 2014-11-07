using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ScheduleCustomCalendar
    {
        public int ScheduleCustomCalendarId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<int> CustomCalendarId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CustomCalendar CustomCalendar { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
