using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JenkinsTraining
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod, TestCategory("First")]
        public void TestMethod1()
        {
            Console.WriteLine("First Test Method");
        }


        [TestMethod, TestCategory("Second")]
        public void TestMethod2()
        {
            Console.WriteLine("Second Test Method");
        }

        [TestMethod, TestCategory("Third")]
        public void TestMethod3()
        {
            Console.WriteLine("Third Test Method");
        }
    }
}
