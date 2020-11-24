using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;

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
            List<GroupData> OldGroups = app.Groups.GetGroupList();

            if (OldGroups.Count == 0)

            { 
                 GroupData group = new GroupData("aaa");
                 group.Header = "ddd";
                 group.Footer = "fff";

                app.Groups.Create(group);
                
            }

            app.Groups.Remove(0);

            List<GroupData> NewGroups = app.Groups.GetGroupList();

            OldGroups.RemoveAt(0);
            Assert.AreEqual(OldGroups, NewGroups);
        }
    }
}
