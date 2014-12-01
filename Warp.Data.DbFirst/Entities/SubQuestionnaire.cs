using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class SubQuestionnaire
    {
        public SubQuestionnaire()
        {
            AreaQuestionnaires = new List<AreaQuestionnaire>();
            Assessments = new List<Assessment>();
            BranchQuestionnaires = new List<BranchQuestionnaire>();
            BrandQuestionnaires = new List<BrandQuestionnaire>();
            ClientQuestionnaires = new List<ClientQuestionnaire>();
            QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
            RegionQuestionnaires = new List<RegionQuestionnaire>();
            SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int SubQuestionnaireId { get; set; }
        public int QuestionnaireId { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public virtual ICollection<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public virtual ICollection<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual ICollection<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
        public virtual ICollection<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}