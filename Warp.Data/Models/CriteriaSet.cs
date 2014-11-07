using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CriteriaSet
    {
        public CriteriaSet()
        {
            this.CriteriaAssessorAttributes = new List<CriteriaAssessorAttribute>();
            this.CriteriaConfigs = new List<CriteriaConfig>();
            this.Visits = new List<Visit>();
        }

        public int CriteriaSetID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
