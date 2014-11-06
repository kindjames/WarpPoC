using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionTag
    {
        public int QuestionTagID { get; set; }
        public int QuestionID { get; set; }
        public short TagID { get; set; }
        public virtual Question Question { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
