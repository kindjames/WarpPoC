using System;

namespace Warp.Data.Entities
{
    public class QuestionnaireAccountingProduct
    {
        public int QuestionnaireAccountingProductId { get; set; }
        public int QuestionnaireId { get; set; }
        public int? SubQuestionnaireId { get; set; }
        public int AccountingProductId { get; set; }
        public decimal? DefaultValue { get; set; }
        public int? KashFlowId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}