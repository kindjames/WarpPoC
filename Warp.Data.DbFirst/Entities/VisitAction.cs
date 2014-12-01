using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitAction
    {
        public int VisitActionId { get; set; }
        public int VisitId { get; set; }
        public int ActionId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Action Action { get; set; }
        public virtual Visit Visit { get; set; }
    }
}