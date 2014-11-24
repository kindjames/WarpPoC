using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Tag
    {
        public Tag()
        {
            QuestionTags = new List<QuestionTag>();
        }

        public short TagId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
    }
}