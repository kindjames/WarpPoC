using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
