using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class EventCategory
    {
        public EventCategory()
        {
            Events = new List<Event>();
        }

        public int EventCategoryId { get; set; }
        public string Category { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}