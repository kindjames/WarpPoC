using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SuggestionVote
    {
        public int SuggestionVoteID { get; set; }
        public int SuggestionID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime VoteDate { get; set; }
        public bool Vote { get; set; }
        public string Comment { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Suggestion Suggestion { get; set; }
    }
}
