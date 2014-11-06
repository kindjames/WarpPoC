using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionType
    {
        public ActionType()
        {
            this.Actions = new List<Action>();
        }

        public short ActionTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
