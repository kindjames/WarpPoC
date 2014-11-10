using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Region
    {
        public Region()
        {
            this.Areas = new List<Area>();
            this.AreaHistories = new List<AreaHistory>();
            this.PersonRegions = new List<PersonRegion>();
            this.RegionLegacyUsers = new List<RegionLegacyUser>();
            this.RegionQuestionnaires = new List<RegionQuestionnaire>();
            this.RegionHistories = new List<RegionHistory>();
        }

        public int RegionID { get; set; }
        public string Name { get; set; }
        public int RegionStatusID { get; set; }
        public int AreaID { get; set; }
        public Nullable<int> RegionGroupID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
        public virtual ICollection<PersonRegion> PersonRegions { get; set; }
        public virtual RegionGroup RegionGroup { get; set; }
        public virtual RegionStatu RegionStatu { get; set; }
        public virtual ICollection<RegionLegacyUser> RegionLegacyUsers { get; set; }
        public virtual ICollection<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public virtual ICollection<RegionHistory> RegionHistories { get; set; }
    }
}
