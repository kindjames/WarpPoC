using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class BriefSection
    {
        public BriefSection()
        {
            BriefConfigurations = new List<BriefConfiguration>();
        }

        public short BriefSectionId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}