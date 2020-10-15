using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodScuare()
        {
            Scuare s1 = new Scuare (5);
            Scuare s2 = new Scuare (10);
            Scuare s3 = s1;
        
            Assert.AreEqual(s1.Size,5);
            Assert.AreEqual(s2.Size,10);
            Assert.AreEqual(s3.Size,5);

            s3.Size = 15;
            Assert.AreEqual(s1.Size,15);

            s2.Colored = true;
        }
        [TestMethod]
        public void TestMethodCircle()
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Radius, 5);
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = 15;
            Assert.AreEqual(s1.Radius, 15);

            s2.Colored = true;
        }
    }
}
