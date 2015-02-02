using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Warp.Data.Models.Mapping;

namespace Warp.Data.Models
{
    public partial class hospitalityGEMLocalContext : DbContext
    {
        static hospitalityGEMLocalContext()
        {
            Database.SetInitializer<hospitalityGEMLocalContext>(null);
        }

        public hospitalityGEMLocalContext()
            : base("Name=hospitalityGEMLocalContext")
        {
        }

        public DbSet<PasswordQuestion> PasswordQuestions { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionGroup> PermissionGroups { get; set; }
        public DbSet<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
        public DbSet<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserImpersonationUserRole> UserImpersonationUserRoles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<AuditAction> AuditActions { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Severity> Severities { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaHistory> AreaHistories { get; set; }
        public DbSet<AreaStatu> AreaStatus { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchHistory> BranchHistories { get; set; }
        public DbSet<BranchLogo> BranchLogoes { get; set; }
        public DbSet<BranchStatu> BranchStatus { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandHistory> BrandHistories { get; set; }
        public DbSet<BrandLogo> BrandLogoes { get; set; }
        public DbSet<BrandStatu> BrandStatus { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAccountManager> ClientAccountManagers { get; set; }
        public DbSet<ClientContactStatu> ClientContactStatus { get; set; }
        public DbSet<ClientHistory> ClientHistories { get; set; }
        public DbSet<ClientLogo> ClientLogoes { get; set; }
        public DbSet<ClientOrganisation> ClientOrganisations { get; set; }
        public DbSet<ClientStatu> ClientStatus { get; set; }
        public DbSet<ContactAddressBranch> ContactAddressBranches { get; set; }
        public DbSet<ContactAddressBrand> ContactAddressBrands { get; set; }
        public DbSet<ContactAddressClient> ContactAddressClients { get; set; }
        public DbSet<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<IndustrySector> IndustrySectors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationStatu> LocationStatus { get; set; }
        public DbSet<Logo> Logoes { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonArea> PersonAreas { get; set; }
        public DbSet<PersonBranch> PersonBranches { get; set; }
        public DbSet<PersonBrand> PersonBrands { get; set; }
        public DbSet<PersonClient> PersonClients { get; set; }
        public DbSet<PersonRegion> PersonRegions { get; set; }
        public DbSet<PersonStatu> PersonStatus { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionGroup> RegionGroups { get; set; }
        public DbSet<RegionHistory> RegionHistories { get; set; }
        public DbSet<RegionStatu> RegionStatus { get; set; }
        public DbSet<AbsenceInstance> AbsenceInstances { get; set; }
        public DbSet<AbsenceType> AbsenceTypes { get; set; }
        public DbSet<AccountingClient> AccountingClients { get; set; }
        public DbSet<AccountingInvoice> AccountingInvoices { get; set; }
        public DbSet<AccountingPeriod> AccountingPeriods { get; set; }
        public DbSet<AccountingProduct> AccountingProducts { get; set; }
        public DbSet<AccountingTransaction> AccountingTransactions { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<ActionComment> ActionComments { get; set; }
        public DbSet<ActionPriority> ActionPriorities { get; set; }
        public DbSet<ActionStatu> ActionStatus { get; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<ActionUser> ActionUsers { get; set; }
        public DbSet<AdminClientContactTracking> AdminClientContactTrackings { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AreaQuestionnaire> AreaQuestionnaires { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentArea> AssessmentAreas { get; set; }
        public DbSet<AssessmentAreaBranch> AssessmentAreaBranches { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        public DbSet<Assessor> Assessors { get; set; }
        public DbSet<AssessorAttribute> AssessorAttributes { get; set; }
        public DbSet<AssessorAttributeItem> AssessorAttributeItems { get; set; }
        public DbSet<AssessorAttributeOption> AssessorAttributeOptions { get; set; }
        public DbSet<AssessorCallBackRequest> AssessorCallBackRequests { get; set; }
        public DbSet<AssessorCallInLog> AssessorCallInLogs { get; set; }
        public DbSet<AssessorExpense> AssessorExpenses { get; set; }
        public DbSet<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
        public DbSet<AssessorGeographicPostCode> AssessorGeographicPostCodes { get; set; }
        public DbSet<AssessorHistory> AssessorHistories { get; set; }
        public DbSet<AssessorLevel> AssessorLevels { get; set; }
        public DbSet<AssessorNote> AssessorNotes { get; set; }
        public DbSet<AssessorStatu> AssessorStatus { get; set; }
        public DbSet<AssessorStatusChangeReason> AssessorStatusChangeReasons { get; set; }
        public DbSet<AssessorTimeTracker> AssessorTimeTrackers { get; set; }
        public DbSet<AuditAdminEvent> AuditAdminEvents { get; set; }
        public DbSet<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public DbSet<AuditPersonEvent> AuditPersonEvents { get; set; }
        public DbSet<AuditTable> AuditTables { get; set; }
        public DbSet<BanBranch> BanBranches { get; set; }
        public DbSet<BanBrand> BanBrands { get; set; }
        public DbSet<BanClient> BanClients { get; set; }
        public DbSet<Benchmark> Benchmarks { get; set; }
        public DbSet<BranchAccountingProduct> BranchAccountingProducts { get; set; }
        public DbSet<BranchNote> BranchNotes { get; set; }
        public DbSet<BranchQuestionnaire> BranchQuestionnaires { get; set; }
        public DbSet<BrandAccountingProduct> BrandAccountingProducts { get; set; }
        public DbSet<BrandNote> BrandNotes { get; set; }
        public DbSet<BrandQuestionnaire> BrandQuestionnaires { get; set; }
        public DbSet<Brief> Briefs { get; set; }
        public DbSet<BriefBranch> BriefBranches { get; set; }
        public DbSet<BriefBrand> BriefBrands { get; set; }
        public DbSet<BriefClient> BriefClients { get; set; }
        public DbSet<BriefConfiguration> BriefConfigurations { get; set; }
        public DbSet<BriefConfigurationBranch> BriefConfigurationBranches { get; set; }
        public DbSet<BriefConfigurationBrand> BriefConfigurationBrands { get; set; }
        public DbSet<BriefItem> BriefItems { get; set; }
        public DbSet<BriefSection> BriefSections { get; set; }
        public DbSet<BroadcastMessage> BroadcastMessages { get; set; }
        public DbSet<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
        public DbSet<CallBackRequest> CallBackRequests { get; set; }
        public DbSet<CallInLog> CallInLogs { get; set; }
        public DbSet<CCTFurtherNote> CCTFurtherNotes { get; set; }
        public DbSet<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public DbSet<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public DbSet<ClientCallInLog> ClientCallInLogs { get; set; }
        public DbSet<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
        public DbSet<ClientContactTracking> ClientContactTrackings { get; set; }
        public DbSet<ClientNote> ClientNotes { get; set; }
        public DbSet<ClientQuestionnaire> ClientQuestionnaires { get; set; }
        public DbSet<CommunicationPreference> CommunicationPreferences { get; set; }
        public DbSet<CommunicationStatu> CommunicationStatus { get; set; }
        public DbSet<CommunicationType> CommunicationTypes { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<ConfigurationItem> ConfigurationItems { get; set; }
        public DbSet<ConfigurationSystem> ConfigurationSystems { get; set; }
        public DbSet<ConfigurationType> ConfigurationTypes { get; set; }
        public DbSet<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public DbSet<CriteriaAssessorAttribute> CriteriaAssessorAttributes { get; set; }
        public DbSet<CriteriaConfig> CriteriaConfigs { get; set; }
        public DbSet<CriteriaOperator> CriteriaOperators { get; set; }
        public DbSet<CriteriaOption> CriteriaOptions { get; set; }
        public DbSet<CriteriaSet> CriteriaSets { get; set; }
        public DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerClient> CustomerClients { get; set; }
        public DbSet<CustomerLinkStatu> CustomerLinkStatus { get; set; }
        public DbSet<CustomerUser> CustomerUsers { get; set; }
        public DbSet<DynamicQuestion> DynamicQuestions { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<ExpenseStatu> ExpenseStatus { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<ForumAdminReply> ForumAdminReplies { get; set; }
        public DbSet<ForumAssessorReply> ForumAssessorReplies { get; set; }
        public DbSet<ForumCategory> ForumCategories { get; set; }
        public DbSet<ForumReportedReply> ForumReportedReplies { get; set; }
        public DbSet<ForumThread> ForumThreads { get; set; }
        public DbSet<FurtherActionComment> FurtherActionComments { get; set; }
        public DbSet<FurtherNote> FurtherNotes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceCategory> MaintenanceCategories { get; set; }
        public DbSet<MaintenanceCustomer> MaintenanceCustomers { get; set; }
        public DbSet<ManagementCategory> ManagementCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuConfig> MenuConfigs { get; set; }
        public DbSet<MenuConfigBranch> MenuConfigBranches { get; set; }
        public DbSet<MenuConfigBrand> MenuConfigBrands { get; set; }
        public DbSet<MenuConfigClient> MenuConfigClients { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
        public DbSet<MenuSection> MenuSections { get; set; }
        public DbSet<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteCalendar> NoteCalendars { get; set; }
        public DbSet<NoteType> NoteTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationCategory> NotificationCategories { get; set; }
        public DbSet<PandoraCache> PandoraCaches { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<PeriodBrand> PeriodBrands { get; set; }
        public DbSet<PeriodClient> PeriodClients { get; set; }
        public DbSet<PersonCallBackRequest> PersonCallBackRequests { get; set; }
        public DbSet<PersonClientContactTracking> PersonClientContactTrackings { get; set; }
        public DbSet<PersonTimeTracker> PersonTimeTrackers { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<PointReason> PointReasons { get; set; }
        public DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionDepartment> QuestionDepartments { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
        public DbSet<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public DbSet<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set; }
        public DbSet<QuestionnaireStatu> QuestionnaireStatus { get; set; }
        public DbSet<QuestionOverwrite> QuestionOverwrites { get; set; }
        public DbSet<QuestionPossibleAnswer> QuestionPossibleAnswers { get; set; }
        public DbSet<QuestionResult> QuestionResults { get; set; }
        public DbSet<QuestionResultAction> QuestionResultActions { get; set; }
        public DbSet<QuestionSection> QuestionSections { get; set; }
        public DbSet<QuestionTag> QuestionTags { get; set; }
        public DbSet<QuestionTracker> QuestionTrackers { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<RailStation> RailStations { get; set; }
        public DbSet<RegionQuestionnaire> RegionQuestionnaires { get; set; }
        public DbSet<RemovalReason> RemovalReasons { get; set; }
        public DbSet<ReportProblemAction> ReportProblemActions { get; set; }
        public DbSet<ReportProblemActionType> ReportProblemActionTypes { get; set; }
        public DbSet<ReportProblemCause> ReportProblemCauses { get; set; }
        public DbSet<ReportProblemTracking> ReportProblemTrackings { get; set; }
        public DbSet<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
        public DbSet<ReportProblemType> ReportProblemTypes { get; set; }
        public DbSet<ResultComment> ResultComments { get; set; }
        public DbSet<SimpleVisit> SimpleVisits { get; set; }
        public DbSet<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public DbSet<SimpleVisitTemplate> SimpleVisitTemplates { get; set; }
        public DbSet<SimpleVisitTemplateBranch> SimpleVisitTemplateBranches { get; set; }
        public DbSet<SQQOPossibleAnswer> SQQOPossibleAnswers { get; set; }
        public DbSet<StaffAge> StaffAges { get; set; }
        public DbSet<StaffClothingColour> StaffClothingColours { get; set; }
        public DbSet<StaffClothingItem> StaffClothingItems { get; set; }
        public DbSet<StaffFeature> StaffFeatures { get; set; }
        public DbSet<StaffHairColour> StaffHairColours { get; set; }
        public DbSet<StaffHairLength> StaffHairLengths { get; set; }
        public DbSet<StaffHairStyle> StaffHairStyles { get; set; }
        public DbSet<StaffHeight> StaffHeights { get; set; }
        public DbSet<StaffMember> StaffMembers { get; set; }
        public DbSet<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
        public DbSet<StaffMemberFeature> StaffMemberFeatures { get; set; }
        public DbSet<SubDynamicQuestion> SubDynamicQuestions { get; set; }
        public DbSet<SubQuestionnaire> SubQuestionnaires { get; set; }
        public DbSet<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<SuggestionStatu> SuggestionStatus { get; set; }
        public DbSet<SuggestionVote> SuggestionVotes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TelephoneRecording> TelephoneRecordings { get; set; }
        public DbSet<Terminology> Terminologies { get; set; }
        public DbSet<TerminologyBrand> TerminologyBrands { get; set; }
        public DbSet<TerminologyClient> TerminologyClients { get; set; }
        public DbSet<TimeTracker> TimeTrackers { get; set; }
        public DbSet<TimeTrackerType> TimeTrackerTypes { get; set; }
        public DbSet<TradeLevel> TradeLevels { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitAction> VisitActions { get; set; }
        public DbSet<VisitAssessor> VisitAssessors { get; set; }
        public DbSet<VisitCallBackRequest> VisitCallBackRequests { get; set; }
        public DbSet<VisitCallInLog> VisitCallInLogs { get; set; }
        public DbSet<VisitDetail> VisitDetails { get; set; }
        public DbSet<VisitNote> VisitNotes { get; set; }
        public DbSet<VisitPoint> VisitPoints { get; set; }
        public DbSet<VisitStatu> VisitStatus { get; set; }
        public DbSet<VisitStatusHistory> VisitStatusHistories { get; set; }
        public DbSet<VisitTimeTracker> VisitTimeTrackers { get; set; }
        public DbSet<VisitType> VisitTypes { get; set; }
        public DbSet<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
        public DbSet<ContactAddressType> ContactAddressTypes { get; set; }
        public DbSet<GeographicCountry> GeographicCountries { get; set; }
        public DbSet<GeographicCounty> GeographicCounties { get; set; }
        public DbSet<GeographicLocation> GeographicLocations { get; set; }
        public DbSet<GeographicPostalArea> GeographicPostalAreas { get; set; }
        public DbSet<GeographicPostCode> GeographicPostCodes { get; set; }
        public DbSet<GeographicRegion> GeographicRegions { get; set; }
        public DbSet<GeographicWorldArea> GeographicWorldAreas { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticlePermission> ArticlePermissions { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageArticle> PageArticles { get; set; }
        public DbSet<PageTour> PageTours { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourStep> TourSteps { get; set; }
        public DbSet<TourStepPlacement> TourStepPlacements { get; set; }
        public DbSet<TourUserRole> TourUserRoles { get; set; }
        public DbSet<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
        public DbSet<AreaLegacyUser> AreaLegacyUsers { get; set; }
        public DbSet<BranchLegacyUser> BranchLegacyUsers { get; set; }
        public DbSet<BrandLegacyUser> BrandLegacyUsers { get; set; }
        public DbSet<ClientLegacyUser> ClientLegacyUsers { get; set; }
        public DbSet<RegionLegacyUser> RegionLegacyUsers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportCategory> ReportCategories { get; set; }
        public DbSet<ReportParameterType> ReportParameterTypes { get; set; }
        public DbSet<ReportParameterValue> ReportParameterValues { get; set; }
        public DbSet<ReportReportType> ReportReportTypes { get; set; }
        public DbSet<ReportRestrictionClient> ReportRestrictionClients { get; set; }
        public DbSet<ReportSection> ReportSections { get; set; }
        public DbSet<ReportSource> ReportSources { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Messages_0> Messages_0 { get; set; }
        public DbSet<Messages_0_Id> Messages_0_Id { get; set; }
        public DbSet<Schema> Schemata { get; set; }
        public DbSet<BranchSocialNetwork> BranchSocialNetworks { get; set; }
        public DbSet<BrandSocialNetwork> BrandSocialNetworks { get; set; }
        public DbSet<ClientSocialNetwork> ClientSocialNetworks { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<CustomCalendar> CustomCalendars { get; set; }
        public DbSet<CustomCalendarDate> CustomCalendarDates { get; set; }
        public DbSet<DayOfWeek> DayOfWeeks { get; set; }
        public DbSet<DelayType> DelayTypes { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<DestinationEmail> DestinationEmails { get; set; }
        public DbSet<DestinationFileShare> DestinationFileShares { get; set; }
        public DbSet<DestinationFTP> DestinationFTPs { get; set; }
        public DbSet<DestinationType> DestinationTypes { get; set; }
        public DbSet<DynamicText> DynamicTexts { get; set; }
        public DbSet<EmailRecipient> EmailRecipients { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<ParameterOption> ParameterOptions { get; set; }
        public DbSet<Quarter> Quarters { get; set; }
        public DbSet<ReportFormat> ReportFormats { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleCustomCalendar> ScheduleCustomCalendars { get; set; }
        public DbSet<ScheduleDaily> ScheduleDailies { get; set; }
        public DbSet<ScheduleMonthly> ScheduleMonthlies { get; set; }
        public DbSet<ScheduleMonthlyMonth> ScheduleMonthlyMonths { get; set; }
        public DbSet<ScheduleQuarterly> ScheduleQuarterlies { get; set; }
        public DbSet<ScheduleQuarterlyQuarter> ScheduleQuarterlyQuarters { get; set; }
        public DbSet<ScheduleSpecific> ScheduleSpecifics { get; set; }
        public DbSet<ScheduleSubType> ScheduleSubTypes { get; set; }
        public DbSet<ScheduleType> ScheduleTypes { get; set; }
        public DbSet<ScheduleWeekly> ScheduleWeeklies { get; set; }
        public DbSet<ScheduleWeeklyDayOfWeek> ScheduleWeeklyDayOfWeeks { get; set; }
        public DbSet<ScheduleYearly> ScheduleYearlies { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public DbSet<SubscriptionDocument> SubscriptionDocuments { get; set; }
        public DbSet<SubscriptionEvent> SubscriptionEvents { get; set; }
        public DbSet<SubscriptionEventType> SubscriptionEventTypes { get; set; }
        public DbSet<SubscriptionReport> SubscriptionReports { get; set; }
        public DbSet<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
        public DbSet<SubscriptionReportParameter> SubscriptionReportParameters { get; set; }
        public DbSet<SubscriptionStatu> SubscriptionStatus { get; set; }
        public DbSet<SubscriptionStatusType> SubscriptionStatusTypes { get; set; }
        public DbSet<Trigger> Triggers { get; set; }
        public DbSet<TriggerCheck> TriggerChecks { get; set; }
        public DbSet<TriggerEvent> TriggerEvents { get; set; }
        public DbSet<TriggerHistory> TriggerHistories { get; set; }
        public DbSet<TriggerInstance> TriggerInstances { get; set; }
        public DbSet<TriggerInstanceReport> TriggerInstanceReports { get; set; }
        public DbSet<TriggerInstanceReportStatusType> TriggerInstanceReportStatusTypes { get; set; }
        public DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        public DbSet<CodeResource> CodeResources { get; set; }
        public DbSet<CodeResourceType> CodeResourceTypes { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<ApplicationLanguage1> ApplicationLanguage1 { get; set; }
        public DbSet<CodeResource1> CodeResource1 { get; set; }
        public DbSet<CodeResourceType1> CodeResourceType1 { get; set; }
        public DbSet<Translation1> Translation1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PasswordQuestionMap());
            modelBuilder.Configurations.Add(new PasswordResetMap());
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new PermissionGroupMap());
            modelBuilder.Configurations.Add(new PermissionGroupPermissionMap());
            modelBuilder.Configurations.Add(new PermissionGroupUserMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserImpersonationUserRoleMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new AuditActionMap());
            modelBuilder.Configurations.Add(new DatabaseMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventCategoryMap());
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
            modelBuilder.Configurations.Add(new BrandLogoMap());
            modelBuilder.Configurations.Add(new BrandStatuMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ClientAccountManagerMap());
            modelBuilder.Configurations.Add(new ClientContactStatuMap());
            modelBuilder.Configurations.Add(new ClientHistoryMap());
            modelBuilder.Configurations.Add(new ClientLogoMap());
            modelBuilder.Configurations.Add(new ClientOrganisationMap());
            modelBuilder.Configurations.Add(new ClientStatuMap());
            modelBuilder.Configurations.Add(new ContactAddressBranchMap());
            modelBuilder.Configurations.Add(new ContactAddressBrandMap());
            modelBuilder.Configurations.Add(new ContactAddressClientMap());
            modelBuilder.Configurations.Add(new ContactAddressUserRoleMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new IndustrySectorMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LocationStatuMap());
            modelBuilder.Configurations.Add(new LogoMap());
            modelBuilder.Configurations.Add(new PermissionTypeMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonAreaMap());
            modelBuilder.Configurations.Add(new PersonBranchMap());
            modelBuilder.Configurations.Add(new PersonBrandMap());
            modelBuilder.Configurations.Add(new PersonClientMap());
            modelBuilder.Configurations.Add(new PersonRegionMap());
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
            modelBuilder.Configurations.Add(new AreaQuestionnaireMap());
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
            modelBuilder.Configurations.Add(new AuditAdminEventMap());
            modelBuilder.Configurations.Add(new AuditAssessorEventMap());
            modelBuilder.Configurations.Add(new AuditPersonEventMap());
            modelBuilder.Configurations.Add(new AuditTableMap());
            modelBuilder.Configurations.Add(new BanBranchMap());
            modelBuilder.Configurations.Add(new BanBrandMap());
            modelBuilder.Configurations.Add(new BanClientMap());
            modelBuilder.Configurations.Add(new BenchmarkMap());
            modelBuilder.Configurations.Add(new BranchAccountingProductMap());
            modelBuilder.Configurations.Add(new BranchNoteMap());
            modelBuilder.Configurations.Add(new BranchQuestionnaireMap());
            modelBuilder.Configurations.Add(new BrandAccountingProductMap());
            modelBuilder.Configurations.Add(new BrandNoteMap());
            modelBuilder.Configurations.Add(new BrandQuestionnaireMap());
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
            modelBuilder.Configurations.Add(new ClientAccountingProductMap());
            modelBuilder.Configurations.Add(new ClientCallBackRequestMap());
            modelBuilder.Configurations.Add(new ClientCallInLogMap());
            modelBuilder.Configurations.Add(new ClientCommunicationLogMap());
            modelBuilder.Configurations.Add(new ClientContactTrackingMap());
            modelBuilder.Configurations.Add(new ClientNoteMap());
            modelBuilder.Configurations.Add(new ClientQuestionnaireMap());
            modelBuilder.Configurations.Add(new CommunicationPreferenceMap());
            modelBuilder.Configurations.Add(new CommunicationStatuMap());
            modelBuilder.Configurations.Add(new CommunicationTypeMap());
            modelBuilder.Configurations.Add(new ConfigurationMap());
            modelBuilder.Configurations.Add(new ConfigurationItemMap());
            modelBuilder.Configurations.Add(new ConfigurationSystemMap());
            modelBuilder.Configurations.Add(new ConfigurationTypeMap());
            modelBuilder.Configurations.Add(new ContactAddressCustomerMap());
            modelBuilder.Configurations.Add(new CriteriaAssessorAttributeMap());
            modelBuilder.Configurations.Add(new CriteriaConfigMap());
            modelBuilder.Configurations.Add(new CriteriaOperatorMap());
            modelBuilder.Configurations.Add(new CriteriaOptionMap());
            modelBuilder.Configurations.Add(new CriteriaSetMap());
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
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new GroupUserMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new MaintenanceMap());
            modelBuilder.Configurations.Add(new MaintenanceCategoryMap());
            modelBuilder.Configurations.Add(new MaintenanceCustomerMap());
            modelBuilder.Configurations.Add(new ManagementCategoryMap());
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
            modelBuilder.Configurations.Add(new PeriodMap());
            modelBuilder.Configurations.Add(new PeriodBrandMap());
            modelBuilder.Configurations.Add(new PeriodClientMap());
            modelBuilder.Configurations.Add(new PersonCallBackRequestMap());
            modelBuilder.Configurations.Add(new PersonClientContactTrackingMap());
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
            modelBuilder.Configurations.Add(new RegionQuestionnaireMap());
            modelBuilder.Configurations.Add(new RemovalReasonMap());
            modelBuilder.Configurations.Add(new ReportProblemActionMap());
            modelBuilder.Configurations.Add(new ReportProblemActionTypeMap());
            modelBuilder.Configurations.Add(new ReportProblemCauseMap());
            modelBuilder.Configurations.Add(new ReportProblemTrackingMap());
            modelBuilder.Configurations.Add(new ReportProblemTrackingActionMap());
            modelBuilder.Configurations.Add(new ReportProblemTypeMap());
            modelBuilder.Configurations.Add(new ResultCommentMap());
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
            modelBuilder.Configurations.Add(new TradeLevelMap());
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
            modelBuilder.Configurations.Add(new ContactAddressMap());
            modelBuilder.Configurations.Add(new ContactAddressGeoLocationMap());
            modelBuilder.Configurations.Add(new ContactAddressTypeMap());
            modelBuilder.Configurations.Add(new GeographicCountryMap());
            modelBuilder.Configurations.Add(new GeographicCountyMap());
            modelBuilder.Configurations.Add(new GeographicLocationMap());
            modelBuilder.Configurations.Add(new GeographicPostalAreaMap());
            modelBuilder.Configurations.Add(new GeographicPostCodeMap());
            modelBuilder.Configurations.Add(new GeographicRegionMap());
            modelBuilder.Configurations.Add(new GeographicWorldAreaMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticlePermissionMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new PageArticleMap());
            modelBuilder.Configurations.Add(new PageTourMap());
            modelBuilder.Configurations.Add(new TourMap());
            modelBuilder.Configurations.Add(new TourStepMap());
            modelBuilder.Configurations.Add(new TourStepPlacementMap());
            modelBuilder.Configurations.Add(new TourUserRoleMap());
            modelBuilder.Configurations.Add(new TourUserRoleTourStepMap());
            modelBuilder.Configurations.Add(new AreaLegacyUserMap());
            modelBuilder.Configurations.Add(new BranchLegacyUserMap());
            modelBuilder.Configurations.Add(new BrandLegacyUserMap());
            modelBuilder.Configurations.Add(new ClientLegacyUserMap());
            modelBuilder.Configurations.Add(new RegionLegacyUserMap());
            modelBuilder.Configurations.Add(new ReportMap());
            modelBuilder.Configurations.Add(new ReportCategoryMap());
            modelBuilder.Configurations.Add(new ReportParameterTypeMap());
            modelBuilder.Configurations.Add(new ReportParameterValueMap());
            modelBuilder.Configurations.Add(new ReportReportTypeMap());
            modelBuilder.Configurations.Add(new ReportRestrictionClientMap());
            modelBuilder.Configurations.Add(new ReportSectionMap());
            modelBuilder.Configurations.Add(new ReportSourceMap());
            modelBuilder.Configurations.Add(new ReportTypeMap());
            modelBuilder.Configurations.Add(new Messages_0Map());
            modelBuilder.Configurations.Add(new Messages_0_IdMap());
            modelBuilder.Configurations.Add(new SchemaMap());
            modelBuilder.Configurations.Add(new BranchSocialNetworkMap());
            modelBuilder.Configurations.Add(new BrandSocialNetworkMap());
            modelBuilder.Configurations.Add(new ClientSocialNetworkMap());
            modelBuilder.Configurations.Add(new SocialNetworkMap());
            modelBuilder.Configurations.Add(new CustomCalendarMap());
            modelBuilder.Configurations.Add(new CustomCalendarDateMap());
            modelBuilder.Configurations.Add(new DayOfWeekMap());
            modelBuilder.Configurations.Add(new DelayTypeMap());
            modelBuilder.Configurations.Add(new DestinationMap());
            modelBuilder.Configurations.Add(new DestinationEmailMap());
            modelBuilder.Configurations.Add(new DestinationFileShareMap());
            modelBuilder.Configurations.Add(new DestinationFTPMap());
            modelBuilder.Configurations.Add(new DestinationTypeMap());
            modelBuilder.Configurations.Add(new DynamicTextMap());
            modelBuilder.Configurations.Add(new EmailRecipientMap());
            modelBuilder.Configurations.Add(new MonthMap());
            modelBuilder.Configurations.Add(new ParameterOptionMap());
            modelBuilder.Configurations.Add(new QuarterMap());
            modelBuilder.Configurations.Add(new ReportFormatMap());
            modelBuilder.Configurations.Add(new ScheduleMap());
            modelBuilder.Configurations.Add(new ScheduleCustomCalendarMap());
            modelBuilder.Configurations.Add(new ScheduleDailyMap());
            modelBuilder.Configurations.Add(new ScheduleMonthlyMap());
            modelBuilder.Configurations.Add(new ScheduleMonthlyMonthMap());
            modelBuilder.Configurations.Add(new ScheduleQuarterlyMap());
            modelBuilder.Configurations.Add(new ScheduleQuarterlyQuarterMap());
            modelBuilder.Configurations.Add(new ScheduleSpecificMap());
            modelBuilder.Configurations.Add(new ScheduleSubTypeMap());
            modelBuilder.Configurations.Add(new ScheduleTypeMap());
            modelBuilder.Configurations.Add(new ScheduleWeeklyMap());
            modelBuilder.Configurations.Add(new ScheduleWeeklyDayOfWeekMap());
            modelBuilder.Configurations.Add(new ScheduleYearlyMap());
            modelBuilder.Configurations.Add(new SubscriptionMap());
            modelBuilder.Configurations.Add(new SubscriptionDestinationMap());
            modelBuilder.Configurations.Add(new SubscriptionDocumentMap());
            modelBuilder.Configurations.Add(new SubscriptionEventMap());
            modelBuilder.Configurations.Add(new SubscriptionEventTypeMap());
            modelBuilder.Configurations.Add(new SubscriptionReportMap());
            modelBuilder.Configurations.Add(new SubscriptionReportDestinationMap());
            modelBuilder.Configurations.Add(new SubscriptionReportParameterMap());
            modelBuilder.Configurations.Add(new SubscriptionStatuMap());
            modelBuilder.Configurations.Add(new SubscriptionStatusTypeMap());
            modelBuilder.Configurations.Add(new TriggerMap());
            modelBuilder.Configurations.Add(new TriggerCheckMap());
            modelBuilder.Configurations.Add(new TriggerEventMap());
            modelBuilder.Configurations.Add(new TriggerHistoryMap());
            modelBuilder.Configurations.Add(new TriggerInstanceMap());
            modelBuilder.Configurations.Add(new TriggerInstanceReportMap());
            modelBuilder.Configurations.Add(new TriggerInstanceReportStatusTypeMap());
            modelBuilder.Configurations.Add(new ApplicationLanguageMap());
            modelBuilder.Configurations.Add(new CodeResourceMap());
            modelBuilder.Configurations.Add(new CodeResourceTypeMap());
            modelBuilder.Configurations.Add(new TranslationMap());
            modelBuilder.Configurations.Add(new ApplicationLanguage1Map());
            modelBuilder.Configurations.Add(new CodeResource1Map());
            modelBuilder.Configurations.Add(new CodeResourceType1Map());
            modelBuilder.Configurations.Add(new Translation1Map());
        }
    }
}
