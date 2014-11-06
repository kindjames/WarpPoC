using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionResultAction
    {
        public int QuestionResultActionID { get; set; }
        public int QuestionResultID { get; set; }
        public int ActionID { get; set; }
        public virtual Action Action { get; set; }
        public virtual QuestionResult QuestionResult { get; set; }
    }
}
