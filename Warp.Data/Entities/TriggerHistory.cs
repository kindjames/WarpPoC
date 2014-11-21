using System;

namespace Warp.Data.Entities
{
    public class TriggerHistory
    {
        public int TriggerHistoryId { get; set; }
        public int TriggerId { get; set; }
        public int InstanceId { get; set; }
        public bool? Triggered { get; set; }
        public DateTime? DateTriggered { get; set; }
        public string Notes { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Trigger Trigger { get; set; }
    }
}