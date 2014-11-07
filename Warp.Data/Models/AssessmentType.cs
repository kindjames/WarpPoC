using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessmentType
    {
        public AssessmentType()
        {
            this.AssessmentAreas = new List<AssessmentArea>();
        }

        public short AssessmentTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessmentArea> AssessmentAreas { get; set; }
    }
}
