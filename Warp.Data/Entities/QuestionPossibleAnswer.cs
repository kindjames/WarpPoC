namespace Warp.Data.Entities
{
    public partial class QuestionPossibleAnswer
    {
        public int QuestionPossibleAnswerID { get; set; }
        public int QuestionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}
