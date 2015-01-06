using System;
using Machine.Specifications;
using OpenQA.Selenium.Remote;

namespace Warp.Testing.Integration.WebUI.Util
{
    public abstract class SeleniumSpecs
    {
        internal static ScreenshotRemoteWebDriver Selenium;

        Establish context = () =>
        {
            Selenium = new ScreenshotRemoteWebDriver(new Uri("http://localhost:50240/"), DesiredCapabilities.Chrome());
        };

        Cleanup after =
            () => Selenium.Close();
    }
}