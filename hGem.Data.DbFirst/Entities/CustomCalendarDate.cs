using System;

namespace Warp.Data.DbFirst.Entities
{
    public class CustomCalendarDate
    {
        public int CustomCalendarDateId { get; set; }
        public int CustomCalendarId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CustomCalendar CustomCalendar { get; set; }
    }
}