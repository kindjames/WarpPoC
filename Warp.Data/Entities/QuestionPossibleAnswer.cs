using System;

namespace Warp.Data.Entities
{
    public class QuestionPossibleAnswer
    {
        public int QuestionPossibleAnswerId { get; set; }
        public int QuestionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}