using System;
using System.IO;
using System.Net.Http.Headers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMehod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorldCoreTest.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }

}


