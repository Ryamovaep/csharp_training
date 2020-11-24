using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace addressbook_web_tests 
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        


        [Test]
        public void ContactRemovalTest()
        {
            List<ContactData> OldContacts = app.Contacts.GetContactList(); 

            if (OldContacts.Count == 0)
            {
                ContactData contact = new ContactData("Ася");
                contact.Middlename = "Павлова";
                contact.Lastname = "Хомякова";
                contact.Title = "Задание 4";
                contact.Address = "Москва, ул.Вавилова 55";
                contact.Mobile = "9252583243";
                contact.Email = "dgokonda2@bk.ru";
                contact.Bday = "16";
                contact.Bmonth = "January";
                contact.Byear = "1900";

                app.Contacts.Create(contact);
            }

            app.Navigator.GoToContactsPage();
            app.Contacts
                .SelectContact("1")
                .RemoveContact();

        }

    }
}
