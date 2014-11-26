using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CriteriaOption
    {
        public CriteriaOption()
        {
            CriteriaConfigs = new List<CriteriaConfig>();
        }

        public short CriteriaOptionId { get; set; }
        public string Name { get; set; }
        public string FieldAddress { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public bool Search { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CriteriaConfig> CriteriaConfigs { get; set; }
    }
}