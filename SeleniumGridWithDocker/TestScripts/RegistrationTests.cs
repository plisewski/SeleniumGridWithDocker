using NUnit.Framework;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.PageObjects;
using SeleniumGridWithDocker.PageObjects.UserAccountPages;

namespace SeleniumGridWithDocker.TestScripts
{
    [TestFixture]
    class RegistrationTests : TestBase
    {
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
    }
}
