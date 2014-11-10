using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            this.QuestionTags = new List<QuestionTag>();
        }

        public short TagID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
    }
}
