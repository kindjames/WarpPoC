using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class BriefSection
    {
        public BriefSection()
        {
            this.BriefConfigurations = new List<BriefConfiguration>();
        }

        public short BriefSectionID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}
