using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class DynamicQuestion
    {
        public int DynamicQuestionID { get; set; }
        public int MasterQuestionnaireQuestionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public Nullable<int> ChildQuestionnaireQuestionID { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion1 { get; set; }
    }
}
