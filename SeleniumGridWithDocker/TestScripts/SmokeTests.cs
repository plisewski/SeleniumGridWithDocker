using NUnit.Framework;
using SeleniumGridWithDocker.BaseClasses;
using SeleniumGridWithDocker.PageObjects;

namespace SeleniumGridWithDocker.TestScripts
{
    [TestFixture]
    class SmokeTests : TestBase
    {
        [Test]
        public void CanNavigateToHomePage()
        {
            var homePage = new HomePage(Driver);

            homePage
                .Navigate();

            Assert.That(Driver.Url, Is.EqualTo("http://automationpractice.com/index.php"));
        }
    }
}
