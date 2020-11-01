using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace addressbook_web_tests 
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        [Test]
        public void ContactRemovalTest()
        {
            
            app.Navigator.GoToContactsPage();
            app.Contacts
                .SelectContact("1")
                .RemoveContact()
                .ReturnToContactPage();

        }

    }
}
