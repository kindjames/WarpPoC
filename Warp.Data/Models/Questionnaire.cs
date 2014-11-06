using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            this.AreaQuestionnaires = new List<AreaQuestionnaire>();
            this.Assessments = new List<Assessment>();
            this.BranchQuestionnaires = new List<BranchQuestionnaire>();
            this.BrandQuestionnaires = new List<BrandQuestionnaire>();
            this.ClientQuestionnaires = new List<ClientQuestionnaire>();
            this.QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.RegionQuestionnaires = new List<RegionQuestionnaire>();
            this.SimpleVisitTemplates = new List<SimpleVisitTemplate>();
            this.SubQuestionnaires = new List<SubQuestionnaire>();
        }

        public int QuestionnaireID { get; set; }
        public string Title { get; set; }
        public short QuestionnaireStatusID { get; set; }
        public short QuestionnaireTypeID { get; set; }
        public short VisitTypeID { get; set; }
        public virtual ICollection<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public virtual ICollection<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public virtual ICollection<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public virtual QuestionnaireStatu QuestionnaireStatu { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public virtual ICollection<SimpleVisitTemplate> SimpleVisitTemplates { get; set; }
        public virtual ICollection<SubQuestionnaire> SubQuestionnaires { get; set; }
    }
}
