using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen;
using static Examen.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Count count = new Count();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(count.answer1, 0);
            
        }
    }
}
