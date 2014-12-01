using System;

namespace Warp.Data.DbFirst.Entities
{
    public class TelephoneRecording
    {
        public int TelephoneRecordingId { get; set; }
        public int AssessmentId { get; set; }
        public int AssessorId { get; set; }
        public string FilePath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}