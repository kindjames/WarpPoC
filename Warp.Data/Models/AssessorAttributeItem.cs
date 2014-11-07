using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorAttributeItem
    {
        public AssessorAttributeItem()
        {
            this.AssessorAttributes = new List<AssessorAttribute>();
            this.AssessorAttributeOptions = new List<AssessorAttributeOption>();
            this.CriteriaAssessorAttributes = new List<CriteriaAssessorAttribute>();
        }

        public short AssessorAttributeItemID { get; set; }
        public string Name { get; set; }
        public bool MultipleSelection { get; set; }
        public bool ForecRequirement { get; set; }
        public bool Display { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorAttribute> AssessorAttributes { get; set; }
        public virtual ICollection<AssessorAttributeOption> AssessorAttributeOptions { get; set; }
        public virtual ICollection<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
    }
}
