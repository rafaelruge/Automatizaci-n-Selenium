using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement username => driver.FindElement(By.Id("username"));
        private IWebElement password => driver.FindElement(By.Id("password"));
        private IWebElement loginBtn => driver.FindElement(By.Id("submit"));

        public void EnterUsername(string user)
        {
            username.SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            password.SendKeys(pass);
        }

        public void ClickLogin()
        {
            loginBtn.Click();
        }
    }
}
