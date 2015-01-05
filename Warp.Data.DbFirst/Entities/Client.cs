using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Client : EntityBase
    {
        public Client()
        {
            Brands = new List<Brand>();
            AccountingClients = new List<AccountingClient>();
            AccountingPeriods = new List<AccountingPeriod>();
            BriefClients = new List<BriefClient>();
            ClientAccountingProducts = new List<ClientAccountingProduct>();
            ClientAccountManagers = new List<ClientAccountManager>();
            BanClients = new List<BanClient>();
            ClientCallBackRequests = new List<ClientCallBackRequest>();
            ClientCallInLogs = new List<ClientCallInLog>();
            ClientContactTrackings = new List<ClientContactTracking>();
            ClientLegacyUsers = new List<ClientLegacyUser>();
            ClientNotes = new List<ClientNote>();
            ClientOrganisations = new List<ClientOrganisation>();
            ClientQuestionnaires = new List<ClientQuestionnaire>();
            ClientSocialNetworks = new List<ClientSocialNetwork>();
            ClientHistories = new List<ClientHistory>();
            ContactAddressClients = new List<ContactAddressClient>();
            CustomerClients = new List<CustomerClient>();
            MenuConfigClients = new List<MenuConfigClient>();
            PeriodClients = new List<PeriodClient>();
            People = new List<Person>();
            PersonClients = new List<PersonClient>();
            Questions = new List<Question>();
            QuestionTrackers = new List<QuestionTracker>();
            ReportRestrictionClients = new List<ReportRestrictionClient>();
            TerminologyClients = new List<TerminologyClient>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public short ClientStatusId { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DateValidFrom { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<AccountingClient> AccountingClients { get; set; }
        public virtual ICollection<AccountingPeriod> AccountingPeriods { get; set; }
        public virtual ICollection<BriefClient> BriefClients { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }
        public virtual ICollection<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public virtual ICollection<ClientAccountManager> ClientAccountManagers { get; set; }
        public virtual ICollection<BanClient> BanClients { get; set; }
        public virtual ICollection<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public virtual ICollection<ClientCallInLog> ClientCallInLogs { get; set; }
        public virtual ICollection<ClientContactTracking> ClientContactTrackings { get; set; }
        public virtual ICollection<ClientLegacyUser> ClientLegacyUsers { get; set; }
        public virtual ICollection<ClientNote> ClientNotes { get; set; }
        public virtual ICollection<ClientOrganisation> ClientOrganisations { get; set; }
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
        public virtual ICollection<ReportRestrictionClient> ReportRestrictionClients { get; set; }
        public virtual ICollection<TerminologyClient> TerminologyClients { get; set; }
    }
}
