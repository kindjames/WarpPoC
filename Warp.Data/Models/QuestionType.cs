using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            this.Questions = new List<Question>();
        }

        public short QuestionTypeID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
