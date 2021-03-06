using NUnit.Framework;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.PageObjects;
using SeleniumGridWithDocker.PageObjects.UserAccountPages;
using System;

namespace SeleniumGridWithDocker.TestScripts
{
    [TestFixture]
    class RegistrationTests : TestBase
    {
        private string EmailAddress = $"{Guid.NewGuid()}@email.com";

        [Test]
        public void CanNotRegisterWithoutProvidingEmailAddress()
        {
            var homePage = new HomePage(Driver);
            var mainUserAccountPage = new MainUserAccountPage(Driver);

            homePage
                .Navigate()
                .GetTopNavigationComponent()
                .ClickSignInLink()
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);
        }

        [Test]
        public void CanNotRegisterWithoutProvidingRequiredUserData()
        {
            var homePage = new HomePage(Driver);
            var registrationPage = new RegistrationPage(Driver);

            homePage
                .Navigate()
                .GetTopNavigationComponent()
                .ClickSignInLink()
                .FillRegistrationEmailTextBox($"{Guid.NewGuid()}@email.com")
                .ClickCreateAccountButton()
                .ClickSubmitRegistrationButton();

            Assert.That(registrationPage.IsMissingRequiredFieldsErrorAlertDisplayed(), Is.True);
        }

        [Test]
        public void CanNotRegisterProvidingInvalidEmailAddress()
        {
            var homePage = new HomePage(Driver);
            var mainUserAccountPage = new MainUserAccountPage(Driver);

            homePage
                .Navigate()
                .GetTopNavigationComponent()
                .ClickSignInLink()
                .FillRegistrationEmailTextBox("test")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);

            mainUserAccountPage
                .FillRegistrationEmailTextBox("test@")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);

            mainUserAccountPage
                .FillRegistrationEmailTextBox("test@123")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);

            mainUserAccountPage
                .FillRegistrationEmailTextBox("test@123@com")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);

            mainUserAccountPage
                .FillRegistrationEmailTextBox("test.test.test")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);

            mainUserAccountPage
                .FillRegistrationEmailTextBox("test@email.com.")
                .ClickCreateAccountButton();

            Assert.That(mainUserAccountPage.IsAccountCreationErrorAlertDisplayed(), Is.True);
        }

        [Test]
        public void CanRegisterAndGetAutomaticallyRedirectedToUserDashboard()
        {
            var homePage = new HomePage(Driver);
            var registrationPage = new RegistrationPage(Driver);

            homePage
                .Navigate()
                .GetTopNavigationComponent()
                .ClickSignInLink()
                .FillRegistrationEmailTextBox(EmailAddress)
                .ClickCreateAccountButton();

            registrationPage
                .FillFirstNamePersonalTextBox("MyFirstName")
                .FillLastNamePersonalTextBox("MyLastName")
                .FillEmailTextBox(EmailAddress)
                .FillPasswordTextBox("123Test!")
                .FillFirstNameAddressTextBox("MyFirstName")
                .FillLastNameAddressTextBox("MyLastName")
                .FillAddressTextBox("MyAddress")
                .FillCityTextBox("MyCity")
                .SelectStateDropDown(Helpers.DropDownSelectionMethods.DropDownSelectionMethod.SelectByText, "Alabama")
                .FillPostalCodeTextBox("12345")
                .FillMobilePhoneTextBox("987654321")
                .FillAddressAliasTextBox("MyAliasAddress")
                .ClickSubmitRegistrationButton();

            Assert.That(registrationPage.GetTopNavigationComponent().GetUserFirstAndLastNameFromDashboardLink(), Is.EqualTo("MyFirstName MyLastName"));
        }
    }
}
