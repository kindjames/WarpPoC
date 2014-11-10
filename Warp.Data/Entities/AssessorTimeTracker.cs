namespace Warp.Data.Entities
{
    public partial class AssessorTimeTracker
    {
        public int AssessorTimeTrackerID { get; set; }
        public int AssessorID { get; set; }
        public int TimeTrackerID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}
