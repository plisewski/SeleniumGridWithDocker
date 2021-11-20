using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.Helpers;
using SeleniumGridWithDocker.PageObjects.UserAccountPages;

namespace SeleniumGridWithDocker.PageObjects.Components
{
    class TopNavigationComponent : PageBase
    {
        //not looged user
        private readonly By signInLink = By.ClassName("login");

        //logged user
        private readonly By userDashboardLink = By.ClassName("account");
        private readonly By signOutLink = By.ClassName("logout");

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

        public string GetUserFirstAndLastNameFromDashboardLink()
        {
            ExplicitWaitWrappers.UntilElementIsVisible(Driver, userDashboardLink);

            return Driver.FindElement(userDashboardLink).Text;
        }
    }
}
