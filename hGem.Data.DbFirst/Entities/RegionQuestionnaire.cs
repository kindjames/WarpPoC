using System;

namespace Warp.Data.DbFirst.Entities
{
    public class RegionQuestionnaire
    {
        public int RegionQuestionnaireId { get; set; }
        public int RegionId { get; set; }
        public int QuestionnaireId { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Region Region { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}