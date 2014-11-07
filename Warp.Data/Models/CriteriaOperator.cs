using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CriteriaOperator
    {
        public CriteriaOperator()
        {
            this.CriteriaConfigs = new List<CriteriaConfig>();
        }

        public short CriteriaOperatorID { get; set; }
        public string Name { get; set; }
        public string SQLOperatorStart { get; set; }
        public string SQLOperatorEnd { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
    }
}
