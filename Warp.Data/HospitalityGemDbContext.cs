using System.Data.Entity;
using Warp.Data.Models.Mapping;
using Warp.Data.Models;

namespace Warp.Data
{
    public partial class HospitalityGemDbContext : DbContext, IHospitalityGemDbContext
    {
        static HospitalityGemDbContext()
        {
            Database.SetInitializer<HospitalityGemDbContext>(null);
        }

        public HospitalityGemDbContext()
            : base("Name=HospitalityGEMLocalContext")
        {
        }

        public IDbSet<ActionCategory> ActionCategories { get; set; }
        public IDbSet<ActionEvent> ActionEvents { get; set; }
        public IDbSet<Event> Events { get; set; }
        public IDbSet<Operation> Operations { get; set; }
        public IDbSet<Severity> Severities { get; set; }
        public IDbSet<Area> Areas { get; set; }
        public IDbSet<AreaHistory> AreaHistories { get; set; }
        public IDbSet<AreaStatu> AreaStatus { get; set; }
        public IDbSet<Branch> Branches { get; set; }
        public IDbSet<BranchHistory> BranchHistories { get; set; }
        public IDbSet<BranchLogo> BranchLogos { get; set; }
        public IDbSet<Logo> Logos { get; set; }
        public IDbSet<BranchStatu> BranchStatus { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<BrandHistory> BrandHistories { get; set; }
        public IDbSet<BrandStatu> BrandStatus { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
        public IDbSet<ClientContactStatu> ClientContactStatus { get; set; }
        public IDbSet<ClientLogo> ClientLogos { get; set; }
        public IDbSet<ClientStatu> ClientStatus { get; set; }
        public IDbSet<ContactAddressBranch> ContactAddressBranches { get; set; }
        public IDbSet<ContactAddressBrand> ContactAddressBrands { get; set; }
        public IDbSet<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<LocationStatu> LocationStatus { get; set; }
        public IDbSet<Person> People { get; set; }
        public IDbSet<PersonStatu> PersonStatus { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<RegionGroup> RegionGroups { get; set; }
        public IDbSet<RegionHistory> RegionHistories { get; set; }
        public IDbSet<RegionStatu> RegionStatus { get; set; }
        public IDbSet<AbsenceInstance> AbsenceInstances { get; set; }
        public IDbSet<AbsenceType> AbsenceTypes { get; set; }
        public IDbSet<AccountingClient> AccountingClients { get; set; }
        public IDbSet<AccountingInvoice> AccountingInvoices { get; set; }
        public IDbSet<AccountingPeriod> AccountingPeriods { get; set; }
        public IDbSet<AccountingProduct> AccountingProducts { get; set; }
        public IDbSet<AccountingTransaction> AccountingTransactions { get; set; }
        public IDbSet<ActionComment> ActionComments { get; set; }
        public IDbSet<ActionPriority> ActionPriorities { get; set; }
        public IDbSet<ActionStatu> ActionStatus { get; set; }
        public IDbSet<ActionType> ActionTypes { get; set; }
        public IDbSet<ActionUser> ActionUsers { get; set; }
        public IDbSet<AdminClientContactTracking> AdminClientContactTrackings { get; set; }
        public IDbSet<Airport> Airports { get; set; }
        public IDbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        public IDbSet<Area1> Area1 { get; set; }
        public IDbSet<AreaHistory1> AreaHistory1 { get; set; }
        public IDbSet<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public IDbSet<AreaStatus1> AreaStatus1 { get; set; }
        public IDbSet<Assessment> Assessments { get; set; }
        public IDbSet<AssessmentArea> AssessmentAreas { get; set; }
        public IDbSet<AssessmentAreaBranch> AssessmentAreaBranches { get; set; }
        public IDbSet<AssessmentType> AssessmentTypes { get; set; }
        public IDbSet<Assessor> Assessors { get; set; }
        public IDbSet<AssessorAttribute> AssessorAttributes { get; set; }
        public IDbSet<AssessorAttributeItem> AssessorAttributeItems { get; set; }
        public IDbSet<AssessorAttributeOption> AssessorAttributeOptions { get; set; }
        public IDbSet<AssessorCallBackRequest> AssessorCallBackRequests { get; set; }
        public IDbSet<AssessorCallInLog> AssessorCallInLogs { get; set; }
        public IDbSet<AssessorExpense> AssessorExpenses { get; set; }
        public IDbSet<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
        public IDbSet<AssessorGeographicPostCode> AssessorGeographicPostCodes { get; set; }
        public IDbSet<AssessorHistory> AssessorHistories { get; set; }
        public IDbSet<AssessorLevel> AssessorLevels { get; set; }
        public IDbSet<AssessorNote> AssessorNotes { get; set; }
        public IDbSet<AssessorStatu> AssessorStatus { get; set; }
        public IDbSet<AssessorStatusChangeReason> AssessorStatusChangeReasons { get; set; }
        public IDbSet<AssessorTimeTracker> AssessorTimeTrackers { get; set; }
        public IDbSet<AuditAction> AuditActions { get; set; }
        public IDbSet<AuditAdminEvent> AuditAdminEvents { get; set; }
        public IDbSet<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public IDbSet<AuditManagerEvent> AuditManagerEvents { get; set; }
        public IDbSet<AuditPersonEvent> AuditPersonEvents { get; set; }
        public IDbSet<AuditTable> AuditTables { get; set; }
        public IDbSet<BanBranch> BanBranches { get; set; }
        public IDbSet<BanBrand> BanBrands { get; set; }
        public IDbSet<BanClient> BanClients { get; set; }
        public IDbSet<Benchmark> Benchmarks { get; set; }
        public IDbSet<Branch1> Branch1 { get; set; }
        public IDbSet<BranchAccountingProduct> BranchAccountingProducts { get; set; }
        public IDbSet<BranchHistory1> BranchHistory1 { get; set; }
        public IDbSet<BranchNote> BranchNotes { get; set; }
        public IDbSet<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public IDbSet<BranchStatus1> BranchStatus1 { get; set; }
        public IDbSet<Brand1> Brand1 { get; set; }
        public IDbSet<BrandAccountingProduct> BrandAccountingProducts { get; set; }
        public IDbSet<BrandHistory1> BrandHistory1 { get; set; }
        public IDbSet<BrandNote> BrandNotes { get; set; }
        public IDbSet<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public IDbSet<BrandStatus1> BrandStatus1 { get; set; }
        public IDbSet<Brief> Briefs { get; set; }
        public IDbSet<BriefBranch> BriefBranches { get; set; }
        public IDbSet<BriefBrand> BriefBrands { get; set; }
        public IDbSet<BriefClient> BriefClients { get; set; }
        public IDbSet<BriefConfiguration> BriefConfigurations { get; set; }
        public IDbSet<BriefConfigurationBranch> BriefConfigurationBranches { get; set; }
        public IDbSet<BriefConfigurationBrand> BriefConfigurationBrands { get; set; }
        public IDbSet<BriefItem> BriefItems { get; set; }
        public IDbSet<BriefSection> BriefSections { get; set; }
        public IDbSet<BroadcastMessage> BroadcastMessages { get; set; }
        public IDbSet<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
        public IDbSet<CallBackRequest> CallBackRequests { get; set; }
        public IDbSet<CallInLog> CallInLogs { get; set; }
        public IDbSet<CCTFurtherNote> CCTFurtherNotes { get; set; }
        public IDbSet<Client1> Client1 { get; set; }
        public IDbSet<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public IDbSet<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public IDbSet<ClientCallInLog> ClientCallInLogs { get; set; }
        public IDbSet<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
        public IDbSet<ClientContactStatus1> ClientContactStatus1 { get; set; }
        public IDbSet<ClientContactTracking> ClientContactTrackings { get; set; }
        public IDbSet<ClientHistory> ClientHistories { get; set; }
        public IDbSet<ClientNote> ClientNotes { get; set; }
        public IDbSet<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public IDbSet<ClientStatus1> ClientStatus1 { get; set; }
        public IDbSet<CommunicationPreference> CommunicationPreferences { get; set; }
        public IDbSet<CommunicationStatu> CommunicationStatus { get; set; }
        public IDbSet<CommunicationType> CommunicationTypes { get; set; }
        public IDbSet<Configuration> Configurations { get; set; }
        public IDbSet<ConfigurationItem> ConfigurationItems { get; set; }
        public IDbSet<ConfigurationSystem> ConfigurationSystems { get; set; }
        public IDbSet<ConfigurationType> ConfigurationTypes { get; set; }
        public IDbSet<ContactAddress> ContactAddresses { get; set; }
        public IDbSet<ContactAddressBranch1> ContactAddressBranch1 { get; set; }
        public IDbSet<ContactAddressBrand1> ContactAddressBrand1 { get; set; }
        public IDbSet<ContactAddressClient> ContactAddressClients { get; set; }
        public IDbSet<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public IDbSet<ContactAddressType> ContactAddressTypes { get; set; }
        public IDbSet<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public IDbSet<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
        public IDbSet<CriteriaConfig> CriteriaConfigs { get; set; }
        public IDbSet<CriteriaOperator> CriteriaOperators { get; set; }
        public IDbSet<CriteriaOption> CriteriaOptions { get; set; }
        public IDbSet<CriteriaSet> CriteriaSets { get; set; }
        public IDbSet<Currency> Currencies { get; set; }
        public IDbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<CustomerClient> CustomerClients { get; set; }
        public IDbSet<CustomerLinkStatu> CustomerLinkStatus { get; set; }
        public IDbSet<CustomerUser> CustomerUsers { get; set; }
        public IDbSet<DynamicQuestion> DynamicQuestions { get; set; }
        public IDbSet<Error> Errors { get; set; }
        public IDbSet<ExpenseStatu> ExpenseStatus { get; set; }
        public IDbSet<ExpenseType> ExpenseTypes { get; set; }
        public IDbSet<ForumAdminReply> ForumAdminReplies { get; set; }
        public IDbSet<ForumAssessorReply> ForumAssessorReplies { get; set; }
        public IDbSet<ForumCategory> ForumCategories { get; set; }
        public IDbSet<ForumReportedReply> ForumReportedReplies { get; set; }
        public IDbSet<ForumThread> ForumThreads { get; set; }
        public IDbSet<FurtherActionComment> FurtherActionComments { get; set; }
        public IDbSet<FurtherNote> FurtherNotes { get; set; }
        public IDbSet<Gender> Genders { get; set; }
        public IDbSet<GeographicCountry> GeographicCountries { get; set; }
        public IDbSet<GeographicCounty> GeographicCounties { get; set; }
        public IDbSet<GeographicLocation> GeographicLocations { get; set; }
        public IDbSet<GeographicPostalArea> GeographicPostalAreas { get; set; }
        public IDbSet<GeographicPostCode> GeographicPostCodes { get; set; }
        public IDbSet<GeographicRegion> GeographicRegions { get; set; }
        public IDbSet<GeographicWorldArea> GeographicWorldAreas { get; set; }
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<GroupUser> GroupUsers { get; set; }
        public IDbSet<IndustrySector> IndustrySectors { get; set; }
        public IDbSet<Log> Logs { get; set; }
        public IDbSet<Login> Logins { get; set; }
        public IDbSet<Maintenance> Maintenances { get; set; }
        public IDbSet<MaintenanceCategory> MaintenanceCategories { get; set; }
        public IDbSet<MaintenanceCustomer> MaintenanceCustomers { get; set; }
        public IDbSet<ManagementCategory> ManagementCategories { get; set; }
        public IDbSet<ManagerArea> ManagerAreas { get; set; }
        public IDbSet<ManagerBranch> ManagerBranches { get; set; }
        public IDbSet<ManagerBrand> ManagerBrands { get; set; }
        public IDbSet<ManagerCallBackRequest> ManagerCallBackRequests { get; set; }
        public IDbSet<ManagerClient> ManagerClients { get; set; }
        public IDbSet<ManagerClientContactTracking> ManagerClientContactTrackings { get; set; }
        public IDbSet<ManagerRegion> ManagerRegions { get; set; }
        public IDbSet<ManagerTimeTracker> ManagerTimeTrackers { get; set; }
        public IDbSet<Menu> Menus { get; set; }
        public IDbSet<MenuConfig> MenuConfigs { get; set; }
        public IDbSet<MenuConfigBranch> MenuConfigBranches { get; set; }
        public IDbSet<MenuConfigBrand> MenuConfigBrands { get; set; }
        public IDbSet<MenuConfigClient> MenuConfigClients { get; set; }
        public IDbSet<MenuItem> MenuItems { get; set; }
        public IDbSet<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
        public IDbSet<MenuSection> MenuSections { get; set; }
        public IDbSet<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }
        public IDbSet<Note> Notes { get; set; }
        public IDbSet<NoteCalendar> NoteCalendars { get; set; }
        public IDbSet<NoteType> NoteTypes { get; set; }
        public IDbSet<Notification> Notifications { get; set; }
        public IDbSet<NotificationCategory> NotificationCategories { get; set; }
        public IDbSet<PandoraCache> PandoraCaches { get; set; }
        public IDbSet<PasswordQuestion> PasswordQuestions { get; set; }
        public IDbSet<PasswordReset> PasswordResets { get; set; }
        public IDbSet<Period> Periods { get; set; }
        public IDbSet<PeriodBrand> PeriodBrands { get; set; }
        public IDbSet<PeriodClient> PeriodClients { get; set; }
        public IDbSet<Permission> Permissions { get; set; }
        public IDbSet<PermissionGroup> PermissionGroups { get; set; }
        public IDbSet<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
        public IDbSet<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public IDbSet<PersonArea> PersonAreas { get; set; }
        public IDbSet<PersonBranch> PersonBranches { get; set; }
        public IDbSet<PersonBrand> PersonBrands { get; set; }
        public IDbSet<PersonCallBackRequest> PersonCallBackRequests { get; set; }
        public IDbSet<PersonClient> PersonClients { get; set; }
        public IDbSet<PersonClientContactTracking> PersonClientContactTrackings { get; set; }
        public IDbSet<PersonRegion> PersonRegions { get; set; }
        public IDbSet<PersonTimeTracker> PersonTimeTrackers { get; set; }
        public IDbSet<Point> Points { get; set; }
        public IDbSet<PointReason> PointReasons { get; set; }
        public IDbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public IDbSet<Question> Questions { get; set; }
        public IDbSet<QuestionDepartment> QuestionDepartments { get; set; }
        public IDbSet<Questionnaire> Questionnaires { get; set; }
        public IDbSet<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
        public IDbSet<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public IDbSet<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set; }
        public IDbSet<QuestionnaireStatu> QuestionnaireStatus { get; set; }
        public IDbSet<QuestionOverwrite> QuestionOverwrites { get; set; }
        public IDbSet<QuestionPossibleAnswer> QuestionPossibleAnswers { get; set; }
        public IDbSet<QuestionResult> QuestionResults { get; set; }
        public IDbSet<QuestionResultAction> QuestionResultActions { get; set; }
        public IDbSet<QuestionSection> QuestionSections { get; set; }
        public IDbSet<QuestionTag> QuestionTags { get; set; }
        public IDbSet<QuestionTracker> QuestionTrackers { get; set; }
        public IDbSet<QuestionType> QuestionTypes { get; set; }
        public IDbSet<RailStation> RailStations { get; set; }
        public IDbSet<Region1> Region1 { get; set; }
        public IDbSet<RegionHistory1> RegionHistory1 { get; set; }
        public IDbSet<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public IDbSet<RegionStatus1> RegionStatus1 { get; set; }
        public IDbSet<RemovalReason> RemovalReasons { get; set; }
        public IDbSet<ReportProblemAction> ReportProblemActions { get; set; }
        public IDbSet<ReportProblemActionType> ReportProblemActionTypes { get; set; }
        public IDbSet<ReportProblemCause> ReportProblemCauses { get; set; }
        public IDbSet<ReportProblemTracking> ReportProblemTrackings { get; set; }
        public IDbSet<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
        public IDbSet<ReportProblemType> ReportProblemTypes { get; set; }
        public IDbSet<ResultComment> ResultComments { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<SimpleVisit> SimpleVisits { get; set; }
        public IDbSet<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public IDbSet<SimpleVisitTemplate> SimpleVisitTemplates { get; set; }
        public IDbSet<SimpleVisitTemplateBranch> SimpleVisitTemplateBranches { get; set; }
        public IDbSet<SQQOPossibleAnswer> SQQOPossibleAnswers { get; set; }
        public IDbSet<StaffAge> StaffAges { get; set; }
        public IDbSet<StaffClothingColour> StaffClothingColours { get; set; }
        public IDbSet<StaffClothingItem> StaffClothingItems { get; set; }
        public IDbSet<StaffFeature> StaffFeatures { get; set; }
        public IDbSet<StaffHairColour> StaffHairColours { get; set; }
        public IDbSet<StaffHairLength> StaffHairLengths { get; set; }
        public IDbSet<StaffHairStyle> StaffHairStyles { get; set; }
        public IDbSet<StaffHeight> StaffHeights { get; set; }
        public IDbSet<StaffMember> StaffMembers { get; set; }
        public IDbSet<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
        public IDbSet<StaffMemberFeature> StaffMemberFeatures { get; set; }
        public IDbSet<SubDynamicQuestion> SubDynamicQuestions { get; set; }
        public IDbSet<SubQuestionnaire> SubQuestionnaires { get; set; }
        public IDbSet<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
        public IDbSet<Suggestion> Suggestions { get; set; }
        public IDbSet<SuggestionStatu> SuggestionStatus { get; set; }
        public IDbSet<SuggestionVote> SuggestionVotes { get; set; }
        public IDbSet<sysdiagram> sysdiagrams { get; set; }
        public IDbSet<Tag> Tags { get; set; }
        public IDbSet<TelephoneRecording> TelephoneRecordings { get; set; }
        public IDbSet<Terminology> Terminologies { get; set; }
        public IDbSet<TerminologyBrand> TerminologyBrands { get; set; }
        public IDbSet<TerminologyClient> TerminologyClients { get; set; }
        public IDbSet<TimeTracker> TimeTrackers { get; set; }
        public IDbSet<TimeTrackerType> TimeTrackerTypes { get; set; }
        public IDbSet<Tour> Tours { get; set; }
        public IDbSet<TourStep> TourSteps { get; set; }
        public IDbSet<TourStepPlacement> TourStepPlacements { get; set; }
        public IDbSet<TourUserRole> TourUserRoles { get; set; }
        public IDbSet<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
        public IDbSet<TradeLevel> TradeLevels { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserImpersonationUserRole> UserImpersonationUserRoles { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        public IDbSet<Visit> Visits { get; set; }
        public IDbSet<VisitAction> VisitActions { get; set; }
        public IDbSet<VisitAssessor> VisitAssessors { get; set; }
        public IDbSet<VisitCallBackRequest> VisitCallBackRequests { get; set; }
        public IDbSet<VisitCallInLog> VisitCallInLogs { get; set; }
        public IDbSet<VisitDetail> VisitDetails { get; set; }
        public IDbSet<VisitNote> VisitNotes { get; set; }
        public IDbSet<VisitPoint> VisitPoints { get; set; }
        public IDbSet<VisitStatu> VisitStatus { get; set; }
        public IDbSet<VisitStatusHistory> VisitStatusHistories { get; set; }
        public IDbSet<VisitTimeTracker> VisitTimeTrackers { get; set; }
        public IDbSet<VisitType> VisitTypes { get; set; }
        public IDbSet<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
        public IDbSet<Weather> Weathers { get; set; }
        public IDbSet<Article> Articles { get; set; }
        public IDbSet<ArticlePermission> ArticlePermissions { get; set; }
        public IDbSet<Page> Pages { get; set; }
        public IDbSet<PageArticle> PageArticles { get; set; }
        public IDbSet<PageTour> PageTours { get; set; }
        public IDbSet<AreaLegacyUser> AreaLegacyUsers { get; set; }
        public IDbSet<BranchLegacyUser> BranchLegacyUsers { get; set; }
        public IDbSet<BrandLegacyUser> BrandLegacyUsers { get; set; }
        public IDbSet<ClientLegacyUser> ClientLegacyUsers { get; set; }
        public IDbSet<RegionLegacyUser> RegionLegacyUsers { get; set; }
        public IDbSet<Messages_0> Messages_0 { get; set; }
        public IDbSet<Messages_0_Id> Messages_0_Id { get; set; }
        public IDbSet<Schema> Schemata { get; set; }
        public IDbSet<BranchSocialNetwork> BranchSocialNetworks { get; set; }
        public IDbSet<BrandSocialNetwork> BrandSocialNetworks { get; set; }
        public IDbSet<ClientSocialNetwork> ClientSocialNetworks { get; set; }
        public IDbSet<SocialNetwork> SocialNetworks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActionCategoryMap());
            modelBuilder.Configurations.Add(new ActionEventMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new OperationMap());
            modelBuilder.Configurations.Add(new SeverityMap());
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new AreaHistoryMap());
            modelBuilder.Configurations.Add(new AreaStatuMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new BranchHistoryMap());
            modelBuilder.Configurations.Add(new BranchLogoMap());
            modelBuilder.Configurations.Add(new BranchStatuMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new BrandHistoryMap());
            modelBuilder.Configurations.Add(new BrandStatuMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ClientAccountManagerMap());
            modelBuilder.Configurations.Add(new ClientContactStatuMap());
            modelBuilder.Configurations.Add(new ClientLogoMap());
            modelBuilder.Configurations.Add(new ClientStatuMap());
            modelBuilder.Configurations.Add(new ContactAddressBranchMap());
            modelBuilder.Configurations.Add(new ContactAddressBrandMap());
            modelBuilder.Configurations.Add(new ContactAddressGeoLocationMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LocationStatuMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonStatuMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new RegionGroupMap());
            modelBuilder.Configurations.Add(new RegionHistoryMap());
            modelBuilder.Configurations.Add(new RegionStatuMap());
            modelBuilder.Configurations.Add(new AbsenceInstanceMap());
            modelBuilder.Configurations.Add(new AbsenceTypeMap());
            modelBuilder.Configurations.Add(new AccountingClientMap());
            modelBuilder.Configurations.Add(new AccountingInvoiceMap());
            modelBuilder.Configurations.Add(new AccountingPeriodMap());
            modelBuilder.Configurations.Add(new AccountingProductMap());
            modelBuilder.Configurations.Add(new AccountingTransactionMap());
            modelBuilder.Configurations.Add(new ActionMap());
            modelBuilder.Configurations.Add(new ActionCommentMap());
            modelBuilder.Configurations.Add(new ActionPriorityMap());
            modelBuilder.Configurations.Add(new ActionStatuMap());
            modelBuilder.Configurations.Add(new ActionTypeMap());
            modelBuilder.Configurations.Add(new ActionUserMap());
            modelBuilder.Configurations.Add(new AdminClientContactTrackingMap());
            modelBuilder.Configurations.Add(new AirportMap());
            modelBuilder.Configurations.Add(new ApplicationLanguageMap());
            modelBuilder.Configurations.Add(new Area1Map());
            modelBuilder.Configurations.Add(new AreaHistory1Map());
            modelBuilder.Configurations.Add(new AreaQuestionnaireMap());
            modelBuilder.Configurations.Add(new AreaStatus1Map());
            modelBuilder.Configurations.Add(new AssessmentMap());
            modelBuilder.Configurations.Add(new AssessmentAreaMap());
            modelBuilder.Configurations.Add(new AssessmentAreaBranchMap());
            modelBuilder.Configurations.Add(new AssessmentTypeMap());
            modelBuilder.Configurations.Add(new AssessorMap());
            modelBuilder.Configurations.Add(new AssessorAttributeMap());
            modelBuilder.Configurations.Add(new AssessorAttributeItemMap());
            modelBuilder.Configurations.Add(new AssessorAttributeOptionMap());
            modelBuilder.Configurations.Add(new AssessorCallBackRequestMap());
            modelBuilder.Configurations.Add(new AssessorCallInLogMap());
            modelBuilder.Configurations.Add(new AssessorExpenseMap());
            modelBuilder.Configurations.Add(new AssessorExpenseHistoryMap());
            modelBuilder.Configurations.Add(new AssessorGeographicPostCodeMap());
            modelBuilder.Configurations.Add(new AssessorHistoryMap());
            modelBuilder.Configurations.Add(new AssessorLevelMap());
            modelBuilder.Configurations.Add(new AssessorNoteMap());
            modelBuilder.Configurations.Add(new AssessorStatuMap());
            modelBuilder.Configurations.Add(new AssessorStatusChangeReasonMap());
            modelBuilder.Configurations.Add(new AssessorTimeTrackerMap());
            modelBuilder.Configurations.Add(new AuditActionMap());
            modelBuilder.Configurations.Add(new AuditAdminEventMap());
            modelBuilder.Configurations.Add(new AuditAssessorEventMap());
            modelBuilder.Configurations.Add(new AuditManagerEventMap());
            modelBuilder.Configurations.Add(new AuditPersonEventMap());
            modelBuilder.Configurations.Add(new AuditTableMap());
            modelBuilder.Configurations.Add(new BanBranchMap());
            modelBuilder.Configurations.Add(new BanBrandMap());
            modelBuilder.Configurations.Add(new BanClientMap());
            modelBuilder.Configurations.Add(new BenchmarkMap());
            modelBuilder.Configurations.Add(new Branch1Map());
            modelBuilder.Configurations.Add(new BranchAccountingProductMap());
            modelBuilder.Configurations.Add(new BranchHistory1Map());
            modelBuilder.Configurations.Add(new BranchNoteMap());
            modelBuilder.Configurations.Add(new BranchQuestionnaireMap());
            modelBuilder.Configurations.Add(new BranchStatus1Map());
            modelBuilder.Configurations.Add(new Brand1Map());
            modelBuilder.Configurations.Add(new BrandAccountingProductMap());
            modelBuilder.Configurations.Add(new BrandHistory1Map());
            modelBuilder.Configurations.Add(new BrandNoteMap());
            modelBuilder.Configurations.Add(new BrandQuestionnaireMap());
            modelBuilder.Configurations.Add(new BrandStatus1Map());
            modelBuilder.Configurations.Add(new BriefMap());
            modelBuilder.Configurations.Add(new BriefBranchMap());
            modelBuilder.Configurations.Add(new BriefBrandMap());
            modelBuilder.Configurations.Add(new BriefClientMap());
            modelBuilder.Configurations.Add(new BriefConfigurationMap());
            modelBuilder.Configurations.Add(new BriefConfigurationBranchMap());
            modelBuilder.Configurations.Add(new BriefConfigurationBrandMap());
            modelBuilder.Configurations.Add(new BriefItemMap());
            modelBuilder.Configurations.Add(new BriefSectionMap());
            modelBuilder.Configurations.Add(new BroadcastMessageMap());
            modelBuilder.Configurations.Add(new BroadcastMessageUserMap());
            modelBuilder.Configurations.Add(new CallBackRequestMap());
            modelBuilder.Configurations.Add(new CallInLogMap());
            modelBuilder.Configurations.Add(new CCTFurtherNoteMap());
            modelBuilder.Configurations.Add(new Client1Map());
            modelBuilder.Configurations.Add(new ClientAccountingProductMap());
            modelBuilder.Configurations.Add(new ClientCallBackRequestMap());
            modelBuilder.Configurations.Add(new ClientCallInLogMap());
            modelBuilder.Configurations.Add(new ClientCommunicationLogMap());
            modelBuilder.Configurations.Add(new ClientContactStatus1Map());
            modelBuilder.Configurations.Add(new ClientContactTrackingMap());
            modelBuilder.Configurations.Add(new ClientHistoryMap());
            modelBuilder.Configurations.Add(new ClientNoteMap());
            modelBuilder.Configurations.Add(new ClientQuestionnaireMap());
            modelBuilder.Configurations.Add(new ClientStatus1Map());
            modelBuilder.Configurations.Add(new CommunicationPreferenceMap());
            modelBuilder.Configurations.Add(new CommunicationStatuMap());
            modelBuilder.Configurations.Add(new CommunicationTypeMap());
            modelBuilder.Configurations.Add(new ConfigurationMap());
            modelBuilder.Configurations.Add(new ConfigurationItemMap());
            modelBuilder.Configurations.Add(new ConfigurationSystemMap());
            modelBuilder.Configurations.Add(new ConfigurationTypeMap());
            modelBuilder.Configurations.Add(new ContactAddressMap());
            modelBuilder.Configurations.Add(new ContactAddressBranch1Map());
            modelBuilder.Configurations.Add(new ContactAddressBrand1Map());
            modelBuilder.Configurations.Add(new ContactAddressClientMap());
            modelBuilder.Configurations.Add(new ContactAddressCustomerMap());
            modelBuilder.Configurations.Add(new ContactAddressTypeMap());
            modelBuilder.Configurations.Add(new ContactAddressUserRoleMap());
            modelBuilder.Configurations.Add(new CriteriaAssessorAttributeMap());
            modelBuilder.Configurations.Add(new CriteriaConfigMap());
            modelBuilder.Configurations.Add(new CriteriaOperatorMap());
            modelBuilder.Configurations.Add(new CriteriaOptionMap());
            modelBuilder.Configurations.Add(new CriteriaSetMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new CurrencyExchangeRateMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerClientMap());
            modelBuilder.Configurations.Add(new CustomerLinkStatuMap());
            modelBuilder.Configurations.Add(new CustomerUserMap());
            modelBuilder.Configurations.Add(new DynamicQuestionMap());
            modelBuilder.Configurations.Add(new ErrorMap());
            modelBuilder.Configurations.Add(new ExpenseStatuMap());
            modelBuilder.Configurations.Add(new ExpenseTypeMap());
            modelBuilder.Configurations.Add(new ForumAdminReplyMap());
            modelBuilder.Configurations.Add(new ForumAssessorReplyMap());
            modelBuilder.Configurations.Add(new ForumCategoryMap());
            modelBuilder.Configurations.Add(new ForumReportedReplyMap());
            modelBuilder.Configurations.Add(new ForumThreadMap());
            modelBuilder.Configurations.Add(new FurtherActionCommentMap());
            modelBuilder.Configurations.Add(new FurtherNoteMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new GeographicCountryMap());
            modelBuilder.Configurations.Add(new GeographicCountyMap());
            modelBuilder.Configurations.Add(new GeographicLocationMap());
            modelBuilder.Configurations.Add(new GeographicPostalAreaMap());
            modelBuilder.Configurations.Add(new GeographicPostCodeMap());
            modelBuilder.Configurations.Add(new GeographicRegionMap());
            modelBuilder.Configurations.Add(new GeographicWorldAreaMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new GroupUserMap());
            modelBuilder.Configurations.Add(new IndustrySectorMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new MaintenanceMap());
            modelBuilder.Configurations.Add(new MaintenanceCategoryMap());
            modelBuilder.Configurations.Add(new MaintenanceCustomerMap());
            modelBuilder.Configurations.Add(new ManagementCategoryMap());
            modelBuilder.Configurations.Add(new ManagerAreaMap());
            modelBuilder.Configurations.Add(new ManagerBranchMap());
            modelBuilder.Configurations.Add(new ManagerBrandMap());
            modelBuilder.Configurations.Add(new ManagerCallBackRequestMap());
            modelBuilder.Configurations.Add(new ManagerClientMap());
            modelBuilder.Configurations.Add(new ManagerClientContactTrackingMap());
            modelBuilder.Configurations.Add(new ManagerRegionMap());
            modelBuilder.Configurations.Add(new ManagerTimeTrackerMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new MenuConfigMap());
            modelBuilder.Configurations.Add(new MenuConfigBranchMap());
            modelBuilder.Configurations.Add(new MenuConfigBrandMap());
            modelBuilder.Configurations.Add(new MenuConfigClientMap());
            modelBuilder.Configurations.Add(new MenuItemMap());
            modelBuilder.Configurations.Add(new MenuItemPossibleAnswerMap());
            modelBuilder.Configurations.Add(new MenuSectionMap());
            modelBuilder.Configurations.Add(new MenuSectionPossibleAnswerMap());
            modelBuilder.Configurations.Add(new NoteMap());
            modelBuilder.Configurations.Add(new NoteCalendarMap());
            modelBuilder.Configurations.Add(new NoteTypeMap());
            modelBuilder.Configurations.Add(new NotificationMap());
            modelBuilder.Configurations.Add(new NotificationCategoryMap());
            modelBuilder.Configurations.Add(new PandoraCacheMap());
            modelBuilder.Configurations.Add(new PasswordQuestionMap());
            modelBuilder.Configurations.Add(new PasswordResetMap());
            modelBuilder.Configurations.Add(new PeriodMap());
            modelBuilder.Configurations.Add(new PeriodBrandMap());
            modelBuilder.Configurations.Add(new PeriodClientMap());
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new PermissionGroupMap());
            modelBuilder.Configurations.Add(new PermissionGroupPermissionMap());
            modelBuilder.Configurations.Add(new PermissionGroupUserMap());
            modelBuilder.Configurations.Add(new PersonAreaMap());
            modelBuilder.Configurations.Add(new PersonBranchMap());
            modelBuilder.Configurations.Add(new PersonBrandMap());
            modelBuilder.Configurations.Add(new PersonCallBackRequestMap());
            modelBuilder.Configurations.Add(new PersonClientMap());
            modelBuilder.Configurations.Add(new PersonClientContactTrackingMap());
            modelBuilder.Configurations.Add(new PersonRegionMap());
            modelBuilder.Configurations.Add(new PersonTimeTrackerMap());
            modelBuilder.Configurations.Add(new PointMap());
            modelBuilder.Configurations.Add(new PointReasonMap());
            modelBuilder.Configurations.Add(new PossibleAnswerMap());
            modelBuilder.Configurations.Add(new QuestionMap());
            modelBuilder.Configurations.Add(new QuestionDepartmentMap());
            modelBuilder.Configurations.Add(new QuestionnaireMap());
            modelBuilder.Configurations.Add(new QuestionnaireAccountingProductMap());
            modelBuilder.Configurations.Add(new QuestionnaireQuestionMap());
            modelBuilder.Configurations.Add(new QuestionnaireQuestionPossibleAnswerMap());
            modelBuilder.Configurations.Add(new QuestionnaireStatuMap());
            modelBuilder.Configurations.Add(new QuestionOverwriteMap());
            modelBuilder.Configurations.Add(new QuestionPossibleAnswerMap());
            modelBuilder.Configurations.Add(new QuestionResultMap());
            modelBuilder.Configurations.Add(new QuestionResultActionMap());
            modelBuilder.Configurations.Add(new QuestionSectionMap());
            modelBuilder.Configurations.Add(new QuestionTagMap());
            modelBuilder.Configurations.Add(new QuestionTrackerMap());
            modelBuilder.Configurations.Add(new QuestionTypeMap());
            modelBuilder.Configurations.Add(new RailStationMap());
            modelBuilder.Configurations.Add(new Region1Map());
            modelBuilder.Configurations.Add(new RegionHistory1Map());
            modelBuilder.Configurations.Add(new RegionQuestionnaireMap());
            modelBuilder.Configurations.Add(new RegionStatus1Map());
            modelBuilder.Configurations.Add(new RemovalReasonMap());
            modelBuilder.Configurations.Add(new ReportProblemActionMap());
            modelBuilder.Configurations.Add(new ReportProblemActionTypeMap());
            modelBuilder.Configurations.Add(new ReportProblemCauseMap());
            modelBuilder.Configurations.Add(new ReportProblemTrackingMap());
            modelBuilder.Configurations.Add(new ReportProblemTrackingActionMap());
            modelBuilder.Configurations.Add(new ReportProblemTypeMap());
            modelBuilder.Configurations.Add(new ResultCommentMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SimpleVisitMap());
            modelBuilder.Configurations.Add(new SimpleVisitQuestionResultMap());
            modelBuilder.Configurations.Add(new SimpleVisitTemplateMap());
            modelBuilder.Configurations.Add(new SimpleVisitTemplateBranchMap());
            modelBuilder.Configurations.Add(new SQQOPossibleAnswerMap());
            modelBuilder.Configurations.Add(new StaffAgeMap());
            modelBuilder.Configurations.Add(new StaffClothingColourMap());
            modelBuilder.Configurations.Add(new StaffClothingItemMap());
            modelBuilder.Configurations.Add(new StaffFeatureMap());
            modelBuilder.Configurations.Add(new StaffHairColourMap());
            modelBuilder.Configurations.Add(new StaffHairLengthMap());
            modelBuilder.Configurations.Add(new StaffHairStyleMap());
            modelBuilder.Configurations.Add(new StaffHeightMap());
            modelBuilder.Configurations.Add(new StaffMemberMap());
            modelBuilder.Configurations.Add(new StaffMemberClothingItemMap());
            modelBuilder.Configurations.Add(new StaffMemberFeatureMap());
            modelBuilder.Configurations.Add(new SubDynamicQuestionMap());
            modelBuilder.Configurations.Add(new SubQuestionnaireMap());
            modelBuilder.Configurations.Add(new SubQuestionnaireQuestionOverwriteMap());
            modelBuilder.Configurations.Add(new SuggestionMap());
            modelBuilder.Configurations.Add(new SuggestionStatuMap());
            modelBuilder.Configurations.Add(new SuggestionVoteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new TelephoneRecordingMap());
            modelBuilder.Configurations.Add(new TerminologyMap());
            modelBuilder.Configurations.Add(new TerminologyBrandMap());
            modelBuilder.Configurations.Add(new TerminologyClientMap());
            modelBuilder.Configurations.Add(new TimeTrackerMap());
            modelBuilder.Configurations.Add(new TimeTrackerTypeMap());
            modelBuilder.Configurations.Add(new TourMap());
            modelBuilder.Configurations.Add(new TourStepMap());
            modelBuilder.Configurations.Add(new TourStepPlacementMap());
            modelBuilder.Configurations.Add(new TourUserRoleMap());
            modelBuilder.Configurations.Add(new TourUserRoleTourStepMap());
            modelBuilder.Configurations.Add(new TradeLevelMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserImpersonationUserRoleMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new VisitMap());
            modelBuilder.Configurations.Add(new VisitActionMap());
            modelBuilder.Configurations.Add(new VisitAssessorMap());
            modelBuilder.Configurations.Add(new VisitCallBackRequestMap());
            modelBuilder.Configurations.Add(new VisitCallInLogMap());
            modelBuilder.Configurations.Add(new VisitDetailMap());
            modelBuilder.Configurations.Add(new VisitNoteMap());
            modelBuilder.Configurations.Add(new VisitPointMap());
            modelBuilder.Configurations.Add(new VisitStatuMap());
            modelBuilder.Configurations.Add(new VisitStatusHistoryMap());
            modelBuilder.Configurations.Add(new VisitTimeTrackerMap());
            modelBuilder.Configurations.Add(new VisitTypeMap());
            modelBuilder.Configurations.Add(new VisitTypeExpenseTypeMap());
            modelBuilder.Configurations.Add(new WeatherMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticlePermissionMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new PageArticleMap());
            modelBuilder.Configurations.Add(new PageTourMap());
            modelBuilder.Configurations.Add(new AreaLegacyUserMap());
            modelBuilder.Configurations.Add(new BranchLegacyUserMap());
            modelBuilder.Configurations.Add(new BrandLegacyUserMap());
            modelBuilder.Configurations.Add(new ClientLegacyUserMap());
            modelBuilder.Configurations.Add(new RegionLegacyUserMap());
            modelBuilder.Configurations.Add(new Messages_0Map());
            modelBuilder.Configurations.Add(new Messages_0_IdMap());
            modelBuilder.Configurations.Add(new SchemaMap());
            modelBuilder.Configurations.Add(new BranchSocialNetworkMap());
            modelBuilder.Configurations.Add(new BrandSocialNetworkMap());
            modelBuilder.Configurations.Add(new ClientSocialNetworkMap());
            modelBuilder.Configurations.Add(new SocialNetworkMap());
        }
    }
}