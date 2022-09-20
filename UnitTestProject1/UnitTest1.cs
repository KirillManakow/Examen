using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen;
using static Examen.Program;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        Actions actions = new Actions();

        // Данный тест расчитан на проверку того, 
        // что если переменная answer1 будет равнять 0 то ответ должне выводиться 1
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(actions.answer1, 0);
            
        }
    }
}
