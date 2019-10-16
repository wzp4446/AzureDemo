using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string sReturnCode;
            string sReturnMsg;
            ClassLibrary.Class1.Sum(1, 1, out sReturnCode, out sReturnMsg);
        }
    }
}
