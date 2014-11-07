using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Event
    {
        public int EventLogID { get; set; }
        public Nullable<int> UserRoleID { get; set; }
        public int SeverityID { get; set; }
        public int EventCategoryID { get; set; }
        public Nullable<int> CodeResourceID { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual EventCategory EventCategory { get; set; }
        public virtual Severity Severity { get; set; }
    }
}
