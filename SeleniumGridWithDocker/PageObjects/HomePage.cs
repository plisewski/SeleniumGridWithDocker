using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridWithDocker.PageObjects
{
    class HomePage : PageBase
    {
        public HomePage(RemoteWebDriver driver) : base(driver)
        {

        }

        public HomePage Navigate()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com");

            return this;
        }
    }
}
