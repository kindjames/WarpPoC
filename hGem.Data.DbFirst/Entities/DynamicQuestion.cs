using System;

namespace Warp.Data.DbFirst.Entities
{
    public class DynamicQuestion
    {
        public int DynamicQuestionId { get; set; }
        public int MasterQuestionnaireQuestionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public int? ChildQuestionnaireQuestionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion1 { get; set; }
    }
}