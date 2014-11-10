using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class RemovalReason
    {
        public RemovalReason()
        {
            this.VisitAssessors = new List<VisitAssessor>();
        }

        public short RemovalReasonID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VisitAssessor> VisitAssessors { get; set; }
    }
}
