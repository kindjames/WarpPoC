using System;

namespace Warp.Data.Entities
{
    public class BrandQuestionnaire
    {
        public int BrandQuestionnaireId { get; set; }
        public int BrandId { get; set; }
        public int QuestionnaireId { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}