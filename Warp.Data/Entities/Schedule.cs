using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Schedule
    {
        public Schedule()
        {
            this.ScheduleCustomCalendars = new List<ScheduleCustomCalendar>();
            this.ScheduleDailies = new List<ScheduleDaily>();
            this.ScheduleMonthlies = new List<ScheduleMonthly>();
            this.ScheduleQuarterlies = new List<ScheduleQuarterly>();
            this.ScheduleSpecifics = new List<ScheduleSpecific>();
            this.ScheduleWeeklies = new List<ScheduleWeekly>();
            this.ScheduleYearlies = new List<ScheduleYearly>();
            this.Triggers = new List<Trigger>();
        }

        public int ScheduleId { get; set; }
        public int ScheduleTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
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
