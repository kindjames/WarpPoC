using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Severity
    {
        public Severity()
        {
            this.Events = new List<Event>();
        }

        public int SeverityID { get; set; }
        public string Severity1 { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
