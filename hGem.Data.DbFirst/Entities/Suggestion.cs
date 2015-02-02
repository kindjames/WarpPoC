using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Suggestion
    {
        public Suggestion()
        {
            SuggestionVotes = new List<SuggestionVote>();
        }

        public int SuggestionId { get; set; }
        public int AssessorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte SuggestionStatusId { get; set; }
        public bool AllowComments { get; set; }
        public bool DisplayComments { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual SuggestionStatus SuggestionStatus { get; set; }
        public virtual ICollection<SuggestionVote> SuggestionVotes { get; set; }
    }
}