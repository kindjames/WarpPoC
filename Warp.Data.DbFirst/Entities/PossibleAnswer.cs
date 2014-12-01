using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class PossibleAnswer
    {
        public PossibleAnswer()
        {
            DynamicQuestions = new List<DynamicQuestion>();
            MenuItemPossibleAnswers = new List<MenuItemPossibleAnswer>();
            MenuSectionPossibleAnswers = new List<MenuSectionPossibleAnswer>();
            QuestionnaireQuestionPossibleAnswers = new List<QuestionnaireQuestionPossibleAnswer>();
            QuestionPossibleAnswers = new List<QuestionPossibleAnswer>();
            SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
            SQQOPossibleAnswers = new List<SQQOPossibleAnswer>();
            SubDynamicQuestions = new List<SubDynamicQuestion>();
        }

        public int PossibleAnswerId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public decimal Score { get; set; }
        public short PossibleAnswerTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions { get; set; }
        public virtual ICollection<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
        public virtual ICollection<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }

        public virtual ICollection<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set;
        }

        public virtual ICollection<QuestionPossibleAnswer> QuestionPossibleAnswers { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public virtual ICollection<SQQOPossibleAnswer> SQQOPossibleAnswers { get; set; }
        public virtual ICollection<SubDynamicQuestion> SubDynamicQuestions { get; set; }
    }
}