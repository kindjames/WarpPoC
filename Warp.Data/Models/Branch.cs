using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Branch
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
            this.MenuConfigBranches = new List<MenuConfigBranch>();
            this.PersonBranches = new List<PersonBranch>();
            this.SimpleVisits = new List<SimpleVisit>();
            this.SimpleVisitTemplateBranches = new List<SimpleVisitTemplateBranch>();
            this.Visits = new List<Visit>();
        }

        public int BranchID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public int AreaID { get; set; }
        public int BranchStatusID { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<int> IndustrySectorID { get; set; }
        public Nullable<int> PersonID { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int LocationID { get; set; }
        public string Code { get; set; }
        public string Website { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<AssessmentAreaBranch> AssessmentAreaBranches { get; set; }
        public virtual ICollection<BanBranch> BanBranches { get; set; }
        public virtual BranchStatu BranchStatu { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Location Location { get; set; }
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
        public virtual ICollection<MenuConfigBranch> MenuConfigBranches { get; set; }
        public virtual ICollection<PersonBranch> PersonBranches { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<SimpleVisitTemplateBranch> SimpleVisitTemplateBranches { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
