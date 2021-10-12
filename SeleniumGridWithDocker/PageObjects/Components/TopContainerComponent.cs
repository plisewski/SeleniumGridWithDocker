using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;

namespace SeleniumGridWithDocker.PageObjects.Components
{
    class TopContainerComponent : PageBase
    {
        private readonly By logoImage = By.ClassName("logo");
        private readonly By searchForm = By.Id("searchbox");
        private readonly By shoppingCartLink = By.CssSelector(".shopping_cart > a");
        private readonly By womenCategoryLink = By.CssSelector("li > [title='Women']");
        private readonly By dressesCategoryLink = By.XPath("(//a[@title='Dresses'])[2]");
        private readonly By thirtsCategoryLink = By.XPath("(//a[@title='T-shirts'])[2]");

        public TopContainerComponent(RemoteWebDriver driver) : base(driver)
        {

        }
    }
}
