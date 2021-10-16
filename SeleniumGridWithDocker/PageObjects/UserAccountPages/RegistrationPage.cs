using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;

namespace SeleniumGridWithDocker.PageObjects.UserAccountPages
{
    class RegistrationPage : PageBase
    {
        //required fields
        private readonly By firstNamePersonalTextBox = By.Id("customer_firstname");
        private readonly By lastNamePersonalTextBox = By.Id("customer_lastname");
        private readonly By emailTextBox = By.Id("email");
        private readonly By passwordTextBox = By.Id("passwd");
        private readonly By firstNameAddressTextBox = By.CssSelector("[name='firstname']");
        private readonly By lastNameAddressTextBox = By.CssSelector("[name='lastname']");
        private readonly By addressTextBox = By.Id("address1");
        private readonly By cityTextBox = By.Id("city");
        private readonly By stateTextBox = By.Id("uniform-id_state");
        private readonly By postalCodeTextBox = By.Id("postcode");
        private readonly By mobilePhoneTextBox = By.Id("phone_mobile");
        private readonly By addressAliasTextBox = By.Id("alias");

        private readonly By submitRegistrationFormButton = By.Id("submitAccount");

        public RegistrationPage(RemoteWebDriver driver) : base(driver)
        {

        }
    }
}
