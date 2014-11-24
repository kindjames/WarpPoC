using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ActionStatu
    {
        public ActionStatu()
        {
            Actions = new List<Action>();
            ActionComments = new List<ActionComment>();
        }

        public short ActionStatusId { get; set; }
        public string Name { get; set; }
        public bool OpenStatus { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
    }
}