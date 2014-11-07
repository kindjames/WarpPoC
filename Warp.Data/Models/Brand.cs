using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Brand
    {
        public Brand()
        {
            this.Branches = new List<Branch>();
            this.BanBrands = new List<BanBrand>();
            this.BrandAccountingProducts = new List<BrandAccountingProduct>();
            this.BrandLegacyUsers = new List<BrandLegacyUser>();
            this.BrandNotes = new List<BrandNote>();
            this.BrandQuestionnaires = new List<BrandQuestionnaire>();
            this.BrandSocialNetworks = new List<BrandSocialNetwork>();
            this.BrandHistories = new List<BrandHistory>();
            this.BriefBrands = new List<BriefBrand>();
            this.ContactAddressBrands = new List<ContactAddressBrand>();
            this.MenuConfigBrands = new List<MenuConfigBrand>();
            this.PeriodBrands = new List<PeriodBrand>();
            this.PersonBrands = new List<PersonBrand>();
            this.TerminologyBrands = new List<TerminologyBrand>();
        }

        public int BrandID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public int BrandStatusID { get; set; }
        public int IndustrySectorID { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<BanBrand> BanBrands { get; set; }
        public virtual BrandStatu BrandStatu { get; set; }
        public virtual Client Client { get; set; }
        public virtual IndustrySector IndustrySector { get; set; }
        public virtual ICollection<BrandAccountingProduct> BrandAccountingProducts { get; set; }
        public virtual ICollection<BrandLegacyUser> BrandLegacyUsers { get; set; }
        public virtual ICollection<BrandNote> BrandNotes { get; set; }
        public virtual ICollection<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public virtual ICollection<BrandSocialNetwork> BrandSocialNetworks { get; set; }
        public virtual ICollection<BrandHistory> BrandHistories { get; set; }
        public virtual ICollection<BriefBrand> BriefBrands { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<MenuConfigBrand> MenuConfigBrands { get; set; }
        public virtual ICollection<PeriodBrand> PeriodBrands { get; set; }
        public virtual ICollection<PersonBrand> PersonBrands { get; set; }
        public virtual ICollection<TerminologyBrand> TerminologyBrands { get; set; }
    }
}
