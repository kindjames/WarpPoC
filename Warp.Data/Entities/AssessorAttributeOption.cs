using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessorAttributeOption
    {
        public AssessorAttributeOption()
        {
            AssessorAttributes = new List<AssessorAttribute>();
        }

        public short AssessorAttributeOptionId { get; set; }
        public short AssessorAttributeItemId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorAttribute> AssessorAttributes { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
    }
}