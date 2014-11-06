using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessmentAreaBranch
    {
        public int AssessmentAreaBranchID { get; set; }
        public short AssessmentAreaID { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AssessmentArea AssessmentArea { get; set; }
    }
}
