using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {

        [Test]
        public void LoginWithValidCredentials()
        {
            //prepare - подготовка
            AccountData account = new AccountData("admin", "secret");

            // action - действие
            app.Auth.Logout();
            app.Auth.Login(account);

            // veryfication - проверка
            Assert.IsTrue(app.Auth.IsLoggedIn());
        }

        [Test]

        public void LoginWithInValidCredentials()
        {

            //prepare - подготовка
            AccountData account = new AccountData("sdfsfsdf", "123456");

            app.Auth.Logout();
            app.Auth.Login(account);

            // veryfication - проверка
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}
