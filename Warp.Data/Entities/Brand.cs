using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Brand
    {
        public Brand()
        {
            Branches = new List<Branch>();
            BanBrands = new List<BanBrand>();
            BrandAccountingProducts = new List<BrandAccountingProduct>();
            BrandLegacyUsers = new List<BrandLegacyUser>();
            BrandNotes = new List<BrandNote>();
            BrandQuestionnaires = new List<BrandQuestionnaire>();
            BrandSocialNetworks = new List<BrandSocialNetwork>();
            BrandHistories = new List<BrandHistory>();
            BriefBrands = new List<BriefBrand>();
            ContactAddressBrands = new List<ContactAddressBrand>();
            MenuConfigBrands = new List<MenuConfigBrand>();
            PeriodBrands = new List<PeriodBrand>();
            PersonBrands = new List<PersonBrand>();
            TerminologyBrands = new List<TerminologyBrand>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int BrandStatusId { get; set; }
        public int IndustrySectorId { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<BanBrand> BanBrands { get; set; }
        public virtual BrandStatus BrandStatus { get; set; }
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