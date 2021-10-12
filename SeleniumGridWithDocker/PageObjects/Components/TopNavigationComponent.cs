using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;

namespace SeleniumGridWithDocker.PageObjects.Components
{
    class TopNavigationComponent : PageBase
    {
        private readonly By signInLink = By.ClassName("login");
        private readonly By contactLink = By.CssSelector("#contact-link a");

        public TopNavigationComponent(RemoteWebDriver driver) : base(driver)
        {

        }
    }
}
