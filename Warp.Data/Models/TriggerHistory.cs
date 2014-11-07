using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TriggerHistory
    {
        public int TriggerHistoryId { get; set; }
        public int TriggerId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<bool> Triggered { get; set; }
        public Nullable<System.DateTime> DateTriggered { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Trigger Trigger { get; set; }
    }
}
