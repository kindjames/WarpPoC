using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Severity
    {
        public Severity()
        {
            Events = new List<Event>();
        }

        public int SeverityId { get; set; }
        public string Severity1 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}