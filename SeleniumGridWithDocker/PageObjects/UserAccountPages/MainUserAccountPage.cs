using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.Helpers;

namespace SeleniumGridWithDocker.PageObjects.UserAccountPages
{
    class MainUserAccountPage : PageBase
    {
        //Registration Form
        private readonly By registrationEmailTextBox = By.Id("email_create");
        private readonly By createAccountButton = By.Id("SubmitCreate");

        //Login Form
        private readonly By loginEmailTextBox = By.Id("email");
        private readonly By loginPasswordTextBox = By.Id("passwd");
        private readonly By submitLoginButton = By.Id("SubmitLogin");

        public MainUserAccountPage(RemoteWebDriver driver) : base(driver)
        {

        }

        public MainUserAccountPage FillRegistrationEmailTextBox(string email)
        {
            ClearTextBox(registrationEmailTextBox);
            FillTextBox(registrationEmailTextBox, email);

            return this;
        }

        public RegistrationPage ClickCreateAccountButton()
        {
            ExplicitWaitWrappers.UntilElementToBeClickable(Driver, createAccountButton);
            ClickOnElement(createAccountButton);

            return new RegistrationPage(Driver);
        }
    }
}
