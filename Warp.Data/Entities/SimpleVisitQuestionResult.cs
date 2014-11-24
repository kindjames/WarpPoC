using System;

namespace Warp.Data.Entities
{
    public class SimpleVisitQuestionResult
    {
        public int SimpleVisitQuestionResultId { get; set; }
        public int SimpleVisitId { get; set; }
        public int QuestionnaireQuestionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public decimal Score { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual SimpleVisit SimpleVisit { get; set; }
    }
}