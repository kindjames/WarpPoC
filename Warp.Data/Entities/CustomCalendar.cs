using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CustomCalendar
    {
        public CustomCalendar()
        {
            this.CustomCalendarDates = new List<CustomCalendarDate>();
            this.ScheduleCustomCalendars = new List<ScheduleCustomCalendar>();
        }

        public int CustomCalendarId { get; set; }
        public string CustomCalendarName { get; set; }
        public Nullable<int> Owner { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CustomCalendarDate> CustomCalendarDates { get; set; }
        public virtual ICollection<ScheduleCustomCalendar> ScheduleCustomCalendars { get; set; }
    }
}
