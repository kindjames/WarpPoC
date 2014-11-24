using System;

namespace Warp.Data.Entities
{
    public class SimpleVisitTemplateBranch
    {
        public int SimpleVisitTemplateBranchId { get; set; }
        public int SimpleVisitTemplateId { get; set; }
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}