namespace Warp.Data.Entities
{
    public partial class ReportProblemTrackingAction
    {
        public int ReportProblemTrackingActionID { get; set; }
        public int ReportProblemTrackingID { get; set; }
        public int ReportProblemActionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ReportProblemAction ReportProblemAction { get; set; }
        public virtual ReportProblemTracking ReportProblemTracking { get; set; }
    }
}
