using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Brief
    {
        public Brief()
        {
            Assessments = new List<Assessment>();
            BriefBranches = new List<BriefBranch>();
            BriefBrands = new List<BriefBrand>();
            BriefClients = new List<BriefClient>();
            BriefConfigurations = new List<BriefConfiguration>();
        }

        public int BriefId { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<BriefBranch> BriefBranches { get; set; }
        public virtual ICollection<BriefBrand> BriefBrands { get; set; }
        public virtual ICollection<BriefClient> BriefClients { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}