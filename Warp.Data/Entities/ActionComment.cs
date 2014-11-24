using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ActionComment
    {
        public ActionComment()
        {
            FurtherActionComments = new List<FurtherActionComment>();
        }

        public int ActionCommentId { get; set; }
        public int ActionId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public short ActionPriorityId { get; set; }
        public short ActionTypeId { get; set; }
        public short ActionStatusId { get; set; }
        public bool Display { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual Action Action { get; set; }
        public virtual ActionStatus ActionStatus { get; set; }
        public virtual ICollection<FurtherActionComment> FurtherActionComments { get; set; }
    }
}