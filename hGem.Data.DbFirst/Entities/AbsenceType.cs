using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class AbsenceType
    {
        public AbsenceType()
        {
            AbsenceInstances = new List<AbsenceInstance>();
        }

        public byte AbsenceTypeId { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AbsenceInstance> AbsenceInstances { get; set; }
    }
}