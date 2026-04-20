using NUnit.Framework;
using OpenQA.Selenium;
using Core.Driver;

namespace Core.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.QuitDriver();
        }
    }
}
