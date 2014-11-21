using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class CriteriaOperator
    {
        public CriteriaOperator()
        {
            CriteriaConfigs = new List<CriteriaConfig>();
        }

        public short CriteriaOperatorId { get; set; }
        public string Name { get; set; }
        public string SQLOperatorStart { get; set; }
        public string SQLOperatorEnd { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
    }
}