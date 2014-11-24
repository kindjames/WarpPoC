using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Region
    {
        public Region()
        {
            Areas = new List<Area>();
            AreaHistories = new List<AreaHistory>();
            PersonRegions = new List<PersonRegion>();
            RegionLegacyUsers = new List<RegionLegacyUser>();
            RegionQuestionnaires = new List<RegionQuestionnaire>();
            RegionHistories = new List<RegionHistory>();
        }

        public int RegionId { get; set; }
        public string Name { get; set; }
        public int RegionStatusId { get; set; }
        public int AreaId { get; set; }
        public int? RegionGroupId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
        public virtual ICollection<PersonRegion> PersonRegions { get; set; }
        public virtual RegionGroup RegionGroup { get; set; }
        public virtual RegionStatus RegionStatus { get; set; }
        public virtual ICollection<RegionLegacyUser> RegionLegacyUsers { get; set; }
        public virtual ICollection<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public virtual ICollection<RegionHistory> RegionHistories { get; set; }
    }
}