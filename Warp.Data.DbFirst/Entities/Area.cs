using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Area
    {
        public Area()
        {
            AreaLegacyUsers = new List<AreaLegacyUser>();
            AreaHistories = new List<AreaHistory>();
            Branches = new List<Branch>();
            PersonAreas = new List<PersonArea>();
        }

        public int AreaId { get; set; }
        public string Name { get; set; }
        public int AreaStatusId { get; set; }
        public int RegionId { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual AreaStatus AreaStatus { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<AreaLegacyUser> AreaLegacyUsers { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<PersonArea> PersonAreas { get; set; }
    }
}