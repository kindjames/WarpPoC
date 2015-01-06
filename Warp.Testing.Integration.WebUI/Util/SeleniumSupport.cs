using System.IO;
using OpenQA.Selenium;

namespace Warp.Testing.Integration.WebUI.Util
{
    public class SeleniumSupport : WebDriverResultSupplementer
    {
        static string TempPath;

        protected override string ImagesPath
        {
            get
            {
                return GetTempPath();
            }
        }

        protected override ITakesScreenshot Screenshotter
        {
            get
            {
                return SeleniumSpecs.Selenium;
            }
        }

        protected override IWebDriver WebDriver
        {
            get
            {
                return SeleniumSpecs.Selenium;
            }
        }

        static string GetTempPath()
        {
            if (string.IsNullOrEmpty(TempPath))
            {
                TempPath = Path.Combine(Path.GetTempPath(), "selenium");

                if (Directory.Exists(TempPath))
                {
                    Directory.Delete(TempPath, true);
                }

                Directory.CreateDirectory(TempPath);
            }

            return TempPath;
        }
    }
}