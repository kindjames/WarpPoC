using System;

namespace Warp.Data.DbFirst.Entities
{
    public class QuestionnaireQuestionPossibleAnswer
    {
        public int QuestionnaireQuestionPossibleAnswerId { get; set; }
        public int QuestionnaireQuestionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public decimal? Score { get; set; }
        public string Guidance { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
    }
}