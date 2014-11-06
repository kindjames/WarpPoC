using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionPriority
    {
        public ActionPriority()
        {
            this.Actions = new List<Action>();
        }

        public short ActionPriorityID { get; set; }
        public string Name { get; set; }
        public int WorkingDays { get; set; }
        public System.TimeSpan Hours { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
