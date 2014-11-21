using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class QuestionType
    {
        public QuestionType()
        {
            Questions = new List<Question>();
        }

        public short QuestionTypeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}