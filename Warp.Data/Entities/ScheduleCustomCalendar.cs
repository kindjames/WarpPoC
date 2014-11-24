using System;

namespace Warp.Data.Entities
{
    public class ScheduleCustomCalendar
    {
        public int ScheduleCustomCalendarId { get; set; }
        public int? ScheduleId { get; set; }
        public int? CustomCalendarId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CustomCalendar CustomCalendar { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}