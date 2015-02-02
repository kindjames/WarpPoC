using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            AreaQuestionnaires = new List<AreaQuestionnaire>();
            Assessments = new List<Assessment>();
            BranchQuestionnaires = new List<BranchQuestionnaire>();
            BrandQuestionnaires = new List<BrandQuestionnaire>();
            ClientQuestionnaires = new List<ClientQuestionnaire>();
            QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
            QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            RegionQuestionnaires = new List<RegionQuestionnaire>();
            SimpleVisitTemplates = new List<SimpleVisitTemplate>();
            SubQuestionnaires = new List<SubQuestionnaire>();
        }

        public int QuestionnaireId { get; set; }
        public string Title { get; set; }
        public short QuestionnaireStatusId { get; set; }
        public short QuestionnaireTypeId { get; set; }
        public short VisitTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public virtual ICollection<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public virtual ICollection<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public virtual QuestionnaireStatus QuestionnaireStatus { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public virtual ICollection<SimpleVisitTemplate> SimpleVisitTemplates { get; set; }
        public virtual ICollection<SubQuestionnaire> SubQuestionnaires { get; set; }
    }
}