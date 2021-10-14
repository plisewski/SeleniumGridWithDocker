using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;

namespace SeleniumGridWithDocker.PageObjects.UserAccountPages.LoggedUserPages
{
    class DashboardLoggedUserPage : PageBase
    {
        private readonly By ordersHistoryLink = By.CssSelector("[title='Orders']");
        private readonly By creditSlipsLink = By.CssSelector("[title='Credit slips']");
        private readonly By addressesLink = By.CssSelector("[title='Addresses']");
        private readonly By personalInformationLink = By.CssSelector("[title='Information']");
        private readonly By wishlistsLink = By.CssSelector("[title='My wishlists']");

        public DashboardLoggedUserPage(RemoteWebDriver driver) : base(driver)
        {

        }
    }
}
