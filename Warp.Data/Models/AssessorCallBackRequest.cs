using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorCallBackRequest
    {
        public int AssessorCallBackRequestID { get; set; }
        public int AssessorID { get; set; }
        public int CallBackRequestID { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}
