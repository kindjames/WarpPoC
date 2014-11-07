using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SQQOPossibleAnswer
    {
        public int SQQOPossibleAnswerID { get; set; }
        public int SubQuestionnaireQuestionOverwriteID { get; set; }
        public int PossibleAnswerID { get; set; }
        public Nullable<decimal> Score { get; set; }
        public string Guidance { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite { get; set; }
    }
}
