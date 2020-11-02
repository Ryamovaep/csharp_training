using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {

        [Test]
        public void ContactModificationTest()
        {
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
