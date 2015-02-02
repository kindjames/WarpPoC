using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CodeResourceType
    {
        public CodeResourceType()
        {
            CodeResources = new List<CodeResource>();
        }

        public int CodeResourceTypeId { get; set; }
        public string ResourceTypeDescription { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<CodeResource> CodeResources { get; set; }
    }
}