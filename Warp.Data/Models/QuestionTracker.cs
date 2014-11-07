using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionTracker
    {
        public int QuestionTrackerID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public short AddedByAdminID { get; set; }
        public int MasterQuestionID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public int ChildQuestionID { get; set; }
        public Nullable<System.DateTime> DateRemoved { get; set; }
        public Nullable<short> RemovedByAdminID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Question Question { get; set; }
        public virtual Question Question1 { get; set; }
    }
}
