using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Warp.Testing.Integration.WebUI.Util
{
    public class ScreenshotRemoteWebDriver : RemoteWebDriver, ITakesScreenshot
    {
        public ScreenshotRemoteWebDriver(Uri address, ICapabilities capabilities)
            : base(address, capabilities)
        {
        }

        public new Screenshot GetScreenshot()
        {
            var screenshotResponse = Execute(DriverCommand.Screenshot, null);
            var base64 = screenshotResponse.Value.ToString();

            return new Screenshot(base64);
        }
    }
}