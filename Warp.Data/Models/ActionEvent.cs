using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionEvent
    {
        public ActionEvent()
        {
            this.Events = new List<Event>();
        }

        public int ActionEventID { get; set; }
        public int ActionCategoryID { get; set; }
        public int SeverityID { get; set; }
        public string Action { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ActionCategory ActionCategory { get; set; }
        public virtual Severity Severity { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
