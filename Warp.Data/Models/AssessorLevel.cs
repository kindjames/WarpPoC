using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorLevel
    {
        public AssessorLevel()
        {
            this.AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorLevelID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}
