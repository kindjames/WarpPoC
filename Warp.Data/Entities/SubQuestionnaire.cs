using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SubQuestionnaire
    {
        public SubQuestionnaire()
        {
            this.AreaQuestionnaires = new List<AreaQuestionnaire>();
            this.Assessments = new List<Assessment>();
            this.BranchQuestionnaires = new List<BranchQuestionnaire>();
            this.BrandQuestionnaires = new List<BrandQuestionnaire>();
            this.ClientQuestionnaires = new List<ClientQuestionnaire>();
            this.QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
            this.RegionQuestionnaires = new List<RegionQuestionnaire>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int SubQuestionnaireID { get; set; }
        public int QuestionnaireID { get; set; }
        public string Title { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
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
