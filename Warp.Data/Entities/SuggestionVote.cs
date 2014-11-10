namespace Warp.Data.Entities
{
    public partial class SuggestionVote
    {
        public int SuggestionVoteID { get; set; }
        public int SuggestionID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime DateOfVote { get; set; }
        public bool Vote { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Suggestion Suggestion { get; set; }
    }
}
