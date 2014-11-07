using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorStatu
    {
        public AssessorStatu()
        {
            this.AssessorHistories = new List<AssessorHistory>();
        }

        public short AssessorStatusID { get; set; }
        public string InternalName { get; set; }
        public string ExternalName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}
