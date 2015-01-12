using System;
using System.IO;
using NUnit.Framework;
using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Warp.Testing.Acceptance.Behaviors;
using Warp.WebUI;
using Warp.WebUI.Controllers;

namespace Warp.Testing.Acceptance
{
    /// <summary>
    /// Creates the ASP.NET MVC Web Application for use with all tests.
    /// </summary>
    [SetUpFixture]
    internal class WebApplicationTestingContext : SpecsForConfiguration
    {
        public WebApplicationTestingContext()
        {
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
            
            config.UseBrowser(BrowserDriver.Chrome);
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