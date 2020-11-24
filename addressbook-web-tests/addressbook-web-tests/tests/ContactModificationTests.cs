using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests :  AuthTestBase
    {

        [Test]
        public void ContactModificationTest()

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


            ContactData newData = new ContactData("Анна-Мария");
            newData.Middlename = "null";
            newData.Lastname = "null";
            newData.Title = "null";
            newData.Address = "null";
            newData.Mobile = "null";
            newData.Email = "null";
            newData.Bday = "-";
            newData.Bmonth = "-";
            newData.Byear = "null";

            app.Contacts.Modify("1", newData);
            

        }
    }
}
