using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class CriteriaSet
    {
        public CriteriaSet()
        {
            CriteriaAssessorAttributes = new List<CriteriaAssessorAttribute>();
            CriteriaConfigs = new List<CriteriaConfig>();
            Visits = new List<Visit>();
        }

        public int CriteriaSetId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}