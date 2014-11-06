using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            this.QuestionTags = new List<QuestionTag>();
        }

        public short TagID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
    }
}
