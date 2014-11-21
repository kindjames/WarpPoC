using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Branch : EntityBase
    {
        public Branch()
        {
            this.AssessmentAreaBranches = new List<AssessmentAreaBranch>();
            this.BanBranches = new List<BanBranch>();
            this.BranchAccountingProducts = new List<BranchAccountingProduct>();
            this.BranchLegacyUsers = new List<BranchLegacyUser>();
            this.BranchNotes = new List<BranchNote>();
            this.BranchQuestionnaires = new List<BranchQuestionnaire>();
            this.BranchSocialNetworks = new List<BranchSocialNetwork>();
            this.BranchHistories = new List<BranchHistory>();
            this.BriefBranches = new List<BriefBranch>();
            this.BriefConfigurationBranches = new List<BriefConfigurationBranch>();
            this.ContactAddressBranches = new List<ContactAddressBranch>();
            this.PersonBranches = new List<PersonBranch>();
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
