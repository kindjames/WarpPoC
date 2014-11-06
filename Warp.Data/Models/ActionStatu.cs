using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionStatu
    {
        public ActionStatu()
        {
            this.Actions = new List<Action>();
            this.ActionComments = new List<ActionComment>();
        }

        public short ActionStatusID { get; set; }
        public string Name { get; set; }
        public bool OpenStatus { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
    }
}
