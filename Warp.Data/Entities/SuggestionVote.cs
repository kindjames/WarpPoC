using System;

namespace Warp.Data.Entities
{
    public class SuggestionVote
    {
        public int SuggestionVoteId { get; set; }
        public int SuggestionId { get; set; }
        public int AssessorId { get; set; }
        public DateTime DateOfVote { get; set; }
        public bool Vote { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Suggestion Suggestion { get; set; }
    }
}