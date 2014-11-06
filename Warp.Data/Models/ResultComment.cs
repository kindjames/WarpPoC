using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ResultComment
    {
        public int ResultCommentID { get; set; }
        public int AssessmentID { get; set; }
        public int AssessorID { get; set; }
        public string AssessorComments { get; set; }
        public Nullable<int> AdminID { get; set; }
        public string AdminComments { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
