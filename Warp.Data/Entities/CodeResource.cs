using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CodeResource
    {
        public CodeResource()
        {
            this.Translations = new List<Translation>();
        }

        public int CodeResourceID { get; set; }
        public int CodeResourceTypeID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual CodeResourceType CodeResourceType { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
    }
}
