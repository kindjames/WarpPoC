using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessmentType
    {
        public AssessmentType()
        {
            AssessmentAreas = new List<AssessmentArea>();
        }

        public short AssessmentTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessmentArea> AssessmentAreas { get; set; }
    }
}