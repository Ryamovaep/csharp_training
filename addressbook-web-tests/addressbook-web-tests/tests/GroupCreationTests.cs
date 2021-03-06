﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests: AuthTestBase
    {
       
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";

            List<GroupData> OldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> NewGroups = app.Groups.GetGroupList();
            OldGroups.Add(group);
            OldGroups.Sort();
            NewGroups.Sort();
            Assert.AreEqual(OldGroups, NewGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> OldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> NewGroups = app.Groups.GetGroupList();
            OldGroups.Add(group);
            OldGroups.Sort();
            NewGroups.Sort();
            Assert.AreEqual(OldGroups, NewGroups);

        }


        //[Test]
        //public void BadNameGroupCreationTest()
        //{
        //    GroupData group = new GroupData("a'a");
        //    group.Header = "";
        //    group.Footer = "";

        //    List<GroupData> OldGroups = app.Groups.GetGroupList();

        //    app.Groups.Create(group);

        //    List<GroupData> NewGroups = app.Groups.GetGroupList();
        //    OldGroups.Add(group);
        //    OldGroups.Sort();
        //    NewGroups.Sort();
        //    Assert.AreEqual(OldGroups, NewGroups);
        //}
    }
}
