using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TelephoneRecording
    {
        public int TelephoneRecordingID { get; set; }
        public int AssessmentID { get; set; }
        public int AssessorID { get; set; }
        public string FilePath { get; set; }
        public System.DateTime Timestamp { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
