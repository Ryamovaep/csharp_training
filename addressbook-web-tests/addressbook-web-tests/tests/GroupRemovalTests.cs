using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests: AuthTestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);

        }
    }
}
