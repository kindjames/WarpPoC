using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Client
    {
        public Client()
        {
            this.Brands = new List<Brand>();
            this.AccountingClients = new List<AccountingClient>();
            this.AccountingPeriods = new List<AccountingPeriod>();
            this.BriefClients = new List<BriefClient>();
            this.ClientAccountingProducts = new List<ClientAccountingProduct>();
            this.ClientAccountManagers = new List<ClientAccountManager>();
            this.BanClients = new List<BanClient>();
            this.ClientCallBackRequests = new List<ClientCallBackRequest>();
            this.ClientCallInLogs = new List<ClientCallInLog>();
            this.ClientContactTrackings = new List<ClientContactTracking>();
            this.ClientLegacyUsers = new List<ClientLegacyUser>();
            this.ClientNotes = new List<ClientNote>();
            this.ClientQuestionnaires = new List<ClientQuestionnaire>();
            this.ClientSocialNetworks = new List<ClientSocialNetwork>();
            this.ClientHistories = new List<ClientHistory>();
            this.ContactAddressClients = new List<ContactAddressClient>();
            this.CustomerClients = new List<CustomerClient>();
            this.MenuConfigClients = new List<MenuConfigClient>();
            this.PeriodClients = new List<PeriodClient>();
            this.People = new List<Person>();
            this.PersonClients = new List<PersonClient>();
            this.Questions = new List<Question>();
            this.QuestionTrackers = new List<QuestionTracker>();
            this.Regions = new List<Region>();
            this.TerminologyClients = new List<TerminologyClient>();
        }

        public int ClientID { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public short ClientStatusID { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<AccountingClient> AccountingClients { get; set; }
        public virtual ICollection<AccountingPeriod> AccountingPeriods { get; set; }
        public virtual ICollection<BriefClient> BriefClients { get; set; }
        public virtual ClientStatu ClientStatu { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public virtual ICollection<ClientAccountManager> ClientAccountManagers { get; set; }
        public virtual ICollection<BanClient> BanClients { get; set; }
        public virtual ICollection<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public virtual ICollection<ClientCallInLog> ClientCallInLogs { get; set; }
        public virtual ICollection<ClientContactTracking> ClientContactTrackings { get; set; }
        public virtual ICollection<ClientLegacyUser> ClientLegacyUsers { get; set; }
        public virtual ICollection<ClientNote> ClientNotes { get; set; }
        public virtual ICollection<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public virtual ICollection<ClientSocialNetwork> ClientSocialNetworks { get; set; }
        public virtual ICollection<ClientHistory> ClientHistories { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<CustomerClient> CustomerClients { get; set; }
        public virtual ICollection<MenuConfigClient> MenuConfigClients { get; set; }
        public virtual ICollection<PeriodClient> PeriodClients { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PersonClient> PersonClients { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuestionTracker> QuestionTrackers { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<TerminologyClient> TerminologyClients { get; set; }
    }
}
