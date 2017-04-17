using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void TestLogSimple()
        {
            new Logger().LogSimple("test");
        }
    }
}
