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
            newData.Middlename = "Захарова";
            newData.Lastname = "Иль";
            newData.Title = "Задание 9";
            newData.Address = "Пермь, ул.Профсоюзная 100";
            newData.Mobile = "9252583243";
            newData.Email = "dgokonda2@bk.bankru";
            newData.Bday = "20";
            newData.Bmonth = "January";
            newData.Byear = "1991";

            app.Contacts.Modify("1", newData);
            

        }
    }
}
