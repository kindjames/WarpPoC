namespace Warp.Data.Entities
{
    public class AssessmentAreaBranch : EntityBase
    {
        public int AssessmentAreaBranchId { get; set; }
        public short AssessmentAreaId { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AssessmentArea AssessmentArea { get; set; }
    }
}
