using System;

namespace Warp.Data.DbFirst.Entities
{
    public class Event
    {
        public int EventLogId { get; set; }
        public int? UserRoleId { get; set; }
        public int SeverityId { get; set; }
        public int EventCategoryId { get; set; }
        public int? CodeResourceId { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual EventCategory EventCategory { get; set; }
        public virtual Severity Severity { get; set; }
    }
}