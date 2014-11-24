using System;

namespace Warp.Data.Entities
{
    public class SQQOPossibleAnswer
    {
        public int SQQOPossibleAnswerId { get; set; }
        public int SubQuestionnaireQuestionOverwriteId { get; set; }
        public int PossibleAnswerId { get; set; }
        public decimal? Score { get; set; }
        public string Guidance { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite { get; set; }
    }
}