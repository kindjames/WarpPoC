using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CriteriaOption
    {
        public CriteriaOption()
        {
            this.CriteriaConfigs = new List<CriteriaConfig>();
        }

        public short CriteriaOptionID { get; set; }
        public string Name { get; set; }
        public string FieldAddress { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public bool Search { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
    }
}
