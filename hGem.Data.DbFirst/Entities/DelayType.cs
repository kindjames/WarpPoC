using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class DelayType
    {
        public DelayType()
        {
            TriggerEvents = new List<TriggerEvent>();
        }

        public int DelayTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
    }
}