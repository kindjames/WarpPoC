using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using Warp.Core.Domain.Enum;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    public class AuthenticationDataFactory : IDataFactory
    {
        public int Order { get { return 2; } }

        public void AddDataToContext(MigrationsAndTestingContext context)
        {
            var x = new PasswordHasher();

            var roleGroups = new[]
            {
                new RoleGroup {
                    Name = "GodMode",
                    Description = "Access all areas",
                    Roles = new[] {
                        new Role {Name = "GodMode", Description = "Access all areas"}
                    }
                },
                new RoleGroup {Name = "DeleteUsers", Description = "Permissions to delete users"},
                new RoleGroup {Name = "AddVisits", Description = "Permissions to add visits"},
                new RoleGroup {Name = "Resetpasswords", Description = "Permission to reset user's passwords"},
                new RoleGroup {Name = "Manager", Description = "Permissions for a manager"},
                new RoleGroup {Name = "DashboardReadOnly", Description = "Read only access for the Dashboard tab"},
                new RoleGroup {Name = "VisitsReadOnly", Description = "Read only access for the Visits tab"},
                new RoleGroup {Name = "FeedbackReadOnly", Description = "Read only access for the Feedback tab"},
                new RoleGroup {Name = "AnalysisReadOnly", Description = "Read only access for the Analysis tab"},
                new RoleGroup {Name = "DocumentsReadOnly", Description = "Read only access for the Documents tab"},
                new RoleGroup {Name = "NewsReadOnly", Description = "Read only access for the News tab"},
                new RoleGroup {Name = "SubscriptionsReadOnly", Description = "Read only access for the Subscriptions tab"},
                new RoleGroup {Name = "Notifications", Description = "All Notifications Permissions"},
                new RoleGroup {Name = "MaintenanceWarnings", Description = "All Maintenance Permissions"},
                new RoleGroup {Name = "ToursReadOnly", Description = "Contains all read only permissions for tours"},
                new RoleGroup {Name = "HelpAdmin", Description = "Contains all admin help permissions"},
                new RoleGroup {Name = "HelpReadOnly", Description = "Contains all read only help permissions"},
                new RoleGroup {Name = "SubscriptionsAdmin", Description = "Contains the permissions for editing subscriptions"},
                new RoleGroup {Name = "ToursAdmin", Description = "Contains the admin permissions for tours"},
                new RoleGroup
                {
                    Name = "HospitalityGEMClientReadOnly",
                    Description = "Contains the read only permissions for the client page",
                    Roles = new[] {
                        new Role {Name = "CanViewClientPage", Description = "User can view the client page"}
                    }
                },
                new RoleGroup {Name = "HospitalityGEMDashboardReadOnly", Description = "Contains the read only permissions for the HospitalityGEM dashboard"},
                new RoleGroup {Name = "HospitalityGEMAssessorsReadOnly", Description = "Contains the read only permissions for the HospitalityGEMassessors"},
                new RoleGroup {Name = "HospitalityGEMPortalReadOnly", Description = "Contains the read only permissions for the HospitalityGEM portal"},
                new RoleGroup {Name = "HospitalityGEMVisitsReadOnly", Description = "Contains the read only permissions for the HospitalityGEM visits page"},
                new RoleGroup {Name = "HospitalityGEMAccountsReadOnly", Description = "Contains the read only permissions for the HospitalityGEM accounts page"},
                new RoleGroup {Name = "HospitalityGEMAnalysisReadOnly", Description = "Contains the read only permissions for the HospitalityGEM analysis page"},
                new RoleGroup {Name = "HospitalityGEMSettingsReadOnly", Description = "Contains the read only permissions for the HospitalityGEM settings page"},
                new RoleGroup {Name = "DashboardPrint", Description = "Dashboard PDF and print access"},
                new RoleGroup {Name = "TranslationAdmin", Description = "Contains the admin permissions for the Translation Service"},
                new RoleGroup {Name = "TranslationUserAdmin", Description = "Contains the User specific admin permissions for the Translation Service"},
                new RoleGroup {Name = "TranslationClientAdmin", Description = "Contains Client specific admin permissions for the Translation Service"}
            };

            //context.RoleGroups.AddOrUpdate(roleGroups);

            //var roles = new[]
            //{
            //    new Role {Name = "DeleteVisit", Description = "User can delete a visit"},
            //    new Role {Name = "DeleteUser", Description = "User can delete user"},
            //    new Role {Name = "AllocateVisit", Description = "User can allocate a visit"},
            //    new Role {Name = "CreateSuperUser", Description = "User can upgrade other users to super users"},
            //    new Role {Name = "CreateCustomer", Description = "User can create a customer"},
            //    new Role {Name = "DeleteCustomer", Description = "User can delete a customer"},
            //    new Role {Name = "ChangeImpersonation", Description = "User can change the impersonated client and manager"},
            //    new Role {Name = "ViewHelp", Description = "User can view the help system"},
            //    new Role {Name = "AddHelpArticle", Description = "User can add a help article"},
            //    new Role {Name = "DeleteHelpArticle", Description = "User can delete help articles"},
            //    new Role {Name = "EditHelpArticle", Description = "User can Edit help articles"},
            //    new Role {Name = "SettingsView", Description = "User can see the settings button and view the settings page"},
            //    new Role {Name = "DashboardView", Description = "User can see the dashboard tab"},
            //    new Role {Name = "AddDashboard", Description = "User can add dashboards"},
            //    new Role {Name = "EditDashboard", Description = "User can edit dashboards"},
            //    new Role {Name = "DeleteDashboard", Description = "User can delete dashboards"},
            //    new Role {Name = "AddGadget", Description = "User can add dashboards to a gadget"},
            //    new Role {Name = "EditGadget", Description = "User can edit a gadget on a dashboard"},
            //    new Role {Name = "RemoveGadget", Description = "User can remove a gadget from a dashboard"},
            //    new Role {Name = "AssessmentsQuickSearch", Description = "User can use the Quick search feature"},
            //    new Role {Name = "AssessmentsAdvancedSearch", Description = "User can use the Advanced search feature"},
            //    new Role {Name = "AssessmentsView", Description = "User can view the assessments tab and individual visits"},
            //    new Role {Name = "AssessmentsDownloadPDF", Description = "User can download a PDF"},
            //    new Role {Name = "AssessmentsChart", Description = "User can see the Colour coded assessments chart"},
            //    new Role {Name = "FeedbackQuickSearch", Description = "User can use the Quick search feature"},
            //    new Role {Name = "FeedbackAdvancedSearch", Description = "User can use the Advanced search feature"},
            //    new Role {Name = "FeedbackView", Description = "User can view the Feedback tab and individual visits"},
            //    new Role {Name = "FeedbackDownloadPDF", Description = "User can download a PDF"},
            //    new Role {Name = "FeedbackChart", Description = "User can see the Colour coded assessments chart"},
            //    new Role {Name = "FeedbackWordle", Description = "User can see the feedback Wordle"},
            //    new Role {Name = "ManagerCommentsRead", Description = "User can see Manager Comments"},
            //    new Role {Name = "ManagercommentsEdit", Description = "User can edit Manager Comments"},
            //    new Role {Name = "GuestContactInformation", Description = "User can see the Guest Contact information"},
            //    new Role {Name = "AnalysisView", Description = "User can see the analysis tab and any reports assigned to them"},
            //    new Role {Name = "AddSection", Description = "User can add Report Sections"},
            //    new Role {Name = "EditSection", Description = "User can edit Report Sections"},
            //    new Role {Name = "DeleteSection", Description = "User can delete Report Sections"},
            //    new Role {Name = "AddReport", Description = "User can add reports"},
            //    new Role {Name = "EditReport", Description = "User can Edit Reports"},
            //    new Role {Name = "DeleteReport", Description = "User can delete reports"},
            //    new Role {Name = "ExportReport", Description = "User can export a report to various formats"},
            //    new Role {Name = "SubscriptionsDashboard", Description = "User can see the subscriptions Dashboard"},
            //    new Role {Name = "SubscriptionsView", Description = "User can view subscriptions"},
            //    new Role {Name = "SubscriptionsStart", Description = "User can Start subscriptions"},
            //    new Role {Name = "SubscriptionsPause", Description = "User can Pause subscriptions"},
            //    new Role {Name = "SubscriptionsStop", Description = "User can Stop subscriptions"},
            //    new Role {Name = "SubscriptionsAdd", Description = "User can Add subscriptions"},
            //    new Role {Name = "SubscriptionsDelete", Description = "User can Delete subscriptions"},
            //    new Role {Name = "SubscriptionsEdit", Description = "User can Edit subscriptions"},
            //    new Role {Name = "SubscriptionsResend", Description = "User can Resend subscriptions"},
            //    new Role {Name = "MaintenanceWarningsView", Description = "User can see Maintenance Warnings"},
            //    new Role {Name = "MaintenanceWarningsAdd", Description = "User can Add Maintenance Warnings"},
            //    new Role {Name = "ViewNotifications", Description = "User can see the notification count and dropdown"},
            //    new Role {Name = "ViewDetailedNotifications", Description = "User can select a notification and see more detailed information"},
            //    new Role {Name = "MarkasUnread", Description = "User can mark a notification as unread"},
            //    new Role {Name = "MarkasRead", Description = "User can mark a notification as read"},
            //    new Role {Name = "ShowAllNotifications", Description = "User can view all notifications"},
            //    new Role {Name = "ViewTours", Description = "User can view tours"},
            //    new Role {Name = "ViewTours", Description = "User can view tours"},
            //    new Role {Name = "SwitchRoles", Description = "User can switch between roles that they are assigned to"},
            //    new Role {Name = "AddHelpArticleToPage", Description = "User can add help articles to a page"},
            //    new Role {Name = "RemoveHelpArticleFromPage", Description = "User can remove help articles from a page"},
            //    new Role {Name = "PublishArticles", Description = "User can Publish Articles"},
            //    new Role {Name = "CanViewUnpublishedArticles", Description = "User can view unpublished Articles"},
            //    new Role {Name = "CanViewPublishedArticles", Description = "User can view published Articles"},
            //    new Role {Name = "CanEditTours", Description = "User can edit the steps in a tour"},
            //    new Role {Name = "CanAddTours", Description = "User can add tours to a page"},
            //    new Role {Name = "CanDeleteTours", Description = "User can delete tours from a page"},
            //    new Role {Name = "CanViewClientPage", Description = "User can view the client page"},
            //    new Role {Name = "CanViewDashboardPage", Description = "User can view the dashboard page"},
            //    new Role {Name = "CanViewAssessorsPage", Description = "User can view the assessors page"},
            //    new Role {Name = "CanViewPortalPage", Description = "User can view the portal page"},
            //    new Role {Name = "CanViewVisitsPage", Description = "User can view the visits page"},
            //    new Role {Name = "CanViewAccountsPage", Description = "User can view the accounts page"},
            //    new Role {Name = "CanViewAnalysisPage", Description = "User can view the analysis page"},
            //    new Role {Name = "CanViewSystemSettingsPage", Description = "User can view the systems settings page"},
            //    new Role {Name = "PDFandPrintDashboard", Description = "User can PDF or  Print Dashboard"},
            //    new Role {Name = "PDFandPrintDashboard", Description = "User can PDF or  Print Dashboard"},
            //    new Role {Name = "TextResourceSystemAdministration", Description = "User can create, retrieve, edit and delete all System translation resources"},
            //    new Role {Name = "TextResourceUserAdministration", Description = "User can create, retrieve, edit and delete User specific translation resource s only"},
            //    new Role {Name = "TextResourceUserAdministration", Description = "User can create, retrieve, edit and delete User specific translation resource s only"},
            //    new Role {Name = "TextResourceClientAdministration", Description = "User can create, retrieve, edit and delete Client specific translation resources only"},
            //    new Role {Name = "TextResourceClientAdministration", Description = "User can create, retrieve, edit and delete Client specific translation resources only"},
            //};


            var languages = new[]
            {
                new Language {Id = Guid.NewGuid(), InvariantCulture = "en", Locale = "GB", Name = "English"},
                new Language {InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {InvariantCulture = "nl", Locale = "NL", Name = "Dutch"},
                new Language {InvariantCulture = "de", Locale = "DE", Name = "German"},
                new Language {InvariantCulture = "oo", Locale = "AR", Name = "Pirate"}
            };

            context.Languages.AddOrUpdate(languages);

            var customers = new[]
            {
                new Customer {Name = "Test CustomerId", UrlName = "http://www.mysterydining.com", DisplayName = "Test", CustomerCode = "TEST", DefaultLanguageId = languages[0].Id },
                new Customer {Name = "HospitalityGEM", UrlName = "http://www.hospitalitygem.com", DisplayName = "hGEM", CustomerCode = "hGEM", DefaultLanguageId = languages[0].Id }
            };

            context.Customers.AddOrUpdate(customers);

            var users = new[]
            {
                new User
                {
                    Forename = "Test",
                    Surname = "User",
                    PasswordHash = x.HashPassword("test1"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test@test.com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Customer = customers[0],
                    RoleGroups = new Collection<RoleGroup>
                    {
                        roleGroups[0],
                        roleGroups[19]
                    }
                },
                new User
                {
                    Forename = "Test",
                    Surname = "User 2",
                    PasswordHash = x.HashPassword("test2"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test2@test.com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Customer = customers[0],
                    RoleGroups = new Collection<RoleGroup>
                    {
                        roleGroups[0],
                        roleGroups[19]
                    }
                },
                new User
                {
                    Forename = "Test",
                    Surname = "User 3",
                    PasswordHash = x.HashPassword("test3"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test3@test.com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Customer = customers[0],
                    RoleGroups = new Collection<RoleGroup>
                    {
                        roleGroups[0],
                        roleGroups[19]
                    }
                }
            };

            context.Users.AddOrUpdate(users);

            var clients = new[]
            {
                new Client
                {
                    AccountManager = users[0],
                    Status = ClientStatus.Active,
                    Name = "Test active client",
                    Code = "AC10",
                    Customer = customers[0]
                },
                new Client
                {
                    AccountManager = users[0],
                    Status = ClientStatus.Inactive,
                    Name = "Test inactive client",
                    Code = "IC10",
                    Customer = customers[0]
                },
                new Client
                {
                    AccountManager = users[0],
                    Status = ClientStatus.Test,
                    Name = "Test, test client",
                    Code = "TC10",
                    Customer = customers[1]
                }
            };

            context.Clients.AddOrUpdate(clients);

            var textResourceIdentifiers = new[]
            {
                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "UsernameLabel",
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "UsernameTextPlaceholder",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "PasswordLabel",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "PasswordTextPlaceholder",
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "RememberMeCheckbox",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    ResourceIdentifierCode = "LoginButton",
                    ClientOverridable = false
                }
            };

            context.TextResourceIdentifiers.AddOrUpdate(textResourceIdentifiers);

            var textResources = new[]
            {
                new TextResource
                {
                    ResourceString = "Username",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "UsernameLabel"),
                    Language = languages[0],
                    Client = clients[0]
                },
                new TextResource
                {
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "UsernameTextPlaceholder"),
                    Language = languages[0],
                    Client = clients[0]
                },
                new TextResource
                {
                    ResourceString = "Password",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "PasswordLabel"),
                    Language = languages[0],
                    Client = clients[0]
                },
                new TextResource
                {
                    ResourceString = "Password",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "PasswordTextPlaceholder"),
                    Language = languages[0],
                    Client = clients[0]
                },
                new TextResource
                {
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "RememberMeCheckbox"),
                    Language = languages[0],
                    Client = clients[0]
                },
                new TextResource
                {
                    ResourceString = "Log in",
                    TextResourceIdentifier = textResourceIdentifiers.Single(i => i.ResourceIdentifierCode == "LoginButton"),
                    Language = languages[0],
                    Client = clients[0]
                }
            };

            context.TextResources.AddOrUpdate(textResources);
        }
    }
}