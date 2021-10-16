using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.Helpers;
using SeleniumGridWithDocker.PageObjects.UserAccountPages.LoggedUserPages;

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

        public RegistrationPage FirstNamePersonalTextBox(string text)
        {
            ClearTextBox(firstNamePersonalTextBox);
            FillTextBox(firstNamePersonalTextBox, text);

            return this;
        }

        public RegistrationPage LastNamePersonalTextBox(string text)
        {
            ClearTextBox(lastNamePersonalTextBox);
            FillTextBox(lastNamePersonalTextBox, text);

            return this;
        }

        public RegistrationPage EmailTextBox(string text)
        {
            ClearTextBox(emailTextBox);
            FillTextBox(emailTextBox, text);

            return this;
        }

        public RegistrationPage PasswordTextBox(string text)
        {
            ClearTextBox(passwordTextBox);
            FillTextBox(passwordTextBox, text);

            return this;
        }

        public RegistrationPage FirstNameAddressTextBox(string text)
        {
            ClearTextBox(firstNameAddressTextBox);
            FillTextBox(firstNameAddressTextBox, text);

            return this;
        }

        public RegistrationPage LastNameAddressTextBox(string text)
        {
            ClearTextBox(lastNameAddressTextBox);
            FillTextBox(lastNameAddressTextBox, text);

            return this;
        }

        public RegistrationPage AddressTextBox(string text)
        {
            ClearTextBox(addressTextBox);
            FillTextBox(addressTextBox, text);

            return this;
        }

        public RegistrationPage CityTextBox(string text)
        {
            ClearTextBox(cityTextBox);
            FillTextBox(cityTextBox, text);

            return this;
        }

        public RegistrationPage StateTextBox(string text)
        {
            ClearTextBox(stateTextBox);
            FillTextBox(stateTextBox, text);

            return this;
        }

        public RegistrationPage PostalCodeTextBox(string text)
        {
            ClearTextBox(postalCodeTextBox);
            FillTextBox(postalCodeTextBox, text);

            return this;
        }

        public RegistrationPage MobilePhoneTextBox(string text)
        {
            ClearTextBox(mobilePhoneTextBox);
            FillTextBox(mobilePhoneTextBox, text);

            return this;
        }

        public RegistrationPage AddressAliasTextBox(string text)
        {
            ClearTextBox(addressAliasTextBox);
            FillTextBox(addressAliasTextBox, text);

            return this;
        }

        public DashboardLoggedUserPage ClickSubmitRegistrationButton()
        {
            ExplicitWaitWrappers.UntilElementToBeClickable(Driver, submitRegistrationFormButton);
            ClickOnElement(submitRegistrationFormButton);

            return new DashboardLoggedUserPage(Driver);
        }
    }
}
