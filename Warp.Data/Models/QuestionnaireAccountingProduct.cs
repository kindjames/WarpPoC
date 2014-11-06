using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionnaireAccountingProduct
    {
        public int QuestionnaireAccountingProductID { get; set; }
        public int QuestionnaireID { get; set; }
        public Nullable<int> SubQuestionnaireID { get; set; }
        public int AccountingProductID { get; set; }
        public Nullable<decimal> DefaultValue { get; set; }
        public Nullable<int> KashFlowID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}
