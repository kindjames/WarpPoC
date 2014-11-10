using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class DelayType
    {
        public DelayType()
        {
            this.TriggerEvents = new List<TriggerEvent>();
        }

        public int DelayTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
    }
}
