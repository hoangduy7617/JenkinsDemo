using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDemo;

namespace JenkinsDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("123", Program.CreateMessage());
        }
    }
}
