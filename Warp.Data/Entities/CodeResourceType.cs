using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CodeResourceType
    {
        public CodeResourceType()
        {
            this.CodeResources = new List<CodeResource>();
        }

        public int CodeResourceTypeID { get; set; }
        public string ResourceTypeDescription { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<CodeResource> CodeResources { get; set; }
    }
}
