using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Branch : EntityBase
    {
        public Branch()
        {
            AssessmentAreaBranches = new List<AssessmentAreaBranch>();
            BanBranches = new List<BanBranch>();
            BranchAccountingProducts = new List<BranchAccountingProduct>();
            BranchLegacyUsers = new List<BranchLegacyUser>();
            BranchNotes = new List<BranchNote>();
            BranchQuestionnaires = new List<BranchQuestionnaire>();
            BranchSocialNetworks = new List<BranchSocialNetwork>();
            BranchHistories = new List<BranchHistory>();
            BriefBranches = new List<BriefBranch>();
            BriefConfigurationBranches = new List<BriefConfigurationBranch>();
            ContactAddressBranches = new List<ContactAddressBranch>();
            PersonBranches = new List<PersonBranch>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int AreaId { get; set; }
        public int BranchStatusId { get; set; }
        public int CurrencyId { get; set; }
        public int? IndustrySectorId { get; set; }
        public int? PersonId { get; set; }
        public string Code { get; set; }
        public string Website { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<AssessmentAreaBranch> AssessmentAreaBranches { get; set; }
        public virtual ICollection<BanBranch> BanBranches { get; set; }
        public virtual BranchStatus BranchStatus { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<BranchAccountingProduct> BranchAccountingProducts { get; set; }
        public virtual ICollection<BranchLegacyUser> BranchLegacyUsers { get; set; }
        public virtual ICollection<BranchNote> BranchNotes { get; set; }
        public virtual ICollection<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public virtual ICollection<BranchSocialNetwork> BranchSocialNetworks { get; set; }
        public virtual ICollection<BranchHistory> BranchHistories { get; set; }
        public virtual ICollection<BriefBranch> BriefBranches { get; set; }
        public virtual ICollection<BriefConfigurationBranch> BriefConfigurationBranches { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<PersonBranch> PersonBranches { get; set; }
    }
}
