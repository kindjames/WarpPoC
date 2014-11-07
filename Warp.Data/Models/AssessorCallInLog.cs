using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorCallInLog
    {
        public int AssessorCallInLogID { get; set; }
        public int AssessorID { get; set; }
        public int CallInLogID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CallInLog CallInLog { get; set; }
    }
}
