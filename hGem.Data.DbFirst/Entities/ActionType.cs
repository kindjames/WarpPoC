using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ActionType
    {
        public ActionType()
        {
            Actions = new List<Action>();
        }

        public short ActionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}