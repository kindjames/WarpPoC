using System;
using System.IO;
using hGem.WebUI;
using NUnit.Framework;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Warp.WebUI.Controllers;

namespace hGem.Testing.Acceptance
{
    //public class TestDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    //{
    //    protected override void Seed(ApplicationDbContext context)
    //    {
    //        var user = new ApplicationUser
    //        {
    //            UserName = "real@user.com",
    //            Email = "real@user.com",
    //            LockoutEnabled = true,
    //            SecurityStamp = Guid.NewGuid().ToString(),
    //            PasswordHash = new PasswordHasher().HashPassword("P@ssw0rd1")
    //        };

    //        context.Users.Add(user);
    //        context.SaveChanges();
    //    }
    //}

    /// <summary>
    /// Creates the ASP.NET MVC Web Application for use with all tests.
    /// </summary>
    [SetUpFixture]
    internal class WebApplicationTestingContext : SpecsForConfiguration//SpecsForMvcConfig
    {
        public WebApplicationTestingContext()
        {
            //BeforeEachTest(() =>
            //{
            //    Database.SetInitializer(new TestDbInitializer());
            //    ApplicationDbContext context = ApplicationDbContext.Create();
            //    context.Database.Initialize(true);
            //});
            //WhenTesting<SpecsFor<MvcWebApp>>().EnrichWith<TestDatabaseInitializer>();
        }

        private SpecsForIntegrationHost _host;

        [SetUp]
        public void SetupTestRun()
        {
            var config = new SpecsForMvcConfig();

            config.UseIISExpress()
                .With(Project.Named("Warp.WebUI"));
                //.ApplyWebConfigTransformForConfig("Acceptance");

            config.BuildRoutesUsingAttributeRoutingFromAssemblyContaining<HomeController>();
            config.BuildRoutesUsing(Startup.ConfigureRoutes);
            
            config.UseBrowser(BrowserDriver.InternetExplorer);
            //config.UseBrowser(BrowserDriver.Firefox);

            //config.RegisterArea<TasksAreaRegistration>();
            //config.InterceptEmailMessagesOnPort(13565);

            config.AuthenticateBeforeEachTestUsing<StandardAuthenticator>();
            config.AssertConfigurationValid();

            _host = new SpecsForIntegrationHost(config);
            var stringWriter = new StringWriter();
            try
            {
                // Build log is sent to console, redirect output to StringWriter
                Console.SetOut(stringWriter);
                _host.Start();
            }
            catch (ApplicationException ex)
            {
                throw new Exception("Build failed. Output: " + stringWriter, ex);
            }
        }

        [TearDown]
        public void TearDownTestRun()
        {
            _host.Shutdown();
        }
    }
}