using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ActionPriority
    {
        public ActionPriority()
        {
            Actions = new List<Action>();
        }

        public short ActionPriorityId { get; set; }
        public string Name { get; set; }
        public int WorkingDays { get; set; }
        public TimeSpan Hours { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}