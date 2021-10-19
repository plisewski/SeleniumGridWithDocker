using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedCondition = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumGridWithDocker.Helpers
{
    public static class ExplicitWaitWrappers
    {
        public static void UntilElementToBeClickable(RemoteWebDriver driver, By e, int waitInSeconds = 15)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(waitInSeconds)).
                Until(ExpectedCondition.ElementToBeClickable(e));
        }

        public static void UntilElementIsVisible(RemoteWebDriver driver, By e, int waitInSeconds = 15)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(waitInSeconds)).
                Until(ExpectedCondition.ElementIsVisible(e));
        }
    }
}
