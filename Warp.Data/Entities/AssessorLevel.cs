using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessorLevel
    {
        public AssessorLevel()
        {
            AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}