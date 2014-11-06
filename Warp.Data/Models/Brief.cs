using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Brief
    {
        public Brief()
        {
            this.Assessments = new List<Assessment>();
            this.BriefBranches = new List<BriefBranch>();
            this.BriefBrands = new List<BriefBrand>();
            this.BriefClients = new List<BriefClient>();
            this.BriefConfigurations = new List<BriefConfiguration>();
        }

        public int BriefID { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<BriefBranch> BriefBranches { get; set; }
        public virtual ICollection<BriefBrand> BriefBrands { get; set; }
        public virtual ICollection<BriefClient> BriefClients { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}
