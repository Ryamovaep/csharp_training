using NUnit.Framework;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests: TestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret")) ;
            GoToContactCreationPage();
            InitNewContactCreation();
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
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToContactPage();
        }

    }
}
