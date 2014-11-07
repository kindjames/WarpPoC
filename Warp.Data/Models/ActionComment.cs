using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionComment
    {
        public ActionComment()
        {
            this.FurtherActionComments = new List<FurtherActionComment>();
        }

        public int ActionCommentID { get; set; }
        public int ActionID { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
        public short ActionPriorityID { get; set; }
        public short ActionTypeID { get; set; }
        public short ActionStatusID { get; set; }
        public bool Display { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual Action Action { get; set; }
        public virtual ActionStatu ActionStatu { get; set; }
        public virtual ICollection<FurtherActionComment> FurtherActionComments { get; set; }
    }
}
