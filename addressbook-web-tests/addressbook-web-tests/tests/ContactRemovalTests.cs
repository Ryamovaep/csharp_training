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
