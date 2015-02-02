using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CustomCalendar
    {
        public CustomCalendar()
        {
            CustomCalendarDates = new List<CustomCalendarDate>();
            ScheduleCustomCalendars = new List<ScheduleCustomCalendar>();
        }

        public int CustomCalendarId { get; set; }
        public string CustomCalendarName { get; set; }
        public int? Owner { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CustomCalendarDate> CustomCalendarDates { get; set; }
        public virtual ICollection<ScheduleCustomCalendar> ScheduleCustomCalendars { get; set; }
    }
}