namespace Warp.Data.Entities
{
    public partial class TelephoneRecording
    {
        public int TelephoneRecordingID { get; set; }
        public int AssessmentID { get; set; }
        public int AssessorID { get; set; }
        public string FilePath { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
