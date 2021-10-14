using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.Helpers;
using SeleniumGridWithDocker.PageObjects.UserAccountPages;

namespace SeleniumGridWithDocker.PageObjects.Components
{
    class TopNavigationComponent : PageBase
    {
        private readonly By signInLink = By.ClassName("login");
        private readonly By contactLink = By.CssSelector("#contact-link a");

        public TopNavigationComponent(RemoteWebDriver driver) : base(driver)
        {

        }

        public MainUserAccountPage ClickSignInLink()
        {
            ExplicitWaitWrappers.UntilElementToBeClickable(Driver, signInLink);
            ClickOnElement(signInLink);

            return new MainUserAccountPage(Driver);
        }
    }
}
