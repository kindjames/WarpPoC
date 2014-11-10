using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
    }
}
