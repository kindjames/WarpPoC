using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class PossibleAnswer
    {
        public PossibleAnswer()
        {
            this.DynamicQuestions = new List<DynamicQuestion>();
            this.MenuItemPossibleAnswers = new List<MenuItemPossibleAnswer>();
            this.MenuSectionPossibleAnswers = new List<MenuSectionPossibleAnswer>();
            this.QuestionnaireQuestionPossibleAnswers = new List<QuestionnaireQuestionPossibleAnswer>();
            this.QuestionPossibleAnswers = new List<QuestionPossibleAnswer>();
            this.SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
            this.SQQOPossibleAnswers = new List<SQQOPossibleAnswer>();
            this.SubDynamicQuestions = new List<SubDynamicQuestion>();
        }

        public int PossibleAnswerID { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public decimal Score { get; set; }
        public short PossibleAnswerTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions { get; set; }
        public virtual ICollection<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
        public virtual ICollection<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }
        public virtual ICollection<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set; }
        public virtual ICollection<QuestionPossibleAnswer> QuestionPossibleAnswers { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public virtual ICollection<SQQOPossibleAnswer> SQQOPossibleAnswers { get; set; }
        public virtual ICollection<SubDynamicQuestion> SubDynamicQuestions { get; set; }
    }
}
