using System;

namespace Warp.Data.DbFirst.Entities
{
    public class NoteCalendar
    {
        public int NoteCalendarId { get; set; }
        public int NoteId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
    }
}