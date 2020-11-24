using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addressbook_web_tests;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "null";
            newData.Footer = "null";

            List<GroupData> OldGroups = app.Groups.GetGroupList();

            if (OldGroups.Count == 0)

            {
                GroupData group = new GroupData("aaa");
                group.Header = "ddd";
                group.Footer = "fff";

                app.Groups.Create(group);

            }

            app.Groups.Modify(0, newData);

            List<GroupData> NewGroups = app.Groups.GetGroupList();
            OldGroups[0].Name=newData.Name;
            OldGroups.Sort();
            NewGroups.Sort();
            Assert.AreEqual(OldGroups, NewGroups);

        }
    }
}
