using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests:  AuthTestBase
    {
        
        [Test]
        public void ContactCreationTest()
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

            List<ContactData> OldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> NewContacts = app.Contacts.GetContactList();
            Assert.AreEqual(OldContacts.Count + 1, NewContacts.Count);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("");
            contact.Middlename = "";
            contact.Lastname = "";
            contact.Title = "";
            contact.Address = "";
            contact.Mobile = "";
            contact.Email = "";
            contact.Bday = "-";
            contact.Bmonth = "-";
            contact.Byear = "1989";

            List<ContactData> OldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> NewContacts = app.Contacts.GetContactList();
            Assert.AreEqual(OldContacts.Count + 1, NewContacts.Count);
        }

        //[Test]
        //public void BadNameContactCreationTest()
        //{
        //    ContactData contact = new ContactData("a'a");
        //    contact.Middlename = "";
        //    contact.Lastname = "";
        //    contact.Title = "";
        //    contact.Address = "";
        //    contact.Mobile = "";
        //    contact.Email = "";
        //    contact.Bday = "-";
        //    contact.Bmonth = "-";
        //    contact.Byear = "1989";

        //    List<ContactData> OldContacts = app.Contacts.GetContactList();

        //    app.Contacts.Create(contact);

        //    List<ContactData> NewContacts = app.Contacts.GetContactList();
        //    Assert.AreEqual(OldContacts.Count + 1, NewContacts.Count);
        //}
    }
}
