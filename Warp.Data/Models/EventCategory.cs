using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class EventCategory
    {
        public EventCategory()
        {
            this.Events = new List<Event>();
        }

        public int EventCategoryID { get; set; }
        public string Category { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
