using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class BriefItem
    {
        public BriefItem()
        {
            BriefConfigurations = new List<BriefConfiguration>();
        }

        public int BriefItemId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}