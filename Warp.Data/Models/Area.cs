using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Area
    {
        public Area()
        {
            this.AreaLegacyUsers = new List<AreaLegacyUser>();
            this.AreaQuestionnaires = new List<AreaQuestionnaire>();
            this.AreaHistories = new List<AreaHistory>();
            this.Branches = new List<Branch>();
            this.PersonAreas = new List<PersonArea>();
        }

        public int AreaID { get; set; }
        public string Name { get; set; }
        public int AreaStatusID { get; set; }
        public int RegionID { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual AreaStatu AreaStatu { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<AreaLegacyUser> AreaLegacyUsers { get; set; }
        public virtual ICollection<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<PersonArea> PersonAreas { get; set; }
    }
}
