using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class AssessorAttributeItem
    {
        public AssessorAttributeItem()
        {
            AssessorAttributes = new List<AssessorAttribute>();
            AssessorAttributeOptions = new List<AssessorAttributeOption>();
            CriteriaAssessorAttributes = new List<CriteriaAssessorAttribute>();
        }

        public short AssessorAttributeItemId { get; set; }
        public string Name { get; set; }
        public bool MultipleSelection { get; set; }
        public bool ForecRequirement { get; set; }
        public bool Display { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorAttribute> AssessorAttributes { get; set; }
        public virtual ICollection<AssessorAttributeOption> AssessorAttributeOptions { get; set; }
        public virtual ICollection<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
    }
}