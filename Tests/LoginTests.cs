using NUnit.Framework;
using Core.Base;
using Pages;
using Core.Utilities;

namespace Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void Login_ValidCredentials_ShouldSucceed()
        {
            driver.Navigate().GoToUrl(ConfigReader.GetConfigValue("baseUrl"));

            var loginPage = new LoginPage(driver);

            loginPage.EnterUsername("student");
            loginPage.EnterPassword("Password123");
            loginPage.ClickLogin();

            Assert.IsTrue(driver.Url.Contains("logged-in-successfully"));
        }
    }
}
