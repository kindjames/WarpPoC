using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Schedule
    {
        public Schedule()
        {
            ScheduleCustomCalendars = new List<ScheduleCustomCalendar>();
            ScheduleDailies = new List<ScheduleDaily>();
            ScheduleMonthlies = new List<ScheduleMonthly>();
            ScheduleQuarterlies = new List<ScheduleQuarterly>();
            ScheduleSpecifics = new List<ScheduleSpecific>();
            ScheduleWeeklies = new List<ScheduleWeekly>();
            ScheduleYearlies = new List<ScheduleYearly>();
            Triggers = new List<Trigger>();
        }

        public int ScheduleId { get; set; }
        public int ScheduleTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ScheduleType ScheduleType { get; set; }
        public virtual ICollection<ScheduleCustomCalendar> ScheduleCustomCalendars { get; set; }
        public virtual ICollection<ScheduleDaily> ScheduleDailies { get; set; }
        public virtual ICollection<ScheduleMonthly> ScheduleMonthlies { get; set; }
        public virtual ICollection<ScheduleQuarterly> ScheduleQuarterlies { get; set; }
        public virtual ICollection<ScheduleSpecific> ScheduleSpecifics { get; set; }
        public virtual ICollection<ScheduleWeekly> ScheduleWeeklies { get; set; }
        public virtual ICollection<ScheduleYearly> ScheduleYearlies { get; set; }
        public virtual ICollection<Trigger> Triggers { get; set; }
    }
}