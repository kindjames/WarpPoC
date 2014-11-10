using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Suggestion
    {
        public Suggestion()
        {
            this.SuggestionVotes = new List<SuggestionVote>();
        }

        public int SuggestionID { get; set; }
        public int AssessorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte SuggestionStatusID { get; set; }
        public bool AllowComments { get; set; }
        public bool DisplayComments { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual SuggestionStatu SuggestionStatu { get; set; }
        public virtual ICollection<SuggestionVote> SuggestionVotes { get; set; }
    }
}
