using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class AbsenceType
    {
        public AbsenceType()
        {
            this.AbsenceInstances = new List<AbsenceInstance>();
        }

        public byte AbsenceTypeID { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<AbsenceInstance> AbsenceInstances { get; set; }
    }
}
