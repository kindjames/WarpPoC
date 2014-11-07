using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SimpleVisitQuestionResult
    {
        public int SimpleVisitQuestionResultID { get; set; }
        public int SimpleVisitID { get; set; }
        public int QuestionnaireQuestionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public decimal Score { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual SimpleVisit SimpleVisit { get; set; }
    }
}
