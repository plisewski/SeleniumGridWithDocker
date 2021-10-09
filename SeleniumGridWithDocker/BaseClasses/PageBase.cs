using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace SeleniumGridWithDocker.BaseClasses
{
    abstract class PageBase
    {
        protected readonly RemoteWebDriver Driver;

        public PageBase(RemoteWebDriver remoteWebDriver)
        {
            Driver = remoteWebDriver;
        }

        public void ClickOnElement(By webElement)
        {
            Driver.FindElement(webElement).Click();
        }

        public void ClickOnElementUsingJavaScript(By webElement)
        {
            Driver.ExecuteScript("arguments[0].click();", Driver.FindElement(webElement));
        }

        public void ClearTextBox(By webElement)
        {
            if (Driver.FindElement(webElement).GetAttribute("value").Length > 0)
                Driver.FindElement(webElement).Clear();
        }

        public void FillTextBox(By webElement, string text)
        {
            Driver.FindElement(webElement).SendKeys(text);
        }

        public void HoverOverElement(By webelement)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(webelement)).Perform();
        }
    }
}
