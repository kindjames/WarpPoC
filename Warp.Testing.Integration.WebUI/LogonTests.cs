using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using OpenQA.Selenium;
using Warp.Testing.Integration.WebUI.Util;

namespace Warp.Testing.Integration.WebUI
{
    class LogonTests
    {
        [Subject("Selenium support")]
        public class When_a_specification_fails : SeleniumSpecs
        {
            Because of = () =>
            {
                Selenium.Navigate().GoToUrl("http://localhost:50240/authentication/login");
                Selenium.FindElement(By.Id("UserName")).SendKeys("haxor");
                Selenium.FindElement(By.Id("Password")).SendKeys("password");
                Selenium.FindElement(By.XPath("//input[@value='Log in']")).Click();
            };

            It should_supply_screenshots_detailing_the_error =
                () => true.ShouldBeFalse();
        }

        //[Subject("Log in")]
        //public class When_logging_in_valid_credentials : SeleniumSpecs
        //{
        //    Because of = () =>
        //    {
        //        Selenium.Navigate().GoToUrl("http://localhost:1337/Account/LogOn");
        //        Selenium.FindElement(By.Id("UserName")).SendKeys("admin");
        //        Selenium.FindElement(By.Id("Password")).SendKeys("secret");
        //        Selenium.FindElement(By.XPath("//input[@value='Log On']")).Click();
        //    };

        //    It should_display_the_home_page =
        //        () => Selenium.Title.ShouldContain("Home Page");
        //}

        //[Subject("Log in")]
        //public class When_logging_in_with_invalid_credentials : SeleniumSpecs
        //{
        //    Because of = () =>
        //    {
        //        Selenium.Navigate().GoToUrl("http://localhost:1337/Account/LogOn");
        //        Selenium.FindElement(By.Id("UserName")).SendKeys("haxor");
        //        Selenium.FindElement(By.Id("Password")).SendKeys("password");
        //        Selenium.FindElement(By.XPath("//input[@value='Log On']")).Click();
        //    };

        //    It should_display_an_error_message =
        //        () => Selenium
        //            .FindElement(By.CssSelector(".validation-summary-errors"))
        //            .FindElement(By.TagName("span"))
        //            .Text
        //            .ShouldEqual("Login was unsuccessful. Please correct the errors and try again.");
        //}
    }
}
