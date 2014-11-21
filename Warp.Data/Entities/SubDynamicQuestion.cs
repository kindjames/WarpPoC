using System;

namespace Warp.Data.Entities
{
    public class SubDynamicQuestion
    {
        public int SubDynamicQuestionId { get; set; }
        public int MasterSubQuestionnaireQuestionOverwriteId { get; set; }
        public int PossibleAnswerId { get; set; }
        public int ChildSubQuestionnaireQuestionOverwriteId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite1 { get; set; }
    }
}