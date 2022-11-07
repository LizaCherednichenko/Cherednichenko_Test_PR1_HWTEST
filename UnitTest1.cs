using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Cherednichenko_Test_PR1_HWTEST
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Cherednichenko_Test_PR1_HW.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }    
        }

        private const string Expected2 = "Goodbye World!!";
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw2 = new StringWriter())
            {
                Console.SetOut(sw2);
                Cherednichenko_Test_PR1_HW.Program.SayGoodbye();

                var result2 = sw2.ToString().Trim();
                Assert.AreEqual(Expected2, result2);
            }
        }

    }
}
