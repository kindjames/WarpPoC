namespace Warp.Data.Entities
{
    public partial class VisitTimeTracker
    {
        public int VisitTimeTrackerID { get; set; }
        public int VisitID { get; set; }
        public int TimeTrackerID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
