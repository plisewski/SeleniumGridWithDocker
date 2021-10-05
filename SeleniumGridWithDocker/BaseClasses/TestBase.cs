using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumGridWithDocker.BaseClasses
{
    public class TestBase
    {
        protected RemoteWebDriver Driver;
        private DriverOptions browserOptions;

        [SetUp]
        public void Setup()
        {
            var hubUrl = TestContext.Parameters["RemoteWebDriverHubUrl"];
            var browser = TestContext.Parameters["Browser"];

            Driver = new RemoteWebDriver(new Uri(hubUrl), ChooseBrowserOptions(browser));

            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        private DriverOptions ChooseBrowserOptions(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    browserOptions = new ChromeOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };
                    break;
                case "firefox":
                    browserOptions = new FirefoxOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };
                    break;
            }

            return browserOptions;
        }
    }
}
